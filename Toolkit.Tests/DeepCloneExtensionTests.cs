using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolkit.Tests
{
    [TestClass()]
    public class DeepCloneExtensionTests
    {
        [TestMethod()]
        public void IntDeepCloneTest()
        {
            var a = 5;
            var b = a.DeepClone();
            Assert.Equals(a, b);
        }

        [TestMethod()]
        public void StringDeepCloneTest()
        {
            var a = "asdf";
            var b = a.DeepClone();
            Assert.Equals(a, b);
        }

        [TestMethod()]
        public void ListDeepCloneEqualAfterCloningTest()
        {
            var a = Enumerable
                        .Range(0, 10)
                        .ToList()
                        .Cast<string>()
                        .ToList();
            var b = a.DeepClone();
            Assert.IsTrue(a.SequenceEqual(b));
        }

        [TestMethod()]
        public void ListDeepCloneNotEqualAfterCloningAndChangingTest()
        {
            var a = Enumerable
                        .Range(0, 10)
                        .ToList()
                        .Cast<string>()
                        .ToList();
            var b = a.DeepClone();
            b[1] = "test";
            Assert.IsFalse(a.SequenceEqual(b));
        }
    }
}