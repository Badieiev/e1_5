using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1_5
{
    class Team
    {
        public string NameTeam { get; set; }
        Coach coach;
        public Team(string nameTeam, Coach c)
        {
            NameTeam = nameTeam;
            coach = c;
        }
        List<Player> playees = new List<Player>();

        public void AddPlayee(Player p)
        {
            playees.Add(p);
        }

        double sumMastery;
        public double SumMastery
        {
            get { return sumMastery; }
            set { this.sumMastery = GetAllMastery(); }
        }
        public double GetAllMastery()
        {
            foreach (var playee in playees)
            {
                sumMastery += playee.GetRandomMastery;
            }
            return sumMastery * coach.GetRandomLucky;
        }

        //- вывести список всех игроков по алфавиту(использовать LINQ)
        public void ShowAllNamePlayees()
        {
            var result = from playee in playees
                         orderby playee.NamePlayer
                         select playee;
            foreach (var person in result)
            {
                Console.WriteLine(person.NamePlayer);
            }
        }

        //- вывести список всех игроков старше 30 лет по убыванию уровня их мастерства(использовать LINQ)
        public void ShowAll30AgePlayees()
        {
            var result = from playee in playees
                         orderby playee.GetRandomMastery
                         where playee.AgePlayer > 30
                         select playee;
            foreach (var person in result)
            {
                Console.WriteLine(person.NamePlayer);
            }
        }
    }
}
