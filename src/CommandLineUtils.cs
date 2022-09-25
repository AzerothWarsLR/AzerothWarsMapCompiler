using System;
using System.Collections;
using System.Diagnostics;

namespace AzerothWarsMapCompiler;

public static class CommandLineUtils
{
  private const string Quote = "\"";

  /// <summary>
  /// Adds quotes around the command if it has spaces in it.
  /// </summary>
  internal static string ParseCommand(string cmd)
  {
    if (cmd.Contains(' ')) cmd = Quote + cmd + Quote;
    return cmd;
  }

  /// <summary>
  /// Adds quotes around the arguments that have spaces in them.
  /// </summary>
  internal static string ParseArguments(string[] argumentArray)
  {
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

    return arguments;
  }

  public static void RunCommand(string cmd, string[] argumentArray)
  {
    var procStartInfo = new ProcessStartInfo("cmd", $"/c {ParseCommand(cmd)} {ParseArguments(argumentArray)}")
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