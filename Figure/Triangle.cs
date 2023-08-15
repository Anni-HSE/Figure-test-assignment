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
        private double sideA, sideB, sideC;

        public Triangle(double triangleSideA, double triangleSideB, double triangleSideC)
        {
            if (triangleSideA < 0) throw new ArgumentOutOfRangeException("Сторона треугольника не может быть отрицательная");
            if (triangleSideB < 0) throw new ArgumentOutOfRangeException("Сторона треугольника не может быть отрицательная");
            if (triangleSideC < 0) throw new ArgumentOutOfRangeException("Сторона треугольника не может быть отрицательная");
            
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

        public override double Area()
        {
            double semPer = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semPer * (semPer - sideA) * (semPer - sideB) * (semPer - sideC));
        }

        public override double Perimeter()
        {
            return sideA + sideB + sideC;
        }

        public override string ShapeName()
        {
            double sigCosA = Math.Round(sideB * sideB + sideC * sideC - sideA * sideA);
            double sigCosB = Math.Round(sideC * sideC + sideA * sideA - sideB * sideB);
            double sigCosC = Math.Round(sideA * sideA + sideB * sideB - sideC * sideC);

            if (sigCosA < 0 || sigCosB < 0 || sigCosC < 0)
            {
                if (sideA == sideB || sideA == sideC || sideB == sideC)
                {
                    return "Равнобедренный тупоугольный треугольник";
                }
                else
                {
                    return "Тупоугольный треугольник";
                }
            }
            else if (sigCosA == 0 || sigCosB == 0 || sigCosC == 0)
            {
                if (sideA == sideB || sideA == sideC || sideB == sideC)
                {
                    return "Равнобедренный прямоугольный треугольник";
                }
                else
                {
                    return "Прямоугольный треугольник";
                }
            }
            else
            {
                if (sideA == sideB && sideB == sideC)
                {
                    return "Равносторонний треугольник";
                }
                else if (sideA == sideB || sideA == sideC || sideB == sideC)
                {
                    return "Равнобедренный остроугольный треугольник";
                }
                else
                {
                    return "Остроугольный треугольник";
                }
            }    
        }

        private bool isExist(double _sideA, double _sideB, double _sideC)
        {
            if ((_sideA < (_sideB + _sideC)) && (_sideB < (_sideA + _sideC)) && (_sideC < (_sideA + _sideB)))
                return true; 
            
            return false;
        }
    }
}
