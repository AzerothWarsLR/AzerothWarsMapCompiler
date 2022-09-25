namespace AzerothWarsMapCompiler.Test;

public class CommandLineUtilsTests
{
  [Theory]
  [InlineData(@"C:\Program Files (x86)\Warcraft III\_retail_\x86_64", "-launch", "-loadFile")]
  public void ParseCommand_Spaces(string cmd, params string[] args)
  {
    var parsedCommand = CommandLineUtils.ParseCommand(cmd, args);
    parsedCommand.Cmd.Should().Be("\"C:\\Program Files (x86)\\Warcraft III\\_retail_\\x86_64\"");
  }
}