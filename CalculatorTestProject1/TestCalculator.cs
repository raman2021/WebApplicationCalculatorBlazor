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
            public void MyBlazingUnitTest()
            {
                var component = _host.AddComponent<Calculator>();

                Assert.Equal("Testing is awesome!", component.Find("h1").InnerText);
            }


            [Fact]
            public void InitiallyDisplaysNoItems()
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
                var component = host.AddComponent<Calculator>();
                component.Find("input1").Input1("");
               
                component.Find("input2").Input2("");
                component.Find("+").Addition();
                component.Find("result").Result();

                // Act
                component.Find("div .result").Click();

                // Assert
                Assert.Collection(component.FindAll("div span"),
                    div => Assert.Equal(" ", div.InnerText));
            }
        }
    }
}
