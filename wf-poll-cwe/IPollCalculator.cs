using System.Collections;
using System.Collections.Generic;

namespace wf_poll_cwe
{
    interface IPollCalculator
    {
        Dictionary<string, PollResult> TallyResults(IEnumerable votes);
    }
}