using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindrome
{
        /*给定一个字符串，验证它是否是回文串，只考虑字母和数字字符，可以忽略字母的大小写。

    说明：本题中，我们将空字符串定义为有效的回文串。

    示例 1:

    输入: "A man, a plan, a canal: Panama"
    输出: true
    示例 2:

    输入: "race a car"
    输出: false*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
            Console.ReadKey();
        }

        public static bool IsPalindrome(string s)
        {
            if (s == "") return true;
            var chars = s.ToUpper(). ToCharArray();
            int start = 0, end = chars.Length-1;
            while (start < end)
            {
                if (char.IsLetter(chars[start]) || char.IsNumber(chars[start]))
                {
                    if(char.IsLetter(chars[end]) || char.IsNumber(chars[end]))
                    {
                        if (chars[start]!=chars[end]) {
                            return false;
                        }
                        else
                        {
                            start++;
                            end--;
                        }
                    }
                    else
                    {
                        end--;
                    }
                }
                else
                {
                    start++;
                }
            }
            return true;
        }
    }
}
