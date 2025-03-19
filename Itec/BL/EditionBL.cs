using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itec.BL
{
        public class Edition
        {
            public int ItecId { get; set; } 
            public int Year { get; set; }
            public string Theme { get; set; }
            public string Description { get; set; }
            public int EventCount { get; set; }
            public int ParticipantCount { get; set; } 
        }
    
}
