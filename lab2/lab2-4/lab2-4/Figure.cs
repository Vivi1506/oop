using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_4
{
    class Figure
    {
        public Point A { get; private set; }
        public Point B { get; private set; }
        public Point C { get; private set; }
        public Point D { get; private set; }
        public Point E { get; private set; }
        public string whatFigure { get; private set; }
        public Figure(Point A1, Point B1, Point C1)
        {
            whatFigure = "Triangle";
            A = A1;
            B = B1;
            C = C1;

        }
        public Figure(Point A1, Point B1, Point C1, Point D1)
        {
            whatFigure = "Quadrangle";
            A = A1;
            B = B1;
            C = C1;
            D = D1;

        }
        public Figure(Point A1, Point B1, Point C1, Point D1, Point E1)
        {
            whatFigure = "Pentagon";
            A = A1;
            B = B1;
            C = C1;
            D = D1;
            E = E1;

        }
        double LengthSide(Point A, Point B)
        {
            double result = Math.Sqrt(Math.Pow((B.x - A.x), 2) + Math.Pow((B.y - A.y), 2));
            return result;
        }
        public void PerimeterCalculator()
        {
            double length = LengthSide(A, B);
            if (whatFigure == "Triangle")
            {
                Console.WriteLine(length * 3);

            }
            else if (whatFigure == "Quadrangle")
            {
                Console.WriteLine(length * 4);
            }
            else if(whatFigure == "Pentagon")
            {
                Console.WriteLine(length * 5);
            }
        }

    }
}
