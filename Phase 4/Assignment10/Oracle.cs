using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;
using System.Threading.Tasks;
using System.Data;

namespace Assignment10
{
   class Oracle
   {
      //The Enumeration Data Type for user response 
      public enum ResponseType { OK, Cancel };

      internal static string UserName;
      internal static string PassWd;
      internal static string Server;
      internal static ResponseType Result;

      internal static OracleConnection OC = new OracleConnection();

      internal static OracleDataAdapter staffAdapter = new OracleDataAdapter();
      internal static OracleCommand staffCommand = new OracleCommand();
      internal static OracleCommandBuilder staffCommandBuilder = new OracleCommandBuilder();

      internal static OracleDataAdapter qualificationAdapter = new OracleDataAdapter();
      internal static OracleCommand qualificationCommand = new OracleCommand();
      internal static OracleCommandBuilder qualificationCommandBuilder = new OracleCommandBuilder();

      internal static OracleDataAdapter exAdapter = new OracleDataAdapter();
      internal static OracleCommand exCommand = new OracleCommand();
      internal static OracleCommandBuilder exCommandBuilder = new OracleCommandBuilder();

      internal static DataTable staffTable = new DataTable();
      internal static DataTable qualTable = new DataTable();
      internal static DataTable exTable = new DataTable();

      public static void LogInAtRunTime()
      {
         // For testing
         //UserName = "yangq";
         //PassWd = "cs3630";
         //Server = "EDDB";

         OC.ConnectionString = "Data Source = " + Server + ";Persist Security Info=True;User ID=" + UserName + ";Password=" + PassWd + ";Unicode=True";

         staffCommand.CommandType = CommandType.Text;
         staffCommand.CommandText = "Select * from UWP_Staff";
         staffCommand.Connection = OC;

         staffAdapter.SelectCommand = staffCommand;
         staffCommandBuilder = new OracleCommandBuilder(staffAdapter);
         staffAdapter.Fill(staffTable);

         string staffNo = staffTable.Rows[0]["StaffNo"].ToString();

         qualificationCommand.CommandType = CommandType.Text;
         qualificationCommand.CommandText = "Select * from UWP_Qualifications where staffNo = '" + staffNo + "'";
         qualificationCommand.Connection = OC;

         qualificationAdapter.SelectCommand = qualificationCommand;
         qualificationCommandBuilder = new OracleCommandBuilder(qualificationAdapter);
         qualificationAdapter.Fill(qualTable);

         exCommand.CommandType = CommandType.Text;
         exCommand.CommandText = "Select * from UWP_WorkExperience where staffNo = '" + staffNo + "'";
         exCommand.Connection = OC;

         exAdapter.SelectCommand = exCommand;
         exCommandBuilder = new OracleCommandBuilder(exAdapter);
         exAdapter.Fill(exTable);
      }

      public static void Main()
      {
         bool connected = false;
         FormClassLogin login = new FormClassLogin();
         while (!connected)
         {
            login.ShowDialog();
            if (Result == ResponseType.Cancel)
               break;
            else
               try
               {
                  LogInAtRunTime();
                  connected = true;
               }
               catch(System.Exception ex)
               {
                  System.Windows.Forms.MessageBox.Show(ex.Message);
               }
         }
         if (connected)
            System.Windows.Forms.Application.Run(new FormClassBooking());
      }

      public static void LoadQualWorkTable(string staffNo)
      {
         qualificationCommand.CommandText = "Select * from UWP_Qualifications where staffNo = '" + staffNo + "'";
         exCommand.CommandText = "Select * from UWP_WorkExperience where staffNo = '" + staffNo + "'";
         qualTable.Clear();
         exTable.Clear();
         qualificationAdapter.Fill(qualTable);
         exAdapter.Fill(exTable);
      }

      public static void LoadAll()
      {
         staffCommand.CommandText = "Select * from UWP_Staff";
         staffTable.Clear();
         staffAdapter.Fill(staffTable);
         string staffNo = staffTable.Rows[0]["StaffNo"].ToString();
         qualificationCommand.CommandText = "Select * from UWP_Qualifications where staffNo = '" + staffNo + "'";
         exCommand.CommandText = "Select * from UWP_WorkExperience where staffNo = '" + staffNo + "'";
         qualTable.Clear();
         exTable.Clear();
         qualificationAdapter.Fill(qualTable);
         exAdapter.Fill(exTable);
      }
   }
   /*
   The pseudo code of Sub Main could be as follows:
      Set Connected to False
      While Not Connected
         Show Form Login as a dialogue
         If Response is Cancel
            Exit while
         Else
            Try
               Call LogInAtRunTime
               Set Connected to true and exit while
            Catch an exception
               Display a message box
      End While

      If Connected
         Run application with FormClassBooking
   }
   */
}
