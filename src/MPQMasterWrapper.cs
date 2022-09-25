using System.IO;
using AzerothWarsMapCompiler.Properties;

namespace AzerothWarsMapCompiler;

internal static class MpqMasterWrapper
{
  public static void Add(string mapFile, string file, string targetName)
  {
    CommandLineUtils.RunCommand(Path.GetFullPath(Settings.Default.MPQMasterPath), new string[]
    {
      "/add",
      mapFile,
      file,
      targetName
    });
  }

  public static void Delete(string mapFile, string file)
  {
    CommandLineUtils.RunCommand(Path.GetFullPath(Settings.Default.MPQMasterPath), new string[]
    {
      "/delete",
      mapFile,
      file
    });
  }

  public static string Extract(string mapFile, string file, string destinationFolder)
  {
    CommandLineUtils.RunCommand(Path.GetFullPath(Settings.Default.MPQMasterPath), new string[]
    {
      "/extract",
      mapFile,
      file,
      destinationFolder
    });
    return destinationFolder + file;
  }
}