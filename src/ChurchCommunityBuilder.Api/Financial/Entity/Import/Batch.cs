using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Financial.Entity.Import
{
    public class Batch
    {
        public Batch()
        {
            this.Transactions = new List<Transaction>();
        }

        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("campus")]
        public Lookup Campus { get; set; }

        [XmlElement("post_date")]
        public DateTime PostDate { get; set; }

        [XmlElement("begin_date")]
        public DateTime BeginDate { get; set; }

        [XmlElement("in_accounting_package")]
        public bool InAccountingPackage { get; set; }

        [XmlElement("status")]
        public string Status { get; set; }

        [XmlElement("source")]
        public string Source { get; set; }

        [XmlArrayItem("transaction", typeof(Transaction))]
        [XmlArray("transactions")]
        public List<Transaction> Transactions { get; set; }

        public string ToXml()
        {
            string ret = "";

            var xmlObject = new BatchApiWrapper(this);

            Type serializableObjectType = xmlObject.GetType();

            using (System.IO.StringWriter output = new System.IO.StringWriter(new StringBuilder()))
            {
                XmlSerializer s = new XmlSerializer(serializableObjectType);
                XmlSerializerNamespaces xsn = new XmlSerializerNamespaces();
                xsn.Add("", "");
                s.Serialize(output, xmlObject, xsn);
                ret = output.ToString().Replace("utf-16", "utf-8").Trim();
            }

            return ret;
        }
    }

    [XmlRoot("ccbapi")]
    public class BatchApiWrapper
    {
        public BatchApiWrapper()
        {
        }

        public BatchApiWrapper(Batch batch)
        {
            Batch = batch;
        }

        [XmlElement("batch")]
        public Batch Batch { get; set; }
    }
}
