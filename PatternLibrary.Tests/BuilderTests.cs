using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Builder;
using Toolkit;

namespace PatternLibrary.Tests
{
    [TestClass]
    public class BuilderTests
    {
        [TestMethod]
        public void RobotHasTheElementsThatItWasGivenByEngineer()
        {
            var eng = new RobotEngineer()
                        .WithBuilder(new RobotBuilder())
                        .CreateProduct();
            var robotStr = (eng as Robot)?.GetRobotElements()
                        .Stringify();
            var robotStrShouldEquals = new List<string>() { "Steel head", "Steel arm", "Steel arm", "Steel platform"}
            .Stringify();
            Assert.Equals(robotStr, robotStrShouldEquals);
        }
    }
}
