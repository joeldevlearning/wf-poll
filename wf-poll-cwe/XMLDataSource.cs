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
            this.List = list;
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

            var imVoteCount = GetResultsFor(List.CandidateOne, xmlDoc);

            var caVoteCount = from v in xmlDoc.Descendants("Poll").Descendants("Vote")
                where v.Value.Contains(List.CandidateTwo)
                select v.Value;

            var votes = caVoteCount.Concat(imVoteCount).ToList();
            return votes;
        }

        /*
        public void submitVote(string theVote)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(_XmlFile);

                xmlDoc.Element("Poll").Add(new XElement("Vote", theVote));

                xmlDoc.Save("Poll.xml");
                //lblResults.Text = "Thank you for your vote.";
                readXML();
            }
            catch
            {
                lblResults.Text = "Sorry, unable to process request. Please try again.";
            }
        }
        */

        private List<string> GetResultsFor(string candidate, XDocument xmlDoc)
        {
            //method syntax
            return xmlDoc.Descendants("Poll").Descendants("Vote")
                .Where(v => v.Value.Contains(candidate))
                .Select(v => v.Value)
                .ToList();

            /*
            query syntax
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