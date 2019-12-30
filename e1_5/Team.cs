using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1_5
{
    class Team
    {
        public string Name { get; set; }
        Coach coach;
        public Team(string name, Coach c)
        {
            Name = name;
            coach = c;
        }
        List<Player> players = new List<Player>();

        public void AddPlayer(Player p)
        {
            players.Add(p);
        }

        public double GetAllMastery()
        {
            double sumMastery = 0.0;
            foreach (var player in players)
            {
                sumMastery += player.GetRandomMastery;
            }
            return sumMastery * coach.GetRandomLucky;
        }

        //- вывести список всех игроков по алфавиту(использовать LINQ)
        public void ShowAllNamePlayers()
        {
            var result = from player in players
                         orderby player.Name
                         select player;
            foreach (var person in result)
            {
                Console.WriteLine(person.Name);
            }
        }

        //- вывести список всех игроков старше 30 лет по убыванию уровня их мастерства(использовать LINQ)
        public void ShowAll30AgePlayers()
        {
            var result = from player in players
                         orderby player.GetRandomMastery
                         where player.Age > 30
                         select player;
            foreach (var person in result)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
