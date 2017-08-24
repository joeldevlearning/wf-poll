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
            this.CandidateOne = new System.Windows.Forms.RadioButton();
            this.CandidateTwo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelForResults = new System.Windows.Forms.Label();
            this.butResults = new System.Windows.Forms.Button();
            this.candidateListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
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
            this.CandidateTwo.Size = new System.Drawing.Size(17, 16);
            this.CandidateTwo.TabIndex = 1;
            this.CandidateTwo.TabStop = true;
            this.CandidateTwo.UseVisualStyleBackColor = true;
            this.CandidateTwo.CheckedChanged += new System.EventHandler(this.CA_CheckedChanged);
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.butSubmit);
            this.groupBox1.Controls.Add(this.label1);
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
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Who is your favorite Candidate?";
            //
            // LabelForResults
            //
            this.LabelForResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelForResults.Location = new System.Drawing.Point(44, 292);
            this.LabelForResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelForResults.Name = "LabelForResults";
            this.LabelForResults.Size = new System.Drawing.Size(426, 162);
            this.LabelForResults.TabIndex = 3;
            //
            // butResults
            //
            this.butResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butResults.Location = new System.Drawing.Point(130, 240);
            this.butResults.Margin = new System.Windows.Forms.Padding(4);
            this.butResults.Name = "butResults";
            this.butResults.Size = new System.Drawing.Size(235, 48);
            this.butResults.TabIndex = 6;
            this.butResults.Text = "Show Results";
            this.butResults.UseVisualStyleBackColor = true;
            this.butResults.Click += new System.EventHandler(this.butResults_Click);
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
            this.ClientSize = new System.Drawing.Size(530, 515);
            this.Controls.Add(this.butResults);
            this.Controls.Add(this.LabelForResults);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PollForm";
            this.Text = "Polling System";
            this.Load += new System.EventHandler(this.PollForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidateListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton CandidateOne;
        private System.Windows.Forms.RadioButton CandidateTwo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelForResults;
        private System.Windows.Forms.Button butResults;
        private System.Windows.Forms.Button butSubmit;
        private System.Windows.Forms.BindingSource candidateListBindingSource;
    }
}

