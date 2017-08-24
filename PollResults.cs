using System;

namespace wf_poll_cwe
{
    public class PollResults : IPollResults
    {
        private List<int> CandidateOne { get; }
        private List<int> CandidateTwo { get; }

        public PollResults(int cOneTotal, int cTwoTotal)
        {
            CandidateOne = new List<int> { cOneTotal };
            CandidateTwo = new List<int> { cTwoTotal };
        }

        interface IPollResults
        {
            List<int> CandidateOne();

            List<int> CandidateTwo();
        }
    }
}