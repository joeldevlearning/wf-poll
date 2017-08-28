using System.Collections.Generic;


namespace wf_poll_cwe
{
    class Poller : IPoller
    {
        private readonly IPollModel _model;

        private IDataSource Data;
        private IPollCalculator Calc;
        private CandidateList CList;

        public Poller(IPollModel m)
        {
            _model = m;

            CList = new CandidateList();
            Data = new XmlDataSource(CList);
            Calc = new PollCalculator(CList);
        }

        public IEnumerable<Candidate> GetCandidateList()
        {
            return _model.AllCandidates();
        }

        public CandidateList GetCandidates()
        {
            return CList;
        }

        public void SaveVote(string vote)
        {
            Data.WriteVote(vote);
        }

        public Dictionary<string, PollResult> GetPollResults()
        {
            return Calc.TallyResults(Data.ReadAllVotes());
        }

    }

    public class CandidateList
    {
        public string CandidateOne { get; }
        public string CandidateTwo { get; }

        public CandidateList(string one="Iron Man", string two="Captain America")
        {
            CandidateOne = one;
            CandidateTwo = two;
        }
    }

    public interface IPoller
    {
        void SaveVote(string vote);

        Dictionary<string, PollResult> GetPollResults();

        CandidateList GetCandidates();

        IEnumerable<Candidate> GetCandidateList();
    }
}
