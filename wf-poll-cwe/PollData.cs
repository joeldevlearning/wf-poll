using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_poll
{
    /*
     * PollData contains Candidate objects
     * Each Candidate object contains all of its own information
     */
    class PollData
    {
        public IEnumerable<Candidate> Candidates { get; }
        public PollResults Results { get; }

        public PollData(List<string> candidates)
        {
            if (candidates.Count() != 2)
            {
                throw new Exception("Exactly two candidates are required.");
            }
                Candidates = candidates.Select(c => new Candidate(c));
        }
    }

    class Candidate
    {
        public readonly string Name;
        public readonly Guid Id;

        public Candidate(string name)
        {
            Name = name;
            Id = new Guid();
        }
    }

    class PollResults
    {
        private int Total { get; }
        private Dictionary<Candidate, int> Breakdown { get; }

        public PollResults(IEnumerable<Candidate> cList, int total=0)
        {
            foreach (Candidate c in cList)
            {
                Breakdown.Add(c,0); //begin with zero votes
            }
            Total = total;
        }

        public Tuple<int, int, decimal> For(Candidate c)
        {
            var part = Breakdown[c]; //get vote count for candidate
            return new Tuple<int, int, decimal>(part, Total, Percent(part, Total));
        }

        private decimal Percent(int part, int total)
        {
            return Math.Round(((decimal)part / total) * 100, 2);
        }


    }
}
