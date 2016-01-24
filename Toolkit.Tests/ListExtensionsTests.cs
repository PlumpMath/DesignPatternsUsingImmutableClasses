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
    public class ListExtensionsTests
    {
        static readonly int[] Ints = { 1, 2, 3, 4, 5, 6 };

        [TestMethod()]
        public void StringifyIntsWithDefaultValuePrinter()
        {
            Assert.AreEqual(Ints.Stringify(), "1 2 3 4 5 6"); 
        }

        [TestMethod()]
        public void StringifyIntsWithCustomValuePrinter()
        {
            Assert.AreEqual(Ints.Stringify(e=>(e+e).ToString()), "2 4 6 8 10 12");
        }

        [TestMethod()]
        public void StringifyIntsWithCustomSeparatorAndCustomPrinter()
        {
            Assert.AreEqual(Ints.Stringify(e => e+"", "."), "1.2.3.4.5.6");
        }
    }
}