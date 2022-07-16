using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonNumber
{
    internal class NeonNumber
    {
        public void checkNeonNumber(int num)
        {
            double sqnum = Math.Pow(num, 2);
            int sum = 0;
            while (sqnum != 0)
            {
                int x = (int)sqnum % 10;
                sum = sum + x;
                sqnum /= 10;
            }
            if(sum == num)
            {
                Console.WriteLine(num+" is a neon number.");
            }
            else
            {
                Console.WriteLine(num + " is not a neon number.");
            }
        }
    }
}
