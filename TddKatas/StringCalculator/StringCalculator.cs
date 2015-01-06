using System;

namespace TddKatas
{
	public class StringCalculator
	{
		public StringCalculator ()
		{
		}

		public int Add(string numbers)
		{
			if (string.IsNullOrEmpty (numbers))
				return 0;

      int result;
      int.TryParse(numbers, out result);
      return result;
		}
	}
}

