using System;
using System.Text.RegularExpressions;

namespace Triangles
{
	public class TriangleDeterminer
	{
		private int sideACandidate;
		private int sideBCandidate;
		private int sideCCandidate;

		public TriangleDeterminer(Object sideA, Object sideB, Object sideC)
		{
			if (inputIsValidNumbers(sideA, sideB, sideC))
            {

            }

			else
            {
				throw new Exception("Invalid Input");
            }
		}

		private bool inputIsValidNumbers(Object sideA, Object sideB, Object sideC)
		{
			try
			{
				this.sideACandidate = (int)sideA;
				this.sideBCandidate = (int)sideB;
				this.sideCCandidate = (int)sideC;
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
