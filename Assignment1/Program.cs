using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string str = null;
            try
            {
                int output1 = int.Parse(str);
                Console.WriteLine(output1);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //-----------------------------------------------------------------------------------------------------

            int output2 = Convert.ToInt32(str);
            Console.WriteLine($"The output is: {output2}");

            //-----------------------------------------------------------------------------------------------------

            string input = "101ab";
            int num = 0;
            bool success = int.TryParse(input, out num);
            if (success)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Incorrect number...");
            }

            Console.ReadLine();
        }
    }
}
