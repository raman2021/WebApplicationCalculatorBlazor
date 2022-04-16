using NUnit.Framework;
using WebApplicationCalculatorAPI.Pages;
using Xceed.Wpf.Toolkit;

namespace CalculatorTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Subtraction1()
        {
            double number1 = 5;
            double number2 = 1;
            (double number1, double number2) p = (
                            number1, number2);
            Assert.AreEqual(4, (object)Calculator.- p);

        }
        [Test]
        public void Addition1()
        {
            double number1 = 5;
            double number2 = 1;
            (double number1, double number2) p = (
                            number1, number2);
            Assert.AreEqual(4, (object)Calculator.+ p);
        }
        [Test]
        public void Multiplication1()
        {
            double number1 = 5;
            double number2 = 1;
            (double number1, double number2) p = (
                            number1, number2);
            Assert.AreEqual(4, (object)Calculator.* p);
        }
        [Test]
        public void Division1()
        {
            double number1 = 5;
            double number2 = 1;
            (double number1, double number2) p = (
                            number1, number2);
            Assert.AreEqual(4, (object)Calculator./ p);
        }
    }
}

