using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApplication4
{
    class Rectangle : Poin
    {
        double a, b, c, d;
        public Rectangle (Point P1, Point P2, Point P3, Point P4)
        {
                P3.X = P2.X;
                P3.Y = P2.X - 2;
                P4.X = P1.X;
                P4.Y = P2.X - 2;
                a = P2.X - P1.X;
                b = P3.Y - P2.Y;
                c = P3.X - P4.X;
                d = P4.Y - P1.Y;
        }

        double x;
        public override double GetPerimetr()
        {
            x = a+b+c+d;
            Console.WriteLine("Периметр прямоугольника: " + x);
            return x;
        }
    }
}
