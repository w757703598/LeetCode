using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组旋转
{
    class Program
    {
        //给定一个数组，将数组中的元素向右移动 k 个位置，其中 k 是非负数。
        static void Main(string[] args)
        {
            int[] nums = new int[] { -1 };
            Resver(nums, 2);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 临时数组
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public static void Rotate(int[] nums, int k)
        {
            if (nums.Length < k)
            {
                k = k - nums.Length;
            }
            if (nums.Length > k)
            {
                var temp = new int[nums.Length];
                int Index = nums.Length - k;
                for (int i = 0; i < k; i++)
                {
                    temp[i] = nums[i + Index];

                }
                for (int i = k; i < nums.Length; i++)
                {
                    temp[i] = nums[i - k];
                }
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = temp[i];
                }
            }
           

        }
        /// <summary>
        /// 反转
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public static void Resver(int [] nums ,int k)
        {
            if (nums.Length < k)
            {
                k = k - nums.Length;
            }
            if (nums.Length > k)
            {
                Array.Reverse(nums);
                Array.Reverse(nums, 0, k);
                Array.Reverse(nums, k, nums.Length - k);
            }
 

        }


    }
}
