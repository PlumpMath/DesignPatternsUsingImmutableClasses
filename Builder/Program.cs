using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
             var eng = new Engineer()
                        .WithRobotBuilder(new SteelRobotBuilder())
                        .CreateRobot()
                        .Stringify("\n");
            Console.WriteLine("Robot:");
            Console.WriteLine(eng);
            Console.ReadLine();
            
        }
    }
}
