using System.Collections.Generic;

namespace wf_poll_cwe
{
    public interface IPollModel
    {
        IEnumerable<Candidate> AllCandidates();
        void UpdateByOne(Candidate c);
        IPollResults Results();
    }
}