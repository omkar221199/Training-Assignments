using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            NeonNumber neonNumber = new NeonNumber();
            neonNumber.checkNeonNumber(num);

            Console.ReadLine();
        }
    }
}
