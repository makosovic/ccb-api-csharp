using System.Collections.Generic;
using ChurchCommunityBuilder.Api.Events.Entity;
using ChurchCommunityBuilder.Api.Events.QueryObject;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.Events.Sets {
    public class Forms : BaseApiSet<FormCollection> {
        public Forms(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public IChurchCommunityBuilderResponse<Form> Get(int id, bool includeGuests = false) {
            var parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());

            return this.Execute<Form>("form_detail", parameters);
        }
    }
}
