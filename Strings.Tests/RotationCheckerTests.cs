using System;
using InterviewPreparation.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Strings
{
    [TestClass]
    public class RotationCheckerTests
    {
        [TestMethod]
        public void Strings_RotationCheckerPositives()
        {
            Assert.IsTrue(RotationChecker.IsRotationWithOneSubstringCall("ab", "ba"));
            Assert.IsTrue(RotationChecker.IsRotationWithOneSubstringCall("abc", "bca"));
            Assert.IsTrue(RotationChecker.IsRotationWithOneSubstringCall("abc", "cab"));
        }

        [TestMethod]
        public void Strings_RotationCheckerNegatives()
        {
            Assert.IsFalse(RotationChecker.IsRotationWithOneSubstringCall("bottle", "ottlbe"));
        }
    }
}
