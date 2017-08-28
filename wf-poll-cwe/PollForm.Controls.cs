using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_poll_cwe
{
    partial class PollForm
    {
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
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    Location = new System.Drawing.Point(horizontal, vertical),
                    Margin = new System.Windows.Forms.Padding(4),
                    Tag = c //attach Candidate object

            };
                rButton.CheckedChanged += this.AllCheckBoxes_CheckedChanged;
                vertical += 50;
                this.Controls.Add(rButton);
            }
        }
    }
}
