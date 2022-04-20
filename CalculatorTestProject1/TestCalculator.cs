using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf.Hosts;
using WebApplicationCalculatorAPI.Pages;
using Xunit;
using System.Collections.Generic.IEnumerable<T>;

namespace CalculatorTestProject1
{
    class TestCalculator
    {
        public class CalcTest
        {
            private TestHost host = new TestHost();

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
                component.Find("input").Input1(" ");
                component.Find("div").Result();

                component.Find("input").Input2(" ");
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
