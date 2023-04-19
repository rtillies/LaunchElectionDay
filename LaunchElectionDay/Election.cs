using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LaunchElectionDay
{
    public class Election
    {
        private string Year { get; }
        private List<Race> Races { get; set; }

        public Election(string year)
        {
            Year = year;
            Races = new List<Race>();
        }

        public string GetYear()
        {
            return Year;
        }

        public List<Race> GetRaces()
        {
            return Races;
        }

        public void AddRace(Race race)
        {
            Races.Add(race);
        }
    }
}
