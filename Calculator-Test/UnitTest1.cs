using Microsoft.Extensions.DependencyModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplicationCalculatorAPI.Pages;

namespace Calculator_Test
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void Addition1()
        {
            double number1 = 5;
            double number2 = 1;
            double result = Calculator.Addition(number1, number2);
            Assert.AreEqual(4, result);
        }

        /*using Microsoft.Extensions.DependencyModel;
        using Microsoft.VisualStudio.TestTools.UnitTesting;

        namespace Calculator_Test
        {
            [TestClass]
            public class CalculatorTest
            {

                [TestMethod]
                [DataRow("5 1", 6)]
                [DataRow("10 20", 30)]
                [DataRow("30 22", 52)]
                [DataRow("1 20", 21)]
                public void Addition1(string input, int expected)
                {
                    Assert.AreEqual(expected, Library.Addition(input));
                }


                [TestMethod]
                public void Subtraction1()
                {
                    double number1 = 5;
                    double number2 = 1;
                    double result = Library.Sub(number1, number2);
                    Assert.AreEqual(4, result);
                }
                [TestMethod()]
                public void Subtraction2()
                {
                    double number1 = 15;
                    double number2 = 5;
                    double result = Library.Sub(number1, number2);
                    Assert.AreEqual(10, result);
                }

                [TestMethod()]
                public void Subtraction3()
                {
                    double number1 = 30;
                    double number2 = 2;
                    double result = Library.Sub(number1, number2);
                    Assert.AreEqual(28, result);
                }
                [TestMethod()]
                public void Subtraction4()
                {
                    double number1 = 10;
                    double number2 = 11;
                    double result = Library.Sub(number1, number2);
                    Assert.AreEqual(-1, result);
                }

                [TestMethod()]
                public void Multiplication1()
                {
                    double number1 = 5;
                    double number2 = 1;
                    double result = Library.Multi(number1, number2);
                    Assert.AreEqual(5, result);
                }

                [TestMethod()]
                public void Multiplication2()
                {
                    double number1 = 5;
                    double number2 = 5;
                    double result = Library.Multi(number1, number2);
                    Assert.AreEqual(25, result);
                }

                [TestMethod()]
                public void Multiplication3()
                {
                    double number1 = 3;
                    double number2 = 2;
                    double result = Library.Multi(number1, number2);
                    Assert.AreEqual(6, result);
                }
                [TestMethod()]
                public void Multiplication4()
                {
                    double number1 = 6;
                    double number2 = 4;
                    double result = Library.Multi(number1, number2);
                    Assert.AreEqual(24, result);
                }
                [TestMethod()]
                public void Division1()
                {
                    double number1 = 10;
                    double number2 = 2;
                    double result = Library.Division(number1, number2);
                    Assert.AreEqual(5, result);
                }

                [TestMethod()]
                public void Division2()
                {
                    double number1 = 30;
                    double number2 = 6;
                    double result = Library.Division(number1, number2);
                    Assert.AreEqual(5, result);
                }

                [TestMethod()]
                public void Division3()
                {
                    double number1 = 10;
                    double number2 = 10;
                    double result = Library.Division(number1, number2);
                    Assert.AreEqual(1, result);
                }
                [TestMethod()]
                public void Division4()
                {
                    double number1 = 100;
                    double number2 = 10;
                    double result = Calculator.razor.Division(number1, number2);
                    Assert.AreEqual(10, result);
                }
                [TestMethod()]
                public void Percentage1()
                {
                    double number1 = 400;
                    double number2 = 320;
                    double result = Library.Percentages(number1, number2);
                    Assert.AreEqual(80, result);
                }






            }
        }
        */



    }
}
