using System;
using InterviewPreparation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.MultiDimenArrays
{
    [TestClass]
    public class MultiDimenArrayTests
    {
        [TestMethod]
        public void MultiDimenArrays_Initializers()
        {
            char[,] ar1 = { 
                { 'A', 'B' }, 
                { 'C', 'D' }, 
                { 'E', 'F' } };

            Assert.AreEqual('A', ar1[0, 0]);
            Assert.AreEqual('B', ar1[0, 1]);
            Assert.AreEqual('C', ar1[1, 0]);
            Assert.AreEqual('D', ar1[1, 1]);
            Assert.AreEqual('E', ar1[2, 0]);
            Assert.AreEqual('F', ar1[2, 1]);
        }

        [TestMethod]
        public void MultiDimenArrays_DimLength()
        {
            char[,] ar1 = {
                { 'A', 'B', 'C' },
                { 'D', 'E', 'F' },
                { 'G', 'H', 'I' },
                { 'J', 'K', 'L' } };

            Assert.AreEqual(12, ar1.Length);
            Assert.AreEqual(4, ar1.GetLength(0));
            Assert.AreEqual(3, ar1.GetLength(1));
        }

        [TestMethod]
        public void MultiDimenArrays_ThreeDimAccess()
        {
            char[,,] ar1 =
            {
                {
                    { 'A', 'B', 'C' },
                    { 'D', 'E', 'F' }
                },
                {
                    { 'G', 'H', 'I' },
                    { 'J', 'K', 'L' }
                }
            };

            Assert.AreEqual(2, ar1.GetLength(0));
            Assert.AreEqual(2, ar1.GetLength(1));
            Assert.AreEqual(3, ar1.GetLength(2));

            Assert.AreEqual('B', ar1[0, 0, 1]);
            Assert.AreEqual('G', ar1[1, 0, 0]);
            Assert.AreEqual('F', ar1[0, 1, 2]);
            Assert.AreEqual('K', ar1[1, 1, 1]);
        }

        [TestMethod]
        public void MultiDimenArrays_MatrixEq()
        {
            char[,] m1 =
                {
                    { 'A', 'B' },
                    { 'C', 'D' }
                };

            char[,] m2 =
                {
                    { 'A', 'B' },
                    { 'C', 'D' }
                };

            Assert.IsTrue(MatrixEquality.AreEqual(m1, m2));
        }

    }
}
