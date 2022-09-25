using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using AzerothWarsMapCompiler.Properties;
using Newtonsoft.Json;

namespace AzerothWarsMapCompiler;

internal static class Program
{
  /// <summary>
  ///   The main entry point for the application.
  /// </summary>
  [STAThread]
  private static void Main()
  {
    Application.SetHighDpiMode(HighDpiMode.SystemAware);
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);

    var tempDirectoryPath = Path.GetFullPath(Settings.Default.TemporaryFilePath);
    var compiledMapsDirectoryPath = Path.GetFullPath(Settings.Default.CompiledMapsPath);

    var newJassHelper = new JassHelper(
      Path.GetFullPath(Settings.Default.JASSHelperPath),
      Path.GetFullPath(Settings.Default.commonjPath),
      Path.GetFullPath(Settings.Default.blizzardjPath),
      Path.GetFullPath(Settings.Default.TemporaryFilePath));

    var newMapCompiler =
      new MapCompiler(tempDirectoryPath, compiledMapsDirectoryPath, newJassHelper);

    var publishSettings = new PublishSettings(Settings.Default.SourceMapPath, Settings.Default.SourceCodePath, Settings.Default.PublishedMapName);
    
    Application.Run(new MainForm(publishSettings, newMapCompiler));
  }
}