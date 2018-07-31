using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 只出现一次的数字
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2,2,5,6,6};
            Console.WriteLine(SingleNumber(nums));
            Console.ReadKey();
        }

        public static int SingleNumber(int[] nums)
        {
            Array.Sort(nums);
            int Index = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i]-nums[i+1]!=0)
                {
                    Index++;
                }
                else
                {
                    Index = 0;
                }
                if ((Index == 1 &&i == 0)|| (Index == 2))
                {
                    Index = i;
                    break;
                }
                if (Index == 1 &&  i == nums.Length - 2)
                {
                    Index = i+1;
                    break;
                }
            }
            return nums[Index];
        }
    }
}
