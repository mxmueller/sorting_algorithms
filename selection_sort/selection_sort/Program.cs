using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection_sort
{
    internal class Program
    {
        static int[] SelectionSort(int[] nums)
        {
            int n = nums.Length;
            for(int m = 0; m < n - 1; m++)
            {
                int min = m;
                for (int q = (m + 1); q < n; q++)
                {
                    if (nums[q] < nums[min])
                    {
                        min = q;
                    }
                }

                int temp = nums[m];
                nums[m] = nums[min];
                nums[min] = temp;

            }
            return nums;
        }

        static void Main(string[] args)
        {
            int[] randoms = {
                23, 45, 12, 67, 89, 34, 56, 78, 90, 11,
                43, 55, 88, 21, 66, 39, 72, 15, 83, 98,
                29, 77, 51, 62, 17, 31, 74, 53, 92, 28,
                60, 84, 37, 70, 26, 48, 71, 94, 19, 63
            };
            int[] sorted = SelectionSort(randoms);
            
            foreach (int i in sorted)
            {
                Console.WriteLine(i);
            }

        }
    }
}
