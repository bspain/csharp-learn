using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation
{
    public class MatrixEquality
    {
        public static bool AreEqual(int[,] m1, int[,] m2)
        {
            // We lose the ability to get lengths of dimensions once
            // we cast to IList, so we need to check dimensions for each type
            // first.
            if (m1.GetLength(0) != m2.GetLength(0) ||
                m1.GetLength(1) != m2.GetLength(1))
            {
                return false;
            }

            return MatrixEquality.BaseAreEqual<int>(m1, m2);
        }

        public static bool AreEqual(char[,] m1, char[,] m2)
        {
            //...
            if (m1.GetLength(0) != m2.GetLength(0) ||
                m1.GetLength(1) != m2.GetLength(1))
            {
                return false;
            }

            return MatrixEquality.BaseAreEqual<char>(m1, m2);
        }

        private static bool BaseAreEqual<T>(IEnumerable m1, IEnumerable m2)
        {
            var m1E = m1.Cast<T>().GetEnumerator();
            var m2E = m2.Cast<T>().GetEnumerator();

            while (m1E.MoveNext())
            {
                m2E.MoveNext();

                if (!m1E.Current.Equals(m2E.Current))
                {
                    return false;
                }

            }
            return true;
        }
    }
}
