using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace wf_poll_cwe
{
    public partial class PollForm : Form
    {
        private IPoller poller;
        private List<int> CandidateOneResults;
        private List<int> CandidateTwoResults;

        public PollForm()
        {
            //ORDER MATTERS! Components have a dependency on poller
            poller = new Poller();
            InitializeComponent();

            CandidateOneResults = new List<int> {0};
            CandidateTwoResults = new List<int> {0};
            ChartForResults.Series[poller.GetCandidates().CandidateOne].Points.DataBindY(CandidateOneResults);
            ChartForResults.Series[poller.GetCandidates().CandidateTwo].Points.DataBindY(CandidateTwoResults);
        }

            private void submitVote(string vote)
            {
                try
                {
                    poller.SaveVote(vote);
                }
                catch
                {
                    LabelForResults.Text = "Sorry, unable to process request. Please try again.";
                }
            }

            private void butResults_Click(object sender, EventArgs e)
            {
                var results = poller.GetPollResults();

                string cOne = poller.GetCandidates().CandidateOne;
                string cTwo = poller.GetCandidates().CandidateTwo;

                int totalVotes = results[cOne].Total + results[cTwo].Total;

            LabelForResults.Text =
                "Total Votes: " + totalVotes + "\n\n" +
                cOne + ": " + results[cOne].Total + " votes (" + results[cOne].Percent + "%).\n" +
                cTwo + ": " + results[cTwo].Total + " votes (" + results[cTwo].Percent + "%).\n\n";


            CandidateOneResults = new List<int> {results[cOne].Total};
            CandidateTwoResults = new List<int> {results[cTwo].Total};

            ChartForResults.Series[cOne].Points.DataBindY(CandidateOneResults);
            ChartForResults.Series[cTwo].Points.DataBindY(CandidateTwoResults);

            //this.ChartForResults.Series["CandidateOne"].Points.AddY(results[cOne].Total);
            //  this.ChartForResults.Series["CandidateTwo"].Points.AddY(results[cTwo].Total);

        }

            private void butSubmit_Click(object sender, EventArgs e)
            {
                if (CandidateOne.Checked == true)
                    submitVote(poller.GetCandidates().CandidateOne);
                else if (CandidateTwo.Checked == true)
                    submitVote(poller.GetCandidates().CandidateTwo);
            }

        private void PollForm_Load(object sender, EventArgs e)
        {
            candidateListBindingSource
                .Add(new CandidateList(
                    poller.GetCandidates().CandidateOne,
                    poller.GetCandidates().CandidateTwo));

            ChartForResults.Series["CandidateOne"]["PointWidth"] = "1";
            ChartForResults.Series["CandidateTwo"]["PointWidth"] = "1";
        }

        private void IM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void candidateListBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void LabelForResults_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void ChartForResults_Click(object sender, EventArgs e)
        {

        }
    }
    }
