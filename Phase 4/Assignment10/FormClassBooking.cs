using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment10
{
   public partial class FormClassBooking : Form
   {
      public FormClassBooking()
      {
         InitializeComponent();
      }

      private void FormClassBooking_Load(object sender, EventArgs e)
      {
         dataGridView1.DataSource = Oracle.myTable;

      }

      private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {

      }


      // Update
      private void button1_Click(object sender, EventArgs e)
      {
         try
         {
            dataGridView1.EndEdit();
            Oracle.bookingAdapter.Update(Oracle.myTable);
         }
         catch
         {

         }
      }

      private void button2_Click(object sender, EventArgs e)
      {
         Oracle.myTable.Clear();

         string field = cmbDOB.Text;
         string op = cmbQualDate.Text;
         string value = txtStaffNo.Text;

         //for non date things
         if (field != "DATE_TO" && field != "DATE_FROM")
            Oracle.bookingCommand.CommandText = "Select * from booking where " + field + op + "'" + value + "'";
         else
         {
            // date code
         }

         //testing
         //MessageBox.Show(Oracle.bookingCommand.CommandText);

         try
         {
            Oracle.myTable.Clear();
            Oracle.bookingAdapter.Fill(Oracle.myTable);
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }


      }

      private void button3_Click(object sender, EventArgs e)
      {
         Oracle.bookingCommand.CommandText = "SELECT * FROM BOOKING";
         try
         {
            Oracle.myTable.Clear();
            Oracle.bookingAdapter.Fill(Oracle.myTable);
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }

      }

      private void button4_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {

      }

      private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
      {

      }

      private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
      {

      }
   }
}
