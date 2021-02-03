using System;
namespace Triangles
{
	public class Iscosceles : Triangle
	{
		public Iscosceles(double sideALen, double sideBLen, double sideCLen) : base(sideALen, sideBLen, sideCLen)
		{

		}

		public override string printTriangleData()
		{
			return "This is an Iscosceles Triangle. \nValid?: " + this.isValid();
		}
	}

}
