using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApplication4
{
    class Program 
    {
        public static Point P1, P2, P3, P4; 
 

        static void Main(string[] args) 
        {
            P1 = new Point(1, 1);
            P2 = new Point(5, 3);
            P3 = new Point(0, 0);
            P4 = new Point(0, 0);

            Poin[] poins = new Poin[4];    
            poins[0] = new Segment(P1,P2);
            poins[1] = new Square (P1, P2, P3, P4);
            poins[2] = new Rectangle(P1, P2, P3, P4);
            
                                        
            for (int i = 0; i < 3; i++) 
            {                           
                poins[i].GetPerimetr();
            }
            Console.WriteLine("Координаты точки P1: " +P1);

            Console.ReadKey();
        }
    }
}

