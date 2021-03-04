using System.Text.RegularExpressions;

namespace AzerothWarsMapCompiler
{
 public static class WC3Wrapper
  {
    public static void Run(string mapFilePath)
    {
      CommandLineUtils.RunCommand(Properties.Settings.Default.Warcraft3FilePath, new string[]{
        "-launch",
        "-loadfile",
        mapFilePath
      });
    }
  }
}