using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number :");
            double n1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number :");
            double n2=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Add: {Add(n1, n2)}");

            Console.WriteLine($"subtraction: {subtraction(n1, n2)}");
            Console.WriteLine($"multiplication: {multiplication(n1, n2)}");
            Console.WriteLine($"Division: {Division(n1, n2)}");



        }
        static double Add(double a, double b) => a + b;
        static double subtraction(double a, double b) => a - b;
        static double multiplication(double a, double b) => a * b;
        static double Division(double a, double b) => b !=0 ? a / b : 0;
    }
}
