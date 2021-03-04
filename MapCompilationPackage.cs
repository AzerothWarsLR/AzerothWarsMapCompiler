using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AzerothWarsMapCompiler
{
  public class MapCompilationPackage
  {
    public MapCompilationPackage(string name, string sourceMapPath, string[] sourceCodeDirectoryPaths, string tempDirectoryPath, string compiledMapsDirectoryPath)
    {
      Name = name;
      SourceMapPath = sourceMapPath;
      SourceCodeDirectoryPaths = sourceCodeDirectoryPaths;
      TempDirectoryPath = tempDirectoryPath;
      CompiledMapsDirectoryPath = compiledMapsDirectoryPath;
    }

    public string Compile(JassHelper jassHelper, string newMapName = null, bool launch = false)
    {
      if (newMapName == null & launch == true)
      {
        throw new ArgumentException("Launch cannot be true while newMapName is null");
      }

      var joinedJASS = jassHelper.AddJASSDirectoriesToMap(SourceMapPath, SourceCodeDirectoryPaths);
      var compiledJASS = jassHelper.CompileToJASS(joinedJASS, TempDirectoryPath + "compiled.j");

      var tempMapPath = TempDirectoryPath + "tempMap.w3x";
      File.Copy(SourceMapPath, tempMapPath, true);
      MPQMasterWrapper.Add(tempMapPath, compiledJASS, "war3map.j");

      if (newMapName != null){
        File.Copy(tempMapPath, newMapName, true);
        if (launch == true)
        {
          WC3Wrapper.Run(newMapName);
        }
      }
      return newMapName;
    }

    public string SourceMapPath { get ; }
    public string[] SourceCodeDirectoryPaths { get; }
    public string TempDirectoryPath { get;  }
    public string CompiledMapsDirectoryPath { get; }
    public string Name { get;  }
  }
}
