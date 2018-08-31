using System;
using ChurchCommunityBuilder.Api.Entity;
using ChurchCommunityBuilder.Api.Financial.Entity;
using ChurchCommunityBuilder.Api.Financial.Entity.Import;
using ChurchCommunityBuilder.Api.Financial.QueryObject;

namespace ChurchCommunityBuilder.Api.Financial.Sets {
    public class Batches : BaseApiSet<BatchCollection> {
        public Batches(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public IChurchCommunityBuilderResponse<BatchCollection> Create(Batch entity) {
            var batches = this.CreateWithXml("import_batches", entity.ToXml());
            return batches;
        }

        public IChurchCommunityBuilderResponse<BatchCollection> List(DateTime modifiedSince)
        {
            var qo = new BatchQO { ModifiedSince = modifiedSince };
            return this.Execute("batch_profiles", qo);
        }
    }
}
