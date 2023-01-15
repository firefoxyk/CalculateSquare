using CalculateSquare;

public class Program
{
    public static void Main()
    {
        Figure figure;

        Console.Write("Вычиляем площадь круга(1) или треугольника(0)?");
        if (Console.ReadLine() == "1")
        {
            Console.Write("Введите радиус круга: ");
            figure = new Circle(Convert.ToDouble(Console.ReadLine()));
        }
        else
        {
            Console.Write("Введите первую сторону треугольника: "); double SideA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вторую сторону треугольника: "); double SideB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третью сторону треугольника: "); double SideC = Convert.ToDouble(Console.ReadLine());
            figure = new Triangle(SideA, SideB, SideC);
        }

        Console.WriteLine(figure.CalculateSquare());
    }
}
