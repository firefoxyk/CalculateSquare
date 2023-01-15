/* Напишите библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. 
 * Дополнительно оценим: 
 * Юнит - тесты 
 * Легкость добавления других фигур 
 * Вычисление площади фигуры без знания типа фигуры 
 * Проверку на то, является ли треугольник прямоугольным
*/

namespace CalculateSquare
{
    public abstract class Figure
    {
        protected abstract double CalculateSquareCore();
        protected abstract bool Validate();
        public double CalculateSquare()//каждый наследник должен уметь вычислять площадь
        {
            bool validate = Validate();
            if (validate) { return CalculateSquareCore(); }
            else return 0;
        }
    }
}