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
    public static class EventParticipantDL
    {
        public static List<EventParticipant> GetAllParticipants()
        {
            List<EventParticipant> participants = new List<EventParticipant>();
            string query = @"
            SELECT ep.registration_id, ep.event_id, ep.participant_id,ep.payment_status_id, ep.fee_amount,e.event_name, p.name AS participant_name, l.value AS payment_status
            FROM event_participants ep
            LEFT JOIN itec_events e ON ep.event_id = e.event_id
            LEFT JOIN participants p ON ep.participant_id = p.participant_id
            LEFT JOIN lookup l ON ep.payment_status_id = l.lookup_id";

            DataTable dt = DatabaseHelper.GetData(query);

            foreach (DataRow row in dt.Rows)
            {
                participants.Add(new EventParticipant
                {
                    RegistrationId = Convert.ToInt32(row["registration_id"]),
                    EventId = Convert.ToInt32(row["event_id"]),
                    ParticipantId = Convert.ToInt32(row["participant_id"]),
                    PaymentStatusId = Convert.ToInt32(row["payment_status_id"]),
                    FeeAmount = Convert.ToDecimal(row["fee_amount"]),
                    EventName = row["event_name"] == DBNull.Value ? "" : row["event_name"].ToString(),
                    ParticipantName = row["participant_name"] == DBNull.Value ? "" : row["participant_name"].ToString(),
                    PaymentStatus = row["payment_status"] == DBNull.Value ? "" : row["payment_status"].ToString()
                });
            }
            return participants;
        }

        public static void AddParticipant(EventParticipant participant)
        {
            string query = $@"
            INSERT INTO event_participants 
                (event_id, participant_id, payment_status_id, fee_amount)
            VALUES 
                ({participant.EventId}, {participant.ParticipantId}, 
                 {participant.PaymentStatusId}, {participant.FeeAmount})";

            DatabaseHelper.ExecuteQuery(query);
        }

        public static void UpdateParticipant(EventParticipant participant)
        {
            string query = $@"
                UPDATE event_participants 
                SET event_id = {participant.EventId},
                participant_id = {participant.ParticipantId},
                payment_status_id = {participant.PaymentStatusId},
                fee_amount = {participant.FeeAmount}
                WHERE registration_id = {participant.RegistrationId}";

            DatabaseHelper.ExecuteQuery(query);
        }

        public static void DeleteParticipant(int registrationId)
        {
            string query = $"DELETE FROM event_participants WHERE registration_id = {registrationId}";
            DatabaseHelper.ExecuteQuery(query);
        }
    }
}
