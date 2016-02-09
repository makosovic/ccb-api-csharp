using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Financial.Entity.Import;

namespace ChurchCommunityBuilder.Api.Financial.Sets {
    public class Batches : BaseApiSet<Batch> {
        public Batches(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public Batch Create(Batch entity) {
            return this.CreateWithXml("import_batches", entity.ToXml());
        }
    }
}
