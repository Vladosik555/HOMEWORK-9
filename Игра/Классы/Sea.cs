using System;
using System.Threading;

namespace Игра
{
    internal class Sea : IGame
    {
        Random random = new Random();
        /// <summary>
        /// Метод для присваивания очков в игре море
        /// </summary>
        /// <param name="teams"></param>
        void IGame.Game(Team teams)
        {
            int count = 0;
            for (int i = 0; i < 15; i++)
            {
                count += random.Next(0, 10);
                Thread.Sleep(30);
            }
            teams.point += count;
            Console.WriteLine($"Команда {teams.name} набрала {count} очков");
        }
    }
}
