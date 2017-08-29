using System.Collections.Generic;

namespace wf_poll_cwe
{
    public class PollViewModel : IPollViewModel
    {
        private readonly IPoller _poller;
        private readonly IPollModel _backingModel;

        public PollViewModel(IPoller p, IPollModel m)
        {
            _poller = p;
            _backingModel = m;
        }

        public IEnumerable<Candidate> GetCandidates()
        {
            return _backingModel.AllCandidates();
        }

        public void AddVoteFor(Candidate c)
        {
            _poller.AddVoteFor(c);
        }

        public IPollResults GetResults()
        {
            return _backingModel.Results();
        }

    }

    /*
     * Interface exposed to view
     */
    public interface IPollViewModel
    {
        IEnumerable<Candidate> GetCandidates();
        void AddVoteFor(Candidate c);
        IPollResults GetResults();

    }


}
