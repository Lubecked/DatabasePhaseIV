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

      private BindingSource staffBindingSource = new BindingSource();
      private BindingSource qualBindingSource = new BindingSource();
      private BindingSource exBindingSource = new BindingSource();
      public FormClassBooking()
      {
         InitializeComponent();
      }

      private void LoadQualWorkForStaff()
      {
         try
         {
            string staffNo = Oracle.staffTable.Rows[staffBindingSource.Position]["StaffNo"].ToString();
            Oracle.LoadQualWorkTable(staffNo);
         }
         catch (System.Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void FormClassBooking_Load(object sender, EventArgs e)
      {
         staffBindingSource.DataSource = Oracle.staffTable;
         qualBindingSource.DataSource = Oracle.qualTable;
         exBindingSource.DataSource = Oracle.exTable;

         txtStaffNo.DataBindings.Add("Text", staffBindingSource, "staffNo");
         txtFName.DataBindings.Add("Text", staffBindingSource, "fName");
         txtLName.DataBindings.Add("Text", staffBindingSource, "lName");
         txtStreet.DataBindings.Add("Text", staffBindingSource, "street");
         txtCity.DataBindings.Add("Text", staffBindingSource, "city");
         txtState.DataBindings.Add("Text", staffBindingSource, "state");
         txtZIP.DataBindings.Add("Text", staffBindingSource, "zip");
         txtPhone.DataBindings.Add("Text", staffBindingSource, "phone");
         dtpDOB.DataBindings.Add("Text", staffBindingSource, "DOB");
         txtGender.DataBindings.Add("Text", staffBindingSource, "gender");
         txtNIN.DataBindings.Add("Text", staffBindingSource, "NIN");
         txtPosition.DataBindings.Add("Text", staffBindingSource, "position");
         txtCurSalary.DataBindings.Add("Text", staffBindingSource, "curSalary");
         txtSalaryScale.DataBindings.Add("Text", staffBindingSource, "salaryScale");
         txtHours.DataBindings.Add("Text", staffBindingSource, "hrsPerWk");
         txtPosPermTemp.DataBindings.Add("Text", staffBindingSource, "posPermTemp");
         txtTypePay.DataBindings.Add("Text", staffBindingSource, "typeOfPay");
         dtpQualDate.DataBindings.Add("Text", qualBindingSource, "qualDate");
         txtType.DataBindings.Add("Text", qualBindingSource, "type");
         txtInstName.DataBindings.Add("Text", qualBindingSource, "instName");
         txtOrgName.DataBindings.Add("Text", exBindingSource, "orgName");
         txtPositionExp.DataBindings.Add("Text", exBindingSource, "position");
         dtpStartDate.DataBindings.Add("Text", exBindingSource, "startDate");
         dtpFinDate.DataBindings.Add("Text", exBindingSource, "finishDate");

         txtCurEmp.Text = (staffBindingSource.Position + 1) + "/" + staffBindingSource.Count;
      }

      private void btnNextEmp_Click(object sender, EventArgs e)
      {
         staffBindingSource.MoveNext();
         txtCurEmp.Text = (staffBindingSource.Position + 1) + "/" + staffBindingSource.Count;
         LoadQualWorkForStaff();
      }

      private void btnPrevEmp_Click(object sender, EventArgs e)
      {
         staffBindingSource.MovePrevious();
         txtCurEmp.Text = (staffBindingSource.Position + 1) + "/" + staffBindingSource.Count;
         LoadQualWorkForStaff();
      }

      private void btnLastEmp_Click(object sender, EventArgs e)
      {
         staffBindingSource.Position = staffBindingSource.Count - 1;
         txtCurEmp.Text = (staffBindingSource.Position + 1) + "/" + staffBindingSource.Count;
         LoadQualWorkForStaff();
      }

      private void btnFirstEmp_Click(object sender, EventArgs e)
      {
         staffBindingSource.Position = 0;
         txtCurEmp.Text = (staffBindingSource.Position + 1) + "/" + staffBindingSource.Count;
         LoadQualWorkForStaff();
      }

      private void btnNewEmp_Click(object sender, EventArgs e)
      {
         DataRow r = Oracle.staffTable.NewRow();
         Oracle.staffTable.Rows.Add(r);
         staffBindingSource.MoveLast();
         txtCurEmp.Text = (staffBindingSource.Position + 1) + "/" + staffBindingSource.Count;
      }

      private void btnSaveEmp_Click(object sender, EventArgs e)
      {
         try
         {
            staffBindingSource.EndEdit();
            Oracle.staffAdapter.Update(Oracle.staffTable);
         }
         catch (System.Exception ex)
         {
            System.Windows.Forms.MessageBox.Show(ex.Message);
         }
      }

      private void btnDeleteEmp_Click(object sender, EventArgs e)
      {
         try
         {
            staffBindingSource.RemoveCurrent();
            txtCurEmp.Text = (staffBindingSource.Position + 1) + "/" + staffBindingSource.Count;
         }
         catch (System.Exception ex)
         {
            System.Windows.Forms.MessageBox.Show(ex.Message);
         }
      }
   }
}
