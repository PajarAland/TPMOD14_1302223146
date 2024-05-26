using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AljabarLibraries;
using System;

namespace AljabarDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Pilih operasi:");
                Console.WriteLine("1. Akar Persamaan Kuadrat");
                Console.WriteLine("2. Hasil Kuadrat");
                Console.WriteLine("0. Keluar");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Input tidak valid. Coba lagi.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        ProcessQuadraticRoots();
                        break;
                    case 2:
                        ProcessSquareResult();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Coba lagi.");
                        break;
                }
            }
        }

        /// <summary>
        /// Memproses input untuk menghitung akar persamaan kuadrat.
        /// </summary>
        static void ProcessQuadraticRoots()
        {
            Console.WriteLine("Masukkan koefisien a, b, dan c (dipisahkan spasi): ");
            string[] coefficientsStr = Console.ReadLine().Split(' ');

            if (coefficientsStr.Length != 3)
            {
                Console.WriteLine("Jumlah koefisien tidak valid.");
                return;
            }

            double[] coefficients = new double[3];
            for (int i = 0; i < 3; i++)
            {
                if (!double.TryParse(coefficientsStr[i], out coefficients[i]))
                {
                    Console.WriteLine("Koefisien tidak valid.");
                    return;
                }
            }

            double[] roots = Algebra.CalculateQuadraticRoots(coefficients);

            if (roots != null)
            {
                Console.WriteLine("Akar-akar persamaan:");
                for (int i = 0; i < roots.Length; i++)
                {
                    Console.WriteLine("√({0}) = {1}", $"{coefficients[0]}x^2 + {coefficients[1]}x + {coefficients[2]}", roots[i]);
                }
            }
            else
            {
                Console.WriteLine("Persamaan tidak memiliki akar real.");
            }
        }

        /// <summary>
        /// Memproses input untuk menghitung hasil kuadrat dari persamaan linear.
        /// </summary>
        static void ProcessSquareResult()
        {
            Console.WriteLine("Masukkan koefisien a dan b (dipisahkan spasi): ");
            string[] coefficientsStr = Console.ReadLine().Split(' ');

            if (coefficientsStr.Length != 2)
            {
                Console.WriteLine("Jumlah koefisien tidak valid.");
                return;
            }

            double[] coefficients = new double[2];
            for (int i = 0; i < 2; i++)
            {
                if (!double.TryParse(coefficientsStr[i], out coefficients[i]))
                {
                    Console.WriteLine("Koefisien tidak valid.");
                    return;
                }
            }

            double[] squareResult = Algebra.CalculateSquareResult(coefficients);

            Console.WriteLine("Hasil kuadrat dari ({0}x + {1})^2 :", coefficients[0], coefficients[1]);
            for (int i = 0; i < squareResult.Length; i++)
            {
                Console.Write(squareResult[i]);
                if (i < squareResult.Length - 1)
                {
                    Console.Write(" + ");
                }
            }
            Console.WriteLine();
        }
    }
}

