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
    public static class DutyDL
    {
        //Get all duties 
        public static List<Duty> GetAllDuties()
        {
            List<Duty> duties = new List<Duty>();
            string query = @"
            SELECT 
                d.duty_id,d.committee_id, d.assigned_to,d.task_description,d.deadline,d.status_id,c.committee_name,l.value AS status_name
            FROM duties d
            LEFT JOIN committees c on d.committee_id = c.committee_id
            LEFT JOIN lookup l on d.status_id = l.lookup_id";

            DataTable dt = DatabaseHelper.GetData(query);

            foreach (DataRow row in dt.Rows)
            {
                duties.Add(new Duty
                {
                    DutyId = Convert.ToInt32(row["duty_id"]),
                    CommitteeId = Convert.ToInt32(row["committee_id"]),
                    AssignedTo = row["assigned_to"].ToString(),
                    TaskDescription = row["task_description"].ToString(),
                    Deadline = Convert.ToDateTime(row["deadline"]),
                    StatusId = Convert.ToInt32(row["status_id"]),
                    CommitteeName = row["committee_name"].ToString(),
                    StatusName = row["status_name"].ToString()
                });
            }
            return duties;
        }

        //Add new duty
        public static void AddDuty(Duty newDuty)
        {
            string query = $@"INSERT INTO duties 
                         (committee_id, assigned_to, task_description, deadline, status_id) 
                         VALUES ({newDuty.CommitteeId}, '{newDuty.AssignedTo}', '{newDuty.TaskDescription}', 
                                 '{newDuty.Deadline:yyyy-MM-dd}', {newDuty.StatusId})";
            DatabaseHelper.ExecuteQuery(query);
        }

        //Update duty
        public static void UpdateDuty(Duty updatedDuty)
        {
            string query = $@"UPDATE duties 
                         SET committee_id = {updatedDuty.CommitteeId}, 
                             assigned_to = '{updatedDuty.AssignedTo}', 
                             task_description = '{updatedDuty.TaskDescription}', 
                             deadline = '{updatedDuty.Deadline:yyyy-MM-dd}', 
                             status_id = {updatedDuty.StatusId}
                         WHERE duty_id = {updatedDuty.DutyId}";
            DatabaseHelper.ExecuteQuery(query);
        }

        //Delete duty
        public static void DeleteDuty(int dutyId)
        {
            string query = $"DELETE FROM duties WHERE duty_id = {dutyId}";
            DatabaseHelper.ExecuteQuery(query);
        }
    }
}
