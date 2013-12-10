using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApplication4
{
        

        class Segment : Poin
        {
            double a, b, c, d, x, y, z;
            public Segment(Point P1, Point P2)
            {
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
                z = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2));
                Console.WriteLine("Длина отрезка " + z);
                return x;
            }
        }
}
