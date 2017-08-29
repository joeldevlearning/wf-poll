using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace wf_poll_cwe
{
    public class XmlDataSource : IDataSource
    {
        private string XmlFile { get; }

        public XmlDataSource()
        {
            XmlFile = "polldata.xml";

            new XDocument(
                    new XElement("Poll",
                        new XElement("Vote", ""),
                        new XElement("Vote", "")
                    )
                )
                .Save(XmlFile);
        }

        //IDataSource method
        public void WriteVote(string vote)
        {
            XDocument xmlDoc = XDocument.Load(XmlFile);

            //WARNING: would return null if our xml file was not formatted as we expect
            xmlDoc.Element("Poll").Add(new XElement("Vote", vote));

            xmlDoc.Save(XmlFile);
        }

        //IDataSource method
        public IEnumerable<string> ReadAllVotes()
        {
            XDocument xmlDoc = XDocument.Load(XmlFile);

            var cOneVoteCount = GetResultsFor("", xmlDoc);
            var cTwoVoteCount = GetResultsFor("", xmlDoc);

            var votes = cTwoVoteCount.Concat(cOneVoteCount).ToList();
            return votes;
        }

        private IEnumerable<string> GetResultsFor(string candidate, XDocument xmlDoc)
        {
            //LINQ method syntax
            return xmlDoc.Descendants("Poll").Descendants("Vote")
                .Where(v => v.Value.Contains(candidate))
                .Select(v => v.Value)
                .ToList();

            /*
            LINQ query syntax
            return from v in xmlDoc.Descendants("Poll").Descendants("Vote")
                where v.Value.Contains(candidate)
                select v.Value;
            */
        }

    }
}