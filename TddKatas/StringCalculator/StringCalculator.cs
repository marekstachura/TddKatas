using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace TddKatas
{
  public class StringCalculator
  {
    public int Add(string numbers)
    {
      if(string.IsNullOrEmpty(numbers))
        return 0;

      var delimeters = new List<char>() { ',', '\n' };
      numbers = NumbersWithoutDelimeter(numbers, ref delimeters);

      var numbersList = numbers.Split(delimeters.ToArray()).ToList().Select(x => int.Parse(x));
      return numbersList.Sum();
    }

    private string NumbersWithoutDelimeter(string numbers, ref List<char> delimeters) {
      var delimeterRegex = new Regex("//(?<delimeter>.*)\n(?<numbers>.*)");
      var delimeterMatch = delimeterRegex.Match(numbers);
      if(!delimeterMatch.Success)
        return numbers;

      delimeters.Add(Convert.ToChar(delimeterMatch.Groups["delimeter"].Value));
      return delimeterMatch.Groups["numbers"].Value;
    }
  }
}
