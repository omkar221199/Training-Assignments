using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many integers do you want to sort?");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the integers...");
            int[] arr = new int[count];
            for(int i=0; i<count; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.sortNumbers(arr);
            Console.WriteLine("\nSorted Array is: \n"); 
            for(int j=0; j<arr.Length; j++)
            {
                Console.WriteLine(arr[j]);
            }
            Console.ReadLine();
        }
    }
}
