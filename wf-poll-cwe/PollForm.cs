using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace wf_poll_cwe
{
    public partial class PollForm : Form
    {
        private IPoller poller;
        private IPollViewModel viewModel;

        public PollForm(IPoller p, IPollViewModel vm)
        {
            viewModel = vm;
            poller = p;

            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            SendVoteAndDisplayResults();
        }

        private void SendVoteAndDisplayResults()
        {
            //filter ALL radio buttons, get the checked one
            var checkedButton = Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            if (checkedButton == null) return;

            poller.AddVoteFor((Candidate)checkedButton.Tag);
            LabelForResults.Text = GenerateTextResults();

            var results = viewModel.GetResults().ForAll();
            foreach (var candidate in results)
            {
                ChartForResults.Series[candidate.Key.Name]
                    .Points.DataBindY(new List<int> {candidate.Value.Item1});
            }
        }

        private void PollForm_Load(object sender, EventArgs e)
        { }
    }
    }
