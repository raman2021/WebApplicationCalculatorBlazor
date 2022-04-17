using System;

namespace CalculatorLibrary
{
    public class Library
    {
        public static int Add(String series)
        {
            int result = 0;

            String[] numbers = series.Split(' ');


            foreach (string number in numbers)
            {

                int temp;


                if (int.TryParse(number, out temp))
                {

                    result += temp;
                }
                else
                {
                    throw new ArgumentException();
                }

            }


            return result;


        }

        public static double Sub(double number1, double number2)
        {
            return number1 - number2;
        }
        public static double Multi(double number1, double number2)
        {
            return number1 * number2;
        }
        public static double Division(double number1, double number2)
        {
            if (number2 != 0)
            {
                return number1 / number2;
            }
            else
            {
                return number1;
            }
        }
        public static double Percentages(double number1, double number2)
        {
            return number1 % number2;
            // return (number1 * number2) / 100;
        }
    }
}
   