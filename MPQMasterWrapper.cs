using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace AzerothWarsMapCompiler
{
  static class MPQMasterWrapper
  {
    public static void Add(string mapFile, string file, string targetName)
    {
      CommandLineUtils.RunCommand(Path.GetFullPath(Properties.Settings.Default.MPQMasterPath), new string[] {
        "/add",
        mapFile,
        file,
        targetName,
      });
    }

    public static void Delete(string mapFile, string file)
    {
      CommandLineUtils.RunCommand(Path.GetFullPath(Properties.Settings.Default.MPQMasterPath), new string[] {
        "/delete",
        mapFile,
        file,
      });
    }

    public static string Extract(string mapFile, string file, string destinationFolder)
    {
      CommandLineUtils.RunCommand(Path.GetFullPath(Properties.Settings.Default.MPQMasterPath), new string[] {
        "/extract",
        mapFile,
        file,
        destinationFolder
      });
      return destinationFolder + file;
    }
  }
}