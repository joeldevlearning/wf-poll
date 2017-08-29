using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace wf_poll_cwe
{
    partial class PollForm
    {
        private void InitLabelForResults()
        {
            LabelForResults = new Label
            {
                Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Location = new Point(275, 200),
                Margin = new Padding(4, 0, 4, 0),
                Name = "LabelForResults",
                Size = new Size(220, 123),
                TabIndex = 3
            };
        }

        private void InitChart()
        {

            var chartArea = new ChartArea
            {
                AxisX =
                {
                    Enabled = AxisEnabled.False,
                    LineColor = Color.Transparent,
                    MajorGrid = {Enabled = false}
                },
                AxisY =
                {
                    Title = "Votes",
                    TitleFont = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold,
                        GraphicsUnit.Point, 0)
                },
            };

            Legend legend = new Legend()
                    { Name = "Legend", Docking = Docking.Bottom};

            ChartForResults = new Chart
            {
                Dock = DockStyle.Right,
                BackColor = Color.WhiteSmoke,
                Palette = ChartColorPalette.None,
                BorderSkin =
                    {
                    BorderColor = Color.DimGray,
                    BorderWidth = 5
                },
                Location = new Point(541, 42),
                Name = "ChartForResults",
                Size = new Size(650, 500),
                TabIndex = 7,
                Titles = { new Title("Poll Results", Docking.Top)}
            };
            ChartForResults.Titles[0].Font =
                new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);

            ((ISupportInitialize)ChartForResults).BeginInit();
            SuspendLayout();

            ChartForResults.ChartAreas.Add(chartArea);
            ChartForResults.Legends.Add(legend);

                Load += PollForm_Load;
                ((ISupportInitialize)ChartForResults).EndInit();
                ResumeLayout(false);

            var list = viewModel.GetCandidates();
            foreach (var candidate in list)
            {
                var series = new Series
                {
                    Name = candidate.Name,
                    IsVisibleInLegend = true,
                    ChartType = SeriesChartType.Column,
                    Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    Legend = "Legend",
                    IsValueShownAsLabel = true
            };
                ChartForResults.Series.Add(series);
            }
            Controls.Add(ChartForResults);
        }
    }
}
