using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.Financial.Entity.Import;

namespace ChurchCommunityBuilder.Api.Financial.Entity
{
    public class BatchCollection : Response
    {
        public BatchCollection()
        {
            this.Batches = new List<Batch>();
        }

        [XmlArrayItem("batch", typeof(Batch))]
        [XmlArray("batches")]
        public List<Batch> Batches { get; set; }
    }
}
