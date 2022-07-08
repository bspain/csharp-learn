using System;
using InterviewPreparation.BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.BinaryTree
{
    [TestClass]
    public class MinimalBinarySearchTreeCreatorTests
    {
        [TestMethod]
        public void MinBST_BaseCase1()
        {
            int[] source = new int[] { 2 };
            Node<int> root = MinimalBinarySearchTreeCreator<int>.CreateFromSortedArray(source);


            TreeTraverser<int> tt = new TreeTraverser<int>(root);
            Assert.AreEqual("2", tt.Traverse());
        }

        [TestMethod]
        public void MinBST_BaseCase2()
        {
            int[] source = new int[] { 1, 2 };
            Node<int> root = MinimalBinarySearchTreeCreator<int>.CreateFromSortedArray(source);


            TreeTraverser<int> tt = new TreeTraverser<int>(root);
            Assert.AreEqual("1,2", tt.Traverse());
            Assert.AreEqual("2,1", tt.Traverse(TraverseType.PreOrder));
        }

        [TestMethod]
        public void MinBST_BaseCase3()
        {
            int[] source = new int[] { 1, 2, 3 };
            Node<int> root = MinimalBinarySearchTreeCreator<int>.CreateFromSortedArray(source);


            TreeTraverser<int> tt = new TreeTraverser<int>(root);
            Assert.AreEqual("1,2,3", tt.Traverse());
            Assert.AreEqual("2,1,3", tt.Traverse(TraverseType.PreOrder));
            Assert.AreEqual("1,3,2", tt.Traverse(TraverseType.PostOrder));
        }

        [TestMethod]
        public void MinBST_BaseCase4()
        {
            int[] source = new int[] { 1, 2, 3, 4 };
            Node<int> root = MinimalBinarySearchTreeCreator<int>.CreateFromSortedArray(source);

            //   3
            //  2 4
            // 1

            TreeTraverser<int> tt = new TreeTraverser<int>(root);
            Assert.AreEqual("1,2,3,4", tt.Traverse());
            Assert.AreEqual("3,2,1,4", tt.Traverse(TraverseType.PreOrder));
            Assert.AreEqual("1,2,4,3", tt.Traverse(TraverseType.PostOrder));
            Assert.AreEqual("3,2,4,1", tt.Traverse(TraverseType.BreadthFirst));
        }

        [TestMethod]
        public void MinBST_BaseCase5()
        {
            int[] source = new int[] { 1, 2, 3, 4, 5 };
            Node<int> root = MinimalBinarySearchTreeCreator<int>.CreateFromSortedArray(source);

            //     3
            //   2   5
            // 1    4

            TreeTraverser<int> tt = new TreeTraverser<int>(root);
            Assert.AreEqual("1,2,3,4,5", tt.Traverse());
            Assert.AreEqual("3,2,1,5,4", tt.Traverse(TraverseType.PreOrder));
            Assert.AreEqual("1,2,4,5,3", tt.Traverse(TraverseType.PostOrder));
            Assert.AreEqual("3,2,5,1,4", tt.Traverse(TraverseType.BreadthFirst));

        }

        [TestMethod]
        public void MinBST_BaseCase6()
        {
            int[] source = new int[] { 1, 2, 3, 4, 5, 6 };
            Node<int> root = MinimalBinarySearchTreeCreator<int>.CreateFromSortedArray(source);

            //     4
            //   2    6
            // 1  3  5

            TreeTraverser<int> tt = new TreeTraverser<int>(root);
            Assert.AreEqual("1,2,3,4,5,6", tt.Traverse());
            Assert.AreEqual("4,2,1,3,6,5", tt.Traverse(TraverseType.PreOrder));
            Assert.AreEqual("1,3,2,5,6,4", tt.Traverse(TraverseType.PostOrder));
            Assert.AreEqual("4,2,6,1,3,5", tt.Traverse(TraverseType.BreadthFirst));
        }

        [TestMethod]
        public void MinBST_BaseCase7()
        {
            int[] source = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Node<int> root = MinimalBinarySearchTreeCreator<int>.CreateFromSortedArray(source);

            //     4
            //   2    6
            // 1  3  5  7

            TreeTraverser<int> tt = new TreeTraverser<int>(root);
            Assert.AreEqual("1,2,3,4,5,6,7", tt.Traverse());
            Assert.AreEqual("4,2,1,3,6,5,7", tt.Traverse(TraverseType.PreOrder));
            Assert.AreEqual("1,3,2,5,7,6,4", tt.Traverse(TraverseType.PostOrder));
            Assert.AreEqual("4,2,6,1,3,5,7", tt.Traverse(TraverseType.BreadthFirst));
        }

    }
}
