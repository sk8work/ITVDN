using System;
using System.Collections.Generic;
using System.Text;

namespace hw2
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public double Area 
        { 
            get { return value; } 
        }
        public double Perimeter { get; }

        Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator(double side1, double side2)
        {
            return side1 * side2;
        }

        public double PerimeterCalculator(double side1, double side2)
        {
            return 2 * (side1 + side2);
        }
        public void Show()
        {
            Console.WriteLine();
        }
    }
}
