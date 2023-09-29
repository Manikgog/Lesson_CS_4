using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_CS_4
{
    internal class Matrix
    {
        //private int raws;
        //private int cols;
        private int[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.matrix = new int[rows, cols];
        }

        public int getRaws()
        {
            return matrix.GetLength(0);
        }

        public int getCols()
        {
            return matrix.GetLength(1);
        }

        public int[,] getMatrix()
        {
            return matrix;
        }
        

        public static Matrix operator+(Matrix a, Matrix b)
        {
            Matrix m = new Matrix(a.getRaws(), a.getCols());
            if (a.getRaws() == b.getRaws() || a.getCols() == b.getCols())
            {
                for(int i = 0; i < a.getRaws(); i++)
                {
                    for(int j = 0; j < a.getCols(); j++)
                    {
                        m.getMatrix()[i, j] = a.getMatrix()[i, j] + b.getMatrix()[i, j];
                    }
                }
                return m;
            }
            return m;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            Matrix m = new Matrix(a.getRaws(), a.getCols());
            if (a.getRaws() == b.getRaws() || a.getCols() == b.getCols())
            {
                for (int i = 0; i < a.getRaws(); i++)
                {
                    for (int j = 0; j < a.getCols(); j++)
                    {
                        m.getMatrix()[i, j] = a.getMatrix()[i, j] - b.getMatrix()[i, j];
                    }
                }
                return m;
            }
            return m;
        }

        public static Matrix operator*(Matrix m1, Matrix m2)
        {
            Matrix m = new Matrix(m1.getRaws(), m2.getCols());
            if (m1.getRaws() == m2.getCols())
            {
                
                int l = 0;
                for (int i = 0; i < m1.getRaws(); ++i)
                {
                    // умножаем строку первой матрицы на стобцы второй матрицы
                    int g = 0;
                    for (int j = 0; j < m2.getCols(); ++j, ++g)
                    {
                        int summMult = 0;
                        for (int k = 0; k < m1.getCols(); k++)
                        {

                            summMult += m1.getMatrix()[l, k] * m2.getMatrix()[k, g];

                        }

                        m.getMatrix()[i, j] = summMult;

                    }
                    l++;

                }

            }
            return m;
        }

        public static Matrix operator *(Matrix m1, int a)
        {
            Matrix m = new Matrix(m1.getRaws(), m1.getCols());

            for (int i = 0; i < m1.getRaws(); i++)
            {
                for (int j = 0; j < m1.getCols(); j++)
                {
                    m.getMatrix()[i, j] = m1.getMatrix()[i, j] * a;
                }
            }
            return m;
        }



        public void printMatrix()
        {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                

        }

    }
}
