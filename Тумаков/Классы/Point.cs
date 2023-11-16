using System;

namespace Тумаков
{
    internal class Point : Figure
    {
        /// <summary>
        /// Конструктор класса точки
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="color"></param>
        /// <param name="state"></param>
        public Point(int x, int y, Color color, State state) : base(x, y, color, state) { }
        /// <summary>
        /// Метод, который позволяет передвинуть объект по оси X
        /// </summary>
        public void Movement_X()
        {
            Console.Write("Напишите на сколько вы хотите передвинуть точку по оси X: ");
            bool flag = int.TryParse(Console.ReadLine(), out int coord);
            if (flag)
            {
                this.x += coord;
            }
            else
            {
                Console.WriteLine("Нельзя писать строки и символы");
            }
        }
        /// <summary>
        /// Метод, который позволяет передвинуть объект по оси Y
        /// </summary>
        public void Movement_Y()
        {
            Console.Write("Напишите на сколько вы хотите передвинуть точку по оси Y: ");
            bool flag = int.TryParse(Console.ReadLine(), out int coord);
            if (flag)
            {
                this.y += coord;
            }
            else
            {
                Console.WriteLine("Нельзя писать строки и символы");
            }
        }
        /// <summary>
        /// Метод, который позволяет поменять цвет объекта
        /// </summary>
        public void Change_Color()
        {
            Console.WriteLine("Напишите цвет, в который вы хотите покрасить точку" +
                "\nДля того чтобы покрасить в Белый, нажмите 0" +
                "\nДля того чтобы покрасить в Чёрный, нажмите 1" +
                "\nДля того чтобы покрасить в Красный, нажмите 2" +
                "\nДля того чтобы покрасить в Жёлтый, нажмите 3" +
                "\nДля того чтобы покрасить в Синий, нажмите 4");
            bool flag = uint.TryParse(Console.ReadLine(), out uint number);
            if (flag)
            {
                switch (number)
                {
                    case 0:
                        this.color = Color.Белый;
                        break;
                    case 1:
                        this.color = Color.Чёрный;
                        break;
                    case 2:
                        this.color = Color.Красный;
                        break;
                    case 3:
                        this.color = Color.Жёлтый;
                        break;
                    case 4:
                        this.color = Color.Синий;
                        break;
                    default:
                        Console.WriteLine("Вы решили не перекрашивать точку");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Нельзя вводить строки, символы или отрицательные числа");
            }
        }
        /// <summary>
        /// Метод, который показывает состояние объекта
        /// </summary>
        public void Change_State()
        {
            if (state == State.Видимый)
            {
                Console.WriteLine("Ваша точка видимая");
            }
            else if (state == State.Невидимый)
            {
                Console.WriteLine("Ваша точка невидимая");
            }
        }
        /// <summary>
        /// Метод, который выводит всю информацию о объекте
        /// </summary>
        public override void Information()
        {
            Console.WriteLine("Полная информация по точке");
            Console.WriteLine($"Координата точки по X: {x}");
            Console.WriteLine($"Координата точки по Y: {y}");
            if (color == Color.Белый)
            {
                Console.WriteLine("Ваша точка покрашена в Белый");
            }
            if (color == Color.Чёрный)
            {
                Console.WriteLine("Ваша точка покрашена в Чёрный");
            }
            if (color == Color.Красный)
            {
                Console.WriteLine("Ваша точка покрашена в Красный");
            }
            if (color == Color.Жёлтый)
            {
                Console.WriteLine("Ваша точка покрашена в Жёлтый");
            }
            if (color == Color.Синий)
            {
                Console.WriteLine("Ваша точка покрашена в Синий");
            }
            if (state == State.Видимый)
            {
                Console.WriteLine("Ваша точка видимая");
            }
            if (state == State.Невидимый)
            {
                Console.WriteLine("Ваша точка невидимая");
            }
        }
    }
}
