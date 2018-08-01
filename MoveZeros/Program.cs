using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1,0, 1, 0, 3, 12 };
            MoveZeroes(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            Console.ReadKey();
        }
        public static void MoveZeroes(int[] nums)
        {
            int Index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    Index++;
                }
                else
                {
                    if (Index != 0)
                    {
                        nums[i - Index] = nums[i];
                        nums[i] = 0;
                    }

                }
            }
        }
    }
}
