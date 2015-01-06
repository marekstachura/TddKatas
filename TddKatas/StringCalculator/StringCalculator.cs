using System;
using System.Linq;

namespace TddKatas
{
  public class StringCalculator
  {
    public StringCalculator()
    {
    }

    public int Add(string numbers)
    {
      if(string.IsNullOrEmpty(numbers))
        return 0;

      var numbersList = numbers.Split(new char[] { ',', '\n' }).ToList().Select(x => int.Parse(x));
      return numbersList.Sum();
    }
  }
}
