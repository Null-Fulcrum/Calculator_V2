using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class Calculation
    {
        public static string Calculate(double num_1, double num_2, string sigh)
        {
            switch (sigh)
            {
                case "+":
                    return Convert.ToString(num_1 + num_2);

                case "-":
                    return Convert.ToString(num_1 - num_2);
                case "X":
                    return Convert.ToString(num_1 * num_2);
                case "/":
                    return Convert.ToString(num_1 / num_2);
                case "%":
                    return Convert.ToString(num_1 % num_2);
                default:
                    return "";
            }

        }

        public static string ReverseNumber(string num)
        {
            int temp;
            if (Int32.TryParse(num, out temp) == true)
            {
                temp = ~temp;
                temp += 1;
                return temp.ToString();
            }
            else if (num.Contains('-'))
            {

                return num.Replace("-", "");
            }
            else
            {
                return "-" + num;
            }


        }
        public static string DeleteAll()
        {
            return "";
        }
    }
}
