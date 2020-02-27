using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessens
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            calc.X = 5;
            calc.Y = 12;
            var q = calc.Multiply();

            Calculator.Print(q);
            Console.ReadKey();
        }
    }
    public class Calculator
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Multiply()
        {
            return X * Y;
        }

        public static void Print(int result)
        {
            Console.WriteLine(result);
        }

       
    }
}
