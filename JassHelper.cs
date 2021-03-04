using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace AzerothWarsMapCompiler
{
  public class JassHelper
  {
    private string _executablePath;
    private string _commonjPath;
    private string _blizzardjPath;
    private string _tempFileDirectoryPath;

    public JassHelper(string executablePath, string commonjPath, string blizzardjPath, string tempFileDirectoryPath)
    {
      _executablePath = executablePath;
      _commonjPath = commonjPath;
      _blizzardjPath = blizzardjPath;
      _tempFileDirectoryPath = tempFileDirectoryPath;
    }

    /// <summary>
    /// Merges all vJASS .j files in a number of directories and their subdirectories into a single .j file,
    /// merges that with the pure JASS war3map.j file in a single map, and outputs a compiled JASS .j file.
    /// </summary>
    /// <param name="map"></param>
    /// <param name="folders"></param>
    /// <param name="newFilePath"></param>
    /// <returns></returns>
    public string AddJASSDirectoriesToMap(string map, string[] directories)
    {
      using (StreamWriter writer = new StreamWriter(_tempFileDirectoryPath + "merged.j"))
      {
        using (StreamReader reader = File.OpenText(MPQMasterWrapper.Extract(map, "war3map.j", _tempFileDirectoryPath)))
        {
          writer.Write(reader.ReadToEnd());
        }
        foreach (string directory in directories)
        {
          string[] alljfilesindirectory = Directory.GetFiles(directory, "*.j", SearchOption.AllDirectories);
          {
            for (int i = 0; i < alljfilesindirectory.Length; i++)
            {
              using StreamReader reader = File.OpenText(alljfilesindirectory[i]);
              writer.Write(Environment.NewLine + reader.ReadToEnd());
            }
          }
        }
      }
      return _tempFileDirectoryPath + "merged.j";
    }

    public string CompileToJASS(string file, string newFileName)
    {
      File.Create(newFileName).Close();
      CommandLineUtils.RunCommand(_executablePath, new string[] {
        "--scriptonly",
        _commonjPath,
        _blizzardjPath,
        file,
        newFileName
      });
      return newFileName;
    }

  }
}