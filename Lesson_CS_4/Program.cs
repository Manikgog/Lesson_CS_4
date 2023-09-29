using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_CS_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Matrix m1 = new Matrix(4, 5);
            //RandomizeMatrix(m1);
            //Matrix m2 = new Matrix(5, 4);
            //RandomizeMatrix(m2);
            //m1.printMatrix();
            //Console.WriteLine();
            //m2.printMatrix();
            //Console.WriteLine();
            //Matrix m3 = m1 * m2;
            //m3.printMatrix();

            //Matrix m4 = m1 * 2;
            //m4.printMatrix();

            Pilot p1 = new Pilot("Ivan", "Petrov", "15.06.1980", "pilot of airbus 320", 150_000);
            Console.WriteLine(p1.toString());
            p1 = p1 + 1000;
            Console.WriteLine(p1.toString());
            Sailor s2 = new Sailor("Andrey", "Burilov", "16.07.1982", "sailor of Titanic", 200_000);
            Console.WriteLine(s2.toString());
        }

        static void RandomizeMatrix(Matrix m)
        {
            Random random= new Random();
            for (int i = 0; i < m.getRaws(); i++)
            {
                for (int j = 0; j < m.getCols(); j++)
                {
                    m.getMatrix()[i, j] = random.Next(1, 10);
                }
                Console.WriteLine();
            }
        }
    }
}
