using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace insertion_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 3, 7, 8, 3, 2, 4 };
            int n = nums.Length;

            for (int i = 1; i < n; i++)
            {
                int key = nums[i];
                int pre = i - 1;

                while (pre >= 0 && nums[pre] > key)
                {
                    nums[pre + 1] = nums[pre];
                    pre = pre - 1;
                }
                nums[pre + 1] = key;
            }

            foreach (int k in nums)
            {
                Console.WriteLine(k);
            }
        }
    }
}
