using System;
namespace Тумаков
{
    internal class Rectangle : Point
    {
        private double first_side { get; set; }
        private double second_side { get; set; }
        private double square;
        /// <summary>
        /// Конструктор прямоугольника
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="color"></param>
        /// <param name="state"></param>
        /// <param name="first_side"></param>
        /// <param name="second_side"></param>
        public Rectangle(int x, int y, Color color, State state, int first_side, int second_side) : base(x, y, color, state)
        {
            this.first_side = first_side;
            this.second_side = second_side;
        }
        /// <summary>
        /// Метод вычисления площади прямоугольника
        /// </summary>
        public void Square()
        {
            if (first_side < 0 || second_side < 0)
            {
                Console.WriteLine("Площадь не может быть отрицательной");
                square = 0;
            }
            else
            {
                square = first_side * second_side;
            }
        }
        /// <summary>
        /// Полная информация о треугольнике
        /// </summary>
        public override void Information()
        {
            Console.WriteLine("Полная информация по прямоугольнику");
            Console.WriteLine($"Координата прямоугольника по X: {x}");
            Console.WriteLine($"Координата прямоугольника по Y: {y}");
            if (color == Color.Белый)
            {
                Console.WriteLine("Ваш прямоугольник покрашен в Белый");
            }
            if (color == Color.Чёрный)
            {
                Console.WriteLine("Ваш прямоугольник покрашен в Чёрный");
            }
            if (color == Color.Красный)
            {
                Console.WriteLine("Ваш прямоугольник покрашен в Красный");
            }
            if (color == Color.Жёлтый)
            {
                Console.WriteLine("Ваш прямоугольник покрашен в Жёлтый");
            }
            if (color == Color.Синий)
            {
                Console.WriteLine("Ваш прямоугольник покрашен в Синий");
            }
            if (state == State.Видимый)
            {
                Console.WriteLine("Ваш прямоугольник видимый");
            }
            if (state == State.Невидимый)
            {
                Console.WriteLine("Ваш прямоугольник невидимый");
            }
            Console.WriteLine($"Площадь прямоугольника: {square}");
        }
    }
}
