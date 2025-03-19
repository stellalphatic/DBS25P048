using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itec.DB;
using Itec.BL;

namespace Itec.DL
{
 
        public static class EditionDL
        {
            // Get all ITEC editions with additional details
            public static List<Edition> GetAllEditions()
            {
                List<Edition> editions = new List<Edition>();
                string query = @"
            SELECT ie.itec_id, ie.year, ie.theme, ie.description,COUNT(distinct ievent.event_id) AS event_count, COUNT(distinct p.participant_id) AS participant_count
            FROM itec_editions ie
            LEFT JOIN itec_events ievent on ie.itec_id = ievent.itec_id
            LEFT JOIN participants p on ie.itec_id = p.itec_id
            GROUP BY ie.itec_id, ie.year, ie.theme, ie.description";

                DataTable dt = DatabaseHelper.GetData(query);

                foreach (DataRow row in dt.Rows)
                {
                    editions.Add(new Edition
                    {
                        Year = Convert.ToInt32(row["year"]),
                        Theme = row["theme"].ToString(),
                        Description = row["description"].ToString(),
                        EventCount = Convert.ToInt32(row["event_count"]),
                        ParticipantCount = Convert.ToInt32(row["participant_count"])
                    });
                }
                return editions;
            }

            //Add edition
            public static void AddEdition(Edition newEdition)
            {
                string query = $@"INSERT INTO itec_editions(year, theme, description) 
                         VALUES({newEdition.Year}, '{newEdition.Theme}', '{newEdition.Description}')";
                DatabaseHelper.ExecuteQuery(query);
            }

            //Update edition
            public static void UpdateEdition(Edition updatedEdition)
            {
                string query = $@"UPDATE itec_editions 
                         SET year = {updatedEdition.Year}, theme = '{updatedEdition.Theme}',description = '{updatedEdition.Description}'
                         WHERE itec_id = {updatedEdition.ItecId}";
                DatabaseHelper.ExecuteQuery(query);
            }

            //Delete edition
            public static void DeleteEdition(int itecId)
            {
                string query = $"DELETE FROM itec_editions WHERE itec_id = {itecId}";
                DatabaseHelper.ExecuteQuery(query);
            }
        }
    
}
