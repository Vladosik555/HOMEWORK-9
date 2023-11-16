using System;
using System.Collections.Generic;
using System.Linq;

namespace Игра
{
    internal class Total
    {
        /// <summary>
        /// Метод, который показывает сколько очков суммарно набрала команда 
        /// </summary>
        /// <param name="teams"></param>
        public void Totall(Team teams)
        {
            Console.WriteLine($"Команда {teams.name} набрала в сумме {teams.point} очков");
        }
        /// <summary>
        /// Метод, который удаляет команду, с минимальным количеством очков, если 2 или более команды оказываются с минимальным
        /// количеством очков, то метод удаляет команду на рандом
        /// </summary>
        /// <param name="teams"></param>
        public void Remove_Teams(List<Team> teams)
        {
            int minScore_1 = teams.Min(p => p.point);
            int minScore_2 = teams.IndexOf(teams.First(team => team.point == minScore_1));
            Console.WriteLine($"Команда одна из команд покидает игру из-за минимально количества очков");
            teams.RemoveAt(minScore_2);
        }
        /// <summary>
        /// Метод .который обнуляет очки, по прохождению определенных количеств игр
        /// </summary>
        /// <param name="teams"></param>
        public void Update_Point(Team teams)
        {
            teams.point = 0;
        }
        /// <summary>
        /// Метод, который объявляет команду победителя
        /// </summary>
        /// <param name="teams"></param>
        public void Winner(Team teams)
        {
            Console.WriteLine($"Команда {teams.name} победила соревнования");
        }
    }
}
