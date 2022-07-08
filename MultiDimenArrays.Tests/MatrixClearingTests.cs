using System;
using InterviewPreparation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.MultiDimenArrays
{
    [TestClass]
    public class MatrixClearingTests
    {
        [TestMethod]
        public void MultiDimenArrays_MatrixClearNoChanges()
        {
            int[,] m1 =
            {
                { 1, 2 },
                { 3, 4 }
            };

            int[,] m2 = MatrixClearer.ZeroOutRows(m1);

            Assert.IsTrue(MatrixEquality.AreEqual(m1, m2));
        }

        [TestMethod]
        public void MultiDimenArrays_MatrixClearOneSet()
        {
            int[,] m1 =
            {
                { 0, 2 },
                { 3, 4 }
            };

            m1 = MatrixClearer.ZeroOutRows(m1);

            int[,] m2 =
            {
                { 0, 0 },
                { 0, 4 }
            };

            Assert.IsTrue(MatrixEquality.AreEqual(m1, m2));
        }

        [TestMethod]
        public void MultiDimenArrays_ClearMultiSet()
        {
            int[,] m1 =
            {
                { 1, 2, 3, 4, 5 },
                { 1, 0, 3, 0, 5 },
                { 1, 2, 3, 4, 5 }
            };

            m1 = MatrixClearer.ZeroOutRows(m1);

            int[,] m2 =
            {
                { 1, 0, 3, 0, 5 },
                { 0, 0, 0, 0, 0 },
                { 1, 0, 3, 0, 5 }
            };

            Assert.IsTrue(MatrixEquality.AreEqual(m1, m2));
        }
    }
}
