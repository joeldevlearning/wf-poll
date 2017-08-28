using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wf_poll_cwe
{
    public partial class PollForm : Form
    {
        //TODO, ultimately remove dependency on poller
        //replace with single dependency on viewmodel
        private IPoller poller;
        private IPollViewModel viewModel;

        public PollForm(IPoller p, IPollViewModel vm)
        {
            viewModel = vm;
            poller = p;

            InitializeComponent();
        }

            private void SubmitVote(string vote)
            {
                try
                {
                    poller.SaveVote(vote);
                    UpdateResults();
            }
                catch
                {
                    LabelForResults.Text = "Sorry, unable to process request. Please try again.";
                }
            }

        private void butSubmit_Click(object sender, EventArgs e)
            {
                //filter ALL radio buttons, get the checked one
                var checkedButton = this.Controls.OfType<RadioButton>()
                    .FirstOrDefault(r => r.Checked);

                if(checkedButton != null)
                {
                    poller.AddVoteFor((Candidate)checkedButton.Tag);
                    LabelForResults.Text = GenerateTextResults();
            }
        }



        private void UpdateResults()
        {
            var results = poller.GetPollResults();

            //pull candidate names

            string cOneName = poller.GetCandidates().CandidateOne;
            string cTwoName = poller.GetCandidates().CandidateTwo;

            //calculate total votes
            int totalVotes = results[cOneName].Total + results[cTwoName].Total;

            //display totals and percents for each candidate as text
            LabelForResults.Text =
                "Total Votes: " + totalVotes + "\n\n" +
                cOneName + ": " + results[cOneName].Total + " votes (" + results[cOneName].Percent + "%).\n" +
                cTwoName + ": " + results[cTwoName].Total + " votes (" + results[cTwoName].Percent + "%).\n\n";

            //update chart with new data
            //each candidate only has one number to display, but chart library requires IEnumerable, e.g. list
            ChartForResults.Series["Iron Man"].Points.DataBindY(
                new List<int> { results[cOneName].Total });
            ChartForResults.Series["Captain America"].Points.DataBindY(
                new List<int> { results[cTwoName].Total });
        }

        private void PollForm_Load(object sender, EventArgs e)
        {
            //bind candidates in form names to CandidateList
            candidateListBindingSource
                .Add(new CandidateList(
                    poller.GetCandidates().CandidateOne,
                    poller.GetCandidates().CandidateTwo));
        }

        private void AllCheckBoxes_CheckedChanged(Object sender, EventArgs e)
        { }

        private void SelectionBox_Enter(object sender, EventArgs e)
        {

        }

        private void candidateListBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void LabelForResults_Click(object sender, EventArgs e)
        {

        }

        private void ChartForResults_Click(object sender, EventArgs e)
        {

        }
    }
    }
