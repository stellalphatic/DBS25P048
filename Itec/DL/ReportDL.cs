using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using System.IO;
using System.Drawing.Printing;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using Itec.DB;


public static class ReportManager
{
    public static DataTable GetReportData(ReportType type, string year)
    {
        return type switch
        {
            ReportType.Financial => GetFinancialData(year),
            ReportType.Venue => GetVenueData(year),
            ReportType.Event => GetEventData(year),
            _ => throw new ArgumentException("Invalid report type")
        };
    }
    const string FinancialReportQuery = @"
        SELECT    
        e.year AS Year,
        l.value AS TransactionType,
        f.amount AS Amount,
        DATE_FORMAT(f.date_recorded, '%Y-%m-%d') AS TransactionDate,
        COALESCE(s.sponsor_name, v.vendor_name, u.username, c.committee_name) AS FromEntity,
        COALESCE(s2.sponsor_name, v2.vendor_name, u2.username, c2.committee_name) AS ToEntity,
        f.description AS Description,
        CASE
            WHEN l.value IN ('Sponsorship Income', 'Ticket Sales', 'Miscellaneous Income') THEN 'Income'
            WHEN l.value IN ('Vendor Payment', 'Expense', 'Venue Rental Expense', 'Equipment Purchase', 'Marketing Expense') THEN 'Expense'
        END AS FinancialCategory
      FROM finances f
      JOIN itec_editions e ON f.itec_id = e.itec_id
      JOIN lookup l ON f.type_id = l.lookup_id
      LEFT JOIN sponsors s ON f.from_entity_type = 'Sponsor' AND f.from_entity_id = s.sponsor_id
      LEFT JOIN vendors v ON f.from_entity_type = 'Vendor' AND f.from_entity_id = v.vendor_id
      LEFT JOIN users u ON f.from_entity_type = 'User' AND f.from_entity_id = u.user_id
     LEFT JOIN committees c ON f.from_entity_type = 'Committee' AND f.from_entity_id = c.committee_id
     LEFT JOIN sponsors s2 ON f.to_entity_type = 'Sponsor' AND f.to_entity_id = s2.sponsor_id
     LEFT JOIN vendors v2 ON f.to_entity_type = 'Vendor' AND f.to_entity_id = v2.vendor_id
     LEFT JOIN users u2 ON f.to_entity_type = 'User' AND f.to_entity_id = u2.user_id
     LEFT JOIN committees c2 ON f.to_entity_type = 'Committee' AND f.to_entity_id = c2.committee_id";
    const string VenueReportQuery = @"
            SELECT
              e.year AS Year,
              v.venue_name AS Venue,
              v.capacity AS Capacity,
              ev.event_name AS AssignedEvent,
              DATE_FORMAT(va.assigned_date, '%Y-%m-%d') AS AssignmentDate,
              TIME_FORMAT(va.assigned_time, '%H:%i') AS AssignmentTime
            FROM venue_allocations va
            JOIN venues v ON va.venue_id = v.venue_id
            JOIN itec_events ev ON va.event_id = ev.event_id
            JOIN itec_editions e ON ev.itec_id = e.itec_id";
    const string EventReportQuery = @"
            SELECT
                e.year AS Year,
                ev.event_name AS Event,
                ec.category_name AS Category,
                DATE_FORMAT(ev.event_date, '%Y-%m-%d') AS EventDate,
                c.committee_name AS ResponsibleCommittee,
                v.venue_name AS Venue,
                COUNT(ep.participant_id) AS ParticipantsRegistered
            FROM itec_events ev
            JOIN itec_editions e ON ev.itec_id = e.itec_id
            LEFT JOIN event_categories ec ON ev.event_category_id = ec.event_category_id
            LEFT JOIN committees c ON ev.committee_id = c.committee_id
            LEFT JOIN venues v ON ev.venue_id = v.venue_id
            LEFT JOIN event_participants ep ON ev.event_id = ep.event_id
            GROUP BY ev.event_id, e.year, ev.event_name, ec.category_name, ev.event_date, c.committee_name, v.venue_name";
    public static DataTable GetFullReportData(ReportType type)
    {
        return type switch
        {
            ReportType.Financial => DatabaseHelper.GetData(FinancialReportQuery),
            ReportType.Venue => DatabaseHelper.GetData(VenueReportQuery),
            ReportType.Event => DatabaseHelper.GetData(EventReportQuery),
            _ => throw new ArgumentException("Invalid report type")
        };
    }


    private static DataTable GetFinancialData(string year)
    {
        string query = FinancialReportQuery + $@" WHERE e.`year` = {year}";

        return DatabaseHelper.GetData(query);
    }

    private static DataTable GetVenueData(string year)
    {
        string query =VenueReportQuery + $@" WHERE e.year = {year}";

        return DatabaseHelper.GetData(query);
    }

    private static DataTable GetEventData(string year)
    {
        string query = $@"
            SELECT
                 e.year AS Year,
                ev.event_name AS Event,
                ec.category_name AS Category,
                DATE_FORMAT(ev.event_date, '%Y-%m-%d') AS EventDate,
                c.committee_name AS ResponsibleCommittee,
                v.venue_name AS Venue,
                COUNT(ep.participant_id) AS ParticipantsRegistered
            FROM itec_events ev
            JOIN itec_editions e ON ev.itec_id = e.itec_id
            LEFT JOIN event_categories ec ON ev.event_category_id = ec.event_category_id
            LEFT JOIN committees c ON ev.committee_id = c.committee_id
            LEFT JOIN venues v ON ev.venue_id = v.venue_id
            LEFT JOIN event_participants ep ON ev.event_id = ep.event_id
            WHERE e.year = {year}
            GROUP BY ev.event_id";

        return DatabaseHelper.GetData(query);
    }
}