using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace AzerothWarsMapCompiler
{
  public static class W3x2lni
  {
    private static string _executablePath;
    private static string ExecutablePath
    {
      get
      {
        if (_executablePath == null)
        {
          _executablePath = Path.GetFullPath(Properties.Settings.Default.w3x2IniFilePath);
        }
        return _executablePath;
      }
    }

    public static string ConvertToObj(string mapPath, string outputPath)
    {
      CommandLineUtils.RunCommand(ExecutablePath, new string[]{
        "obj",
        mapPath,
        outputPath,
      });
      return outputPath;
    }

    public static string ConvertToSLK(string mapPath, string outputPath)
    {
      CommandLineUtils.RunCommand(ExecutablePath, new string[]{
        "slk",
        mapPath,
        outputPath,
      });
      return outputPath;
    }

    public static string ConvertToLni(string mapPath, string outputPath)
    {
      CommandLineUtils.RunCommand(ExecutablePath, new string[]{
        "lni",
        mapPath,
        outputPath,
      });
      return outputPath;
    }
  }
}