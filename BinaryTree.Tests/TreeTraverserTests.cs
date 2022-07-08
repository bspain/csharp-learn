using System;
using InterviewPreparation.BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.BinaryTree
{
    [TestClass]
    public class TreeTraverserTests
    {
        [TestMethod]
        public void TreeTraverser_TraverseTests()
        {
            Node<int> root = new Node<int>(5);
            TreeTraverser<int> tt = new TreeTraverser<int>(root);

            Assert.AreEqual("5", tt.Traverse());
            Assert.AreEqual("5", tt.Traverse(TraverseType.PreOrder));
            Assert.AreEqual("5", tt.Traverse(TraverseType.PostOrder));
            Assert.AreEqual("5", tt.Traverse(TraverseType.BreadthFirst));

            root.left = new Node<int>(2);
            root.right = new Node<int>(8);

            Assert.AreEqual("2,5,8", tt.Traverse());
            Assert.AreEqual("5,2,8", tt.Traverse(TraverseType.PreOrder));
            Assert.AreEqual("2,8,5", tt.Traverse(TraverseType.PostOrder));
            Assert.AreEqual("5,2,8", tt.Traverse(TraverseType.BreadthFirst));

            root.left.left = new Node<int>(1);
            root.left.right = new Node<int>(3);

            root.right.left = new Node<int>(6);

            Assert.AreEqual("1,2,3,5,6,8", tt.Traverse());
            Assert.AreEqual("5,2,1,3,8,6", tt.Traverse(TraverseType.PreOrder));
            Assert.AreEqual("1,3,2,6,8,5", tt.Traverse(TraverseType.PostOrder));
            Assert.AreEqual("5,2,8,1,3,6", tt.Traverse(TraverseType.BreadthFirst));
        }
    }
}
