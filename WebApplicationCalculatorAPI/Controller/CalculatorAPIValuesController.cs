using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using WebApplicationCalculatorAPI.Pages;
using FromBodyAttribute = System.Web.Http.FromBodyAttribute;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace WebApplicationCalculatorAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class CalculatorAPIValuesController : ControllerBase
    {
      // public List<Calculator> calculators = new List<Calculator> { }


        [HttpGet]
        public double Addition(int lValue, int rValue)
        {
            return lValue + rValue;
        }


        [HttpGet]
        public double Subtraction(int lValue, int rValue)
        {
            return lValue - rValue;
        }


        [HttpGet]
        public double Multiplication(int lValue, int rValue)
        {
            return lValue * rValue;
        }


         [HttpGet]
        public double Division(int lValue, int rValue)
        {


            if (lValue != 0 || rValue != 0)
            {
                return lValue / rValue;

            }
            else
            {
                throw new ArgumentException();


            }



        }
          [HttpGet]

        public double Percentage(int lValue, int rValue)
        {
            return (lValue / rValue)*100;
            // return (number1 * number2) / 100;
        }
    };

        
    
        [HttpPost]
        public ActionResult<IEnumerable<string>> CalcData([FromBody] Calculator Calculation)
        {
            String Input1 = Calculation.Input1.Trim();
            String Input2 = Calculation.Input2.Trim();
            String Result = Calculation.Result.Trim();

            if (Input1.Trim() != "" && Input2.Trim() != "" && Result.Trim() != "")
            {
                Calculator objCalculator = new Calculator();
                String RData = "0";
                if (Result.Trim().ToUpper() == "ADDITION")
                {
                    RData = Convert.ToString(objCalculator.Addition(Convert.ToInt32(Input1.Trim()), Convert.ToInt32(Input2.Trim()))); (Value2.Trim())));
                }
                else if (Result.Trim() == "SUBTRACTION")
                {
                    RData = Convert.ToString(objCalculator.Subtraction(Convert.ToInt32(Input1.Trim()), Convert.ToInt32(Input2.Trim())));
                }
                else if (Result.Trim() == "MULTIPLICATION")
                {
                    RData = Convert.ToString(objCalculator.Multiplication(Convert.ToInt32(Input1.Trim()), Convert.ToInt32(Input2.Trim())));
            }
                else if (Result.Trim() == "DIVISION")
                {
                    RData = Convert.ToString(objCalculator.Division(Convert.ToInt32(Input1.Trim()), Convert.ToInt32(Input2.Trim())));
            }
            else if (Result.Trim() == "PERCENTAGE")
            {
                RData = Convert.ToString(objCalculator.Percentages(Convert.ToInt32(Input1.Trim()), Convert.ToInt32(Input2.Trim())));
            }


            return new string[] { RData };
            }
            else
            {
                return new string[] { "0" };
            }
        }
    }


