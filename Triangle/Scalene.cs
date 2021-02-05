using System;

namespace Triangles
{
	public class Scalene : Triangle
	{
		public Scalene(double sideALen, double sideBLen, double sideCLen, String angleClassification) : base(sideALen, sideBLen, sideCLen, angleClassification)
		{

		}

		public override string printTriangleData()
		{
			return "This is a(n) " + this.angleClassification + " Scalene Triangle. \nValid?: " + this.isValid();
		}
	}
}
