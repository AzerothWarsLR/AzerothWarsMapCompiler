namespace AzerothWarsMapCompiler;

public class PublishSettings
{
  public PublishSettings(string sourceMapPath, string sourceCodePath, string publishedMapName)
  {
    SourceMapPath = sourceMapPath;
    SourceCodePath = sourceCodePath;
    PublishedMapName = publishedMapName;
  }
  
  public string SourceMapPath { get; }
  public string SourceCodePath { get; }
  public string PublishedMapName { get; }
}