using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace SvgReplacer
{
  public static class StringExtensions
  {
    public static List<string> SplitLines(string input)
    {
      using StringReader sr = new StringReader(input);
      var lines = new List<string>();
      string line;
      while ((line = sr.ReadLine()) != null)
      {
        lines.Add(line);
      }
      return lines;
    }
  }
}
