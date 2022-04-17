namespace CalculatorLibrary
{
     
public class Library1

    {
       

        public int Add(int num1, int num2)
        {
            int result = 0;

            result = num1 + num2;
            return result;


        }

        public double Sub(double number1, double number2)
        {
            return number1 - number2;
        }
        public double Multi(double number1, double number2)
        {
            return number1 * number2;
        }
        public double Division(double number1, double number2)
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
        public  double Percentages(double number1, double number2)
        {
            return number1 % number2;
            // return (number1 * number2) / 100;
        }
    }
}