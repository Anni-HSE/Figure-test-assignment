using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Triangle : Figure
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double triangleSideA, double triangleSideB, double triangleSideC)
        {
            if (triangleSideA < 0 || triangleSideB < 0 || triangleSideC < 0) throw new ArgumentOutOfRangeException("Сторона треугольника не может быть отрицательная");
            
            if (isExist(triangleSideA, triangleSideB, triangleSideC))
            {
                sideA = triangleSideA;
                sideB = triangleSideB;
                sideC = triangleSideC;
            }
            else
            {
                throw new ArgumentException($"Треугольник с заданами сторонами ({triangleSideA}, {triangleSideB}, {triangleSideC}) не может существовать.");
            }
        }

        public double SideA
        {
            get => sideA;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Сторона треугольника не может быть отрицательная");

                if (isExist(value, sideB, sideC))
                {
                    sideA = value;
                }
                else
                {
                    throw new ArgumentException($"Треугольник с заданами сторонами ({value}, {sideB}, {sideC}) не может существовать.");
                }
            }
        }

        public double SideB
        {
            get => sideB;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Сторона треугольника не может быть отрицательная");

                if (isExist(sideA, value, sideC))
                {
                    sideB = value;
                }
                else
                {
                    throw new ArgumentException($"Треугольник с заданами сторонами ({sideA}, {value}, {sideC}) не может существовать.");
                }
            }
        }

        public double SideC
        {
            get => sideC;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Сторона треугольника не может быть отрицательная");

                if (isExist(sideA, sideB, value))
                {
                    sideC = value;
                }
                else
                {
                    throw new ArgumentException($"Треугольник с заданами сторонами ({sideA}, {sideB}, {value}) не может существовать.");
                }
            }
        }

        public override double getArea()
        {
            double semPer = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semPer * (semPer - sideA) * (semPer - sideB) * (semPer - sideC));
        }

        public override double getPerimeter()
        {
            return sideA + sideB + sideC;
        }

        public string getTriangleType()
        {
            if (sideA == sideB && sideB == sideC)
                return "Равносторонний";
            
            if (sideA == sideB || sideA == sideC || sideB == sideC)
                return "Равнобедренный";
               
            return "Разносторонний";
        }

        public double getSigCosSelectSide(double selectSide)
        {
            return Math.Round(sideA * sideA + sideB * sideB + sideC * sideC - 2 * (selectSide * selectSide));
        }

        public string getTriangleAngleType()
        {
            double sigCosA = getSigCosSelectSide(sideA);
            double sigCosB = getSigCosSelectSide(sideB);
            double sigCosC = getSigCosSelectSide(sideC);

            if (sigCosA < 0 || sigCosB < 0 || sigCosC < 0)
                return "Тупоугольный";
            
            if (sigCosA == 0 || sigCosB == 0 || sigCosC == 0)
                return "Прямоугольный";

            return "Остроугольный";
        }

        public override string getName()
        {
            string s = $"{getTriangleAngleType()} {getTriangleType()} треугольник";
            return s.Substring(0, 1).ToUpper() + s.Substring(1).ToLower();
        }

        private bool isExist(double _sideA, double _sideB, double _sideC)
        {
            if ((_sideA < (_sideB + _sideC)) && (_sideB < (_sideA + _sideC)) && (_sideC < (_sideA + _sideB)))
                return true; 
            
            return false;
        }
    }
}
