using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation
{
    /* 1.7 - Write an algorithm such that in an elemnt in an MxN matrix is 0.  It's entire
     * row and column are set to 0.
     * 
     * --
     * Trick is to make one pass that accounts for 0's, and then go through and clear.  
     * Use row/col array's to track what to zero out on the second pass.
     * */

    public class MatrixClearer
    {
        public static int[,] ZeroOutRows(int[,] m1)
        {
            int rowCount = m1.GetLength(0);
            int colCount = m1.GetLength(1);

            bool[] rowsToClear = new bool[rowCount];
            bool[] colsToClear = new bool[colCount];

            for(int r = 0; r < rowCount; r++)
            {
                for(int c = 0; c < colCount; c++)
                {
                    if (m1[r, c] == 0)
                    {
                        rowsToClear[r] = true;
                        colsToClear[c] = true;
                    }
                }
            }

            // Clear accordingly
            for(int r = 0; r < rowCount; r++)
            {
                bool clearRowBit = rowsToClear[r];

                for (int c = 0; c < colCount; c++)
                {
                    if (colsToClear[c] || clearRowBit)
                    {
                        m1[r, c] = 0;
                    }
                }
            }

            return m1;
        }
    }
}
