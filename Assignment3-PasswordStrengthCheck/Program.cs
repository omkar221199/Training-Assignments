using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrengthCheckApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a password to check it's strength: ");
            string password = Console.ReadLine();
            PasswordStrengthCheck passwordStrengthCheck = new PasswordStrengthCheck();
            int count = passwordStrengthCheck.PasswordStrength(password);

            if(count == 0)
            {
                Console.WriteLine("Very Weak. Password should be a minimum 6 characters.");
            }
            else if(count == 1)
            {
                Console.WriteLine("Weak Password");
            }
            else if (count == 2)
            {
                Console.WriteLine("Good");
            }
            else if (count == 3){
                Console.WriteLine("Very Good");
            }
            else
            {
                Console.WriteLine("Excellent");
            }

            Console.ReadLine();
        }
    }
}
