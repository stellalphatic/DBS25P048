using Itec.BL;
using Itec.DB;
using System.Data;

namespace Itec.DL
    { 
public static class FinancialDL
{
    public static List<Finance> GetAllTransactions()
    {
        List<Finance> transactions = new List<Finance>();
        string query = @"SELECT f.transaction_id, f.itec_id, f.event_id, f.type_id, f.amount,
         f.from_entity_type, f.from_entity_id, f.to_entity_type, f.to_entity_id,
         f.description, f.date_recorded, l.value AS finance_type,
         e.event_name, ie.year AS itec_year,
         COALESCE(s.sponsor_name, u.username, c.committee_name, v.vendor_name) AS from_entity_name,
         COALESCE(s2.sponsor_name, u2.username, c2.committee_name, v2.vendor_name) AS to_entity_name
         FROM finances f
         LEFT JOIN lookup l ON f.type_id = l.lookup_id
         LEFT JOIN itec_events e ON f.event_id = e.event_id
         LEFT JOIN itec_editions ie ON f.itec_id = ie.itec_id
         LEFT JOIN sponsors s ON f.from_entity_type = 'Sponsor' AND f.from_entity_id = s.sponsor_id
         LEFT JOIN users u ON f.from_entity_type = 'User' AND f.from_entity_id = u.user_id
         LEFT JOIN committees c ON f.from_entity_type = 'Committee' AND f.from_entity_id = c.committee_id
         LEFT JOIN vendors v ON f.from_entity_type = 'Vendor' AND f.from_entity_id = v.vendor_id
         LEFT JOIN sponsors s2 ON f.to_entity_type = 'Sponsor' AND f.to_entity_id = s2.sponsor_id
         LEFT JOIN users u2 ON f.to_entity_type = 'User' AND f.to_entity_id = u2.user_id
         LEFT JOIN committees c2 ON f.to_entity_type = 'Committee' AND f.to_entity_id = c2.committee_id
         LEFT JOIN vendors v2 ON f.to_entity_type = 'Vendor' AND f.to_entity_id = v2.vendor_id";

        DataTable dt = DatabaseHelper.GetData(query);

        foreach (DataRow row in dt.Rows)
        {
            transactions.Add(new Finance
            {
                TransactionId = Convert.ToInt32(row["transaction_id"]),
                ITECId = Convert.ToInt32(row["itec_id"]),
                EventId = row["event_id"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["event_id"]),
                TypeId = Convert.ToInt32(row["type_id"]),
                Amount = Convert.ToDecimal(row["amount"]),
                FromEntityType = row["from_entity_type"].ToString(),
                FromEntityId = Convert.ToInt32(row["from_entity_id"]),
                ToEntityType = row["to_entity_type"].ToString(),
                ToEntityId = Convert.ToInt32(row["to_entity_id"]),
                Description = row["description"].ToString(),
                DateRecorded = Convert.ToDateTime(row["date_recorded"]),
                FinanceType = row["finance_type"].ToString(),
                FromEntityName = row["from_entity_name"].ToString(),
                ToEntityName = row["to_entity_name"].ToString(),
                EventName = row["event_name"] == DBNull.Value ? "" : row["event_name"].ToString(),
                ITECYear = row["itec_year"].ToString()
            });
        }
        return transactions;
    }

    public static void AddTransaction(Finance transaction)
    {
        string eventPart = transaction.EventId.HasValue ? transaction.EventId.ToString() : "NULL";

        string query = $@"
         INSERT INTO finances(itec_id, event_id, type_id, amount, from_entity_type, from_entity_id, 
         to_entity_type, to_entity_id, description, date_recorded)
         VALUES ({transaction.ITECId}, {eventPart}, {transaction.TypeId}, {transaction.Amount}, 
             '{transaction.FromEntityType}', {transaction.FromEntityId}, 
             '{transaction.ToEntityType}', {transaction.ToEntityId}, 
             '{transaction.Description}', '{transaction.DateRecorded:yyyy-MM-dd HH:mm:ss}')";

        DatabaseHelper.ExecuteQuery(query);
    }

    public static void DeleteTransaction(int transactionId)
    {
        string query = $"DELETE FROM finances WHERE transaction_id = {transactionId}";
        DatabaseHelper.ExecuteQuery(query);
    }

    public static DataTable GetBudgetReport(int itecId)
    {
        string query = $@"
         SELECT SUM(CASE WHEN l.value IN ('Sponsorship', 'Ticket Sales') THEN f.amount ELSE 0 END) AS TotalIncome,
         SUM(CASE WHEN l.value = 'Expense' THEN f.amount ELSE 0 END) AS TotalExpenses,
         (SUM(CASE WHEN l.value IN ('Sponsorship', 'Ticket Sales') THEN f.amount ELSE 0 END) - 
         SUM(CASE WHEN l.value = 'Expense' THEN f.amount ELSE 0 END)) AS NetBalance
         FROM finances f
         JOIN lookup l ON f.type_id = l.lookup_id
         WHERE f.itec_id = {itecId}";

        return DatabaseHelper.GetData(query);
    }
    public static void UpdateTransaction(Finance transaction)
    {
        string eventPart = transaction.EventId.HasValue ? transaction.EventId.ToString() : "NULL";

        string query = $@"UPDATE finances 
         SET itec_id = {transaction.ITECId},event_id = {eventPart},type_id = {transaction.TypeId},
         amount = {transaction.Amount},from_entity_type = '{transaction.FromEntityType}',
         from_entity_id = {transaction.FromEntityId},to_entity_type = '{transaction.ToEntityType}',to_entity_id = {transaction.ToEntityId},
         description = '{transaction.Description}',date_recorded = '{transaction.DateRecorded:yyyy-MM-dd HH:mm:ss}'
         WHERE transaction_id = {transaction.TransactionId}";

        DatabaseHelper.ExecuteQuery(query);
    }
}
}