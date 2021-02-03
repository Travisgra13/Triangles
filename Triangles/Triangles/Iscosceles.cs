using System;
namespace Triangles
{
	public class Iscosceles : Triangle
	{
		public Iscosceles(int sideALen, int sideBLen, int sideCLen) : base(sideALen, sideBLen, sideCLen)
		{

		}

		public override string printTriangleType()
		{
			return "This is an Iscosceles Triangle";
		}
	}

}
