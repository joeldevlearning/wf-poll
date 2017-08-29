using System.Collections.Generic;

namespace wf_poll_cwe
{
    public interface IPollViewModel
    {
        IEnumerable<Candidate> GetCandidates();
        void AddVoteFor(Candidate c);
        IPollResults GetResults();

    }
}