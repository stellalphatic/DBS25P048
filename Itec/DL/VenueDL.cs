using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itec.BL;
using Itec.DB;

namespace Itec.DL
{
    public static class VenueDL
    {
        //Get all venues
        public static List<Venue> GetAllVenues()
        {
            List<Venue> venues = new List<Venue>();
            string query = "SELECT * FROM venues";
            DataTable dt = DatabaseHelper.GetData(query);

            foreach (DataRow row in dt.Rows)
            {
                venues.Add(new Venue
                {
                    VenueId = Convert.ToInt32(row["venue_id"]),
                    VenueName = row["venue_name"].ToString(),
                    Capacity = Convert.ToInt32(row["capacity"]),
                    Location = row["location"].ToString()
                });
            }
            return venues;
        }

        //Add venue
        public static void AddVenue(Venue venue)
        {
            string query = $@"INSERT INTO venues(venue_name, capacity, location) 
                         VALUES ('{venue.VenueName}', {venue.Capacity}, '{venue.Location}')";
            DatabaseHelper.ExecuteQuery(query);
        }

        //Update venue
        public static void UpdateVenue(Venue venue)
        {
            string query = $@"UPDATE venues 
                             SET venue_name = '{venue.VenueName}', 
                             capacity = {venue.Capacity}, 
                             location = '{venue.Location}'
                             WHERE venue_id = {venue.VenueId}";
            DatabaseHelper.ExecuteQuery(query);
        }

        //Delete venue
        public static void DeleteVenue(int venueId)
        {
            string query = $"DELETE FROM venues WHERE venue_id = {venueId}";
            DatabaseHelper.ExecuteQuery(query);
        }
    }


    public static class VenueAllocationDL
    {
        //Get all venue allocations
        public static List<VenueAllocation> GetAllVenueAllocations()
        {
            List<VenueAllocation> allocations = new List<VenueAllocation>();
            string query = "SELECT * FROM venue_allocations";
            DataTable dt = DatabaseHelper.GetData(query);

            foreach (DataRow row in dt.Rows)
            {
                allocations.Add(new VenueAllocation
                {
                    VenueAllocationId = Convert.ToInt32(row["venue_allocation_id"]),
                    EventId = Convert.ToInt32(row["event_id"]),
                    VenueId = Convert.ToInt32(row["venue_id"]),
                    AssignedDate = Convert.ToDateTime(row["assigned_date"]),
                    AssignedTime = TimeSpan.Parse(row["assigned_time"].ToString())
                });
            }
            return allocations;
        }

        //Add venue allocation
        public static void AddVenueAllocation(VenueAllocation allocation)
        {
            string query = $@"INSERT INTO venue_allocations(event_id, venue_id, assigned_date, assigned_time) 
                         VALUES ({allocation.EventId}, {allocation.VenueId}, 
                                 '{allocation.AssignedDate:yyyy-MM-dd}', 
                                 '{allocation.AssignedTime:hh\\:mm\\:ss}')";
            DatabaseHelper.ExecuteQuery(query);
        }

        //Update venue allocation
        public static void UpdateVenueAllocation(VenueAllocation allocation)
        {
            string query = $@"UPDATE venue_allocations 
                             SET event_id = {allocation.EventId}, 
                             venue_id = {allocation.VenueId}, 
                             assigned_date = '{allocation.AssignedDate:yyyy-MM-dd}', 
                             assigned_time = '{allocation.AssignedTime:hh\\:mm\\:ss}'
                             WHERE venue_allocation_id = {allocation.VenueAllocationId}";
            DatabaseHelper.ExecuteQuery(query);
        }

        //Delete venue allocation
        public static void DeleteVenueAllocation(int allocationId)
        {
            string query = $"DELETE FROM venue_allocations WHERE venue_allocation_id = {allocationId}";
            DatabaseHelper.ExecuteQuery(query);
        }
    }
}
