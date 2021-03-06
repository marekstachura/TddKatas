﻿using NUnit.Framework;

namespace TddKatas
{
  [TestFixture]
  public class StringCalculatorTest
  {
    [Test]
    public void Add_Should_Return_Zero_For_Empty_String()
    {
      var calculator = new StringCalculator();
      Assert.AreEqual(0, calculator.Add(string.Empty));
    }

    [Test]
    public void Add_Should_Return_Correct_Sum_For_One_Number()
    {
      var calculator = new StringCalculator();
      Assert.AreEqual(9, calculator.Add("9"));
    }

    [Test]
    public void Add_Should_Return_Correct_Sum_For_Two_Numbers()
    {
      var calculator = new StringCalculator();
      Assert.AreEqual(15, calculator.Add("7,8"));
    }

    [Test]
    public void Add_Should_Return_Correct_Sum_For_Unknown_Amount_Of_Numbers()
    {
      var calculator = new StringCalculator();
      Assert.AreEqual(19, calculator.Add("7,8,1,3"));
    }

    [Test]
    public void Add_Should_Support_New_Lines_And_Commas_As_Delimeters()
    {
      var calculator = new StringCalculator();
      Assert.AreEqual(19, calculator.Add("7\n8,1\n3"));
    }

    [Test]
    public void Add_Should_Support_Provided_Delimeter()
    {
      var calculator = new StringCalculator();
      Assert.AreEqual(19, calculator.Add("//;\n7;8;1;3"));
    }
  }
}
