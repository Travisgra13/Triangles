using System;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Not enough arguments passed in.");
                return;
            }

            String arg1 = args[0];
            String arg2 = args[1];
            String arg3 = args[2];
            TriangleDeterminer determiner = new TriangleDeterminer(arg1, arg2, arg3);
            Triangle triangle = determiner.determine();
            while (triangle == null) {
                Console.WriteLine("Invalid input. Try again with valid numbers. Ex: \"1 2 5\"  or \"1.4 2.0 12\" without the quotes.");
                string line = Console.ReadLine();
                args = line.Split(' ');
                if (args.Length < 3)
                {
                    continue;
                }
                else
                {
                    determiner = new TriangleDeterminer(args[0], args[1], args[2]);
                    triangle = determiner.determine();
                }
           
            }
            Console.WriteLine(triangle.printTriangleData());
        }
    }
}