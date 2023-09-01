using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort
{
    internal class Program
    {
        static int[] BubbleSort(int[] nums) {

            int n = nums.Length;
            bool exchanged;
            exchanged = false;

            while (!exchanged)
            {
                exchanged = true;
                for (int k = 0; k < n - 1; k++)
                {
                    if (nums[k] > nums[k + 1])
                    {
                        int temp = nums[k];
                        nums[k] = nums[k + 1];
                        nums[k + 1] = temp;
                        exchanged = false;
                    }

                }
            }
            return nums;
        }

        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 9, 2, 6, 10, 33, 4, 1, 3, 7, 43, 56, 57, 34 };
            int[] sorted_array = BubbleSort(nums);

            foreach (int i in sorted_array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
