using System;
using ChurchCommunityBuilder.Api.Financial.Entity;
using ChurchCommunityBuilder.Api.Financial.Entity.Import;
using ChurchCommunityBuilder.Api.Financial.QueryObject;

namespace ChurchCommunityBuilder.Api.Financial.Sets {
    public class Batches : BaseApiSet<BatchCollection> {
        public Batches(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public Batch Create(Batch entity) {
            var batches = this.CreateWithXml("import_batches", entity.ToXml());

            if (batches != null && batches.Batches.Count > 0)
            {
                return batches.Batches[0];
            }

            return null;
        }

        public BatchCollection List(DateTime modifiedSince)
        {
            var qo = new BatchQO { ModifiedSince = modifiedSince };
            return this.Execute("batch_profiles", qo);
        }
    }
}
