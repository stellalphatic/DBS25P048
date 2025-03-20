using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itec.BL
{
    public class EventParticipant
    {
        public int RegistrationId { get; set; }
        public int EventId { get; set; }
        public int ParticipantId { get; set; }
        public int PaymentStatusId { get; set; }
        public decimal FeeAmount { get; set; }

        //Display fields
        public string EventName { get; set; }  //Ref
        public string ParticipantName { get; set; } //Ref
        public string PaymentStatus { get; set; } //Ref
    }
}
