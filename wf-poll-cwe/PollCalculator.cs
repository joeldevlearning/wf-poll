using System;
using System.Collections;
using System.Collections.Generic;

namespace wf_poll_cwe
{
    class PollCalculator : IPollCalculator
    {
        public Dictionary<string, PollResult> TallyResults(IEnumerable votes, CandidateList cList)
        {
            int cOneTotal = 0;
            int cTwoTotal = 0;
            foreach (var vote in votes)
            {
                if (vote.ToString() == cList.CandidateOne)
                    cOneTotal++;
                else if (vote.ToString() == cList.CandidateTwo)
                    cTwoTotal++;
            }

            double allTotal = cOneTotal + cTwoTotal;
            double cOnePercent = Math.Round((cOneTotal / allTotal) * 100, 2);
            double cTwoPercent = Math.Round((cTwoTotal / allTotal) * 100, 2);

            return new Dictionary<string, PollResult>()
            {
                {cList.CandidateOne, new PollResult(cOneTotal, cOnePercent)},
                {cList.CandidateTwo, new PollResult(cTwoTotal, cTwoPercent)}
            };


        }
    }

    interface IPollCalculator
    {
        Dictionary<string, PollResult> TallyResults(IEnumerable votes, CandidateList list);
    }
}
