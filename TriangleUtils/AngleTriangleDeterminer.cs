using System;
using System.Collections.Generic;
using System.Text;

namespace Triangles
{
    public class AngleTriangleDeterminer {
        public static String determineAngleType(double sideA, double sideB, double sideC)
        {
			String angle = "";
			double[] sortedArray = sortValues(sideA, sideB, sideC);
			if (isObtuseTriangle(sortedArray)) {
				angle = "Obtuse";
            }
			else if (isRightTriangle(sortedArray))
            {
				angle = "Right";
            }
			else if (isAcuteTriangle(sortedArray)) {
				angle = "Acute";
            }
			else
            {
				angle = "Error Fix determineAngleType Method";
            }
			return angle;
        }

		private static bool isAcuteTriangle(double[] arr)
        {
			return (arr[0] + arr[1]) > arr[2];
		}

		private static bool isObtuseTriangle(double[] arr)
		{
			return (arr[0] + arr[1]) < arr[2];
		}

		private static bool isRightTriangle(double[] arr)
		{
			return (arr[0] + arr[1]) == arr[2];
		}

		private static double[] sortValues(double sideA, double sideB, double sideC)
		{
			double[] arr = new double[3];
			arr[0] = sideA;
			arr[1] = sideB;
			arr[2] = sideC;
			Array.Sort(arr);
			double a = arr[0];
			double aSquare = Math.Pow(a, 2);
			double b = arr[1];
			double bSquare = Math.Pow(b, 2);
			double c = arr[2];
			double cSquare = Math.Pow(c, 2);
			return new double[3] { aSquare, bSquare, cSquare };
		}
	}
}
 