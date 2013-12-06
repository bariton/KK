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
            double x;
            public Segment(Point P1, Point P2)
            {
                x = P2.X - P1.X;
            }

            public override double GetPerimetr()
            {
            Console.WriteLine("Длина отрезка: "+x);
            return x;
            }
        }
}
