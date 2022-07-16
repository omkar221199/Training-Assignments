using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {5, 17, 19, 28, 40, 55, 68, 71, 89, 92 };
            Console.WriteLine("Enter the number you want to search?");
            int key = Convert.ToInt32(Console.ReadLine());

            BinarySearch binarySearch = new BinarySearch();
            int index = binarySearch.searchNumber(key,arr,0,arr.Length-1);

            if (index == -1)
            {
                Console.WriteLine("The number is not present in the array.");
            }
            else
            {
                Console.WriteLine("The number is present at index "+index+".");
            }

            Console.ReadLine();
        }
    }
}
