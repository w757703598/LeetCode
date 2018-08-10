using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strStr
{
    class Program
    {
        //实现 strStr() 函数。给定一个 haystack 字符串和一个 needle 字符串，在 haystack 字符串中找出 needle 字符串出现的第一个位置(从0开始)。如果不存在，则返回  -1。
        static void Main(string[] args)
        {
        }
        public int StrStr(string haystack, string needle)
        {
            if (needle == "") return 0;
            return  haystack.IndexOf(needle);
        }
    }
}
