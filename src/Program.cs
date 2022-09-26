using System;
using System.IO;
using System.Windows.Forms;
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
    IConfiguration config = new ConfigurationBuilder()
      .AddJsonFile("appsettings.json")
      .AddEnvironmentVariables()
      .Build();
    
    var publishSettings = config.GetRequiredSection("PublishSettings").Get<PublishSettings>();
    var pathSettings = config.GetRequiredSection("PathSettings").Get<PathSettings>();
    
    Application.SetHighDpiMode(HighDpiMode.SystemAware);
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);

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

    Application.Run(new MainForm(publishSettings, pathSettings, newMapCompiler));
  }
}