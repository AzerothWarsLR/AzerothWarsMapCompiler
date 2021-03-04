using Newtonsoft.Json;
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

      string tempDirectoryPath = Path.GetFullPath(Properties.Settings.Default.TemporaryFilePath);
      string compiledMapsDirectoryPath = Path.GetFullPath(Properties.Settings.Default.CompiledMapsPath);

      var newJassHelper = new JassHelper(
        Path.GetFullPath(Properties.Settings.Default.JASSHelperPath),
        Path.GetFullPath(Properties.Settings.Default.commonjPath),
        Path.GetFullPath(Properties.Settings.Default.blizzardjPath),
        Path.GetFullPath(Properties.Settings.Default.TemporaryFilePath));

      var newMapCompiler = new MapCompiler(tempDirectoryPath, compiledMapsDirectoryPath, newJassHelper);
      var mapCompilationPackages = JsonConvert.DeserializeObject<List<MapCompilationPackage>>(
        File.ReadAllText(Properties.Settings.Default.MapCompilationPackagesPath)).ToArray();
      
      if (!File.Exists(Properties.Settings.Default.MapCompilationPackagesPath))
      {
        File.Create(Properties.Settings.Default.MapCompilationPackagesPath).Close();
      }

      Application.Run(new MainForm(mapCompilationPackages, newMapCompiler));
    }
  }
}
