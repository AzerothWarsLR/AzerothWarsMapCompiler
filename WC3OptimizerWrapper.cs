using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace AzerothWarsMapCompiler
{
  static class WC3OptimizerWrapper
  {
    public static string OptimizeMap(string mapFile, string outputPath)
    {
      File.Delete(outputPath);
      CommandLineUtils.RunCommand(Properties.Settings.Default.Warcraft3OptimizerPath, new string[]{
        mapFile,
        "--do",
        outputPath,
        "--checkall",
        "--exit"
      });
      return outputPath;
    }
  }
}