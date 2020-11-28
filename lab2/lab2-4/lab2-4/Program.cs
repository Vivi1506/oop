using System;

namespace lab2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a1 = new Point(0, 0, "A");
            Point b1 = new Point(0, 1, "B");
            Point c1 = new Point(1, 0, "C");
            Point d1 = new Point(1, 1, "D");
            Figure newFigure = new Figure(a1, b1, c1, d1);
            newFigure.PerimeterCalculator();
            Console.WriteLine(newFigure.whatFigure);

        }
    }
}
