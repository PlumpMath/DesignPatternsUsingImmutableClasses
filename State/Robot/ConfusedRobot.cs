using System;
using PatternLibrary.State;

namespace State.Robot
{
    internal class ConfusedRobot : AbstractRobot
    {
        public override int Speed => -123;

        public override IStateMachine Perform(string command)
        {
            Console.WriteLine("Buelbellelbeble");
            return new ConfusedRobot();
        }
    }
}
