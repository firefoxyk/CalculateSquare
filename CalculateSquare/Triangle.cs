using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSquare
{
    public class Triangle : Figure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double SideA, double SideB, double SideC)
        {
            this.SideA = SideA;
            this.SideB = SideB;
            this.SideC = SideC;
        }
        //Проверка явл ли треугольник прямоугольным
        private bool IfIsItRightTriangle()
        {
            if (Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2)) { return true; }
            if (Math.Pow(SideB, 2) + Math.Pow(SideC, 2) == Math.Pow(SideA, 2)) { return true; }
            if (Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2)) { return true; }
            return false;
        }
        protected override bool Validate()
        {
            if (SideA < 0 || SideB < 0 || SideC < 0)
            {
                Console.WriteLine("Ошибка в воде стороны треугольника. Сторона треугольника не может иметь отрицательную длину.");
                return false;
            }
            if (SideA + SideB < SideC || SideB + SideC < SideA || SideA + SideC < SideB)
            {
                Console.WriteLine("Одна сторона треугольника больше суммы двух других сторон. Такой треугольник не может существовать.");
                return false;
            }
            return true;
        }
        protected override double CalculateSquareCore()
        {
            if (IfIsItRightTriangle())
            {
                Console.Write("Этот треугольник прямоугольный!");
                return (0.5 * SideA * SideB);
            }
            else
            {
                double p = 0.5 * (SideA + SideB + SideC);
                return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            }
        }
    }
}
