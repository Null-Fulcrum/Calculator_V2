using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
   public class Calculation
    {
        public static string Calculate(double num_1, double num_2, string sigh)
        {
            switch (sigh)
            {
                case "+":
                    return Convert.ToString(Summ(num_1,num_2));

                case "-":
                    return Convert.ToString(Subtraction(num_1, num_2));
                case "X":
                    return Convert.ToString(Multiplication(num_1, num_2));
                case "/":
                    return Convert.ToString(Division(num_1, num_2));
                case "%":
                    return Convert.ToString(Remainder_Division(num_1, num_2));
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
        public static double Summ(double num_1, double num_2)
        {
            return num_1 + num_2;
        }
        public static double Subtraction(double num_1, double num_2)
        {
            return num_1 - num_2;
        }
        public static double Multiplication(double num_1, double num_2)
        {
            return num_1 * num_2;
        }
        public static double Division(double num_1, double num_2)
        {
            return num_1 / num_2;
        }
        public static double Remainder_Division(double num_1, double num_2)
        {
            return num_1 % num_2;
        }
    }
}
