using System;
namespace Triangles
{
	public class Right : Triangle
	{

		public Right(double sideALen, double sideBLen, double sideCLen) : base(sideALen, sideBLen, sideCLen) {}

        public override string printTriangleData()
        {
            return "This is a Right Triangle. \nValid?: " + this.isValid();
        }
    }
}
