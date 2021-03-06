using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AzerothWarsMapCompiler
{
  public class MapCompiler
  {
    private readonly string _tempDirectoryPath;
    private readonly string _compiledMapsDirectoryPath;
    private readonly string _sourceMapBackups;
    private readonly JassHelper _jassHelper;

    public MapCompiler(string tempDirectoryPath, string compiledMapsDirectoryPath, string sourceMapBackups, JassHelper jassHelper)
    {
      _tempDirectoryPath = tempDirectoryPath;
      _compiledMapsDirectoryPath = compiledMapsDirectoryPath;
      _sourceMapBackups = sourceMapBackups;
      _jassHelper = jassHelper;
    }

    public void BackupSource(MapCompilationPackage mapCompilationPackage)
    {
      var newFileName = Path.GetFileNameWithoutExtension(mapCompilationPackage.SourceMapPath) + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".w3x";
      Directory.CreateDirectory(_sourceMapBackups);
      File.Copy(mapCompilationPackage.SourceMapPath, _sourceMapBackups + newFileName, false);
    }

    public void ImportObjects(MapCompilationPackage mapCompilationPackage)
    {
      if (mapCompilationPackage.ObjectDirectoryPaths == null)
      {
        throw new Exception("MapCompilationPackage provided has no object directories to source from");
      }

      var templni = W3x2lni.ConvertToLni(mapCompilationPackage.SourceMapPath, _tempDirectoryPath + "tempini.w3x");
      var objectTypes = new string[] { "ability", "buff", "destructable", "doodad", "item", "unit", "upgrade" };
      foreach (var objectType in objectTypes)
      {
        string[] directories = (string[])mapCompilationPackage.ObjectDirectoryPaths.Clone();
        for (int i = 0; i < directories.Length; i++)
        {
          directories[i] = directories[i] + objectType + @"\";
        }
        var objects = W3x2LniObject.CreateObjectsFromDirectories(directories);
        W3x2LniObject.SaveObjectsToFile(objects, templni + "/" + "table/" + objectType + ".ini");
      }
      BackupSource(mapCompilationPackage);
      W3x2lni.ConvertToObj(templni, mapCompilationPackage.SourceMapPath);
    }

    public void ExportObjects(MapCompilationPackage mapCompilationPackage)
    {
      var templni = W3x2lni.ConvertToLni(mapCompilationPackage.SourceMapPath, _tempDirectoryPath + "tempini.w3x");
      var objectTypes = new string[] { "ability", "buff", "destructable", "doodad", "item", "unit", "upgrade" };

      foreach (var objectType in objectTypes)
      {
        string[] directories = (string[])mapCompilationPackage.ObjectDirectoryPaths.Clone();
        for (int i = 0; i < directories.Length; i++)
        {
          directories[i] = directories[i] + objectType + @"\";
        }
        if (File.Exists(templni + @"\table\" + objectType + ".ini"))
        {
          var objects = W3x2LniObject.CreateObjectsFromFile(templni + @"\table\" + objectType + ".ini");
          W3x2LniObject.SaveObjectsToDirectories(objects, directories);
        }
      }
    }

    public void CompileMap(MapCompilationPackage mapCompilationPackage, bool launch = false, bool publish = false)
    {
      var joinedJASS = _jassHelper.AddJASSDirectoriesToMap(mapCompilationPackage.SourceMapPath, mapCompilationPackage.SourceCodeDirectoryPaths);
      var compiledJASS = _jassHelper.CompileToJASS(joinedJASS, _tempDirectoryPath + "compiled.j");

      var tempMapPath = _tempDirectoryPath + "tempMap.w3x";
      File.Copy(mapCompilationPackage.SourceMapPath, tempMapPath, true);
      MPQMasterWrapper.Add(tempMapPath, compiledJASS, "war3map.j");

      var launchPath = tempMapPath;

      if (publish)
      {
        //Convert the map to lni, then set map details appropriately
        var mapAsLni = W3x2lni.ConvertToLni(mapCompilationPackage.SourceMapPath, _tempDirectoryPath + "tempini.w3x");
        var mapDetailsObjects = W3x2LniObject.CreateObjectsFromFile(mapAsLni + @"\table\w3i.ini");
        var mapDescription = mapDetailsObjects["map"];
        mapDescription.SetFieldValue("map_name", mapCompilationPackage.PackageName + " " + mapCompilationPackage.VersionNumber);
        var loadingScreen = mapDetailsObjects["loading_screen"];
        mapDescription.RegenerateFileContents();
        loadingScreen.SetFieldValue("title", mapCompilationPackage.PackageName + " " + mapCompilationPackage.VersionNumber);
        loadingScreen.RegenerateFileContents();
        W3x2LniObject.SaveObjectsToFile(mapDetailsObjects, mapAsLni + @"\table\w3i.ini");
        //Convert the map to slk for publishing
        var newFilePath = _compiledMapsDirectoryPath + mapCompilationPackage.FileName + mapCompilationPackage.VersionNumber + ".w3x";
        W3x2lni.ConvertToSLK(mapAsLni, newFilePath);
        launchPath = newFilePath;
      }
      
      if (launch == true)
      {
        WC3Wrapper.Run(launchPath);
      }
    }
  }

  public class MapCompilationPackage
  {
    public MapCompilationPackage(string packageName, string sourceMapPath, string[] sourceCodeDirectoryPaths, string [] objectDirectoryPaths, string fileName, string versionNumber)
    {
      PackageName = packageName;
      SourceMapPath = sourceMapPath;
      SourceCodeDirectoryPaths = sourceCodeDirectoryPaths;
      ObjectDirectoryPaths = objectDirectoryPaths;
      FileName = fileName;
      VersionNumber = versionNumber;
    }

    public string PackageName { get; }
    public string SourceMapPath { get ; }
    public string[] SourceCodeDirectoryPaths { get; }
    public string[] ObjectDirectoryPaths { get;  }
    public string FileName { get; }
    public string VersionNumber { get; }
  }
}
