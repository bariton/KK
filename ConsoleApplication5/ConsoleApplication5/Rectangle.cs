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
        int A, B;
        double a, b, c, d, e, f, x, z, k, x1, y1, y, m;
        public Rectangle (Point P1, Point P2, Point P3, Point P4)
        {
            A = P2.X - P1.X;
            B = P2.Y - P1.Y;
            P3.X = P2.X + B/2;
            P3.Y = P2.Y - A/2;
            P4.X = P1.X + B/2;
            P4.Y = P1.Y - A/2;

            a = P2.X;
            b = P1.X;
            c = P2.Y;
            d = P1.Y;
            e = P3.X;
            f = P3.Y;
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


            if (a > 0 & e < 0 || a < 0 & e > 0)
            {
                x1 = e - a;
            }
            else
            {
                if (a > e)
                {
                    x1 = a - e;
                }
                else
                {
                    x1 = e - a;
                }
            }
            if (c > 0 & f < 0 || c < 0 & f > 0)
            {
                y1 = f - c;
            }
            else
            {
                if (c > f)
                {
                    y1 = c - f;
                }
                else
                {
                    y1 = f - c;
                }
            }
            k = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));

            m = k * 2 + z * 2;
            Console.WriteLine("Периметр прямоугольника: " + m);

            return x;
        }
    }
}
