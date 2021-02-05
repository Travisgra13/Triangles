using System;
namespace Triangles
{
	public class Isosceles : Triangle
	{
		public Isosceles(double sideALen, double sideBLen, double sideCLen, String angleClassification) : base(sideALen, sideBLen, sideCLen, angleClassification)
		{

		}

		public override string printTriangleData()
		{
			return "This is a(n) " + this.angleClassification + " Isosceles Triangle. \nValid?: " + this.isValid();
		}
	}

}
