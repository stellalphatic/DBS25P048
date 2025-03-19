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
    public static class ParticipantsDL
    {
        //Get all participants 
        public static List<Participant> GetAllParticipants()
        {
            List<Participant> participants = new List<Participant>();
            string query = "SELECT * FROM participants";
            DataTable dt = DatabaseHelper.GetData(query);

            foreach (DataRow row in dt.Rows)
            {
                participants.Add(new Participant
                {
                    ParticipantId = Convert.ToInt32(row["participant_id"]),
                    Name = row["name"].ToString(),
                    ItecId = Convert.ToInt32(row["itec_id"]),
                    Email = row["email"].ToString(),
                    Contact = row["contact"].ToString(),
                    Institute = row["institute"].ToString(),
                    RoleId = Convert.ToInt32(row["role_id"])
                });
            }
            return participants;
        }

        //Add participant
        public static void AddParticipant(Participant participant)
        {
            string query = $@"INSERT INTO participants 
                     (itec_id, name, email, contact, institute, role_id) 
                     VALUES ({participant.ItecId}, '{participant.Name}', 
                             '{participant.Email}', '{participant.Contact}', 
                             '{participant.Institute}', {participant.RoleId})";
            DatabaseHelper.ExecuteQuery(query);
        }

        //Update participant
        public static void UpdateParticipant(Participant participant)
        {
            string query = $@"UPDATE participants 
                         SET itec_id = {participant.ItecId},
                         name = '{participant.Name}', 
                         email = '{participant.Email}',
                         contact = '{participant.Contact}',
                         institute = '{participant.Institute}',
                         role_id = {participant.RoleId}
                         WHERE participant_id = {participant.ParticipantId}";
            DatabaseHelper.ExecuteQuery(query);
        }

        //Delete participant
        public static void DeleteParticipant(int participantId)
        {
            string query = $"DELETE FROM participants WHERE participant_id = {participantId}";
            DatabaseHelper.ExecuteQuery(query);
        }
    }
}
