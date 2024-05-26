using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AljabarLibraries
{
    public static class Algebra
    {
        /// <summary>
        /// Menghitung akar-akar dari persamaan kuadrat.
        /// </summary>
        /// <param name="coefficients">Array koefisien (a, b, c).</param>
        /// <returns>Array akar-akar persamaan atau null jika tidak memiliki akar real.</returns>
        public static double[] CalculateQuadraticRoots(double[] coefficients)
        {
            if (coefficients.Length != 3)
                throw new ArgumentException("Array persamaan harus memiliki panjang 3 (koefisien a, b, c)");

            double a = coefficients[0];
            double b = coefficients[1];
            double c = coefficients[2];

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
                return null;

            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            return new double[] { root1, root2 };
        }

        /// <summary>
        /// Menghitung hasil kuadrat dari persamaan linear.
        /// </summary>
        /// <param name="coefficients">Array koefisien (a, b).</param>
        /// <returns>Array koefisien hasil kuadrat (a^2, 2ab, b^2).</returns>
        public static double[] CalculateSquareResult(double[] coefficients)
        {
            if (coefficients.Length != 2)
                throw new ArgumentException("Array persamaan harus memiliki panjang 2 (koefisien a, b)");

            double a = coefficients[0];
            double b = coefficients[1];

            double aSquared = a * a;
            double twoAb = 2 * a * b;
            double bSquared = b * b;

            return new double[] { aSquared, twoAb, bSquared };
        }
    }
}

