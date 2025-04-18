using System;
using System.Diagnostics;
using System.IO;

namespace MatrixThread
{
    class Program
    {
        static void Main(string[] args)
        {
            int instance = 10;
            Random random = new Random();
            int[] rows = [100, 500, 1000];
            int[] columns = [100, 500, 1000];
            int[] threads = [1, 2, 4, 8];
            long[,] tableTimeParallel = new long[3, 4];
            long[,] tableTimeThread = new long[3, 4];

            using (StreamWriter writer = new StreamWriter("results.csv"))
            {
                writer.WriteLine("Typ,Wiersze,Kolumny,Wątki,Czas (ms)");

                for (int i = 0; i < rows.Length; i++)
                {
                    Console.WriteLine($"Wymiary macierzy: {rows[i]}x{columns[i]}");
                    for (int j = 0; j < threads.Length; j++)
                    {
                        Console.WriteLine($"Liczba wątków: {threads[j]}");

                        Matrix matrix1 = new Matrix(rows[i], columns[i]);
                        Matrix matrix2 = new Matrix(columns[i], rows[i]);

                        Multi matrixMulti = new Multi(matrix1, matrix2, threads[j]);
                        Multi matrixMultiT = new Multi(matrix1, matrix2, threads[j]);

                        long parallelTime = 0;
                        long threadTime = 0;

                        for (int k = 0; k < instance; k++)
                        {
                            int seed = random.Next(100, 1000);
                            matrixMulti.SetMatrices(seed, 1000);
                            matrixMultiT.SetMatrices(seed, 1000);

                            var sw = Stopwatch.StartNew();
                            Matrix result = matrixMulti.Multiply();
                            sw.Stop();
                            parallelTime += sw.ElapsedMilliseconds;

                            sw = Stopwatch.StartNew();
                            Matrix resultT = matrixMultiT.MultiplyT();
                            sw.Stop();
                            threadTime += sw.ElapsedMilliseconds;
                        }

                        parallelTime /= instance;
                        threadTime /= instance;

                        tableTimeParallel[i, j] = parallelTime;
                        tableTimeThread[i, j] = threadTime;

                        Console.WriteLine($"Thread - Liczba wątków: {threads[j]}, Czas: {threadTime} ms");
                        writer.WriteLine($"Thread,{rows[i]},{columns[i]},{threads[j]},{threadTime}");

                        Console.WriteLine($"Parallel - Liczba wątków: {threads[j]}, Czas: {parallelTime} ms");
                        writer.WriteLine($"Parallel,{rows[i]},{columns[i]},{threads[j]},{parallelTime}");
                    }
                }
            }

            Console.WriteLine("\nWyniki zapisane do pliku: results.csv");
        }
    }
}
