using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 颠倒整数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(-2147483648));
            Console.ReadKey();
        }
        public static int Reverse(int x )
        {
      
            var xStr = x.ToString().Contains("-")? x.ToString().Split('-')[1]:x.ToString();
            var xChars= xStr.Reverse();
            StringBuilder sb = new StringBuilder();
            foreach (var item in xChars)
            {
                sb.Append(item);
            }
            var temp = Convert.ToInt64(sb.ToString());
            if (temp > Int32.MaxValue)
            {
                return 0;
            }
            else
            {
                var result = Convert.ToInt32(temp);
                if (x < 0)
                {
                    return 0 - result;
                }
                else
                {
                    return result;
                }
            }
        }
    }
}
