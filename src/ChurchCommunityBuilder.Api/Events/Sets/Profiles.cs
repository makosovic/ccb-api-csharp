using System.Collections.Generic;
using ChurchCommunityBuilder.Api.Entity;
using ChurchCommunityBuilder.Api.Events.Entity;
using ChurchCommunityBuilder.Api.Events.QueryObject;

namespace ChurchCommunityBuilder.Api.Events.Sets {
    public class Profiles : BaseApiSet<EventCollection> {
        public Profiles(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public IChurchCommunityBuilderResponse<EventCollection> List(ProfileQO qo) {
            return this.Execute("event_profiles", qo);
        }

        public IChurchCommunityBuilderResponse<Event> Get(int id, bool includeGuests = false) {
            var parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            parameters.Add("include_guest_list", includeGuests.ToString());
            return this.Execute<Event>("event_profile", parameters);
        }

        public IChurchCommunityBuilderResponse<Event> AddPersonToEvent(string individualID, string eventID, string status = "add") {
            var paramters = new Dictionary<string, string>();
            paramters.Add("id", individualID);
            paramters.Add("event_id", eventID);
            paramters.Add("status", status);

            return this.Execute<Event>("add_individual_to_event", paramters);
        }

        public IChurchCommunityBuilderResponse<Event> Create(Event entity) {
            return base.Create<Event>("create_event", entity.GetFormValues());
        }
    }
}
