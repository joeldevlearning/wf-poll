namespace wf_poll_cwe
{
    partial class PollForm
    {
        #region partially generated code
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox SelectionBox;
        private System.Windows.Forms.Label LabelForQuestion;
        private System.Windows.Forms.Label LabelForResults;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartForResults;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            InitPollForm();

            InitSelectionBox();

            InitLabelForQuestion();
            InitCandidateRadioButtons();
            InitSubmitButton();

            InitLabelForResults();

            this.SelectionBox.Controls.Add(this.SubmitButton);
            this.SelectionBox.Controls.Add(this.LabelForQuestion);

            InitChart();
            this.Controls.Add(this.ChartForResults);
            this.Controls.Add(this.LabelForResults);
            this.Controls.Add(this.SelectionBox);

            InitPollForm();
            this.SelectionBox.PerformLayout();
        }
    }
    #endregion
}

