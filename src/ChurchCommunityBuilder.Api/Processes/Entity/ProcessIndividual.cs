using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Processes.Entity {
    public class ProcessIndividual {
        //<individual id="57">
        //    <name>Bob Ross</name>
        //    <manager id="0"></manager>
        //    <status id="3">Not-Started</status>
        //    <creator id="1">Larry Cucumber</creator>
        //    <modifier id="1">Larry Cucumber</modifier>
        //</individual>

        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("status")]
        public string Status { get; set; }
    }
}
