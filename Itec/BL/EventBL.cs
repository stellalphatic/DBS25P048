using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itec.BL
{
    public class Event
    {
        public int EventId { get; set; } 
        public int ItecId { get; set; }  //Foreign
        public string ItecYear { get; set; } 
        public string EventName { get; set; }
        public int EventCategoryId { get; set; }  //Foreign
        public string? EventCategoryName { get; set; }
        public string? Description { get; set; }
        public DateTime EventDate { get; set; }
        public int VenueId { get; set; } //Foreign
        public string? VenueName { get; set; }
        public int CommitteeId { get; set; } //Foreign
        public string? CommitteeName { get; set; }
      
         
    }
}
