using System;
using System.Text;

namespace wf_poll_cwe
{
    partial class PollForm
    {
        private string GenerateTextResults()
        {
            var results = viewModel.GetResults().ForAll();
            var totalVotes = viewModel.GetResults().TotalVotes();

            StringBuilder builder = new StringBuilder();

            string firstPart = "Total Votes: " + totalVotes + "\n\n";
            string lastPart = "\n";

            builder.Append(firstPart);
            foreach (var candidate in results)
            {
                var (part, percent) = candidate.Value;

                builder.Append(candidate.Key.Name + ": " +
                               part + " votes (" +
                               percent + "%)\n");
            }
            builder.Append(lastPart);
            return builder.ToString();
        }

    }
}
