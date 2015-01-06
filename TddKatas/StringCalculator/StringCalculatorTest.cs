using NUnit.Framework;

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

    [Test()]
    public void Add_Should_Return_Correct_Sum_For_One_Number()
    {
      var calculator = new StringCalculator();
      Assert.AreEqual(9, calculator.Add("9"));
    }

    [Test()]
    public void Add_Should_Return_Correct_Sum_For_Two_Numbers()
    {
      var calculator = new StringCalculator();
      Assert.AreEqual(15, calculator.Add("7,8"));
    }
  }
}
