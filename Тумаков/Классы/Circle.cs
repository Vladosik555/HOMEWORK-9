using System;

namespace Тумаков
{
    internal class Circle : Point
    {
        private double radius { get; set; }
        private double square;
        public Circle(int x, int y, Color color, State state, int radius) : base(x, y, color, state)
        {
            this.radius = radius;
        }
        /// <summary>
        /// Метод, который считает площадь окружности
        /// </summary>
        public void Square()
        {
            if (radius < 0)
            {
                Console.WriteLine("Из отрицательного радиуса невозможно посчитать площадь");
                square = 0;
            }
            else if (radius == 0)
            {
                Console.WriteLine("Так как радиус равен 0, следовательно площадь равна 0");
                square = 0;
            }
            else
            {
                square = Math.PI * radius * radius;
            }
        }
        /// <summary>
        /// Метод, который выводит информацию об окружности
        /// </summary>
        public override void Information()
        {
            Console.WriteLine("Полная информация по точке");
            Console.WriteLine($"Координата окружности по X: {x}");
            Console.WriteLine($"Координата окружности по Y: {y}");
            if (color == Color.Белый)
            {
                Console.WriteLine("Ваша окружность покрашена в Белый");
            }
            if (color == Color.Чёрный)
            {
                Console.WriteLine("Ваша окружность покрашена в Чёрный");
            }
            if (color == Color.Красный)
            {
                Console.WriteLine("Ваша окружность покрашена в Красный");
            }
            if (color == Color.Жёлтый)
            {
                Console.WriteLine("Ваша окружность покрашена в Жёлтый");
            }
            if (color == Color.Синий)
            {
                Console.WriteLine("Ваша окружность покрашена в Синий");
            }
            if (state == State.Видимый)
            {
                Console.WriteLine("Ваша окружность видимая");
            }
            if (state == State.Невидимый)
            {
                Console.WriteLine("Ваша окружность невидимая");
            }
            Console.WriteLine($"Площадь окружности: {square}");
        }
    }
}
