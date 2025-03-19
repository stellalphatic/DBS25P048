using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itec.BL
{
    public class Event
    {
        public int EventId;
        public string EventName;
        public int? EventCategoryId;
        public string Description;
        public DateTime? EventDate;
        public int? VenueId;
        public int? CommitteeId;
    }
}
