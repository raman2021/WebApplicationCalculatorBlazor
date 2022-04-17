using Bunit;
using LINQtoCSV;
using Microsoft.Extensions.DependencyModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Xceed.Wpf.Toolkit;
using Xunit;
using Assert = Xunit.Assert;

namespace CalculatorTestProject1
{
    public class UnitTest1 : Bunit.TestContext
    {
        private IEnumerable<object> expected;

        [Fact]
        [InlineData("5 1", 6)]
       [InlineData ("10 20", 30)]
        [InlineData("30 22", 52)]
        [InlineData ("1 20", 21)]

        public void Addition()
        {
            Assert.Equal(expected, Library.(input));
        }


        [Test]
        public void Subtraction1()
        {
            //double number1 = 5;
           // double number2 = 1;
            double result = Library.Sub(number1, number2);
           Assert.Equal(4, result(2, 2));
        }
        [Test]
        public void Subtraction2()
        {
            double number1 = 15;
            double number2 = 5;
            double result = Library.Sub(number1, number2);
            Assert.Equal(10, result);
        }

        [Test]
        public void Subtraction3()
        {
            double number1 = 30;
            double number2 = 2;
            double result = Library.Sub(number1, number2);
           Assert.Equal(28, result);
        }
        [Test]
        public void Subtraction4()
        {
            double number1 = 10;
            double number2 = 11;
            double result = Library.Sub(number1, number2);
            Assert.Equal(-1, result);
        }

        [Test]
        public void Multiplication1()
        {
            double number1 = 5;
            double number2 = 1;
            double result = Library.Multi(number1, number2);
            Assert.Equal(5, result);
        }

        [Test]
        public void Multiplication2()
        {
            double number1 = 5;
            double number2 = 5;
            double result = Library.Multi(number1, number2);
          Assert.AreEqual(25, result);
        }

        [Test]
        public void Multiplication3()
        {
            double number1 = 3;
            double number2 = 2;
            double result = Library.Multi(number1, number2);
            Assert.Equal(6, result);
        }
        [Test]
        public void Multiplication4()
        {
            double number1 = 6;
            double number2 = 4;
            double result = Library.Multi(number1, number2);
            Assert.Equal(24, result);
        }
        [Test]
        public void Division1()
        {
            double number1 = 10;
            double number2 = 2;
            double result = Library.Division(number1, number2);
            Assert.Equal(5, result);
        }

        [Test]
        public void Division2()
        {
            double number1 = 30;
            double number2 = 6;
            double result = Library.Division(number1, number2);
           Assert.Equal(5, result);
        }

        [Test]
        public void Division3()
        {
            double number1 = 10;
            double number2 = 10;
            double result = Library.Division(number1, number2);
           Assert.Equal(1, result);
        }
        [Test]
        public void Division4()
        {
            double number1 = 100;
            double number2 = 10;
            double result = Library.Division(number1, number2);
            Assert.Equal(10, result);
        }
        [Test]
        public void Percentage1()
        {
            double number1 = 400;
            double number2 = 320;
            double result = Library.Percentages(number1, number2);
            Assert.Equal(80, result);
        }

        /* [Fact]
         public void Test1()
         {

                 double number1 = 5;
                 double number2 = 1;
                 (double number1, double number2) p = (
                                 number1, number2);
                 Assert.AreEqual(4, (object)Calculator.+ p);
             }

         } */
    }
}

