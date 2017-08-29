using System.Collections.Generic;


namespace wf_poll_cwe
{
    public class Poller : IPoller
    {
        private readonly IPollModel _model;

        private IDataSource Data;

        public Poller(IPollModel m)
        {
            _model = m;

            //add some test data to the model

            foreach (var candidate in _model.AllCandidates())
            {
                _model.UpdateByOne(candidate);
            }
        }

        //replaces save vote
        public void AddVoteFor(Candidate c)
        {
            UpdateModel(c);
        }

        /*
        public void UpdateStorage(Candidate c)
        {

        }
        */

        void UpdateModel(Candidate c)
        {
            _model.UpdateByOne(c);
        }

    }
}
