﻿using NUnit.Framework;

namespace TddKatas
{
	[TestFixture ()]
	public class StringCalculatorTest
	{
		[Test ()]
		public void Add_Should_Return_Zero_For_Empty_String ()
		{
			var calculator = new StringCalculator ();
			Assert.AreEqual (0, calculator.Add (string.Empty));
		}
	}
}