using System;

namespace Triangles
{
	public class Equilateral : Triangle
	{
		public Equilateral(double sideALen, double sideBLen, double sideCLen) : base(sideALen, sideBLen, sideCLen)
		{

		}

		public override string printTriangleData()
		{
			return "This is an Equilateral Triangle \nValid?: " + this.isValid();
		}
	}
}
