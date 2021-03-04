using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace AzerothWarsMapCompiler
{
  public class CommandLineUtils
  {
    private const string quote = "\"";

    public static void RunCommand(string cmd, string[] argumentArray)
    {
      //Add quotes around the command if necessary
      if (cmd.Contains(" "))
      {
        cmd = quote + cmd + quote;
      }
      //Add quotes around the arguments if they have spaces in them
      var arguments = "";
      var i = 0;
      foreach (string argument in argumentArray) {
        if (argument.Contains(" "))
        {
          arguments = arguments + quote + argument + quote;
        } else
        {
          arguments += argument;
        }
        i++;
        if (i < argumentArray.Length)
        {
          arguments += " ";
        }
      }
      var test = $"/c {cmd} {arguments}";
      ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", $"/c {cmd} {arguments}")
      {
        RedirectStandardError = true,
        RedirectStandardOutput = true,
        UseShellExecute = false,
        CreateNoWindow = true,
      };
      Process proc = new Process
      {
        StartInfo = procStartInfo,
      };
      proc.Start();
      proc.WaitForExit();
      string result = proc.StandardError.ReadToEnd();

      if (result.Length > 0) {
        throw new Exception(result);
      }
    }
  }
}
