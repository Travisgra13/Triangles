using System;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 4)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            String arg1 = args[1];
            String arg2 = args[2];
            String arg3 = args[3];
            TriangleDeterminer determiner = new TriangleDeterminer(arg1, arg2, arg3);
            Triangle triangle = determiner.determine();
            if (triangle == null)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                Console.WriteLine(triangle.printTriangleData());
            }
        }
    }
}