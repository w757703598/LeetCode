using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 两个数组的交集
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1,2 };
            int[] nums1 = new int[] { 1,1 };
            var numTemp=Intersect(nums, nums1);
            for (int i = 0; i < numTemp.Length; i++)
            {
                Console.WriteLine(numTemp[i]);
            }

            Console.ReadKey();
        }
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            int i=0, j = 0;
            List<int> list = new List<int>();
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] > nums2[j])
                {
                    j++;
                }
                else
                {
                    if (nums1[i] < nums2[j])
                    {
                        i++;
                    }
                    else
                    {
                        list.Add(nums2[j]);
                        i++;
                        j++;
                    }
                }
            }
            return list.ToArray();
        }
    }
}
