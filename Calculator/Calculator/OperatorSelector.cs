using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class OperatorSelector
    {
        public static string HandleEquation(string operation, double value, string text)
        {
            string result = "";

            switch (operation)
            {
                case "+":
                    result = (value + double.Parse(text)).ToString();
                    break;
                case "-":
                    result = (value - double.Parse(text)).ToString();
                    break;
                case "*":
                    result = (value * double.Parse(text)).ToString();
                    break;
                case "/":
                    if (value == 0 || double.Parse(text) == 0)
                    {
                        break;
                    }

                    result = (value / double.Parse(text)).ToString();
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
