using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itec.BL
{
    public class EventResult
    {
        public int ResultId { get; set; }
        public int EventId { get; set; }
        public int? ParticipantId { get; set; }
        public int? TeamId { get; set; }
        public int Position { get; set; }
        public decimal Score { get; set; }
        public string Remarks { get; set; }

        // Display fields
        public string EventName { get; set; }   //Ref
        public string ParticipantName { get; set; } //Ref
        public string TeamName { get; set; }   //Ref
    }
}
