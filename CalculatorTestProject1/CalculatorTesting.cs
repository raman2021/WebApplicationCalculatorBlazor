using Bunit;
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
            using var ctx = new TestContext();
            var cut = ctx.RenderComponent<Calculator>();
            var paraElm = cut.Find("p");

            // Act
            cut.Find("button").Click();
            var paraElmText = paraElm.TextContent;

            // Assert
            paraElmText.MarkupMatches("");

        }
    }
}
