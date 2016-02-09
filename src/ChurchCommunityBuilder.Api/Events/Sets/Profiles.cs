using System.Collections.Generic;
using ChurchCommunityBuilder.Api.Events.Entity;
using ChurchCommunityBuilder.Api.Events.QueryObject;

namespace ChurchCommunityBuilder.Api.Events.Sets {
    public class Profiles : BaseApiSet<EventCollection> {
        public Profiles(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public EventCollection List(ProfileQO qo) {
            return this.Execute("event_profiles", qo);
        }

        public Event Get(int id, bool includeGuests = false) {
            var parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            parameters.Add("include_guest_list", includeGuests.ToString());
            return this.Execute<Event>("event_profile", parameters);
        }
    }
}
