using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumberApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            SwapNumbers(ref a, ref b);
            Console.WriteLine();
            Console.WriteLine("After swapping:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"a = {b}");
            Console.ReadLine();
        }

        static void SwapNumbers(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
