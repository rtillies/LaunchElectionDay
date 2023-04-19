using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchElectionDay
{
    public class Race
    {
        public string Office;
        public List<Candidate> Candidates;
        public bool IsOpen;

        public Race(string office)
        {
            Office = office;
            Candidates = new List<Candidate>();
            IsOpen = true;
        }

        public void RegisterCandidate(Candidate candid)
        {
            Candidates.Add(candid);
        }

        public void Close()
        {
            IsOpen = false;
        }
    }
}
