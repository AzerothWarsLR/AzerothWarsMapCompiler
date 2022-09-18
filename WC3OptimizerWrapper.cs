using System.IO;
using AzerothWarsMapCompiler.Properties;

namespace AzerothWarsMapCompiler;

internal static class Wc3OptimizerWrapper
{
  public static string OptimizeMap(string mapFile, string outputPath)
  {
    File.Delete(outputPath);
    CommandLineUtils.RunCommand(Settings.Default.Warcraft3OptimizerPath, new string[]
    {
      mapFile,
      "--do",
      outputPath,
      "--checkall",
      "--exit"
    });
    return outputPath;
  }
}