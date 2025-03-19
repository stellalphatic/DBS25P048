using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itec.DB;
using Itec.Pages;
using Itec.BL;
namespace Itec.DL
{
    public static class FinanceDL
    {
        public static List<Finance> GetAllFinances()
        {
            List<Finance> finances = new List<Finance>();
            string query = "SELECT * FROM finances";
            DataTable dt = DatabaseHelper.GetData(query);

            foreach (DataRow row in dt.Rows)
            {
                finances.Add(new Finance
                {
                    TransactionId = Convert.ToInt32(row["transaction_id"]),
                    ItecId = row["itec_id"] != DBNull.Value ? Convert.ToInt32(row["itec_id"]) : (int?)null,
                    EventId = row["event_id"] != DBNull.Value ? Convert.ToInt32(row["event_id"]) : (int?)null,
                    TypeId = row["type_id"] != DBNull.Value ? Convert.ToInt32(row["type_id"]) : (int?)null,
                    Amount = Convert.ToDecimal(row["amount"]),
                    FromEntityType = row["from_entity_type"].ToString(),
                    FromEntityId = Convert.ToInt32(row["from_entity_id"]),
                    ToEntityType = row["to_entity_type"].ToString(),
                    ToEntityId = Convert.ToInt32(row["to_entity_id"]),
                    Description = row["description"].ToString(),
                    DateRecorded = Convert.ToDateTime(row["date_recorded"])
                });
            }
            return finances;
        }

        //Add transaction
        public static void AddFinance(Finance newFinance)
        {
            string query = $@"INSERT INTO finances 
                         (itec_id, event_id, type_id, amount, from_entity_type, from_entity_id, to_entity_type, to_entity_id, description, date_recorded) 
                         VALUES ({newFinance.ItecId}, {newFinance.EventId}, {newFinance.TypeId}, {newFinance.Amount}, 
                                 '{newFinance.FromEntityType}', {newFinance.FromEntityId}, '{newFinance.ToEntityType}', {newFinance.ToEntityId}, 
                                 '{newFinance.Description}', '{newFinance.DateRecorded:yyyy-MM-dd HH:mm:ss}')";
            DatabaseHelper.ExecuteQuery(query);
        }

        //Update transaction
        public static void UpdateFinance(Finance updatedFinance)
        {
            string query = $@"UPDATE finances 
                             SET itec_id = {updatedFinance.ItecId}, 
                             event_id = {updatedFinance.EventId}, 
                             type_id = {updatedFinance.TypeId}, 
                             amount = {updatedFinance.Amount}, 
                             from_entity_type = '{updatedFinance.FromEntityType}', 
                             from_entity_id = {updatedFinance.FromEntityId}, 
                             to_entity_type = '{updatedFinance.ToEntityType}', 
                             to_entity_id = {updatedFinance.ToEntityId}, 
                             description = '{updatedFinance.Description}', 
                             date_recorded = '{updatedFinance.DateRecorded:yyyy-MM-dd HH:mm:ss}'
                             WHERE transaction_id = {updatedFinance.TransactionId}";
            DatabaseHelper.ExecuteQuery(query);
        }

        //Delete transaction
        public static void DeleteFinance(int transactionId)
        {
            string query = $"DELETE FROM finances WHERE transaction_id = {transactionId}";
            DatabaseHelper.ExecuteQuery(query);
        }
    }
}
