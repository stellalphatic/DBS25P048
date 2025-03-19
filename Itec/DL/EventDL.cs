using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itec.DB;
using Itec.BL;
namespace Itec.DL
{
    public static class EventDL
    {
        // Get all events
        public static List<Event> GetAllEvents()
        {
            List<Event> events = new List<Event>();
            string query = "SELECT * FROM itec_events";
            DataTable dt = DatabaseHelper.GetData(query);

            foreach (DataRow row in dt.Rows)
            {
                events.Add(new Event
                {
                    EventId = Convert.ToInt32(row["event_id"]),
                    EventName = row["event_name"].ToString(),
                    EventCategoryId = row["event_category_id"] != DBNull.Value ? Convert.ToInt32(row["event_category_id"]) : (int?)null,
                    Description = row["description"].ToString(),
                    EventDate = row["event_date"] != DBNull.Value ? Convert.ToDateTime(row["event_date"]) : (DateTime?)null,
                    VenueId = row["venue_id"] != DBNull.Value ? Convert.ToInt32(row["venue_id"]) : (int?)null,
                    CommitteeId = row["committee_id"] != DBNull.Value ? Convert.ToInt32(row["committee_id"]) : (int?)null
                });
            }
            return events;
        }

        //Add event
        public static void AddEvent(Event newEvent)
        {
            string query = $@"INSERT INTO itec_events(event_name, event_category_id, description, event_date, venue_id, committee_id) 
                              VALUES ('{newEvent.EventName}', {newEvent.EventCategoryId}, '{newEvent.Description}', 
                              '{newEvent.EventDate:yyyy-MM-dd}', {newEvent.VenueId}, {newEvent.CommitteeId})";
            DatabaseHelper.ExecuteQuery(query);
        }

        //Update event
        public static void UpdateEvent(Event updatedEvent)
        {
            string query = $@"UPDATE itec_events 
                             SET event_name = '{updatedEvent.EventName}', 
                             event_category_id = {updatedEvent.EventCategoryId}, 
                             description = '{updatedEvent.Description}', 
                             event_date = '{updatedEvent.EventDate:yyyy-MM-dd}', 
                             venue_id = {updatedEvent.VenueId}, 
                             committee_id = {updatedEvent.CommitteeId}
                             WHERE event_id = {updatedEvent.EventId}";
            DatabaseHelper.ExecuteQuery(query);
        }

        //Delete event
        public static void DeleteEvent(int eventId)
        {
            string query = $"DELETE FROM itec_events WHERE event_id = {eventId}";
            DatabaseHelper.ExecuteQuery(query);
        }
    }
}
