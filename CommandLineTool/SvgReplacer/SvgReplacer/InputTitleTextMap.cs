using System;
using System.Collections.Generic;
using System.Text;

namespace SvgReplacer
{
  public class InputTitleTextMap
  {
    public TitleText ToTitleText(string input)
    {
      var index = input.IndexOf('.');
      if (index == -1)
      {
        throw new InvalidOperationException("No period in input!");
      }
      var title = input.Substring(0, index);
      var text = input.Substring(index + 1).Trim();
      return new TitleText
      {
        Title = title,
        Text = text,
      };
    }
  }
}
