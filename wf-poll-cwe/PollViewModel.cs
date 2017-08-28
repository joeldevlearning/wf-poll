﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //TODO implement, call poller
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