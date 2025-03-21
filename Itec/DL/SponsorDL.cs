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
    public static class SponsorDL
    {
        //Get all sponsors
        public static List<Sponsor> GetAllSponsors()
        {
            List<Sponsor> sponsors = new List<Sponsor>();
            string query = @"
        SELECT 
            s.sponsor_id, s.sponsor_name, s.contact,
            COALESCE(SUM(f.amount), 0) AS total_amount
        FROM sponsors s
        LEFT JOIN finances f ON s.sponsor_id = f.from_entity_id AND f.from_entity_type = 'Sponsor'
        GROUP BY s.sponsor_id, s.sponsor_name, s.contact";

            DataTable dt = DatabaseHelper.GetData(query);

            foreach (DataRow row in dt.Rows)
            {
                sponsors.Add(new Sponsor
                {
                    SponsorId = row["sponsor_id"] == DBNull.Value ? 0 : Convert.ToInt32(row["sponsor_id"]),
                    SponsorName = row["sponsor_name"] == DBNull.Value ? string.Empty : row["sponsor_name"].ToString(),
                    Contact = row["contact"] == DBNull.Value ? string.Empty : row["contact"].ToString(),
                    TotalAmount = row["total_amount"] == DBNull.Value ? 0 : Convert.ToDecimal(row["total_amount"])
                });
            }
            return sponsors;
        }

        //Add sponsor
        public static void AddSponsor(Sponsor newSponsor)
        {
            string query = $@"
        INSERT INTO sponsors (sponsor_name, contact)
        VALUES ('{newSponsor.SponsorName}', '{newSponsor.Contact}')";
            DatabaseHelper.ExecuteQuery(query);
        }

        //Update sponsor
        public static void UpdateSponsor(Sponsor updatedSponsor)
        {
            string query = $@"
        UPDATE sponsors 
        SET sponsor_name = '{updatedSponsor.SponsorName}', 
            contact = '{updatedSponsor.Contact}'
        WHERE sponsor_id = {updatedSponsor.SponsorId}";
            DatabaseHelper.ExecuteQuery(query);
        }

        //Delete sponsor
        public static void DeleteSponsor(int sponsorId)
        {
            string query = $"DELETE FROM sponsors WHERE sponsor_id = {sponsorId}";
            DatabaseHelper.ExecuteQuery(query);
        }
    }
}
