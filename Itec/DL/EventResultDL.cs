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
    public static class EventResultDL
    {
        public static List<EventResult> GetAllResults()
        {
            List<EventResult> results = new List<EventResult>();
            string query = @"
            SELECT er.result_id, er.event_id, er.participant_id, er.team_id, 
                   er.position, er.score, er.remarks,
                   e.event_name, p.name AS participant_name, t.team_name
            FROM event_results er
            LEFT JOIN itec_events e ON er.event_id = e.event_id
            LEFT JOIN participants p ON er.participant_id = p.participant_id
            LEFT JOIN teams t ON er.team_id = t.team_id";

            DataTable dt = DatabaseHelper.GetData(query);

            foreach (DataRow row in dt.Rows)
            {
                results.Add(new EventResult
                {
                    ResultId = Convert.ToInt32(row["result_id"]),
                    EventId = Convert.ToInt32(row["event_id"]),
                    ParticipantId = row["participant_id"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["participant_id"]),
                    TeamId = row["team_id"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["team_id"]),
                    Position = Convert.ToInt32(row["position"]),
                    Score = Convert.ToDecimal(row["score"]),
                    Remarks = row["remarks"].ToString(),
                    EventName = row["event_name"].ToString(),
                    ParticipantName = row["participant_name"] == DBNull.Value ? "" : row["participant_name"].ToString(),
                    TeamName = row["team_name"] == DBNull.Value ? "" : row["team_name"].ToString()
                });
            }
            return results;
        }

        public static void AddResult(EventResult result)
        {
            string participantPart = result.ParticipantId.HasValue ? result.ParticipantId.ToString() : "NULL";
            string teamPart = result.TeamId.HasValue ? result.TeamId.ToString() : "NULL";

            string query = $@"
            INSERT INTO event_results 
                (event_id, participant_id, team_id, position, score, remarks)
            VALUES 
                ({result.EventId}, {participantPart}, {teamPart}, 
                 {result.Position}, {result.Score}, '{result.Remarks}')";

            DatabaseHelper.ExecuteQuery(query);
        }

        public static void UpdateResult(EventResult result)
        {
            string participantPart = result.ParticipantId.HasValue ? result.ParticipantId.ToString() : "NULL";
            string teamPart = result.TeamId.HasValue ? result.TeamId.ToString() : "NULL";

            string query = $@"
            UPDATE event_results 
            SET event_id = {result.EventId},
                participant_id = {participantPart},
                team_id = {teamPart},
                position = {result.Position},
                score = {result.Score},
                remarks = '{result.Remarks}'
            WHERE result_id = {result.ResultId}";

            DatabaseHelper.ExecuteQuery(query);
        }

        public static void DeleteResult(int resultId)
        {
            string query = $"DELETE FROM event_results WHERE result_id = {resultId}";
            DatabaseHelper.ExecuteQuery(query);
        }
    }
}
