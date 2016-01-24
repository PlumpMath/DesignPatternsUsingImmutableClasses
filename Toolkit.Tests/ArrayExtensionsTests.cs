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
    public class ArrayExtensionsTests
    {
        [TestMethod()]
        public void ForEachTest()
        {
            int[] ints = {1, 2, 3, 4, 5};
            ints.ForEach((array, intis)=> {});
        }
    }
}