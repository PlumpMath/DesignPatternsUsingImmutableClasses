using System;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternLibrary.ImmutableObjectConvention;
using PatternLibrary.Logging;

namespace ConventionTests
{
    [TestClass]
    public class ImmutabilityConventionTests
    {
        [TestMethod]
        public void TypesFromAssemblyAreImmutable()
        {

            var allTypes = Assembly
                .GetAssembly(typeof(ILogger))
                .GetTypes();

            var exceptTypeList = Assembly
                                    .GetAssembly(typeof (string)) //mscorelib
                                    .GetTypes();

            var tests = allTypes
                .Where(type => type.FullName.Contains("Test")
                            || type.FullName.Contains("GetEnumerator")
                            || type.FullName.Contains("+<>") // lambda
                            )
                ;

            var exceptList = exceptTypeList.Union(tests).ToList();

            var types = allTypes
                .Except(exceptList)
                .Where(type => !type.IsAbstract
                               && !type.IsInterface)
                .ToList();
            var convTester = new ImmutableObjectConventionTest();
            foreach (var type in types)
            {
                convTester.Test(type);
            }
        }
    }
}
