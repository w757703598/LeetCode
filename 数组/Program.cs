using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[0];
            nums = null;
            Console.WriteLine( RemoveDuplicates(nums));
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadKey();
        }

        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int Index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != nums[Index])
                {
                    Index++;
                    nums[Index] = nums[i];
                }
            }
            return Index++;
        }

        
    }
}
