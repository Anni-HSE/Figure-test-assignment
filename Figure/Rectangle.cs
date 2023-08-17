using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Rectangle : Figure
    {
        private double width;   
        private double height;   

        public Rectangle(double rectangleWidth, double rectangleHeight)
        {
            Width = rectangleWidth;
            Height = rectangleHeight;
        }

        public double Width
        {
            get => width;
            set => width = value < 0 ? -value : value;
        }

        public double Height
        {
            get => height;
            set => height = value < 0 ? -value : value;
        }

        public override double getArea()
        {
            return width * height;
        }

        public override double getPerimeter()
        {
            return width * 2 + height * 2;
        }

        public override string getName()
        {
            return "Прямоугольник";
        }
    }
}
