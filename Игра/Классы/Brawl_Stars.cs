using System;

namespace Игра
{
    internal class Brawl_Stars : IGame
    {
        Random random = new Random();
        /// <summary>
        /// Метод присваивания очко для игры бравл старс
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
