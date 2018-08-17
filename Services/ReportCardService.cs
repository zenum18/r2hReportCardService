using R2hReportCardService.Models;
using MySql.Data.MySqlClient;
using Dapper;
using System;

namespace R2hReportCardService.Services
{
  public class ReportCardService
  {
    public void createMentorReportCard(MentorReportCard requestBody, string dbConnStr)
    {
      MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
      conn_string.Server = "server";
      conn_string.Port = 3306;
      conn_string.UserID = "urs";
      conn_string.Password = "pass";
      conn_string.Database = "db";

      MySqlConnection MyCon = new MySqlConnection(conn_string.ToString());
      MentorReportCard body = new MentorReportCard();
      body.mentorType = (requestBody.mentorType == null) ? 8 : 0;
      body.mentorReportCardId = (requestBody.mentorReportCardId == null) ? 9 : 0;
      Console.WriteLine("In CreateMentoreReportCard");
      string sql = "INSERT INTO MentorReportCards (MentorReportCardID, MentorType) VALUES (@mentorReportCardID, @mentorType);";
      using (var dbConn = new MySqlConnection(conn_string.ToString()))
      {
        try
        {
          Console.WriteLine("attempting sql execute");
          dbConn.Execute(sql, new { mentorReportCardIDId = body.mentorReportCardId, mentorType = body.mentorType});
        }
        catch (Exception e) 
        {
          Console.WriteLine($"Failed to execute query: {e}");
        }
      }
    }
  }
}