using System.Collections.Generic;

namespace wf_poll_cwe
{
    public interface IDataSource
    {
        void WriteVote(string vote);

        IEnumerable<string> ReadAllVotes();
    }
}