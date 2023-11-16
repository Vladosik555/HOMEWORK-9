using System;
using System.Collections.Generic;

namespace Игра
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Игра");
            List<Team> teams = new List<Team>();
            string[] name = new string[] { "Россия", "Франция", "Китай", "Казахстан" };
            for (int i = 0; i < 4; i++)
            {
                Team team = new Team(name[i]);
                teams.Add(team);
            }
            Console.WriteLine("Начитается первый этап из 3-х игр на убывание");
            Console.WriteLine();
            Console.WriteLine("Результаты участников в игре в пляж"); 
            Beach beach = new Beach();
            foreach (Team team in teams)
            {
                ((IGame)beach).Game(team);
            }
            Console.WriteLine();
            Console.WriteLine("Результаты участников в игре в мышеловки");
            Console.WriteLine();
            Mousetrap mousetrap = new Mousetrap();
            foreach (Team team in teams)
            {
                ((IGame)mousetrap).Game(team);
            }
            Console.WriteLine();
            Console.WriteLine("Результаты участников в игре в море");
            Console.WriteLine();
            Sea sea = new Sea();
            foreach (Team team in teams)
            {
                ((IGame)sea).Game(team);
            }
            Console.WriteLine();
            Total total = new Total();
            foreach (Team team in teams)
            {
                total.Totall(team);
            }
            total.Remove_Teams(teams);
            foreach (Team team in teams)
            {
                total.Update_Point(team);
            }
            Console.WriteLine();
            Console.WriteLine("Начинает второй этап игр на убывание, очки участников обновляются");
            Console.WriteLine();
            Console.WriteLine("Результаты участников в игре рыбалка");
            Console.WriteLine();
            Fishing fishing = new Fishing();
            foreach (Team team in teams)
            {
                ((IGame)fishing).Game(team);
            }
            Console.WriteLine();
            Console.WriteLine("Результаты участников в игре почтальоны");
            Console.WriteLine();
            Postmen postmen = new Postmen();
            foreach (Team team in teams)
            {
                ((IGame)postmen).Game(team);
            }
            Console.WriteLine();
            Console.WriteLine("Результаты участников в игре горки");
            Console.WriteLine();
            Gorkp gorkp = new Gorkp();
            foreach (Team team in teams)
            {
                ((IGame)gorkp).Game(team);
            }
            Console.WriteLine();
            foreach (Team team in teams)
            {
                total.Totall(team);
            }
            total.Remove_Teams(teams);
            foreach (Team team in teams)
            {
                total.Update_Point(team);
            }
            Console.WriteLine();
            Console.WriteLine("Финал по игре Brawl Stars, очки участников обновляются");
            Console.WriteLine();
            Brawl_Stars brawl_Stars = new Brawl_Stars();
            foreach (Team team in teams)
            {
                ((IGame)brawl_Stars).Game(team);
            }
            Console.WriteLine();
            foreach (Team team in teams)
            {
                total.Totall(team);
            }
            Console.WriteLine();
            total.Remove_Teams(teams);
            foreach (Team team in teams)
            {
                total.Update_Point(team);
            }
            Console.WriteLine();
            foreach(Team team in teams)
            {
                total.Winner(team);
            }
            Console.WriteLine();
            Console.WriteLine("Для того чтобы закрыть программу, нажмите на любую клавишу");
            Console.ReadKey();
        }
    }
}
