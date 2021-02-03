using System;
namespace Triangles
{
	public class Right : Triangle
	{

		public Right(int sideALen, int sideBLen, int sideCLen) : base(sideALen, sideBLen, sideCLen) {}

        public override string printTriangleType()
        {
            return "This is a Right Triangle";
        }
    }
}
