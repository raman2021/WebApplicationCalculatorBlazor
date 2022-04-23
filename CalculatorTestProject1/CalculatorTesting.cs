using Bunit;
using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationCalculatorAPI.Pages;
using Xunit;

namespace CalculatorTestProject1
{
    public class CalculatorTesting
    {
        [Fact]
        public void DisplaysItems()
        {
            /* using var ctx = new TestContext();
             var cut = ctx.RenderComponent<Calculator>();
             var paraElm = cut.Find("p");

             // Act
             cut.Find("button").Click();
             var paraElmText = paraElm.TextContent;

             // Assert
             paraElmText.MarkupMatches("");

         } */

            {
                // arrange
                var ctx = new TestContext();

                // act
                var comp = ctx.RenderComponent<Calculator>();

                // assert
                var expectedHtml = @"<h1> Calculator Using Blazor</h1>
 <div class=""row"">
    < div class=""col-md-3"">
        <p>Input 1</p>
    </div>
    <div class=""col-md-4"">
        <input placeholder = "" />
    </div>
</div>
<div class=""row"">
    < div class=""col-md-3"">

        <p>Input 2</p>
    </div>
    <div class=""col-md-4"">

        <input placeholder = "" />
    </div>
</div>
<div class=""row"">
    < div class=""col-md-3"">

        <p><b>Result</b></p>
    </div>
    <div class=""col-md-4"">

        <input readonly "" />
    </div>
    
</ div >
<div class=""row"">
    < div class=""col-md-2"">
        <button  class=""btn btn-primary""> + </button>
    </div>
    <div class=""col-md-2"">
        <button  class=""btn btn-primary""> − </button>

    </div>
    <div class=""col-md-2"">
        <button  class=""btn btn-success ""> * </button>
    </div>
    <div class=""col-sm-2"">
        <button class=""btn btn-primary""> / </button>
    </div>
    <div class=""col-sm-2"">
        <button  class=""btn btn-success""> % </button>
    </div>

    <br />
    <div class=""col-sm-2"">
        <button  type=""reset"" class=""btn btn-success""> CLEAR</button>
    </div> ";

                comp.MarkupMatches(expectedHtml);

            }
        }
        public class UnitTest1 : Bunit.TestContext
        {

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
}
