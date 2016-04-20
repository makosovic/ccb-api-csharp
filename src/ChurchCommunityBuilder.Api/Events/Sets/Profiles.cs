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

        public Event AddPersonToEvent(string individualID, string eventID, string status = "add") {
            var paramters = new Dictionary<string, string>();
            paramters.Add("id", individualID);
            paramters.Add("event_id", eventID);
            paramters.Add("status", status);

            return this.Execute<Event>("add_individual_to_event", paramters);
        }

        public Event Create(Event entity) {
            var events = base.Create("create_event", entity.GetFormValues());

            if (events != null && events.Events.Count > 0) {
                return events.Events[0];
            }

            return null;
        }
    }
}
