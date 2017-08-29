using System;

namespace wf_poll_cwe
{
    public class IndividualResults : Tuple<int, decimal>
    {
        public IndividualResults(int partOfTotal, decimal percent) : base(partOfTotal, percent)
        {

        }
    }
}