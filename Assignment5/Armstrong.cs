using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    internal class ArmstrongNumber
    {
        public void checkArmstrong(int num)
        {
            int temp = num;
            double sum = 0;
            while (num != 0)
            {
                int x = num % 10;
                sum = sum + Math.Pow(x, 3);
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine(temp + " is an Armstrong Number");
            }
            else
            {
                Console.WriteLine(temp + " is not an Armstrong Number");
            }
        }
    }
}
