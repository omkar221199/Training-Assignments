using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            ArmstrongNumber armstrongNumber = new ArmstrongNumber();
            armstrongNumber.checkArmstrong(num);

            Console.ReadLine();
        }
    }
}

