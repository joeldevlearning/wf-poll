using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using GroupBox = System.Windows.Forms.GroupBox;
using Label = System.Windows.Forms.Label;
using RadioButton = System.Windows.Forms.RadioButton;

namespace wf_poll_cwe
{
    partial class PollForm
    {

        private void InitPollForm()
        {
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 600);
            Margin = new Padding(4);
            Name = "PollForm";
            Text = "Polling System";


            Load += PollForm_Load;
        }

        private void InitSelectionBox()
        {
            SelectionBox = new GroupBox
            {
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Location = new Point(16, 15),
                Margin = new Padding(4),
                Name = "SelectionBox",
                Padding = new Padding(4),
                Size = new Size(500, 500),
                TabIndex = 2,
                TabStop = false,
                Text = "Vote"
            };
        }

        private void InitLabelForQuestion()
        {
            LabelForQuestion = new Label
            {
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(23, 27),
                Margin = new Padding(4, 0, 4, 0),
                Name = "LabelForQuestion",
                Size = new Size(290, 25),
                TabIndex = 2,
                Text = "Who is your favorite Candidate?"
            };
        }

        private void InitCandidateRadioButtons()
        {
            const int horizontal = 50;
            int vertical = 90;
            foreach (var c in viewModel.GetCandidates())
            {
                var rButton = new RadioButton
                {
                    AutoSize = true,
                    Text = c.Name,
                    Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                    Location = new Point(horizontal, vertical),
                    Margin = new Padding(4),
                    Tag = c //attach Candidate object

            };
                vertical += 50;
                Controls.Add(rButton);
            }
        }

        private void InitSubmitButton()
        {
            SubmitButton = new Button
            {
                Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Location = new Point(334, 94),
                Margin = new Padding(4),
                Name = "SubmitButton",
                Size = new Size(120, 60),
                TabIndex = 3,
                Text = "Submit",
                UseVisualStyleBackColor = true
            };
            SubmitButton.Click += SubmitButton_Click;
        }

    }
}
