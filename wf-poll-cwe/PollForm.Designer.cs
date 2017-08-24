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
            this.CandidateTwo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butSubmit = new System.Windows.Forms.Button();
            this.LabelForQuestion = new System.Windows.Forms.Label();
            this.LabelForResults = new System.Windows.Forms.Label();
            this.butResults = new System.Windows.Forms.Button();
            this.ChartForResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.candidateListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartForResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateListBindingSource)).BeginInit();
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
            this.CandidateOne.CheckedChanged += new System.EventHandler(this.IM_CheckedChanged);
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
            this.CandidateTwo.CheckedChanged += new System.EventHandler(this.CA_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butSubmit);
            this.groupBox1.Controls.Add(this.LabelForQuestion);
            this.groupBox1.Controls.Add(this.CandidateTwo);
            this.groupBox1.Controls.Add(this.CandidateOne);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(501, 217);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vote";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // butResults
            // 
            this.butResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butResults.Location = new System.Drawing.Point(133, 206);
            this.butResults.Margin = new System.Windows.Forms.Padding(4);
            this.butResults.Name = "butResults";
            this.butResults.Size = new System.Drawing.Size(235, 48);
            this.butResults.TabIndex = 6;
            this.butResults.Text = "Show Results";
            this.butResults.UseVisualStyleBackColor = true;
            this.butResults.Click += new System.EventHandler(this.butResults_Click);
            // 
            // ChartForResults
            // 
            this.ChartForResults.BorderSkin.BorderColor = System.Drawing.Color.DimGray;
            this.ChartForResults.BorderSkin.BorderWidth = 5;
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
            series1.Name = "CandidateOne";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "CandidateTwo";
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
            // candidateListBindingSource
            // 
            this.candidateListBindingSource.DataSource = typeof(wf_poll_cwe.CandidateList);
            this.candidateListBindingSource.CurrentChanged += new System.EventHandler(this.candidateListBindingSource_CurrentChanged);
            // 
            // PollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 593);
            this.Controls.Add(this.ChartForResults);
            this.Controls.Add(this.butResults);
            this.Controls.Add(this.LabelForResults);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PollForm";
            this.Text = "Polling System";
            this.Load += new System.EventHandler(this.PollForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartForResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton CandidateOne;
        private System.Windows.Forms.RadioButton CandidateTwo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelForQuestion;
        private System.Windows.Forms.Label LabelForResults;
        private System.Windows.Forms.Button butResults;
        private System.Windows.Forms.Button butSubmit;
        private System.Windows.Forms.BindingSource candidateListBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartForResults;
    }
}

