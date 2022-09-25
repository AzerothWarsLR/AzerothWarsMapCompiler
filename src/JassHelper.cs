using System;
using System.IO;

namespace AzerothWarsMapCompiler;

public class JassHelper
{
  private readonly string _blizzardjPath;
  private readonly string _commonjPath;
  private readonly string _executablePath;
  private readonly string _tempFileDirectoryPath;

  public JassHelper(string executablePath, string commonjPath, string blizzardjPath, string tempFileDirectoryPath)
  {
    _executablePath = executablePath;
    _commonjPath = commonjPath;
    _blizzardjPath = blizzardjPath;
    _tempFileDirectoryPath = tempFileDirectoryPath;
  }

  /// <summary>
  ///   Merges all vJASS .j files in a number of directories and their subdirectories into a single .j file,
  ///   merges that with the pure JASS war3map.j file in a single map, and outputs a compiled JASS .j file.
  /// </summary>
  public string AddJassDirectoriesToMap(string map, params string[] directories)
  {
    Directory.CreateDirectory(_tempFileDirectoryPath);
    using (var writer = new StreamWriter($"{_tempFileDirectoryPath}merged.j"))
    {
      using (var reader = File.OpenText(MpqMasterWrapper.Extract(map, "war3map.j", _tempFileDirectoryPath)))
      {
        writer.Write(reader.ReadToEnd());
      }

      foreach (var directory in directories)
      {
        var alljfilesindirectory = Directory.GetFiles(directory, "*.j", SearchOption.AllDirectories);
        {
          foreach (var t in alljfilesindirectory)
          {
            using var reader = File.OpenText(t);
            writer.Write(Environment.NewLine + reader.ReadToEnd());
          }
        }
      }
    }

    return $"{_tempFileDirectoryPath}merged.j";
  }

  public string CompileToJass(string file, string newFileName)
  {
    File.Create(newFileName).Close();
    CommandLineUtils.RunCommand(_executablePath, new string[]
    {
      "--scriptonly",
      _commonjPath,
      _blizzardjPath,
      file,
      newFileName
    });
    return newFileName;
  }
}