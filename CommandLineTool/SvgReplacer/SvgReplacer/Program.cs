using System;

namespace SvgReplacer
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var input = InputLoader.LoadInput();
      Console.WriteLine($"Loaded input for {input.Details.Count} cards");
      Console.ReadKey();
    }
  }
}
