using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b=0;
            int[] arr = new int[] { 20, 31, 15, 45, 11, 87, 65, 47, 66 };
            MinMax minMax = new MinMax();

            minMax.FindMinMax1(ref a, ref b, arr);
            Console.WriteLine("Max = {0} Min = {1}", a, b);

            minMax.FindMinMax2(out a, out b, arr);
            Console.WriteLine("Max = {0} Min = {1}", a, b);

            int[] minMaxArray = minMax.FindMinMax3(arr);
            Console.WriteLine("Max = {0}, Min = {1}", minMaxArray[0], minMaxArray[1]);

            var tuple = minMax.FindMinMax4(arr);
            Console.WriteLine("Max = {0}, Min = {1}", tuple.Item2, tuple.Item1);

            FindMinMax ans = new FindMinMax();
            ans.FindMinMax5(arr);
            Console.WriteLine("Max = {0}, Min = {1}", ans.max, ans.max);

            Console.ReadLine();
        }
    }

    class MinMax
    {
        public void FindMinMax1(ref int max, ref int min, int[] arr)
        {
            max = arr[0];
            min = arr[1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
                else if (min > arr[i])
                {
                    min = arr[i];
                }
            }
        }

        public void FindMinMax2(out int max, out int min, int[] arr)
        {
            max = arr[0];
            min = arr[1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
                else if (min > arr[i])
                {
                    min = arr[i];
                }
            }
        }

        public int[] FindMinMax3(int[] arr)
        {
            int[] minMax = new int[2];
            minMax[0] = arr[0];
            minMax[1] = arr[1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (minMax[0] < arr[i])
                {
                    minMax[0] = arr[i];
                }
                else if (minMax[1] > arr[i])
                {
                    minMax[1] = arr[i];
                }
            }
            return minMax;
        }

        public Tuple<int, int> FindMinMax4(int[] arr)
        {
            int max = arr[0];
            int min = arr[1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
                else if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return new Tuple<int, int>(min, max);
        }
    }
    

    struct FindMinMax
    {
        public int min;
        public int max;
        public FindMinMax FindMinMax5(int[] arr)
        {
            
            FindMinMax values = new FindMinMax();
            for (int i = 0; i < arr.Length; i++)
            {
                if (values.max < arr[i])
                {
                    values.max = arr[i];
                }
                if (values.min > arr[i])
                {
                    values.min = arr[i];
                }
            }
            return values;
        }
    }    
}

