using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    //给定一个整数数组和一个目标值，找出数组中和为目标值的两个数。

    //你可以假设每个输入只对应一种答案，且同样的元素不能被重复利用。

    //示例:

    //给定 nums = [2, 7, 11, 15], target = 9

    //因为 nums[0] + nums[1] = 2 + 7 = 9
    //所以返回[0, 1]
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {-1, -2, -3, -4, -5 };
            var temp= TwoSum(nums, -8);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(temp[i]);
            }

            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            //Array.Sort(nums);
            int temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                List<int> result = new List<int>();
                    temp = nums[i];
                    result.Add(i);
                    for (int j = i+1; j < nums.Length; j++)
                    {
                        temp += nums[j];
                        if (temp == target)
                        {
                            result.Add(j);
                            return result.ToArray();
                        }

                        else
                        {
                            temp -= nums[j];
                        }
                    }                
            }
            return null;
        }
    }
}
