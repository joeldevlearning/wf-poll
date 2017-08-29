using System.Collections.Generic;

namespace wf_poll_cwe
{
    public interface IPoller
    {
        void AddVoteFor(Candidate c);
    }
}