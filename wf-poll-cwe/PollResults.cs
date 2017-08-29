using System;
using System.Collections.Generic;

namespace wf_poll_cwe
{
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
            }
            TotalVoteCount = 0;
        }

        public Dictionary<Candidate, IndividualResults> ForAll()
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

        private decimal Percent(int part, int total)
        {
            return Math.Round(((decimal)part / total) * 100, 2);
        }
    }
}