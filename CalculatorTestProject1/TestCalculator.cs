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
            private TestHost host = new TestHost();
            // for header tag of calulator page
            [Fact]
            public void BlazorUnitTest()
            {
                var component = _host.AddComponent<Calculator>();

                Assert.Equal("Testing is awesome!", component.Find("h1").InnerText);
            }


            [Fact]
            public void BlazorUnitTest1()
            {
                var component = host.AddComponent<Calculator>();
                var data = component.FindAll("div");
                Assert.Empty(data);
            }

            [Fact]
            public void Input()
            {
                // Arrange
                var component = host.AddComponent<Calculator>();

                // Act
                component.Find("input1").Input1(" ");
                component.Find("div").Result();

                component.Find("input2").Input2(" ");
                component.Find("div").Result();

                // Assert
                Assert.Collection(component.FindAll("div span"),
                    div => Assert.Equal(" ", div.InnerText),
                    div => Assert.Equal(" ", div.InnerText));
                Assert.Empty(component.Find("input").GetAttributeValue("value", string.Empty));
            }

            [Fact]
            public void add()
            {
                // Arrange

                using var ctx = new TestContext();
                var cut = ctx.RenderComponent<Calculator>();
                var paraElm = cut.Find("p");

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
                var paraElm = cut.Find("p");

                // Act
                cut.Find("button").Click();
                var paraElmText = paraElm.TextContent;

                // Assert
                paraElmText.MarkupMatches("+");
            }
            [Fact]
            public void multi()
            {
                // Arrange

                using var ctx = new TestContext();
                var cut = ctx.RenderComponent<Calculator>();
                var paraElm = cut.Find("p");

                // Act
                cut.Find("button").Click();
                var paraElmText = paraElm.TextContent;

                // Assert
                paraElmText.MarkupMatches("+");
            }
            [Fact]
            public void division()
            {
                // Arrange

                using var ctx = new TestContext();
                var cut = ctx.RenderComponent<Calculator>();
                var paraElm = cut.Find("p");

                // Act
                cut.Find("button").Click();
                var paraElmText = paraElm.TextContent;

                // Assert
                paraElmText.MarkupMatches("+");
            }
            [Fact]
            public void percentage()
            {
                // Arrange

                using var ctx = new TestContext();
                var cut = ctx.RenderComponent<Calculator>();
                var paraElm = cut.Find("p");

                // Act
                cut.Find("button").Click();
                var paraElmText = paraElm.TextContent;

                // Assert
                paraElmText.MarkupMatches("+");
            }
        }
    }
}
