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

			return numbers.Length;
		}
	}
}

