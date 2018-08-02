using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsValidSudoku
{
    class Program
    {
        /*
         示例 1:

输入:
[
  ['5','3','.','.','7','.','.','.','.'],
  ['6','.','.','1','9','5','.','.','.'],
  ['.','9','8','.','.','.','.','6','.'],
  ['8','.','.','.','6','.','.','.','3'],
  ['4','.','.','8','.','3','.','.','1'],
  ['7','.','.','.','2','.','.','.','6'],
  ['.','6','.','.','.','.','2','8','.'],
  ['.','.','.','4','1','9','.','.','5'],
  ['.','.','.','.','8','.','.','7','9']
]
输出: true*
说明:

一个有效的数独（部分已被填充）不一定是可解的。
只需要根据以上规则，验证已经填入的数字是否有效即可。
给定数独序列只包含数字 1-9 和字符 '.' 。
给定数独永远是 9x9 形式的。
*/

        static void Main(string[] args)
        {
            char[,] nums = new char[,] { 
                { '3', '.', '.', '.', '8', '9', '.', '.', '.'},
                {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
                {'.', '.', '.', '.', '.', '.', '.', '.', '2'},
                {'.', '.', '.', '.', '6', '.', '.', '.', '.'},
                {'.', '.', '.', '.', '.', '.', '.', '9', '3'},
                {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
                {'.', '.', '9', '.', '.', '.', '.', '2', '.'},
                {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
                {'.', '4', '.', '.', '.', '.', '.', '.', '6'}};
            Console.WriteLine(IsValidSudoku(nums));
            Console.ReadKey();

        }
        public static bool IsValidSudoku(char[,] board)
        {

            var rowLength = board.GetLength(0);
            var columnLength = board.GetLength(1);
            //判断行
            for (int i = 0; i < rowLength; i++)
            {
                var rowData = new List<char>();
                for (int j = 0; j < columnLength; j++)
                {
                    if (board[i, j].Equals('.')) continue;
                    rowData.Add(board[i, j]);
                    var temp = rowData.Distinct().ToList();
                    if (!temp.SequenceEqual(rowData)) return false;

                }
                //列
                var columnData = new List<char>();
                for (int j = 0; j < columnLength; j++)
                {
                    if (board[j, i].Equals('.')) continue;
                    columnData.Add(board[j, i]);
                    if (!columnData.Distinct().SequenceEqual(columnData)) return false;

                }
            }
            //宫
            for (int i = 0; i < rowLength; i+=3)
            {
                for (int j = 0; j < columnLength; j+=3)
                {
                    if (!Goong(board, i, j)) return false;
                }
            }

            return true;
        }
        static bool Goong(char[,] board,int x,int y)
        {
            var data = new List<char>();
            for (int i = x; i < x+3; i++)
            {                
                for (int j = y; j < y+3; j++)
                {
                    if (board[j, i].Equals('.')) continue;
                    data.Add(board[j, i]);
                    if (!data.Distinct().SequenceEqual(data)) return false;

                }
            }
            return true;
        }
    }
}
