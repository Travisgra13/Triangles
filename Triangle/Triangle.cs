using System;

namespace Triangles
{

	public class Triangle
	{
		protected double sideALen;
		protected double sideBLen;
		protected double sideCLen;
		protected String angleClassification;

		public Triangle(double sideALen, double sideBLen, double sideCLen, String angleClassification) {
			this.sideALen = sideALen;
			this.sideBLen = sideBLen;
			this.sideCLen = sideCLen;
			this.angleClassification = angleClassification;
		}
		public virtual String printTriangleData()
        {
			return "This is a Triangle. \nValid?: " + this.isValid();
        }

		public bool isValid()
        {
			return sideALen > 0.0 && sideBLen > 0.0 && sideCLen > 0.0 &&
				sideALen + sideBLen >= sideCLen &&
				sideBLen + sideCLen >= sideALen &&
				sideALen + sideCLen >= sideBLen;
        }



	}

}
