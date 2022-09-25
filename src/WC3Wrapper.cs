namespace AzerothWarsMapCompiler;

public static class Wc3Wrapper
{
  public static void Run(string wc3Path, string mapFilePath)
  {
    CommandLineUtils.RunCommand(wc3Path, new string[]
    {
      "-launch",
      "-loadfile",
      mapFilePath
    });
  }
}