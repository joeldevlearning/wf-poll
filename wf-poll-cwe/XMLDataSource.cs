using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace wf_poll_cwe
{
    public class XmlDataSource : IDataSource
    {
        private string XmlFile { get; }
        private CandidateList List { get; }

        public XmlDataSource(CandidateList list)
        {
            List = list;
            const string filename = "polldata.xml";

            new XDocument(
                    new XElement("Poll",
                        new XElement("Vote", list.CandidateOne),
                        new XElement("Vote", list.CandidateTwo)
                    )
                )
                .Save(filename);

            XmlFile = filename;
        }

        //IDataSource method
        public void WriteVote(string vote)
        {
            XDocument xmlDoc = XDocument.Load(XmlFile);

            xmlDoc.Element("Poll").Add(new XElement("Vote", vote));

            xmlDoc.Save(XmlFile);
        }

        //IDataSource method
        public List<string> ReadAllVotes()
        {
            XDocument xmlDoc = XDocument.Load(XmlFile);

            var cOneVoteCount = GetResultsFor(List.CandidateOne, xmlDoc);
            var cTwoVoteCount = GetResultsFor(List.CandidateTwo, xmlDoc);

            var votes = cTwoVoteCount.Concat(cOneVoteCount).ToList();
            return votes;
        }

        private List<string> GetResultsFor(string candidate, XDocument xmlDoc)
        {
            //method syntax
            return xmlDoc.Descendants("Poll").Descendants("Vote")
                .Where(v => v.Value.Contains(candidate))
                .Select(v => v.Value)
                .ToList();

            /*
            Like the query syntax? Here...
            var IM_vote_count = from v in xmlDoc.Descendants("Poll").Descendants("Vote")
                where v.Value.Contains(candidate)
                select v.Value;
            */
        }

    }

    public interface IDataSource
    {
        void WriteVote(string vote);

        List<string> ReadAllVotes();
    }
}