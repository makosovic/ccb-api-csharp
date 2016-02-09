using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Financial.Entity.Import {
    [XmlRoot("batch")]
    public class Batch {
        public Batch() {
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

        public string ToXml() {
            string ret = "";

            Type serializableObjectType = this.GetType();

            using (System.IO.StringWriter output = new System.IO.StringWriter(new System.Text.StringBuilder())) {
                System.Xml.Serialization.XmlSerializer s = new System.Xml.Serialization.XmlSerializer(serializableObjectType);
                System.Xml.Serialization.XmlSerializerNamespaces xsn = new System.Xml.Serialization.XmlSerializerNamespaces();
                xsn.Add("", "");


                // get a list of the xml type attributes so that we can clean up the xml. In other words. remove extra namespace text.
                object[] attributes = serializableObjectType.GetCustomAttributes(typeof(System.Xml.Serialization.XmlTypeAttribute), false);
                if (attributes != null) {
                    System.Xml.Serialization.XmlTypeAttribute xta;
                    for (int i = 0; i < attributes.Length; i++) {
                        xta = (System.Xml.Serialization.XmlTypeAttribute)attributes[i];
                        //xsn.Add("ns" + 1, xta.Namespace);
                    }
                }

                s.Serialize(output, this, xsn);
                ret = output.ToString().Replace("utf-16", "utf-8").Trim();
            }

            return ret;
        }
    }
}
