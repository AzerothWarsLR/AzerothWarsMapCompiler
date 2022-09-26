using System.IO;
using AzerothWarsMapCompiler.Settings;

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

  public void CompileMap(PathSettings pathSettings, PublishSettings publishSettings, bool launch = false, bool publish = false)
  {
    var tempMapPath = $"{_tempDirectoryPath}tempMap.w3x";

    if (!Directory.Exists(_tempDirectoryPath)) Directory.CreateDirectory(_tempDirectoryPath);
    
    File.Copy(publishSettings.SourceMapPath, tempMapPath, true);
    var joinedJass = _jassHelper.AddJassDirectoriesToMap(tempMapPath, Path.GetFullPath(publishSettings.SourceCodePath));
    var compiledJass = _jassHelper.CompileToJass(joinedJass, $"{_tempDirectoryPath}compiled.j");
    MpqMasterWrapper.Add(pathSettings.MPQMasterPath, tempMapPath, compiledJass, "war3map.j");

    var launchPath = tempMapPath;

    if (publish)
    {
      Directory.CreateDirectory(_compiledMapsDirectoryPath);
      var newFilePath =
        $"{_compiledMapsDirectoryPath}{publishSettings.PublishedMapName}.w3x";
      File.Copy(tempMapPath, newFilePath, true);
      launchPath = newFilePath;
    }

    if (launch) Wc3Wrapper.Run(pathSettings.Warcraft3FilePath, launchPath);
  }
}