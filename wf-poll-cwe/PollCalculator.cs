using System;
using System.Collections;
using System.Collections.Generic;

namespace wf_poll_cwe
{
    class PollCalculator : IPollCalculator
    {
        private CandidateList CList;

        public PollCalculator(CandidateList cList)
        {
            CList = cList;
        }
        public Dictionary<string, PollResult> TallyResults(IEnumerable votes)
        {
            int cOneTotal = 0;
            int cTwoTotal = 0;
            foreach (var vote in votes)
            {
                if (vote.ToString() == CList.CandidateOne)
                    cOneTotal++;
                else if (vote.ToString() == CList.CandidateTwo)
                    cTwoTotal++;
            }

            double allTotal = cOneTotal + cTwoTotal;
            double cOnePercent = Math.Round((cOneTotal / allTotal) * 100, 2);
            double cTwoPercent = Math.Round((cTwoTotal / allTotal) * 100, 2);

            return new Dictionary<string, PollResult>()
            {
                {CList.CandidateOne, new PollResult(cOneTotal, cOnePercent)},
                {CList.CandidateTwo, new PollResult(cTwoTotal, cTwoPercent)}
            };


        }
    }

    interface IPollCalculator
    {
        Dictionary<string, PollResult> TallyResults(IEnumerable votes);
    }
}
