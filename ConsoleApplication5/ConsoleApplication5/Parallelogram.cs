using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApplication4
{
    class Parallelogram:Poin
    {
        double c, d, e, f, m, k, z, x, y;
        int a1, b1, a, b;

        public Parallelogram(Point P1, Point P2, Point P3, Point P4)
        {
            if (P1.Y == P2.Y)
            {
                a=P2.X-P1.X;
                b=P2.Y-P1.Y;
                a1 = -b;
                b1 = a;

                P3.X = P1.X+a1;
                P3.Y = P1.Y+b1;
            }
            else
            {
                P3.X=P1.X;
                P3.Y=P2.Y+1;
            }
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


            k = f - d;

            m = k * 2 + z * 2;
            Console.WriteLine("Периметр параллелограмма: " + m);

            return x;
            
        }
    }
}
