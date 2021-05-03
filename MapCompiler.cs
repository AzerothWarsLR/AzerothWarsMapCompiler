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

    public void CompileMap(MapCompilationPackage mapCompilationPackage, bool launch = false, bool publish = false)
    {
      var tempMapPath = _tempDirectoryPath + "tempMap.w3x";
      File.Copy(mapCompilationPackage.SourceMapPath, tempMapPath, true);
      var joinedJASS = _jassHelper.AddJASSDirectoriesToMap(tempMapPath, mapCompilationPackage.SourceCodeDirectoryPaths);
      var compiledJASS = _jassHelper.CompileToJASS(joinedJASS, _tempDirectoryPath + "compiled.j");
      MPQMasterWrapper.Add(tempMapPath, compiledJASS, "war3map.j");

      var launchPath = tempMapPath;

      if (publish)
      {
        Directory.CreateDirectory(_compiledMapsDirectoryPath);
        var newFilePath = _compiledMapsDirectoryPath + mapCompilationPackage.FileName + mapCompilationPackage.VersionNumber + ".w3x";
        File.Copy(tempMapPath, newFilePath, true);
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
