using Bunit;
using CalculatorLibrary;
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

        Library1 lib = new Library1();

        [Fact]


        public void Addition()
        {
            int number1 = 1;
            int number2 = 2;
            var result = lib.Add(number1, number2);
            Assert.Equal(3, result);



        }

        [Fact]
        public void Subtraction1()
        {
            double number1 = 4;
            double number2 = 2;
            var result = lib.Sub(number1, number2);
            Assert.Equal(2, result);
        }
       

        [Fact]
        public void Multiplication()
        {
            double number1 = 5;
            double number2 = 1;
            double result = lib.Multi(number1, number2);
            Assert.Equal(5, result);
        }

       

        [Fact]
        public void Division()
        {
            double number1 = 30;
            double number2 = 6;
            double result = lib.Division(number1, number2);
           Assert.Equal(5, result);
        }

       
        [Fact]
        public void Percentage()
        {
            double number1 = 400;
            double number2 = 320;
            double result = lib.Percentages(number1, number2);
            Assert.Equal(80, result);
        } 

      
    }
}

