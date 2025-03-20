using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itec.Pages;
using MySql.Data.MySqlClient;
using Itec.BL;
using Itec.DB;
namespace Itec.DL
{
    public static class CommitteeDL
    {
        //Get All Committtees
        public static List<Committee> GetAllCommittees()
        {
            List<Committee> committees = new List<Committee>();
            string query = "SELECT c.committee_id,c.itec_id,ie.year,c.committee_name FROM committees c" +
                " LEFT JOIN itec_editions ie on ie.itec_id=c.itec_id";
            DataTable dt = DatabaseHelper.GetData(query);

            foreach (DataRow row in dt.Rows)
            {
                committees.Add(new Committee
                {
                    CommitteeId = Convert.ToInt32(row["committee_id"]),
                    ItecId = row["itec_id"] != DBNull.Value ? Convert.ToInt32(row["itec_id"]) : (int?)null,
                    Year = Convert.ToInt32(row["year"]),
                    CommitteeName = row["committee_name"].ToString()
                });
            }
            return committees;
        }

        //Adding committee
        public static void AddCommittee(Committee newCommittee)
        {
            string query = $@"INSERT INTO committees 
                         (itec_id, committee_name) 
                         VALUES ({newCommittee.ItecId}, '{newCommittee.CommitteeName}')";
            DatabaseHelper.ExecuteQuery(query);
        }

        //Update committee
        public static void UpdateCommittee(Committee updatedCommittee)
        {
            string query = $@"UPDATE committees 
                         SET itec_id = {updatedCommittee.ItecId}, 
                             committee_name = '{updatedCommittee.CommitteeName}'
                         WHERE committee_id = {updatedCommittee.CommitteeId}";
            DatabaseHelper.ExecuteQuery(query);
        }

        //Delete committee
        public static void DeleteCommittee(int committeeId)
        {
            string query = $"DELETE FROM committees WHERE committee_id = {committeeId}";
            DatabaseHelper.ExecuteQuery(query);
        }
    }
    public static class CommitteeMemberDL
    {
        public static List<CommitteeMember> GetAllCommitteeMembers()
        {
            List<CommitteeMember> members = new List<CommitteeMember>();
            string query = @"
            SELECT cm.member_id, cm.committee_id, cm.name, cm.role_id,c.committee_name, l.value AS role_name
            FROM committee_members cm
            LEFT JOIN committees c on cm.committee_id = c.committee_id
            LEFT JOIN lookup l on cm.role_id = l.lookup_id";

            DataTable dt = DatabaseHelper.GetData(query);

            foreach (DataRow row in dt.Rows)
            {
                members.Add(new CommitteeMember
                {
                    MemberId = row["member_id"] == DBNull.Value ? 0 : Convert.ToInt32(row["member_id"]),
                    CommitteeId = row["committee_id"] == DBNull.Value ? 0 : Convert.ToInt32(row["committee_id"]),
                    Name = row["name"].ToString(),
                    RoleId = row["role_id"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["role_id"]),
                    CommitteeName = row["committee_name"].ToString(),
                    RoleName = row["role_name"].ToString()
                });
            }
            return members;
        }

        public static void AddCommitteeMember(CommitteeMember member)
        {
            string query = $@"
            INSERT INTO committee_members (committee_id, name, role_id)
            VALUES ({member.CommitteeId}, '{member.Name}', 
                    {(member.RoleId.HasValue ? member.RoleId.ToString() : "NULL")})";

            DatabaseHelper.ExecuteQuery(query);
        }

        public static void UpdateCommitteeMember(CommitteeMember member)
        {
            string query = $@"
            UPDATE committee_members 
            SET committee_id = {member.CommitteeId},
                name = '{member.Name}',
                role_id = {(member.RoleId.HasValue ? member.RoleId.ToString() : "NULL")}
            WHERE member_id = {member.MemberId}";

            DatabaseHelper.ExecuteQuery(query);
        }

        public static void DeleteCommitteeMember(int memberId)
        {
            string query = $"DELETE FROM committee_members WHERE member_id = {memberId}";
            DatabaseHelper.ExecuteQuery(query);
        }
    }
}
