using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter first number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second number: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    int result = num1 / num2;
                    Console.WriteLine("The result is {0}", result);
                }
                catch (DivideByZeroException ex)
                {
                    string filePath = @"C:\Sample Files\Log.txt";          // I have kept the filename as Log1.txt
                    StreamWriter sw = new StreamWriter(ex.Message);
                    if (File.Exists(filePath))
                    {
                        sw.WriteLine(ex.GetType().Name);
                        sw.WriteLine();
                        sw.WriteLine(ex.Message);
                        sw.Close();
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " is not present", ex);
                    }
                }


            }
            catch (Exception exception)
            {
                Console.WriteLine("Outer Exception: {0}", exception.GetType().Name);
                Console.WriteLine("Inner Exception: {0}", exception.InnerException.GetType().Name);
            }

            Console.ReadLine();
        }
    }
}
