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
        //Get All Committtee
        public static List<Committee> GetAllCommittees()
        {
            List<Committee> committees = new List<Committee>();
            string query = "SELECT * FROM committees";
            DataTable dt = DatabaseHelper.GetData(query);

            foreach (DataRow row in dt.Rows)
            {
                committees.Add(new Committee
                {
                    CommitteeId = Convert.ToInt32(row["committee_id"]),
                    ItecId = row["itec_id"] != DBNull.Value ? Convert.ToInt32(row["itec_id"]) : (int?)null,
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
}
