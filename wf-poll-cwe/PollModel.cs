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
        public IPollResults AllResults { get; }

        public PollModel(List<string> candidates)
        {
            /*
            if (candidates.Count() > 2 && <= 10)
            {
                throw new Exception("At least two, and no more than ten, candidates are required.");
            }
            */
                _candidates = candidates.Select(c => new Candidate(c));
                AllResults = new PollResults(_candidates);
        }

        public IEnumerable<Candidate> AllCandidates()
        {
            return _candidates;
        }

        public IPollResults Results()
        {
            return AllResults;
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
        private int TotalVoteCount { get; }
        private Dictionary<Candidate, int> AllRaw { get; }

        public PollResults(IEnumerable<Candidate> cList)
        {
            AllRaw = new Dictionary<Candidate, int>();

            foreach (Candidate c in cList)
            {
                AllRaw.Add(c,0); //begin with zero votes
                TotalVoteCount = AllRaw.Count;
            }
        }

        public Dictionary<Candidate, IndividualResults> All()
        {
            var allResults = new Dictionary<Candidate,IndividualResults>();
            foreach (var candidate in AllRaw)
            {
                allResults.Add(candidate.Key,
                    new IndividualResults(candidate.Value,
                                          TotalVoteCount,
                                          Percent(candidate.Value, TotalVoteCount)));
            }
            return allResults;
        }

        public int TotalVotes() => TotalVoteCount;


        public void Update()
        {
            //TODO, called from PollModel
        }

        public IndividualResults For(Candidate c)
        {
            var part = AllRaw[c]; //get vote count for candidate
            return new IndividualResults(part,
                                         TotalVoteCount,
                                         Percent(part, TotalVoteCount));
        }

        private decimal Percent(int part, int total)
        {
            return Math.Round(((decimal)part / total) * 100, 2);
        }
    }

    public class IndividualResults : Tuple<int, int, decimal>
    {
        public IndividualResults(int partOfTotal, int total, decimal percent) : base(partOfTotal, total, percent)
        {

        }
    }

    public interface IPollModel
    {
        IEnumerable<Candidate> AllCandidates();
        IPollResults Results();
    }

    public interface IPollResults
    {
        int TotalVotes();
        Dictionary<Candidate, IndividualResults> All();
        IndividualResults For(Candidate c);

    }


}
