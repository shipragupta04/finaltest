using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newconsole
{
    public class BasicMaths
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Substract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double divide(double num1, double num2)
        {
            return num1 / num2;
        }
        public double Multiply(double num1, double num2)
        {
            // To trace error while testing, writing + operator instead of * operator.
            return num1 + num2;
        }
        public static void Main(string[] args)
        {
            Console.Write("enter first number");
            var x = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter Second number");
            var y = Convert.ToDouble(Console.ReadLine());
            var bm = new BasicMaths();
            Console.WriteLine(bm.Add(x, y));
        }
    }


}