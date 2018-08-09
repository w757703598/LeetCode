using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAtoi
{
//    实现 atoi，将字符串转为整数。

//在找到第一个非空字符之前，需要移除掉字符串中的空格字符。如果第一个非空字符是正号或负号，选取该符号，并将其与后面尽可能多的连续的数字组合起来，这部分字符即为整数的值。如果第一个非空字符是数字，则直接将其与之后连续的数字字符组合起来，形成整数。

//字符串可以在形成整数的字符后面包括多余的字符，这些字符可以被忽略，它们对于函数没有影响。

//当字符串中的第一个非空字符序列不是个有效的整数；或字符串为空；或字符串仅包含空白字符时，则不进行转换。

//若函数不能执行有效的转换，返回 0。

//说明：

//假设我们的环境只能存储 32 位有符号整数，其数值范围是[−231, 231 − 1]。如果数值超过可表示的范围，则返回 INT_MAX(231 − 1) 或 INT_MIN(−231) 。
    class Program
    {
        static void Main(string[] args)
        {
            string s = "-00124";
            Console.WriteLine(MyAtoi(s));
            Console.ReadKey();
        }

        public static int MyAtoi(string str)
        {
            str = str.TrimStart();
            if (str.Length == 0) return 0;
            var strs = str.ToList();
            var strtemp = "";
            if (char.IsNumber(strs[0]) || strs[0] == '-'|| strs[0] == '+')
            {
                strtemp += strs[0];
            }
            else
            {
                return 0;
            }
            var tempNumber= strs.FindAll(s => char.IsNumber(s));
            if (tempNumber.Count!=0)
            {               
                for (int i = 1; i < strs.Count; i++)
                {

                    if (char.IsNumber(strs[i]))
                    {
                        strtemp += strs[i];
                    }
                    else
                    {
                        if (!char.IsNumber(strs[0])&&i==1) return 0;
                        break;
                    }

                }
                int result = 0;
                try
                {
                    result = Convert.ToInt32(strtemp);
                    return result;
                }
                catch (Exception )
                {
                    if (strtemp[0] != '-')
                    {
                        return Int32.MaxValue;
                    }
                    else
                    {
                        return Int32.MinValue;
                    }
                }
 
            }
            else
            {
                return 0;
            }

        }
    }
}
