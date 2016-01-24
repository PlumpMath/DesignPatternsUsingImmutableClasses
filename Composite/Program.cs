using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Composite()
                .AddChild(
                    new Composite()
                        .AddChild(new IntNode(1))
                        .AddChild(new IntNode(2))
                        .AddChild(new IntNode(7))
                        .AddChild(new IntNode(3))
                        .AddChild(new IntNode(9))
                );
            Console.WriteLine(root.GetValue);

            var newroot = root.AddChild(
                new Composite()
                    .AddChild(new IntNode(4))
                    .AddChild(
                        new Composite()
                            .AddChild(new IntNode(3))
                            .AddChild(new IntNode(8))
                            .AddChild(new IntNode(1))
                    )
            );
            Console.WriteLine(root.GetValue);
            Console.WriteLine(newroot.GetValue);

            Console.ReadLine();
        }
    }
}
