namespace AzerothWarsMapCompiler;

public class MapCompilationPackage
{
  public MapCompilationPackage(string packageName, string sourceMapPath, string[] sourceCodeDirectoryPaths,
    string[] objectDirectoryPaths, string fileName, string versionNumber)
  {
    PackageName = packageName;
    SourceMapPath = sourceMapPath;
    SourceCodeDirectoryPaths = sourceCodeDirectoryPaths;
    ObjectDirectoryPaths = objectDirectoryPaths;
    FileName = fileName;
    VersionNumber = versionNumber;
  }

  public string PackageName { get; }
  public string SourceMapPath { get; }
  public string[] SourceCodeDirectoryPaths { get; }
  public string[] ObjectDirectoryPaths { get; }
  public string FileName { get; }
  public string VersionNumber { get; }
}