using Bunit;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf.Hosts;
using WebApplicationCalculatorAPI.Pages;
using Xunit;


namespace CalculatorTestProject1
{
    class TestCalculator
    {
        public class CalcTest
        {
           
            [Fact]
            public void add()
            {
                // Arrange

                using var ctx = new TestContext();
                var cut = ctx.RenderComponent<Calculator>();
                var paraElm = cut.Find("div");

                // Act
                cut.Find("button").Click();
                var paraElmText = paraElm.TextContent;

                // Assert
                paraElmText.MarkupMatches("+");
            }
            [Fact]
            public void sub()
            {
                // Arrange

                using var ctx = new TestContext();
                var cut = ctx.RenderComponent<Calculator>();
                var paraElm = cut.Find("div");

                // Act
                cut.Find("button").Click();
                var paraElmText = paraElm.TextContent;

                // Assert
                paraElmText.MarkupMatches("-");
            }
            [Fact]
            public void multi()
            {
                // Arrange

                using var ctx = new TestContext();
                var cut = ctx.RenderComponent<Calculator>();
                var paraElm = cut.Find("div");

                // Act
                cut.Find("button").Click();
                var paraElmText = paraElm.TextContent;

                // Assert
                paraElmText.MarkupMatches("*");
            }
            [Fact]
            public void division()
            {
                // Arrange

                using var ctx = new TestContext();
                var cut = ctx.RenderComponent<Calculator>();
                var paraElm = cut.Find("div");

                // Act
                cut.Find("button").Click();
                var paraElmText = paraElm.TextContent;

                // Assert
                paraElmText.MarkupMatches("/");
            }
            [Fact]
            public void percentage()
            {
                // Arrange

                using var ctx = new TestContext();
                var cut = ctx.RenderComponent<Calculator>();
                var paraElm = cut.Find("div");

                // Act
                cut.Find("button").Click();
                var paraElmText = paraElm.TextContent;

                // Assert
                paraElmText.MarkupMatches("%");
            }
        }
    }
}