using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {1,2,3};
            var numTemp = PlusOne(nums);
            for (int i = 0; i < numTemp.Length; i++)
            {
                Console.WriteLine(numTemp[i]);
            }

            Console.ReadKey();
        }
        public static int[] PlusOne(int[] digits)
        {
            var list = digits.ToList();
            var index = list.Count - 1;
            for (int i = index; i >= 0; i--)
            {
                if (list[i] < 9)
                {
                    list[i] += 1;
                    return list.ToArray();
                }
                list[i] = 0;

            }
            list.Insert(0, 1);
            return list.ToArray();



        }
    }
}
