using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反转字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("Hello"));
            Console.ReadKey();
        }

        public static string ReverseString(string s)
        {           
            var temp= s.Reverse();
            StringBuilder sb = new StringBuilder();
            foreach (var item in temp)
            {
                sb.Append(item);
            }
            return sb.ToString();
        }
    }
}
