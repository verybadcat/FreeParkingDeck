using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SvgReplacer
{
  public static class InputLoader
  {
    public const string Inputfolder = @"C:\Code\Free Parking\Cards";
    public const string SvgFilename = @"FreeParking.svg";
    public const string CardFilename = "monopoly deck.txt";
    public static Input LoadInput()
    {
      var svgPath = Path.Combine(Inputfolder, SvgFilename);
      var svgText = File.ReadAllText(svgPath);
      var cardPath = Path.Combine(Inputfolder, CardFilename);
      var cardText = File.ReadAllText(cardPath);
      var details = StringExtensions.SplitLines(cardText).Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
      var r = new Input
      {
        Template = svgText,
        Details = details,
      };
      return r;
    }
  }
}
