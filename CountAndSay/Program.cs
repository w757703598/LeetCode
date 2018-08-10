using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountAndSay
{
//    报数序列是指一个整数序列，按照其中的整数的顺序进行报数，得到下一个数。其前五项如下：

//1.     1
//2.     11
//3.     21
//4.     1211
//5.     111221
//1 被读作  "one 1"  ("一个一") , 即 11。
//11 被读作 "two 1s" ("两个一"）, 即 21。
//21 被读作 "one 2",  "one 1" （"一个二" ,  "一个一") , 即 1211。

//给定一个正整数 n ，输出报数序列的第 n 项。

//注意：整数顺序将表示为一个字符串。
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( CountAndSay(4));
            Console.ReadKey();
        }
        public static string CountAndSay(int n)
        {
            string str = "1";
            string tempStr = "";
            if (n == 1) return str;
            for (int i = 1; i < n; i++)
            {
                int count = 1;
                for (int j = 0; j < str.Length; j++)
                {
                    if (j + 1 < str.Length&&str[j] == str[j + 1])
                    {
                        count++;
                    }
                    else
                    {
                        tempStr += count;
                        tempStr += str[j];
                        count = 1;
                    }
                }
                str = tempStr;
                tempStr = "";
            }
            return str;
        }
    }
}
