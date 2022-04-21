using Bunit;
using OpenQA.Selenium;
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
    public class UITesting : TestContext
    {
       /* [Fact]
        public void CounterShouldIncrementWhenSelected()
        {
            // Arrange
            using var ctx = new TestContext();
            var cut = ctx.RenderComponent<Calculator>();
            var paraElm = cut.Find("p");

            // Act
            cut.Find("button").Click();
            var paraElmText = paraElm.TextContent;

            // Assert
            paraElmText.MarkupMatches("Input 1");
        } */
        private TestHost host = new TestHost();

        [Fact]
        public void CounterWorks()
        {
            var component = host.AddComponent<Counter>();
            Func<string> countValue = () => component.Find("#count").InnerText;

            Assert.Equal("Counter", component.Find("h1").InnerText);
            Assert.Equal("Current count: 0", countValue());

            component.Find("button.inc").Click();
            Assert.Contains("Current count: 1", countValue());

            component.Find("button.dec").Click();
            Assert.Contains("Current count: 0", countValue());
        }

        [Fact]
        public void FetchDataWorks()
        {
            


            var req = host.AddMockHttp().Capture("/sample-data/weather.json");
            var component = host.AddComponent<FetchData>();
            Assert.Contains("Loading...", component.GetMarkup());

          


            host.WaitForNextRender(() => req.SetResult(new[]
            {
                new FetchData.WeatherForecast { Summary = "First" },
                new FetchData.WeatherForecast { Summary = "Second" },
            }));
            Assert.DoesNotContain("Loading...", component.GetMarkup());
            Assert.Collection(component.FindAll("tbody tr"),
                row => Assert.Contains("First", row.OuterHtml),
                row => Assert.Contains("Second", row.OuterHtml));
        }
    }
}




    

