using System;
using InterviewPreparation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.MultiDimenArrays
{
    [TestClass]
    public class MatrixRotationTests
    {
        [TestMethod]
        public void MultiDimenArrays_MatrixRotation2x2()
        {
            char[,] sqOrig =
                {
                    { 'A', 'B' },
                    { 'C', 'D' }
                };

            char[,] sqExpect =
                {
                    { 'C', 'A' },
                    { 'D', 'B' }
                };

            sqOrig = MatrixRotator.RotateMatrix(sqOrig);

            Assert.IsTrue(MatrixEquality.AreEqual(sqOrig, sqExpect));
        }

        [TestMethod]
        public void MultiDimenArrays_MatrixRotation3x3()
        {
            char[,] sqOrig =
                {
                    { 'A', 'B', 'C' },
                    { 'D', 'E', 'F' },
                    { 'G', 'H', 'I' },
                };

            char[,] sqExpect =
                {
                    { 'G', 'D', 'A' },
                    { 'H', 'E', 'B' },
                    { 'I', 'F', 'C' },
                };

            sqOrig = MatrixRotator.RotateMatrix(sqOrig);

            Assert.IsTrue(MatrixEquality.AreEqual(sqOrig, sqExpect));
        }

        [TestMethod]
        public void MultiDimenArrays_MatrixRotation4x4()
        {
            char[,] sqOrig =
                {
                    { 'A', 'B', 'C', 'D' },
                    { 'E', 'F', 'G', 'H' },
                    { 'I', 'J', 'K', 'L' },
                    { 'M', 'N', 'O', 'P' },
                };

            char[,] sqExpect =
                {
                    { 'M', 'I', 'E', 'A' },
                    { 'N', 'J', 'F', 'B' },
                    { 'O', 'K', 'G', 'C' },
                    { 'P', 'L', 'H', 'D' },
                };

            sqOrig = MatrixRotator.RotateMatrix(sqOrig);

            Assert.IsTrue(MatrixEquality.AreEqual(sqOrig, sqExpect));
        }

        [TestMethod]
        public void MultiDimenArrays_MatrixRotation5x5()
        {
            char[,] sqOrig =
                {
                    { 'A', 'B', 'C', 'D', 'E' },
                    { 'F', 'G', 'H', 'I', 'J' },
                    { 'K', 'L', 'M', 'N', 'O' },
                    { 'P', 'Q', 'R', 'S', 'T' },
                    { 'U', 'V', 'W', 'X', 'Y' },
                };

            char[,] sqExpect =
                {
                    { 'U', 'P', 'K', 'F', 'A' },
                    { 'V', 'Q', 'L', 'G', 'B' },
                    { 'W', 'R', 'M', 'H', 'C' },
                    { 'X', 'S', 'N', 'I', 'D' },
                    { 'Y', 'T', 'O', 'J', 'E' },
                };

            sqOrig = MatrixRotator.RotateMatrix(sqOrig);

            Assert.IsTrue(MatrixEquality.AreEqual(sqOrig, sqExpect));
        }
    }
}
