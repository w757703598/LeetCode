using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAnagram
{
    class Program
    {
        /*给定两个字符串 s 和 t ，编写一个函数来判断 t 是否是 s 的一个字母异位词。

示例 1:

输入: s = "anagram", t = "nagaram"
输出: true
示例 2:

输入: s = "rat", t = "car"
输出: false
说明:
你可以假设字符串只包含小写字母。

进阶:
如果输入字符串包含 unicode 字符怎么办？你能否调整你的解法来应对这种情况？*/
        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram("a", "b"));
            Console.ReadKey();
        }
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            var temp = 0;
            Dictionary<char, int> keyValuePairs1 = new Dictionary<char, int>();
            Dictionary<char, int> keyValuePairs2 = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (keyValuePairs1.ContainsKey(s[i]))
                {
                    keyValuePairs1[s[i]]++;
                }
                else
                {
                    keyValuePairs1.Add(s[i], 1);
                }
                if (keyValuePairs2.ContainsKey(t[i]))
                {
                    keyValuePairs2[t[i]]++;
                }
                else
                {
                    keyValuePairs2.Add(t[i], 1);
                }
            }
            for (int i = 0; i < keyValuePairs1.Count; i++)
            {
                if (!keyValuePairs2.ContainsKey(s[i])) return false;
                if (keyValuePairs1[s[i]] != keyValuePairs2[s[i]]) return false;
            }
            return true;
        }
    }
}
