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
                _candidates = candidates.Select(c => new Candidate(c));
                CurrentResults = new PollResults(_candidates);
        }

        public IEnumerable<Candidate> AllCandidates() => _candidates;

        public IPollResults Results() => CurrentResults;

        public void UpdateByOne(Candidate c) => CurrentResults.AddOne(c);
    }
}
