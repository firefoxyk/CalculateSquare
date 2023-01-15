using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSquare
{
    public class Circle : Figure
    {
        public double Radius { get; }

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        protected override bool Validate()
        {
            if (Radius < 0)
            {
                Console.WriteLine("Ошибка в вводе раидуса круга. Радиус не может иметь отрицательную длину.");
                return false;
            }
            return true;
        }
        //Вычисление площади
        protected override double CalculateSquareCore()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
