using System;
using System.Collections.Generic;
using System.Linq;

namespace wf_poll_cwe
{
    /*
     * PollModel contains Candidate objects
     * Each Candidate object contains all of its own information
     */
    class PollModel : IPollModel
    {
        private readonly IEnumerable<Candidate> _candidates;
        public IPollResults VoteCounts { get; }

        public PollModel(List<string> candidates)
        {
            /*
            if (candidates.Count() > 2 && <= 10)
            {
                throw new Exception("At least two, and no more than ten, candidates are required.");
            }
            */
                _candidates = candidates.Select(c => new Candidate(c));
                VoteCounts = new PollResults(_candidates);
        }

        public IEnumerable<Candidate> AllCandidates()
        {
            return _candidates;
        }

        public IPollResults Results()
        {
            return VoteCounts;
        }

        public void Update()
        {
            //TODO, call into PollResults to the make the actual change
        }
    }

    public class Candidate
    {
        public readonly string Name;
        public readonly Guid Id;

        public Candidate(string name)
        {
            Name = name;
            Id = new Guid();
        }
    }

    class PollResults : IPollResults
    {
        private int TotalVotes { get; }
        private Dictionary<Candidate, int> All { get; }

        public PollResults(IEnumerable<Candidate> cList)
        {
            All = new Dictionary<Candidate, int>();

            foreach (Candidate c in cList)
            {
                All.Add(c,0); //begin with zero votes
                TotalVotes = All.Count;
            }
        }

        public void Update()
        {
            //TODO, called from PollModel
        }

        public Tuple<int, int, decimal> For(Candidate c)
        {
            var part = All[c]; //get vote count for candidate
            return new Tuple<int, int, decimal>(part, TotalVotes, Percent(part, TotalVotes));
        }

        private decimal Percent(int part, int total)
        {
            return Math.Round(((decimal)part / total) * 100, 2);
        }
    }

    public interface IPollModel
    {
        IEnumerable<Candidate> AllCandidates();
        IPollResults Results();
    }

    public interface IPollResults
    {
        Tuple<int, int, decimal> For(Candidate c);
    }


}
