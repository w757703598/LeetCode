using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1,2,3,1 };
            Console.WriteLine(ContainsDuplicate(nums));
            Console.ReadKey();
        }
        public static bool ContainsDuplicate(int[] nums)
        {
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i+1; j < nums.Length; j++)
            //    {
            //        if (nums[i] == nums[j]) return true;
            //    }

            //}
            //return false;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length-2; i++)
            {
                if (nums[i] == nums[i+1]) return true;
            }
            return false;
        }
        public static bool FastSort(int[] nums, int low, int high)
        {
            bool result = false;
            if (low >= high)
            {
                for (int i = 0; i < nums.Length-1; i++)
                {
                    if (nums[i] - nums[i + 1] == 0) result = true;
                }

            }
            int left = low, right = high;
            var Level = nums[low];
            while (low < high)
            {
                while (nums[high] >= Level && high > low)
                {
                    high--;
                }
                nums[low] = nums[high];
                while (nums[low] <= Level && high > low)
                {
                    low++;
                }
                nums[high] = nums[low];

            }
            nums[low] = Level;
            FastSort(nums, left, low - 1);//递归左边元素
            FastSort(nums, low + 1, right);//递归左边元素
            return result;
        }

    }
}
