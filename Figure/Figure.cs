namespace Figure
{
    public abstract class Figure
    {
        public abstract double Area();
        public abstract double Perimeter();
        public abstract string ShapeName();

        public void ShowInfo()
        {
            Console.WriteLine(
                $"Название фигуры: {ShapeName()}\n" +
                $"Площадь: {Area()}\n" +
                $"Периметр: {Perimeter()}"
            );
            Console.WriteLine();
        }
    }
}