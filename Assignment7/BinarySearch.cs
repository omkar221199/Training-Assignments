using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class BinarySearch
    {
        public int searchNumber(int key, int[] arr, int low, int high)
        {
            if (low > high)
            {
                return -1;
            }
         
            int mid = (low + high) / 2;
            if (arr[mid] == key)
            {
                return mid;
            }
            else if (key > arr[mid])
            {
                low = mid + 1;
                return searchNumber(key, arr, low, high);
            }
            else
            {
                high = mid - 1;
                return searchNumber(key, arr, low, high);
            }
        }
    }
}
