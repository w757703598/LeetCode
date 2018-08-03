using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public void Rotate(int[,] matrix)
        {
            var rowLength = matrix.GetLength(0)-1;
            var columnLength = matrix.GetLength(1)-1;

            for (int i = 0; i < rowLength/2+1; i++)
            {
                for (int j = i; j < columnLength-i; j++)
                {
                    var temp = matrix[i,j];
                    matrix[i, j] = matrix[rowLength - j,i];
                    matrix[rowLength - j, i] = matrix[columnLength-i, columnLength - j];
                    matrix[columnLength -i, columnLength - j ] = matrix[j, rowLength -i];
                    matrix[j, rowLength -i] = temp;
                }
            }
        }
    }
}
