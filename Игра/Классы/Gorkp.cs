using System;

namespace Игра
{
    internal class Gorkp : IGame
    {
        Random random = new Random();
        /// <summary>
        /// Метод для присваивания очков в игре горки
        /// </summary>
        /// <param name="teams"></param>
        void IGame.Game(Team teams)
        {
            int count = 0;
            for (int i = 0; i < 15; i++)
            {
                count += random.Next(0, 10);
            }
            teams.point += count;
            Console.WriteLine($"Команда {teams.name} набрала {count} очков");
        }
    }
}
