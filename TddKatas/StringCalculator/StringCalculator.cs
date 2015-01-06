using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TddKatas
{
  public class StringCalculator
  {
    public StringCalculator()
    {
    }

    public int Add(string numbers)
    {
      Console.WriteLine (numbers);

      if(string.IsNullOrEmpty(numbers))
        return 0;

      var delimeters = new List<char>() { ',', '\n' };
      var delimeterRegex = new System.Text.RegularExpressions.Regex("//(?<delimeter>.*)\n(?<numbers>.*)");
      var delimeterMatch = delimeterRegex.Match(numbers);
      if(delimeterMatch.Success) {
        var delimeter = delimeterMatch.Groups["delimeter"].Value;
        Console.WriteLine (delimeter);
        delimeters.Add(Convert.ToChar(delimeter));
        numbers = delimeterMatch.Groups["numbers"].Value;
      }

      var numbersList = numbers.Split(delimeters.ToArray()).ToList().Select(x => int.Parse(x));
      return numbersList.Sum();
    }
  }
}
