using System.Collections.Generic;

namespace wf_poll_cwe
{
    public interface IPollResults
    {
        int TotalVotes();
        Dictionary<Candidate, IndividualResults> ForAll();
        void AddOne(Candidate c);

    }
}