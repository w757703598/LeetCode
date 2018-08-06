using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUniqChar
{
    class Program
    {
        /// <summary>
        /// 给定一个字符串，找到它的第一个不重复的字符，并返回它的索引。如果不存在，则返回 -1。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
             Console.WriteLine(FirstUniqChar("dddccdbba"));
            Console.ReadKey();
        }
        public static int FirstUniqChar(string s)
        {
            if (string.IsNullOrEmpty(s)) return -1;//为空则无
            if (s.Length == 1) return 0;//
            Dictionary<char, int> keyValues = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (keyValues.ContainsKey(s[i]))
                {
                    keyValues[s[i]]++;
                }
                else
                {
                    keyValues.Add(s[i], 1);
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (keyValues[s[i]] == 1) return i;
            }

            return -1;
        }
    }
}
