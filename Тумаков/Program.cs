using System;

namespace Тумаков
{
    enum Color
    {
        Белый,
        Чёрный,
        Красный,
        Жёлтый,
        Синий
    }
    enum State
    {
        Видимый,
        Невидимый
    }
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Упражнение 10.1");
            Console.WriteLine("Данная программа выводит следующую букву (алфавита или регистра)");
            Console.Write("Напишите букву алфавита или слово: ");
            string letters = Console.ReadLine();
            Console.WriteLine("Вы берите шифровку по алфавитному порядку или по i-позиции"
                +"\nЕсли хотите выбрать по алфавитному порядку, нажмите 0"+
                "\nЕсли по i-позиции, нажмите 1");
            bool flag = uint.TryParse(Console.ReadLine(), out uint number);
            if (flag)
            {
                if(number == 0)
                {
                    Console.WriteLine("Выберите команду" + 
                        "\nЕсли хотите шифровать, нажмите 0" +
                        "\nЕсли хотите дешифровать, нажмите 1");
                    bool flag_1 = uint.TryParse(Console.ReadLine(),out uint number_1);
                    if (flag_1)
                    {
                        if (number_1 == 0)
                        {
                            ACipher aCipher = new ACipher(letters);
                            aCipher.encode(letters);
                        }
                        else if (number_1 == 1)
                        {
                            ACipher aCipher = new ACipher(letters);
                            aCipher.decode(letters);
                        }
                        else
                        {
                            Console.WriteLine("Такой команды не существует");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы не захотели шифровать строки");
                    }
                }
                else if (number == 1)
                {
                    Console.WriteLine("Выберите команду" +
                        "\nЕсли хотите шифровать, нажмите 0" +
                        "\nЕсли хотите дешифровать, нажмите 1");
                    bool flag_2 = uint.TryParse(Console.ReadLine(), out uint number_2);
                    if (flag_2)
                    {
                        if (number_2 == 0)
                        {
                            BCipher bCipher = new BCipher(letters);
                            bCipher.encode(letters);
                        }
                        else if (number_2 == 1)
                        {
                            BCipher bCipher = new BCipher(letters);
                            bCipher.decode(letters);
                        }
                        else
                        {
                            Console.WriteLine("Такой команды не существует");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Вы не захотели шифровать строки");
                }
            }
            else
            {
                Console.WriteLine("Нельзя вводить строки, символы и отрицательные числа");
            }
            Console.WriteLine("Для того чтобы закрыть программу, нажмите на любую клавишу");
            Console.ReadKey();
            


            Console.WriteLine("Упражнение 10.2");
            Console.WriteLine("Работа с геометрическими фигурами");
            Console.WriteLine("\nВыберите геометрическую фигуру"+
                "\nДля того чтобы выбрать точку, нажмите 0" + 
                "\nДля того чтобы выбрать окружность, нажмите 1"+
                "\nДля того чтобы выбрать прямоугольник, нажмите 2");
            bool flag_3 = uint.TryParse(Console.ReadLine(), out uint number_3);
            if (flag_3)
            {
                switch (number_3)
                {
                    case 0:
                        Point point = new Point(0, 0, Color.Белый, State.Видимый);
                        point.Movement_X();
                        point.Movement_Y();
                        point.Change_Color();
                        point.Change_State();
                        point.Information();
                        break;
                    case 1:
                        Circle circle = new Circle(10, 10, Color.Чёрный, State.Невидимый, 5);
                        circle.Movement_X();
                        circle.Movement_Y();
                        circle.Change_Color();
                        circle.Change_State();
                        circle.Square();
                        circle.Information();
                        break;
                    case 2:
                        Rectangle rectangle = new Rectangle(20 ,20, Color.Красный, State.Видимый, 10, 20);
                        rectangle.Movement_X();
                        rectangle.Movement_Y();
                        rectangle.Change_Color();
                        rectangle.Change_State();
                        rectangle.Square();
                        rectangle.Information();
                        break;
                    default:
                        Console.WriteLine("Вы решили не выбирать команду");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Нельзя вводить строки, символы и отрицательные числа");
            }
            Console.WriteLine("Для того чтобы закрыть программу, нажмите на любую клавишу");
            Console.ReadKey();
        }
    }
}
