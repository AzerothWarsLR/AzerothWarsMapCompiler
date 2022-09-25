namespace AzerothWarsMapCompiler.Test;

public class CommandLineUtilsTests
{
  [Theory]
  [InlineData(@"C:\Program Files (x86)\Warcraft III\_retail_\x86_64", "\"C:\\Program Files (x86)\\Warcraft III\\_retail_\\x86_64\"")]
  [InlineData(@"C:\Users\Bean Lord\OneDrive\Documents\Warcraft III\JassHelper", "\"C:\\Users\\Bean Lord\\OneDrive\\Documents\\Warcraft III\\JassHelper\"")]
  public void ParseCommand(string inputCommand, string expectedOutput)
  {
    var parsedCommand = CommandLineUtils.ParseCommand(inputCommand);
    parsedCommand.Should().Be(expectedOutput);
  }
}