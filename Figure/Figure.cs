namespace Figure
{
    public abstract class Figure
    {
        public abstract double getArea();
        public abstract double getPerimeter();
        public abstract string getName();

        public void ShowInfo()
        {
            Console.WriteLine(
                $"Название фигуры: {getName()}\n" +
                $"Площадь: {getArea()}\n" +
                $"Периметр: {getPerimeter()}"
            );
            Console.WriteLine();
        }
    }
}