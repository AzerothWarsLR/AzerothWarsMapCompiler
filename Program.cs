using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzerothWarsMapCompiler
{
  static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.SetHighDpiMode(HighDpiMode.SystemAware);
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      string dowMap = Path.GetFullPath(Properties.Settings.Default.DAWMapPath);
      string rocMap = Path.GetFullPath(Properties.Settings.Default.RoCMapPath);
      string blankMap = Path.GetFullPath(Properties.Settings.Default.BlankMapPath);
      string tempDirectoryPath = Path.GetFullPath(Properties.Settings.Default.TemporaryFilePath);
      string compiledMapsDirectoryPath = Path.GetFullPath(Properties.Settings.Default.CompiledMapsPath);

      var newJassHelper = new JassHelper(
        Path.GetFullPath(Properties.Settings.Default.JASSHelperPath),
        Path.GetFullPath(Properties.Settings.Default.commonjPath),
        Path.GetFullPath(Properties.Settings.Default.blizzardjPath),
        Path.GetFullPath(Properties.Settings.Default.TemporaryFilePath));

      var dowCompiler = new MapCompilationPackage(
        "Burning Crusade",
        dowMap,
        new string[] { Path.GetFullPath(Properties.Settings.Default.MainCodePath),
          Path.GetFullPath(Properties.Settings.Default.DAWCodePath) },
          tempDirectoryPath,
          compiledMapsDirectoryPath);

      var rocCompiler = new MapCompilationPackage(
        "Reign of Chaos",
        rocMap,
        new string[] { Path.GetFullPath(Properties.Settings.Default.MainCodePath),
          Path.GetFullPath(Properties.Settings.Default.RoCCodePath) },
          tempDirectoryPath,
          compiledMapsDirectoryPath);

      var blankCompiler = new MapCompilationPackage(
        "Blank",
        blankMap,
        new string[] { Path.GetFullPath(Properties.Settings.Default.MainCodePath) },
          tempDirectoryPath,
          compiledMapsDirectoryPath);

      Application.Run(new MainForm(new MapCompilationPackage[] {
        blankCompiler,
        rocCompiler,
        dowCompiler}, 
      newJassHelper));
    }
  }
}
