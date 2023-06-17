using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationSolver
{
    internal class EquationSolver
    {
        // Метод Гаусса для решения системы линейных уравнений
        public static double[] GaussElimination(double[,] coefficients, double[] constants)
        {
            int n = constants.Length;

            // Прямой ход метода Гаусса
            for (int i = 0; i < n - 1; i++)
            {
                if (coefficients[i, i] == 0)
                    throw new Exception("Деление на ноль невозможно");

                for (int k = i + 1; k < n; k++)
                {
                    double factor = coefficients[k, i] / coefficients[i, i];
                    constants[k] -= factor * constants[i];

                    for (int j = i; j < n; j++)
                        coefficients[k, j] -= factor * coefficients[i, j];
                }
            }

            // Обратный ход метода Гаусса
            double[] solution = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                double sum = 0;
                for (int j = i + 1; j < n; j++)
                    sum += coefficients[i, j] * solution[j];

                solution[i] = (constants[i] - sum) / coefficients[i, i];
            }

            return solution;
        }

        // Метод Жордана для решения системы линейных уравнений
        public static double[] GaussJordan(double[,] coefficients, double[] constants)
        {
            int n = constants.Length;

            // Прямой ход метода Жордана
            for (int i = 0; i < n; i++)
            {
                if (coefficients[i, i] == 0)
                    throw new Exception("Деление на ноль невозможно");

                double factor = coefficients[i, i];

                for (int j = i; j < n; j++)
                    coefficients[i, j] /= factor;

                constants[i] /= factor;

                for (int k = 0; k < n; k++)
                {
                    if (k != i)
                    {
                        double temp = coefficients[k, i];
                        for (int j = i; j < n; j++)
                            coefficients[k, j] -= temp * coefficients[i, j];

                        constants[k] -= temp * constants[i];
                    }
                }
            }

            // Получение решения
            double[] solution = new double[n];
            for (int i = 0; i < n; i++)
                solution[i] = constants[i];

            return solution;
        }

        // Метод прогонки для решения системы линейных уравнений
        public static double[] ThomasAlgorithm(double[] a, double[] b, double[] c, double[] d)
        {
            int n = d.Length;
            double[] solution = new double[n];

            double[] cPrime = new double[n];
            double[] dPrime = new double[n];

            cPrime[0] = c[0] / b[0];
            dPrime[0] = d[0] / b[0];

            for (int i = 1; i < n; i++)
            {
                double m = 1.0 / (b[i] - a[i] * cPrime[i - 1]);
                cPrime[i] = c[i] * m;
                dPrime[i] = (d[i] - a[i] * dPrime[i - 1]) * m;
            }

            solution[n - 1] = dPrime[n - 1];

            for (int i = n - 2; i >= 0; i--)
                solution[i] = dPrime[i] - cPrime[i] * solution[i + 1];

            return solution;
        }
    }
}
