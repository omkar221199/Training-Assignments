using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] jaggedArray = new string[4][];

            jaggedArray[0] = new string[] { "Mumbai", "Pune", "Nashik", "Nagpur"};
            jaggedArray[1] = new string[] { "Ahmedabad", "Surat", "Baroda" };
            jaggedArray[2] = new string[] { "Indore", "Bhopal" };
            jaggedArray[3] = new string[] { "Bangalore", "Mangalore", "Mysore"};

            Console.WriteLine("Cities of various states are: ");
            foreach (string[] str in jaggedArray)
            {
                foreach (string s in str)
                {
                    Console.Write(s + " ");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
