namespace AzerothWarsMapCompiler;

internal static class MpqMasterWrapper
{
  public static void Add(string mpqMasterPath, string mapFile, string file, string targetName)
  {
    CommandLineUtils.RunCommand(mpqMasterPath, new string[]
    {
      "/add",
      mapFile,
      file,
      targetName
    });
  }

  public static void Delete(string mpqMasterPath, string mapFile, string file)
  {
    CommandLineUtils.RunCommand(mpqMasterPath, new string[]
    {
      "/delete",
      mapFile,
      file
    });
  }

  public static string Extract(string mpqMasterPath, string mapFile, string file, string destinationFolder)
  {
    CommandLineUtils.RunCommand(mpqMasterPath, new string[]
    {
      "/extract",
      mapFile,
      file,
      destinationFolder
    });
    return destinationFolder + file;
  }
}