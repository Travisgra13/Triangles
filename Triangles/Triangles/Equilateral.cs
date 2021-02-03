using System;

namespace Triangles
{
	public class Equilateral : Triangle
	{
		public Equilateral(int sideALen, int sideBLen, int sideCLen) : base(sideALen, sideBLen, sideCLen)
		{

		}

		public override string printTriangleType()
		{
			return "This is an Equilateral Triangle";
		}
	}
}
