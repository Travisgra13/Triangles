using System;

namespace Triangles
{
	public class Scalene : Triangle
	{
		public Scalene(double sideALen, double sideBLen, double sideCLen) : base(sideALen, sideBLen, sideCLen)
		{

		}

		public override string printTriangleData()
		{
			return "This is a Scalene Triangle. \nValid?: " + this.isValid();
		}
	}
}
