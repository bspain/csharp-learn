using System;
using InterviewPreparation.StacksAndQueues;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.StacksAndQueues
{
    [TestClass]
    public class HanoiTowerTests
    {
        [TestMethod]
        public void HanoiTower_Depth1()
        {
            HanoiTower t = new HanoiTower(1);
            t.Go();

            Assert.AreEqual(t.MoveRecord.Count, 2);
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 0, 1));
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 1, 2));

            var results = t.GetResults();

            Assert.AreEqual(1, results.Pop());
        }

        [TestMethod]
        public void HanoiTower_Depth2()
        {
            HanoiTower t = new HanoiTower(2);
            t.Go();

            Assert.AreEqual(t.MoveRecord.Count, 8);

            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 0, 1));
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 1, 2));

            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(2, 0, 1));

            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 2, 1));
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 1, 0));

            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(2, 1, 2));

            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 0, 1));
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 1, 2));

            var results = t.GetResults();

            Assert.AreEqual(1, results.Pop());
            Assert.AreEqual(2, results.Pop());        
        }


        [TestMethod]
        public void HanoiTower_Depth3()
        {
            HanoiTower t = new HanoiTower(3);
            t.Go();

            Assert.AreEqual(t.MoveRecord.Count, 26);

            // 1 ->>
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 0, 1));
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 1, 2));

            // 2 ->
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(2, 0, 1));

            // 1 <<-
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 2, 1));
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 1, 0));

            // 2 ->
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(2, 1, 2));

            // 1 ->>
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 0, 1));
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 1, 2));

            // 3 ->
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(3, 0, 1));

            // 1 <<-
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 2, 1));
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 1, 0));

            // 2 <-
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(2, 2, 1));

            // 1 ->>
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 0, 1));
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 1, 2));

            // 2 <-
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(2, 1, 0));

            // 1 <<-
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 2, 1));
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 1, 0));

            // 3 ->
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(3, 1, 2));

            // 1 ->>
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 0, 1));
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 1, 2));

            // 2 ->
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(2, 0, 1));

            // 1 <<-
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 2, 1));
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 1, 0));

            // 2 ->
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(2, 1, 2));

            // 1 ->>
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 0, 1));
            Assert.IsTrue(t.MoveRecord.Dequeue().IsEqualTo(1, 1, 2));

            var results = t.GetResults();

            Assert.AreEqual(1, results.Pop());
            Assert.AreEqual(2, results.Pop());
            Assert.AreEqual(3, results.Pop());
        }
    }
}
