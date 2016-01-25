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
    public class EnumerableExtensionsTests
    {
        static readonly int[] Ints = { 1, 2, 3, 4, 5, 6 };

        [TestMethod()]
        public void StringifyIntsWithDefaultValuePrinter()
        {
            var stringified = Ints.Stringify();
            Assert.AreEqual("1, 2, 3, 4, 5, 6", stringified); 
        }

        [TestMethod()]
        public void StringifyIntsWithCustomValuePrinter()
        {
            Assert.AreEqual("2, 4, 6, 8, 10, 12", Ints.Stringify(e => (e + e).ToString()));
        }

        [TestMethod()]
        public void StringifyIntsWithCustomSeparatorAndCustomPrinter()
        {
            Assert.AreEqual("1.2.3.4.5.6", Ints.Stringify(e => e + "", "."));
        }
    }
}