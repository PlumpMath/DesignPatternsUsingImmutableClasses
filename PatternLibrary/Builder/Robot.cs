using System.Collections.Generic;

namespace PatternLibrary.Builder
{
    public class Robot 
    {
        IReadOnlyCollection<string> Elements = new List<string>();

        public Robot(){ }
        public Robot(IReadOnlyCollection<string> elements)
        {
            Elements = new List<string>(elements);
        }

        public Robot With(string element)
        {
            var newList = new List<string>(Elements);
            newList.Add(element);
            return new Robot(newList);
        }

        public IReadOnlyList<string> GetRobotElements()
        {
            return new List<string>(Elements);
        }

    }
}
