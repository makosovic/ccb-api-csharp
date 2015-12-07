using System;
using System.Collections.Generic;
using ChurchCommunityBuilder.Api.Events.Entity;
using ChurchCommunityBuilder.Api.Extensions;

namespace ChurchCommunityBuilder.Api.Events.Sets {
    public class Events : BaseApiSet<EventAttendance> {
        public Events(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public IndividualEvent AddIndividualToEvent(int individualID, int eventID) {
            var parameters = new Dictionary<string, string>();
            parameters.Add("id", individualID.ToString());
            parameters.Add("event_id", eventID.ToString());
            parameters.Add("status", "add");
            return this.Execute<IndividualEvent>("add_individual_to_event", parameters);
        }

        public EventAttendance CreateAttendance(List<int> individualIDs, int eventID, DateTime occurence) {

            var eventAttendanceCollection = new EventAttendanceCollection();

            var eventAttendance = new EventAttendance {
                ID = eventID,
                Occurrence = occurence,
                HeadCount = individualIDs.Count
            };

            foreach (var individualID in individualIDs) {
                eventAttendance.Attendees.Add(new Attendee {
                    ID = individualID
                });
            }

            eventAttendanceCollection.EventAttendances.Add(eventAttendance);

            return this.Create("create_event_attendance", "format=xml", eventAttendanceCollection.ToXml());            
        }
    }
}
