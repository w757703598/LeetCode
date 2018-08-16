using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefix
{
    class Program
    {
        //        编写一个函数来查找字符串数组中的最长公共前缀。

        //如果不存在公共前缀，返回空字符串 ""。
        static void Main(string[] args)
        {
            string[] strs = new string[] { "aa", "a" };
            Console.WriteLine(LongestCommonPrefix(strs));
            Console.ReadKey();
        }
        
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length==0) return "";
            var temp = strs[0];
            for (int i = 1; i < strs.Length; i++)
           {
                var newTemp = "";

                for (int j = 0; j < temp.Length; j++)
                {
                    if (j >= strs[i].Length) break;
                    if (temp[j] == strs[i][j])
                    {
                        newTemp += temp[j];
                    }
                    else
                    {
                        break;
                    }
                }
                temp = newTemp;
            }
            return temp;
        }
    }
}
