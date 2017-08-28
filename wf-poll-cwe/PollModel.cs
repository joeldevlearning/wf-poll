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
        public IPollResults CurrentResults { get; }

        public PollModel(List<string> candidates)
        {
            /*
            if (candidates.Count() > 2 && <= 10)
            {
                throw new Exception("At least two, and no more than ten, candidates are required.");
            }
            */
                _candidates = candidates.Select(c => new Candidate(c));
                CurrentResults = new PollResults(_candidates);
        }

        public IEnumerable<Candidate> AllCandidates()
        {
            return _candidates;
        }

        public IPollResults Results()
        {
            return CurrentResults;
        }

        public void UpdateByOne(Candidate c)
        {

            CurrentResults.AddOne(c);
        }
    }

    class PollResults : IPollResults
    {
        private int TotalVoteCount { get; set; }
        private Dictionary<Candidate, int> ResultsByCandidate { get; }

        public PollResults(IEnumerable<Candidate> cList)
        {
            ResultsByCandidate = new Dictionary<Candidate, int>();

            foreach (Candidate c in cList)
            {
                ResultsByCandidate.Add(c,0); //begin with zero votes
                TotalVoteCount = 0;
            }
        }

        public Dictionary<Candidate, IndividualResults> ByCandidate()
        {
            var allResults = new Dictionary<Candidate,IndividualResults>();
            foreach (var candidate in ResultsByCandidate)
            {
                allResults.Add(candidate.Key,
                    new IndividualResults(candidate.Value,
                                          Percent(candidate.Value, TotalVoteCount)));
            }
            return allResults;
        }

        public int TotalVotes() => TotalVoteCount;


        public void AddOne(Candidate c)
        {
            TotalVoteCount++;
            ResultsByCandidate[c]++;
        }

        public IndividualResults For(Candidate c)
        {
            var part = ResultsByCandidate[c]; //get vote count for candidate
            return new IndividualResults(part,
                                         Percent(part, TotalVoteCount));
        }

        private decimal Percent(int part, int total)
        {
            return Math.Round(((decimal)part / total) * 100, 2);
        }
    }


    public class Candidate
    {
        public string Name { get; }
        public Guid Id { get; }

        public Candidate(string name)
        {
            Name = name;
            Id = new Guid();
        }

        public bool Equals(Candidate other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.Name == Name && other.Id == Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Candidate)) return false;
            return Equals((Candidate)obj);
        }

        //adapted from "Effective Java" by Josh Bloch
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Name.GetHashCode();
                hash = hash * 23 + Id.GetHashCode();
                return hash;
            }
        }
    }

    public class IndividualResults : Tuple<int, decimal>
    {
        public IndividualResults(int partOfTotal, decimal percent) : base(partOfTotal, percent)
        {

        }
    }

    public interface IPollModel
    {
        IEnumerable<Candidate> AllCandidates();
        void UpdateByOne(Candidate c);
        IPollResults Results();
    }

    public interface IPollResults
    {
        int TotalVotes();
        Dictionary<Candidate, IndividualResults> ByCandidate();
        IndividualResults For(Candidate c);
        void AddOne(Candidate c);

    }


}
