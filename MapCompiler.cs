using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AzerothWarsMapCompiler
{
  public class MapCompiler
  {
    private string _tempDirectoryPath;
    private string _compiledMapsDirectoryPath;
    private JassHelper _jassHelper;

    public MapCompiler(string tempDirectoryPath, string compiledMapsDirectoryPath, JassHelper jassHelper)
    {
      _tempDirectoryPath = tempDirectoryPath;
      _compiledMapsDirectoryPath = compiledMapsDirectoryPath;
      _jassHelper = jassHelper;
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
    public MapCompilationPackage(string packageName, string sourceMapPath, string[] sourceCodeDirectoryPaths, string FileName, string versionNumber)
    {
      PackageName = packageName;
      SourceMapPath = sourceMapPath;
      SourceCodeDirectoryPaths = sourceCodeDirectoryPaths;
      FileName = FileName;
      VersionNumber = versionNumber;
    }

    public string PackageName { get; }
    public string SourceMapPath { get ; }
    public string[] SourceCodeDirectoryPaths { get; }
    public string FileName { get; }
    public string VersionNumber { get; }
  }
}
