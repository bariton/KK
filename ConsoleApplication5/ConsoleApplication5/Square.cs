using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApplication4
{
    class Square : Poin
    {
        int A, B;
        double a, b, c, d, x, y, z;
        public Square(Point P1, Point P2, Point P3, Point P4)
        {
            A = P2.X - P1.X;
            B = P2.Y - P1.Y;
            P3.X = P2.X + B;
            P3.Y = P2.Y - A;
            P4.X = P1.X + B;
            P4.Y = P1.Y - A;

            a = P2.X;
            b = P1.X;
            c = P2.Y;
            d = P1.Y;
        }

        public override double GetPerimetr()
        {
            if (a > 0 & b < 0 || a < 0 & b > 0)
            {
                x = b - a;
            }
            else
            {
                if (a > b)
                {
                    x = a - b;
                }
                else
                {
                    x = b - a;
                }
            }
            if (c > 0 & d < 0 || c < 0 & d > 0)
            {
                y = d - c;
            }
            else
            {
                if (c > d)
                {
                    y = c - d;
                }
                else
                {
                    y = d - c;
                }
            }
            z = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            z *= 4;
            Console.WriteLine("Периметр квадрата " + z);
            return x;
        }

    }
}
