using System;
using System.Text.RegularExpressions;

namespace Triangles
{
	public class TriangleDeterminer
	{
		private Object sideACandidate;
		private Object sideBCandidate;
		private Object sideCCandidate;

		private int sideALen;
		private int sideBLen;
		private int sideCLen;

		public TriangleDeterminer(Object sideA, Object sideB, Object sideC)
		{
			this.sideACandidate = sideA;
			this.sideBCandidate = sideB;
			this.sideCCandidate = sideC;
		}

		public Triangle determine()
        {
			if (!inputIsValidNumbers(sideACandidate, sideBCandidate, sideCCandidate))
			{
				
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
				throw new Exception("Triangle type not handled");
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
			int[] arr = new int[3];
			Array.Sort(arr);
			int a = arr[0];
			int aSquare = square(a);
			int b = arr[1];
			int bSquare = square(b);
			int c = arr[2];
			int cSquare = square(c);

			return (aSquare + bSquare) == cSquare;
        }

		private int square(int num)
        {
			return num * num;
        }


		private bool inputIsValidNumbers(Object sideA, Object sideB, Object sideC)
		{
			try
			{
				this.sideALen = (int)sideA;
				this.sideBLen = (int)sideB;
				this.sideCLen = (int)sideC;
				return true;
			}
			catch (InvalidCastException e)
			{
				Console.WriteLine(e.Source);
				return false;
			}
		}
	}

}
