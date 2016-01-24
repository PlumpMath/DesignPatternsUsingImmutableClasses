using System;
using System.Collections.Generic;
using PatternLibrary.Iterator;
using Toolkit;

namespace Iterator
{
    public class ClassWithStringProperty
    {
        public string Prop { get; set; }
        public ClassWithStringProperty(string str)
        {
            Prop = str;
        }
        public static implicit operator ClassWithStringProperty(string str)
        {
            return new ClassWithStringProperty(str);
        }
    }
    public class Program
    {
        public static void Main()
        {
            var list = new List<ClassWithStringProperty>() { "test1", "test2", "test3", "test4"};
            var imlist = new ImmutableList<ClassWithStringProperty>(list);
            Console.WriteLine("Lists created:");
            Console.WriteLine(list.Stringify(e =>e.Prop));
            Console.WriteLine(imlist.Stringify(e => e.Prop));

            Console.WriteLine("Mutable list modified[immutable not modified]:");
            list.Add("test5");
            Console.WriteLine(list.Stringify(e => e.Prop));
            Console.WriteLine(imlist.Stringify(e => e.Prop));

            Console.WriteLine("Element in immutable changed[not really...]:");
            var elem = imlist[2];
            elem.Prop = "1234";
            Console.WriteLine(imlist.Stringify(e => e.Prop));

            Console.WriteLine("Element in mutable changed[& not in immutable]:");
            elem = list[2];
            elem.Prop = "12387";
            Console.WriteLine(list.Stringify(e => e.Prop));
            Console.WriteLine(imlist.Stringify(e => e.Prop));

            Console.ReadLine();
        }
    }
}
