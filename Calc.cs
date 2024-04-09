using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DaugiagijisMatrix
{
    internal class Calc
    {

        public static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
        {
            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int rowsB = matrixB.GetLength(0);
            int colsB = matrixB.GetLength(1);

            // Initialize the result matrix
            int[,] resultMatrix = new int[rowsA, colsB];


            // Check if the matrices are compatible for multiplication
            if (colsA != rowsB)
            {
                throw new InvalidOperationException("Cannot multiply matrices with incompatible dimensions.");
            }

            var t0 = new Thread(() =>{ InitializeResultMatrix(resultMatrix);});
            t0.Start();

            Calc calculator = new Calc();
            Thread t1 = new Thread(() => { resultMatrix[0, 0] = calculator.Mult(matrixA, matrixB, 0, 0); });
            Thread t2 = new Thread(() => { resultMatrix[0, 1] = calculator.Mult(matrixA, matrixB, 0, 1); });
            Thread t3 = new Thread(() => { resultMatrix[0, 2] = calculator.Mult(matrixA, matrixB, 0, 2); });
            Thread t4 = new Thread(() => { resultMatrix[1, 0] = calculator.Mult(matrixA, matrixB, 1, 0); });
            Thread t5 = new Thread(() => { resultMatrix[1, 1] = calculator.Mult(matrixA, matrixB, 1, 1); });
            Thread t6 = new Thread(() => { resultMatrix[1, 2] = calculator.Mult(matrixA, matrixB, 1, 2); });
            Thread t7 = new Thread(() => { resultMatrix[2, 0] = calculator.Mult(matrixA, matrixB, 2, 0); });
            Thread t8 = new Thread(() => { resultMatrix[2, 1] = calculator.Mult(matrixA, matrixB, 2, 1); });
            Thread t9 = new Thread(() => { resultMatrix[2, 2] = calculator.Mult(matrixA, matrixB, 2, 2); });

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start();
            t7.Start();
            t8.Start();
            t9.Start();

            t0.Join();
            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
            t5.Join();
            t6.Join();
            t7.Join();
            t8.Join();
            t9.Join();

            return resultMatrix;
        }

        private static void InitializeResultMatrix(int[,] resultMatrix)
        {
          // Initialize the result matrix here if necessary
          // For example, you could set all elements to zero
          int rows = resultMatrix.GetLength(0);
          int cols = resultMatrix.GetLength(1);
           for (int i = 0; i < rows; i++)
           {
              for (int j = 0; j < cols; j++)
              {
                  resultMatrix[i, j] = 0;
              }
           }
        }

        // Perform matrix multiplication using parallelization
        public int Mult(int[,] matrixA, int[,] matrixB, int row, int col)
        {
            int sum = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                sum += matrixA[row, k] * matrixB[k, col];
            }
            return sum;
        }



    }
}

