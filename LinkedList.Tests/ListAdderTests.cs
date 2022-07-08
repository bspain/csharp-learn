using System;
using InterviewPreparation.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.LinkedList
{
    [TestClass]
    public class ListAdderTests
    {
        [TestMethod]
        public void LinkedList_Base()
        {
            var a = ListHelper.Build(new int[] { 0 });
            var b = ListHelper.Build(new int[] { 0 });
            var ab = ListAdder.AddListsForward(a, b);
            var x = ListHelper.Build(new int[] { 0 });

            Assert.IsTrue(ListHelper.AreEqual(ab, x));

        }

        [TestMethod]
        public void LinkedList_Base2()
        {
            var a = ListHelper.Build(new int[] { 1 });
            var b = ListHelper.Build(new int[] { 1 });
            var ab = ListAdder.AddListsForward(a, b);
            var ba = ListAdder.AddListsRecurse(a, b);

            var x = ListHelper.Build(new int[] { 2 });

            Assert.IsTrue(ListHelper.AreEqual(ab, x));
            Assert.IsTrue(ListHelper.AreEqual(ba, x));
        }

        [TestMethod]
        public void LinkedList_Base3()
        {
            var a = ListHelper.Build(new int[] { 5 });
            var b = ListHelper.Build(new int[] { 5 });

            var ab = ListAdder.AddListsForward(a, b);
            var x = ListHelper.Build(new int[] { 0, 1 });

            Assert.IsTrue(ListHelper.AreEqual(ab, x));

            var ba = ListAdder.AddListsRecurse(a, b);
            var y = ListHelper.Build(new int[] { 1, 0 });

            Assert.IsTrue(ListHelper.AreEqual(ba, y));
        }

        [TestMethod]
        public void LinkedList_AdderForward_DiffSize()
        {
            var a = ListHelper.Build(new int[] { 5, 1 });
            var b = ListHelper.Build(new int[] { 5 });

            var ab = ListAdder.AddListsForward(a, b);
            var x = ListHelper.Build(new int[] { 0, 2 });
        }

        [TestMethod]
        public void LinkedList_AdderForward_DiffSize2()
        {
            var a = ListHelper.Build(new int[] { 5, 5 });
            var b = ListHelper.Build(new int[] { 5, 5, 2 });
            var ab = ListAdder.AddListsForward(a, b);
            var x = ListHelper.Build(new int[] { 0, 1, 3 });

            Assert.IsTrue(ListHelper.AreEqual(ab, x));
        }

        [TestMethod]
        public void LinkedList_AdderRecurse_Size2_NoCarry()
        {
            var a = ListHelper.Build(new int[] { 1, 2 });
            var aa = ListAdder.AddListsRecurse(a, a);

            var x = ListHelper.Build(new int[] { 2, 4 });

            Assert.IsTrue(ListHelper.AreEqual(aa, x));
        }

        [TestMethod]
        public void LinkedList_AdderRecurse_Size2_WithCarry()
        {
            var a = ListHelper.Build(new int[] { 1, 6 });
            var aa = ListAdder.AddListsRecurse(a, a);

            var x = ListHelper.Build(new int[] { 3, 2 });

            Assert.IsTrue(ListHelper.AreEqual(aa, x));
        }

        [TestMethod]
        public void LinkedList_AdderRecurse_Size2_CarryOver()
        {
            var a = ListHelper.Build(new int[] { 5, 0 });
            var aa = ListAdder.AddListsRecurse(a, a);

            var x = ListHelper.Build(new int[] { 1,0, 0 });

            Assert.IsTrue(ListHelper.AreEqual(aa, x));
        }

        [TestMethod]
        public void LinkedList_AdderRecurse_SizeDiff_NoCarry()
        {
            var a = ListHelper.Build(new int[] { 1, 0 });
            var b = ListHelper.Build(new int[] { 5 });
            var ab = ListAdder.AddListsRecurse(a, b);
            var ba = ListAdder.AddListsRecurse(b, a);

            var x = ListHelper.Build(new int[] { 1, 5 });

            Assert.IsTrue(ListHelper.AreEqual(ab, x));
            Assert.IsTrue(ListHelper.AreEqual(ba, x));

        }

        [TestMethod]
        public void LinkedList_AdderRecurse_SizeDiff_Carry()
        {
            var a = ListHelper.Build(new int[] { 9, 5 });
            var b = ListHelper.Build(new int[] { 5 });
            var ab = ListAdder.AddListsRecurse(a, b);
            var ba = ListAdder.AddListsRecurse(b, a);

            var x = ListHelper.Build(new int[] { 1, 0, 0 });

            Assert.IsTrue(ListHelper.AreEqual(ab, x));
            Assert.IsTrue(ListHelper.AreEqual(ba, x));
        }

    }
}
