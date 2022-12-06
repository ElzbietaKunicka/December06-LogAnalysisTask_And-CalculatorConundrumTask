using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConundrum
{
    public class SimpleCalculator
    {
        public static string Calculate(int num1, int num2, string oprt)
        {
            var result = 0;
            //if(num2==0 && oprt == "/")
            //{
            //    return "Division by zero is not allowed.";
            //}

            try
            {
                switch (oprt)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                    case "":
                        throw new ArgumentException();
                    case null:
                        throw new ArgumentNullException();


                    default: throw new ArgumentOutOfRangeException();

                }
                return $"{num1} {oprt} {num2} = {result}";

            }catch(DivideByZeroException)
            {
                return "Division by zero is not allowed.";
            }
            
        }
    }
}
