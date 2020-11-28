using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_2
{
    class Rectangle
    {
        double side1;
        double side2;
        public Rectangle(double s1, double s2)
        {
            side1 = s1;
            side2 = s2;
        }
        double Area;
        double Perimeter;
        public double area
        {
            get { return Area; }
            set { Area = AreaCalculator(); }
        }

        double AreaCalculator()
        {

            area = side1 * side2;
            return area;
        }
        double PerimeterCalculator()
        {
            Perimeter = (side1 + side2) * 2;
            return Perimeter;
        }
    }
}
