using PatternLibrary.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternLibrary.Logging;
using Toolkit;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var eng = new RobotEngineer()
                        .WithBuilder(new RobotBuilder())
                        .CreateProduct();
            var robotStr = (eng as Robot)?.GetRobotElements()
                        .Stringify((e)=>e, "\n");

            Console.WriteLine("Robot:");
            Console.WriteLine(robotStr);
            Console.ReadLine();
            
        }
    }
}
