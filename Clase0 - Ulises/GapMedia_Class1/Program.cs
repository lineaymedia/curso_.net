using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GapMedia_Class1
{
    class Point
    {
        private int x;
        private int y;

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public void SetX(int _x)
        {
            x = _x;
        }

        public int GetX()
        {
            return x;
        }

        public Point()
        {
            x = 0;
            y = 0;


        }

        public Point(int _x, int _y)
        {

        }

        public override string ToString()
        {
            return "Mi punto vale: (" + x + ", " + y + ")";
        }
    }

    class Point2 : Point
    {
    }


    class Program
    {
        static void Main(string[] args)
        {
            Point myPoint = new Point();
            myPoint.SetX(100);

            Console.WriteLine("Hola mundo -> " + myPoint.ToString());
        }
    }
}
