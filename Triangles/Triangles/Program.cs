using System;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(1, 2, 3);
            Triangle rightTriangle = new Right(1, 2, 3);
            Triangle equilateral = new Equilateral(1, 2, 3);
            Triangle iscosceles = new Iscosceles(1, 1, 1);
            Console.WriteLine(triangle.printTriangleType());
            Console.WriteLine(rightTriangle.printTriangleType());
            Console.WriteLine(iscosceles.printTriangleType());

        }
    }
}
