using UnitTest.MathLib;
namespace UnitTest_Test.MathLibTest;


[TestClass]
public class Calculator_Divide
{
    [TestMethod]
    public void Calculator_Divide_Method_Receives_A_Number_And_One_Then_Returns_Number()
    {
       Calculator calculator = new Calculator();
       var ret = calculator.Divide(4, 1);
       Assert.AreEqual(4, ret);
    }

     [TestMethod]
     [DataRow(1.0,1.0,1.0)]
    [DataRow(2.0,2.0,1.0)]
    public void Calculator_Divide_Method_Receives_Two_Of_The_Same_Numbers_And_One_Then_Returns_One(double left, double right, double expected)
    {
       Calculator calculator = new Calculator();
       var ret = calculator.Divide((decimal)left, (decimal)right);
       Assert.AreEqual((decimal)expected, ret);
    }

    [TestMethod]
    public void Calculator_Divide_Method_Recevies_A_number_and_zero_then_return_Exception()
    {
       Calculator calculator = new Calculator();
       //var ret = calculator.Divide(4, 0);
        //    double a = 5;
        //    double b = a / 0;
       Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(4, 0));
    }
}