using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation
{
    public class MatrixRotator
    {
        /* 1.6 - Given an NxN Matrix, where each pixed in the image is 4 bytes, write a
         * method to rotate the image by 90 degrees.  Can you do this in place?
         * 
         * --
         * Think of it as array's on each side that are walked and copied.  Each array is length-1,
         * and each element in the array moves accordingly:
         * 
         *  Top[x] -> Right[x] -> Bottom[x] -> Left[x]
         *  
         * Helps to think of all of these in relation to the Top as being the Row
         * 
         *  Top = Row
         *  Right = Inverse Col
         *  Bottom = Inverse Row
         *  Left = Col
         *  
         * Move one index through each array, moving to the others and repeat.
         * 
         * Now, you have to move down a row, and in a column (so address inner matrix's)
         * You could extract this matrix out and recurse until length is 2 or 3
         * Or, in my solution, I added an offset that always moved index's in accordingly. 
         * Stop at row = total rows / 2 - 1.
         * */

        public static char[,] RotateMatrix(char[,] m)
        {
            int length = m.GetLength(0);
            int offset = 0;
            
            for (int row = 0; row < length / 2; row++)
            {
                int invRow = length - 1 - row;
                int col = row;
                int invCol = length - 1 - row;

                for (int p = offset; p < length - 1 - offset; p++)
                {
                    char temp = m[row, col + p];
                    m[row, col + p] = m[invRow - p, col];
                    m[invRow - p, col] = m[invRow, invCol - p];
                    m[invRow, invCol - p] = m[row + p, invCol];
                    m[row + p, invCol] = temp;
                }

                offset++;
            }

            return m;
        }
    }
}
