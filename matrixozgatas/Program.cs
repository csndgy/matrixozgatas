using System;

namespace matrixozgatas
{
    class Matrix
    {
        private int n,m; 
        private double[,] matrix;

        public int GetRow => n;
        public int GetColumn => m;

        public Matrix(int n, int m)
        {
            this.n = n;
            this.m = m;
            matrix = new double[n, m];
        }

        public Matrix(int n) : this(n, n) { }

        public Matrix() : this(3, 3) { }

        public static void MatrixFill(Matrix szam)
        {
            for (int i = 0; i < szam.GetRow; i++)
            {
                for (int j = 0; j < szam.GetColumn; j++)
                {
                    szam.matrix[i, j] = i + j;
                }
            }
        }

        public static Matrix MatrixSum(Matrix a, Matrix b)
        {
            if (a.GetRow != b.GetRow || a.GetColumn != b.GetColumn)
            {
                throw new ArgumentException("A két mátrix mérete nem egyezik meg!");
            }

            Matrix result = new Matrix(a.GetRow, a.GetColumn);
            for (int i = 0; i < a.GetRow; i++)
            {
                for (int j = 0; j < a.GetColumn; j++)
                {
                    result.matrix[i, j] = a.matrix[i, j] + b.matrix[i, j];
                }
            }
            return result;
        }

        public void MatrixKiir()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Matrix elsoMatrix = new Matrix(2, 4);
            Matrix.MatrixFill(elsoMatrix);

            Matrix masodikMatrix = new Matrix(2, 4);
            Matrix.MatrixFill(masodikMatrix);

            Matrix osszeg = Matrix.MatrixSum(elsoMatrix, masodikMatrix);

            Console.WriteLine("A két mátrix összege:");
            osszeg.MatrixKiir();
        }
    }
}
