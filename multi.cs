using System;
using System.Threading;
using System.Threading.Tasks;

namespace MatrixThread
{
    public class Multi
    {
        private Matrix[] matrices = new Matrix[2];
        private int threads;

        public Multi(Matrix matrix1, Matrix matrix2, int threads)
        {
            this.matrices[0] = matrix1;
            this.matrices[1] = matrix2;
            this.threads = threads;
        }

        public void SetMatrices(int seed,int max)
        {
            Random rand = new Random(seed);
            for (int i = 0; i < this.matrices.Length; i++)
            {
                for (int j = 0; j < matrices[i].Rows; j++)
                {
                    for (int k = 0; k < matrices[i].Columns; k++)
                    {
                        matrices[i].SetMatrix(j, k, rand.Next(0, max));
                    }
                }
            }
        }
        public Matrix Multiply()
        {
            if (matrices[0].Columns != matrices[1].Rows)
                throw new InvalidOperationException("Nieprawidłowe wymiary macierzy do mnożenia.");

            Matrix result = new Matrix(matrices[0].Rows, matrices[1].Columns);
            ParallelOptions opt = new ParallelOptions { MaxDegreeOfParallelism = threads };
            Parallel.For(0, matrices[0].Rows, opt, i =>
            {
                for (int j = 0; j < matrices[1].Columns; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < matrices[0].Columns; k++)
                    {
                        sum += matrices[0].GetMatrix(i, k) * matrices[1].GetMatrix(k, j);
                    }
                    result.SetMatrix(i, j, sum);
                }
            });
            return result;
        }

        public Matrix MultiplyT()
        {
            if (matrices[0].Columns != matrices[1].Rows)
                throw new InvalidOperationException("Nieprawidłowe wymiary macierzy do mnożenia.");

            Matrix result = new Matrix(matrices[0].Rows, matrices[1].Columns);
            int totalRows = matrices[0].Rows;
            int rowsPerThread = (int)Math.Ceiling((double)totalRows / threads);

            Thread[] threadArray = new Thread[threads];

            for (int t = 0; t < threads; t++)
            {
                int threadIndex = t;
                threadArray[t] = new Thread(() =>
                {
                    int startRow = threadIndex * rowsPerThread;
                    int endRow = Math.Min(startRow + rowsPerThread, totalRows);

                    for (int i = startRow; i < endRow; i++)
                    {
                        for (int j = 0; j < matrices[1].Columns; j++)
                        {
                            int sum = 0;
                            for (int k = 0; k < matrices[0].Columns; k++)
                            {
                                sum += matrices[0].GetMatrix(i, k) * matrices[1].GetMatrix(k, j);
                            }
                            result.SetMatrix(i, j, sum);
                        }
                    }
                });
                threadArray[t].Start();
            }

            for (int t = 0; t < threads; t++)
            {
                threadArray[t].Join();
            }

            return result;
        }

    }
}


    