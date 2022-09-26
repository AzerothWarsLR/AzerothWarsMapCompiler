using System;
using System.IO;
using AzerothWarsMapCompiler.Settings;
using Microsoft.Extensions.Configuration;

namespace AzerothWarsMapCompiler;

internal static class Program
{
  /// <summary>
  ///   The main entry point for the application.
  /// </summary>
  [STAThread]
  private static void Main()
  {
    var userSpecificAppSettings = $"appsettings.{Environment.UserName}.json";

    if (!File.Exists(userSpecificAppSettings))
    {
      File.Copy("appsettings.json", userSpecificAppSettings);
    }
    
    IConfiguration config = new ConfigurationBuilder()
      .AddJsonFile("appsettings.json")
      .AddJsonFile(userSpecificAppSettings)
      .AddEnvironmentVariables()
      .Build();
    
    var publishSettings = config.GetRequiredSection("PublishSettings").Get<PublishSettings>();
    var pathSettings = config.GetRequiredSection("PathSettings").Get<PathSettings>();

    var tempDirectoryPath = Path.GetFullPath(pathSettings.TemporaryFilePath);
    var compiledMapsDirectoryPath = Path.GetFullPath(pathSettings.CompiledMapsPath);

    var newJassHelper = new JassHelper(
      Path.GetFullPath(pathSettings.JASSHelperPath),
      Path.GetFullPath(pathSettings.MPQMasterPath),
      Path.GetFullPath(pathSettings.commonjPath),
      Path.GetFullPath(pathSettings.blizzardjPath),
      Path.GetFullPath(pathSettings.TemporaryFilePath));

    var newMapCompiler =
      new MapCompiler(tempDirectoryPath, compiledMapsDirectoryPath, newJassHelper);

    newMapCompiler.CompileMap(pathSettings, publishSettings, true, true);
  }
}