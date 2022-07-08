using System;
using InterviewPreparation.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.LinkedList
{
    [TestClass]
    public class ListPartitionerTests
    {
        [TestMethod]
        public void LinkedList_PartitionTest_Lof0()
        {
            Node<int> list = ListHelper.Build(new int[] { });
            Node<int> result = ListPartitioner.PartitionList(list, 0);
        }

        [TestMethod]
        public void LinkedList_PartitionTest_Lof1()
        {
            Node<int> list = ListHelper.Build(new int[] { 1 });
            Node<int> result = ListPartitioner.PartitionList(list, 1);

            Assert.IsTrue(ListHelper.AreEqual(list, result));
        }

        [TestMethod]
        public void LinkedList_PartitionTest_Lof2_NoSwap()
        {
            Node<int> list = ListHelper.Build(new int[] { 1, 2 });
            Node<int> result = ListPartitioner.PartitionList(list, 1);

            Assert.IsTrue(ListHelper.AreEqual(list, result));
        }

        [TestMethod]
        public void LinkedList_PartitionTest_Lof2_Swap()
        {
            Node<int> list = ListHelper.Build(new int[] { 2, 1 });
            Node<int> result = ListPartitioner.PartitionList(list, 1);
            Node<int> expect = ListHelper.Build(new int[] { 1, 2 });
 
            Assert.IsTrue(ListHelper.AreEqual(result, expect));
        }

        [TestMethod]
        public void LinkedList_PartitionTest_PNotIn()
        {
            Node<int> list = ListHelper.Build(new int[] { 2, 4, 5 });
            Node<int> result = ListPartitioner.PartitionList(list, 3);

            Assert.IsTrue(ListHelper.AreEqual(list, result));
        }

        [TestMethod]
        public void LinkedList_PartitionTest_PAtEnd()
        {
            Node<int> list = ListHelper.Build(new int[] { 2, 4, 5 });
            Node<int> result = ListPartitioner.PartitionList(list, 5);

            Assert.IsTrue(ListHelper.AreEqual(list, result));
        }

        [TestMethod]
        public void LinkedList_PartitionTest_PAtHead()
        {
            Node<int> list = ListHelper.Build(new int[] { 2, 4, 5 });
            Node<int> result = ListPartitioner.PartitionList(list, 2);

            Assert.IsTrue(ListHelper.AreEqual(list, result));
        }

        [TestMethod]
        public void LinkedList_PartitionTest_PAtMid()
        {
            Node<int> list = ListHelper.Build(new int[] { 2, 4, 5 });
            Node<int> result = ListPartitioner.PartitionList(list, 4);

            Assert.IsTrue(ListHelper.AreEqual(list, result));
        }

        [TestMethod]
        public void LinkedList_PartitionTest_ShiftCase1()
        {
            Node<int> list = ListHelper.Build(new int[] { 5, 4, 2 });
            Node<int> result = ListPartitioner.PartitionList(list, 4);
            Node<int> expect = ListHelper.Build(new int[] { 2, 4, 5 });

            Assert.IsTrue(ListHelper.AreEqual(expect, result));
        }

        [TestMethod]
        public void LinkedList_PartitionTest_ShiftCase2()
        {
            Node<int> list = ListHelper.Build(new int[] { 5, 4, 2 });
            Node<int> result = ListPartitioner.PartitionList(list, 2);
            Node<int> expect = ListHelper.Build(new int[] { 2, 5, 4 });

            Assert.IsTrue(ListHelper.AreEqual(expect, result));
        }

        [TestMethod]
        public void LinkedList_PartitionTest_ShiftCase3()
        {
            Node<int> list = ListHelper.Build(new int[] { 5, 4, 2 });
            Node<int> result = ListPartitioner.PartitionList(list, 5);
            Node<int> expect = ListHelper.Build(new int[] { 4, 2, 5 });

            Assert.IsTrue(ListHelper.AreEqual(expect, result));
        }

        [TestMethod]
        public void LinkedList_PartitionTest_SubListCase1()
        {
            Node<int> list = ListHelper.Build(new int[] { 2, 3, 4, 5, 6 });
            Node<int> result = ListPartitioner.PartitionList(list, 4);
            Node<int> expect = ListHelper.Build(new int[] { 2, 3, 4, 5, 6 });

            Assert.IsTrue(ListHelper.AreEqual(expect, result));
        }

        [TestMethod]
        public void LinkedList_PartitionTest_SubListCase2()
        {
            Node<int> list = ListHelper.Build(new int[] { 5, 6, 4, 3, 2 });
            Node<int> result = ListPartitioner.PartitionList(list, 4);
            Node<int> expect = ListHelper.Build(new int[] { 3, 2, 4, 5, 6 });

            Assert.IsTrue(ListHelper.AreEqual(expect, result));
        }

        [TestMethod]
        public void LinkedList_PartitionTest_SubListCase3()
        {
            Node<int> list = ListHelper.Build(new int[] { 5, 6, 4, 4, 3, 2 });
            Node<int> result = ListPartitioner.PartitionList(list, 4);
            Node<int> expect = ListHelper.Build(new int[] { 3, 2, 4, 4, 5, 6 });

            Assert.IsTrue(ListHelper.AreEqual(expect, result));
        }
    }
}
