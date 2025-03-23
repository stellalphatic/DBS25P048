using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itec.BL
{
    public class Venue
    {
        public int VenueId;
        public string VenueName;
        public int Capacity;
        public string Location;
    }
    public class VenueAllocation
    {
        public int VenueAllocationId;
        public int EventId;
        public int VenueId;
        public string EventName; //Ref
        public string VenueName; //Ref
        public DateTime AssignedDate;
        public TimeSpan AssignedTime;
    }
}
