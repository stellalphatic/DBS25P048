using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itec.DL;

namespace Itec.BL
{
    public class Committee
    {
        public int CommitteeId;
        public int? ItecId;
        public int Year; //ref
        public string CommitteeName;
    }
    public class CommitteeMember
    {
        public int MemberId { get; set; }
        public int CommitteeId { get; set; } //Foreign
        public string Name { get; set; }
        public int? RoleId { get; set; } //Foreign
        public string CommitteeName { get; set; } //Reference
        public string RoleName { get; set; } //Reference
    }
}
