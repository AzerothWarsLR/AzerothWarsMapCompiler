﻿using System.IO;

namespace AzerothWarsMapCompiler;

public class MapCompiler
{
  private readonly string _compiledMapsDirectoryPath;
  private readonly JassHelper _jassHelper;
  private readonly string _tempDirectoryPath;

  public MapCompiler(string tempDirectoryPath, string compiledMapsDirectoryPath, JassHelper jassHelper)
  {
    _tempDirectoryPath = tempDirectoryPath;
    _compiledMapsDirectoryPath = compiledMapsDirectoryPath;
    _jassHelper = jassHelper;
  }

  public void CompileMap(MapCompilationPackage mapCompilationPackage, bool launch = false, bool publish = false)
  {
    var tempMapPath = $"{_tempDirectoryPath}tempMap.w3x";

    if (!Directory.Exists(tempMapPath)) Directory.CreateDirectory(tempMapPath);
    
    File.Copy(mapCompilationPackage.SourceMapPath, tempMapPath, true);
    var joinedJass = _jassHelper.AddJassDirectoriesToMap(tempMapPath, mapCompilationPackage.SourceCodeDirectoryPaths);
    var compiledJass = _jassHelper.CompileToJass(joinedJass, $"{_tempDirectoryPath}compiled.j");
    MpqMasterWrapper.Add(tempMapPath, compiledJass, "war3map.j");

    var launchPath = tempMapPath;

    if (publish)
    {
      Directory.CreateDirectory(_compiledMapsDirectoryPath);
      var newFilePath =
        $"{_compiledMapsDirectoryPath}{mapCompilationPackage.FileName}{mapCompilationPackage.VersionNumber}.w3x";
      File.Copy(tempMapPath, newFilePath, true);
      launchPath = newFilePath;
    }

    if (launch) Wc3Wrapper.Run(launchPath);
  }
}