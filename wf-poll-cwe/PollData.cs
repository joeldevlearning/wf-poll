using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_poll
{
    class PollData
    {
        public IReadOnlyList<Candidate> Candidates;
    }

    class Candidate
    {
        public readonly string Name;
        public readonly Guid Id;

        public Candidate(string name)
        {
            name = Name;
            Id = new Guid();

        }
    }
}
