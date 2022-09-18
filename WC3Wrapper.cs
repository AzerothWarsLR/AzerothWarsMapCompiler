using AzerothWarsMapCompiler.Properties;

namespace AzerothWarsMapCompiler;

public static class Wc3Wrapper
{
  public static void Run(string mapFilePath)
  {
    CommandLineUtils.RunCommand(Settings.Default.Warcraft3FilePath, new string[]
    {
      "-launch",
      "-loadfile",
      mapFilePath
    });
  }
}