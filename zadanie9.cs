using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициенты для первого столбца");

            Console.WriteLine("a1 = ");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("a2 = ");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("a3 = ");
            int a3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите коэффициенты для второго столбца");

            Console.WriteLine("b1 = ");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("b2 = ");
            int b2 = int.Parse(Console.ReadLine());
            Console.WriteLine("b3 = ");
            int b3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите коэффициенты для третьего столбца");

            Console.WriteLine("c1 =");
            int c1 = int.Parse(Console.ReadLine());
            Console.WriteLine("c2 =");
            int c2 = int.Parse(Console.ReadLine());
            Console.WriteLine("c3 =");
            int c3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите коэффициенты стоящие после знака равно");

            Console.WriteLine("d1 =");
            int d1 = int.Parse(Console.ReadLine());
            Console.WriteLine("d2 =");
            int d2 = int.Parse(Console.ReadLine());
            Console.WriteLine("d3 =");
            int d3 = int.Parse(Console.ReadLine());

            int deltageneral = a1 * b2 * c3 + a2 * c1 * b3 + b1 * c2 * a3 - a3 * b2 * c1 - b1 * c3 * a2 - b3 * c2 * a1;

            int deltax = d1 * b2 * c3 + d2 * c1 * b3 + d3 * b1 * c2 - d3 * b2 * c1 - d2 * b1 * c3 - d1 * b3 * c2;

            int deltay = a1 * d2 * c3 + a2 * c1 * d3 + a3 * d1 * c2 - a3 * d2 * c1 - a1 * d3 * c2 - a2 * d1 * c3;

            int deltaz = a1 * b2 * d3 + a2 * d1 * b3 + a3 * b1 * d2 - a3 * b2 * d1 - a2 * b1 * d3 - a1 * b3 * d2;

            int x = deltax / deltageneral;

            int y = deltay / deltageneral;

            int z = deltaz / deltageneral;

            Console.WriteLine("Ответ:");

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
        }
    }
}
