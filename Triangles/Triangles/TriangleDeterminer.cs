using System;
using System.Text.RegularExpressions;

namespace Triangles
{
	public class TriangleDeterminer
	{
		private String sideACandidate;
		private String sideBCandidate;
		private String sideCCandidate;

		private double sideALen;
		private double sideBLen;
		private double sideCLen;

		public TriangleDeterminer(String sideA, String sideB, String sideC)
		{
			this.sideACandidate = sideA;
			this.sideBCandidate = sideB;
			this.sideCCandidate = sideC;
		}

		public Triangle determine()
        {
			if (inputIsValidNumbers())
			{
				return determineTriangle();
			}

			else
			{
				return null;
			}
		}

		private Triangle determineTriangle()
        {
			if (isEquilateralTriangle())
            {
				return new Equilateral(sideALen, sideBLen, sideCLen);
            }

			else if (isIsoscelesTriangle())
            {
				return new Iscosceles(sideALen, sideBLen, sideCLen);
            }

			else if (isRightTriangle())
            {
				return new Right(sideALen, sideBLen, sideCLen);
            }
			
			else
            {
				return new Scalene(sideALen, sideBLen, sideCLen);
            }
        }

		private bool isEquilateralTriangle()
        {
			return this.sideALen == this.sideBLen && this.sideALen == this.sideCLen;
        }

		private bool isIsoscelesTriangle()
        {
			return (this.sideALen == this.sideBLen && this.sideALen != this.sideCLen) ||
				(this.sideBLen == this.sideCLen && this.sideBLen != this.sideALen) ||
				(this.sideALen == this.sideCLen && this.sideALen != this.sideBLen);
        }

		private bool isRightTriangle()
        {
			double[] arr = new double[3];
			arr[0] = this.sideALen;
			arr[1] = this.sideBLen;
			arr[2] = this.sideCLen;
			Array.Sort(arr);
			double a = arr[0];
			double aSquare = Math.Pow(a, 2);
			double b = arr[1];
			double bSquare = Math.Pow(b, 2);
			double c = arr[2];
			double cSquare = Math.Pow(c, 2);

			return (aSquare + bSquare) == cSquare;
        }

		private bool inputIsValidNumbers()
		{
			if (!Regex.IsMatch(sideACandidate, @"^[+-]?(\d*\.)?\d+$") ||
				(!Regex.IsMatch(sideBCandidate, @"^[+-]?(\d*\.)?\d+$")) ||
				(!Regex.IsMatch(sideCCandidate, @"^[+-]?(\d*\.)?\d+$")))
			{
				return false;
			}
			try
			{
				this.sideALen = Convert.ToDouble(sideACandidate);
				this.sideBLen = Convert.ToDouble(sideBCandidate);
				this.sideCLen = Convert.ToDouble(sideCCandidate);
				return true;
			}
			catch (InvalidCastException e)
			{
				Console.WriteLine(e.Source);
				return false;
			}
			catch (OverflowException ex)
            {
				Console.WriteLine(ex.Source);
				return false;
			}
		}
	}

}
