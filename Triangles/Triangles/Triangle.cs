using System;

namespace Triangles
{

	public class Triangle
	{
		protected int sideALen;
		protected int sideBLen;
		protected int sideCLen;

		public Triangle(int sideALen, int sideBLen, int sideCLen) {
			this.sideALen = sideALen;
			this.sideBLen = sideBLen;
			this.sideCLen = sideCLen;
		}
		public virtual String printTriangleType()
        {
			return "This is a Base Triangle";
        }

		public bool isValid()
        {
			return sideALen != 0 && sideBLen != 0 && sideCLen != 0 &&
				sideALen + sideBLen >= sideCLen &&
				sideBLen + sideCLen >= sideALen &&
				sideALen + sideCLen >= sideBLen;
        }

	}

}
