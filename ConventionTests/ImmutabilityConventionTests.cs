using System;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternLibrary.ImmutableObjectConvention;

namespace ConventionTests
{
    [TestClass]
    public class ImmutabilityConventionTests
    {
        [TestMethod]
        public void TypesFromAssemblyAreImmutable()
        {
            var exceptTypeList = Assembly
                                    .GetAssembly(typeof (string)) //mscorelib
                                    .GetTypes();
            var types = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Except(exceptTypeList)
                .Where(type => !type.IsAbstract
                               && !type.IsInterface);
            var convTester = new ImmutableObjectConventionTest();
            foreach (var type in types)
            {
                convTester.Test(type);
            }
        }
    }
}
