using System;
namespace Triangles
{
	public class Equilateral : Triangle
	{

		public Equilateral(double sideALen, double sideBLen, double sideCLen, String angleClassification) : base(sideALen, sideBLen, sideCLen, angleClassification) {}

        public override string printTriangleData()
        {
            return "This is a(n) " + this.angleClassification + " Equilateral Triangle. \nValid?: " + this.isValid();
        }
    }
}
