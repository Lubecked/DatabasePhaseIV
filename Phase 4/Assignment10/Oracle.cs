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
      internal static OracleDataAdapter bookingAdapter = new OracleDataAdapter();
      internal static OracleCommand bookingCommand = new OracleCommand();
      internal static OracleCommandBuilder bookingCommandBuilder = new OracleCommandBuilder();

      internal static OracleDataAdapter qualificationAdapter = new OracleDataAdapter();
      internal static OracleCommand qualificationCommand = new OracleCommand();
      internal static OracleCommandBuilder qualificationCommandBuilder = new OracleCommandBuilder();

      internal static OracleDataAdapter exAdapter = new OracleDataAdapter();
      internal static OracleCommand exCommand = new OracleCommand();
      internal static OracleCommandBuilder exCommandBuilder = new OracleCommandBuilder();

      internal static DataTable myTable = new DataTable();
      internal static DataTable qualTable = new DataTable();
      internal static DataTable exTable = new DataTable();

      public static void LogInAtRunTime()
      {
         // For testing
         //UserName = "yangq";
         //PassWd = "cs3630";
         //Server = "EDDB";

         OC.ConnectionString = "Data Source = " + Server + ";Persist Security Info=True;User ID=" + UserName + ";Password=" + PassWd + ";Unicode=True";

         bookingCommand.CommandType = CommandType.Text;
         bookingCommand.CommandText = "Select * from UWP_Staff";
         bookingCommand.Connection = OC;

         bookingAdapter.SelectCommand = bookingCommand;
         bookingCommandBuilder = new OracleCommandBuilder(bookingAdapter);
         bookingAdapter.Fill(myTable);

         qualificationCommand.CommandType = CommandType.Text;
         qualificationCommand.CommandText = "Select * from UWP_Qualifications";
         qualificationCommand.Connection = OC;

         bookingAdapter.SelectCommand = qualificationCommand;
         bookingCommandBuilder = new OracleCommandBuilder(qualificationAdapter);
         bookingAdapter.Fill(qualTable);

         exCommand.CommandType = CommandType.Text;
         exCommand.CommandText = "Select * from UWP_WorkExperience";
         exCommand.Connection = OC;

         bookingAdapter.SelectCommand = exCommand;
         bookingCommandBuilder = new OracleCommandBuilder(exAdapter);
         bookingAdapter.Fill(exTable);

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
