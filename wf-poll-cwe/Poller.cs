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

            //add some test data to the model

            foreach (var candidate in _model.AllCandidates())
            {
                _model.UpdateByOne(candidate);
            }


            CList = new CandidateList();
            Data = new XmlDataSource(CList);
            Calc = new PollCalculator(CList);
        }

        public CandidateList GetCandidates()
        {
            return CList;
        }

        public void SaveVote(string vote)
        {
            Data.WriteVote(vote);
        }

        //replaces save vote
        public void AddVoteFor(Candidate c)
        {
            UpdateModel(c);
        }

        public Dictionary<string, PollResult> GetPollResults()
        {
            return Calc.TallyResults(Data.ReadAllVotes());
        }

        private void UpdateStorage(Candidate c)
        {

        }

        private void UpdateModel(Candidate c)
        {
            _model.UpdateByOne(c);
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
        void AddVoteFor(Candidate c);
        Dictionary<string, PollResult> GetPollResults();

        CandidateList GetCandidates();
    }
}
