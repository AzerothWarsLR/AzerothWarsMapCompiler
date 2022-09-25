using System;
using System.Collections;
using System.Diagnostics;

namespace AzerothWarsMapCompiler;

public readonly struct ParsedCommand
{
  public readonly string Cmd;
  public readonly string[] ArgumentArray;

  public ParsedCommand(string cmd, string[] argumentArray)
  {
    Cmd = cmd;
    ArgumentArray = argumentArray;
  }
}

public static class CommandLineUtils
{
  private const string Quote = "\"";

  internal static ParsedCommand ParseCommand(string cmd, string[] argumentArray)
  {
    //Add quotes around the command if necessary
    if (cmd.Contains(' ')) cmd = Quote + cmd + Quote;
    //Add quotes around the arguments if they have spaces in them
    var arguments = "";
    var i = 0;
    foreach (var argument in argumentArray)
    {
      if (argument.Contains(' '))
        arguments = arguments + Quote + argument + Quote;
      else
        arguments += argument;
      i++;
      if (i < argumentArray.Length) arguments += " ";
    }

    return new ParsedCommand(cmd, argumentArray);
  }
  
  public static void RunCommand(string cmd, string[] argumentArray)
  {
    var command = ParseCommand(cmd, argumentArray);
    
    var procStartInfo = new ProcessStartInfo("cmd", $"/c {command.Cmd} {command.ArgumentArray}")
    {
      RedirectStandardError = true,
      RedirectStandardOutput = true,
      UseShellExecute = false,
      CreateNoWindow = true
    };
    var proc = new Process
    {
      StartInfo = procStartInfo
    };
    proc.Start();
    proc.WaitForExit();
    var result = proc.StandardError.ReadToEnd();

    if (result.Length > 0) throw new Exception(result);
  }
}