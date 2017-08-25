namespace wf_poll_cwe
{
    partial class PollForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.CandidateOne = new System.Windows.Forms.RadioButton();
            this.candidateListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CandidateTwo = new System.Windows.Forms.RadioButton();
            this.SelectionBox = new System.Windows.Forms.GroupBox();
            this.butSubmit = new System.Windows.Forms.Button();
            this.LabelForQuestion = new System.Windows.Forms.Label();
            this.LabelForResults = new System.Windows.Forms.Label();
            this.ChartForResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.candidateListBindingSource)).BeginInit();
            this.SelectionBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartForResults)).BeginInit();
            this.SuspendLayout();
            // 
            // CandidateOne
            // 
            this.CandidateOne.AutoSize = true;
            this.CandidateOne.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.candidateListBindingSource, "CandidateOne", true));
            this.CandidateOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CandidateOne.Location = new System.Drawing.Point(41, 82);
            this.CandidateOne.Margin = new System.Windows.Forms.Padding(4);
            this.CandidateOne.Name = "CandidateOne";
            this.CandidateOne.Size = new System.Drawing.Size(127, 33);
            this.CandidateOne.TabIndex = 0;
            this.CandidateOne.TabStop = true;
            this.CandidateOne.Text = "Iron Man";
            this.CandidateOne.UseVisualStyleBackColor = true;
            this.CandidateOne.CheckedChanged += new System.EventHandler(this.CandidateOne_CheckedChanged);
            // 
            // candidateListBindingSource
            // 
            this.candidateListBindingSource.DataSource = typeof(wf_poll_cwe.CandidateList);
            this.candidateListBindingSource.CurrentChanged += new System.EventHandler(this.candidateListBindingSource_CurrentChanged);
            // 
            // CandidateTwo
            // 
            this.CandidateTwo.AutoSize = true;
            this.CandidateTwo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.candidateListBindingSource, "CandidateTwo", true));
            this.CandidateTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CandidateTwo.Location = new System.Drawing.Point(41, 130);
            this.CandidateTwo.Margin = new System.Windows.Forms.Padding(4);
            this.CandidateTwo.Name = "CandidateTwo";
            this.CandidateTwo.Size = new System.Drawing.Size(210, 33);
            this.CandidateTwo.TabIndex = 1;
            this.CandidateTwo.TabStop = true;
            this.CandidateTwo.Text = "Captain America";
            this.CandidateTwo.UseVisualStyleBackColor = true;
            this.CandidateTwo.CheckedChanged += new System.EventHandler(this.CandidateTwo_CheckedChanged);
            // 
            // SelectionBox
            // 
            this.SelectionBox.Controls.Add(this.butSubmit);
            this.SelectionBox.Controls.Add(this.LabelForQuestion);
            this.SelectionBox.Controls.Add(this.CandidateTwo);
            this.SelectionBox.Controls.Add(this.CandidateOne);
            this.SelectionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionBox.Location = new System.Drawing.Point(16, 15);
            this.SelectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.SelectionBox.Name = "SelectionBox";
            this.SelectionBox.Padding = new System.Windows.Forms.Padding(4);
            this.SelectionBox.Size = new System.Drawing.Size(501, 217);
            this.SelectionBox.TabIndex = 2;
            this.SelectionBox.TabStop = false;
            this.SelectionBox.Text = "Vote";
            this.SelectionBox.Enter += new System.EventHandler(this.SelectionBox_Enter);
            // 
            // butSubmit
            // 
            this.butSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSubmit.Location = new System.Drawing.Point(334, 94);
            this.butSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.butSubmit.Name = "butSubmit";
            this.butSubmit.Size = new System.Drawing.Size(120, 60);
            this.butSubmit.TabIndex = 3;
            this.butSubmit.Text = "Submit";
            this.butSubmit.UseVisualStyleBackColor = true;
            this.butSubmit.Click += new System.EventHandler(this.butSubmit_Click);
            // 
            // LabelForQuestion
            // 
            this.LabelForQuestion.AutoSize = true;
            this.LabelForQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelForQuestion.Location = new System.Drawing.Point(23, 27);
            this.LabelForQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelForQuestion.Name = "LabelForQuestion";
            this.LabelForQuestion.Size = new System.Drawing.Size(290, 25);
            this.LabelForQuestion.TabIndex = 2;
            this.LabelForQuestion.Text = "Who is your favorite Candidate?";
            // 
            // LabelForResults
            // 
            this.LabelForResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelForResults.Location = new System.Drawing.Point(44, 292);
            this.LabelForResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelForResults.Name = "LabelForResults";
            this.LabelForResults.Size = new System.Drawing.Size(426, 123);
            this.LabelForResults.TabIndex = 3;
            this.LabelForResults.Click += new System.EventHandler(this.LabelForResults_Click);
            // 
            // ChartForResults
            // 
            this.ChartForResults.BorderSkin.BorderColor = System.Drawing.Color.DimGray;
            this.ChartForResults.BorderSkin.BorderWidth = 5;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.Title = "Votes";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.ChartForResults.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.AutoFitMinFontSize = 12;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.ChartForResults.Legends.Add(legend1);
            this.ChartForResults.Location = new System.Drawing.Point(541, 42);
            this.ChartForResults.Name = "ChartForResults";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Iron Man";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Captain America";
            this.ChartForResults.Series.Add(series1);
            this.ChartForResults.Series.Add(series2);
            this.ChartForResults.Size = new System.Drawing.Size(482, 490);
            this.ChartForResults.TabIndex = 7;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Poll Results";
            this.ChartForResults.Titles.Add(title1);
            this.ChartForResults.Click += new System.EventHandler(this.ChartForResults_Click);
            // 
            // PollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 593);
            this.Controls.Add(this.ChartForResults);
            this.Controls.Add(this.LabelForResults);
            this.Controls.Add(this.SelectionBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PollForm";
            this.Text = "Polling System";
            this.Load += new System.EventHandler(this.PollForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.candidateListBindingSource)).EndInit();
            this.SelectionBox.ResumeLayout(false);
            this.SelectionBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartForResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton CandidateOne;
        private System.Windows.Forms.RadioButton CandidateTwo;
        private System.Windows.Forms.GroupBox SelectionBox;
        private System.Windows.Forms.Label LabelForQuestion;
        private System.Windows.Forms.Label LabelForResults;
        private System.Windows.Forms.Button butSubmit;
        private System.Windows.Forms.BindingSource candidateListBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartForResults;
    }
}

