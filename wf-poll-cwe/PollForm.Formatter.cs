using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_poll_cwe
{
    partial class PollForm
    {
        private string GenerateTextResults()
        {
            //grab results, ultimately from PollModel
            var results = viewModel.GetResults().ByCandidate();
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
