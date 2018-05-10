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

      private void RefreshNums()
      {
         txtCurEmp.Text = (staffBindingSource.Position + 1) + "/" + staffBindingSource.Count;
         txtCurQual.Text = (qualBindingSource.Position + 1) + "/" + qualBindingSource.Count;
         txtCurExp.Text = (exBindingSource.Position + 1) + "/" + exBindingSource.Count;

         btnNextEmp.Enabled = true;
         btnLastEmp.Enabled = true;
         btnPrevEmp.Enabled = true;
         btnFirstEmp.Enabled = true;

         btnNextQual.Enabled = true;
         btnLastQual.Enabled = true;
         btnPrevQual.Enabled = true;
         btnFirstQual.Enabled = true;

         btnNextExp.Enabled = true;
         btnLastExp.Enabled = true;
         btnPrevExp.Enabled = true;
         btnFirstExp.Enabled = true;

         btnNewEmp.Enabled = true;
         btnNewQual.Enabled = true;
         btnNewExp.Enabled = true;
         btnSaveEmp.Enabled = true;
         btnDeleteEmp.Enabled = true;
         btnSaveQual.Enabled = true;
         btnDeleteQual.Enabled = true;
         btnSaveExp.Enabled = true;
         btnDeleteExp.Enabled = true;

         btnSearch.Enabled = true;
         btnSearchAll.Enabled = true;

         if (staffBindingSource.Position == staffBindingSource.Count - 1)
         {
            btnNextEmp.Enabled = false;
            btnLastEmp.Enabled = false;
         }
         if (staffBindingSource.Position == 0)
         {
            btnPrevEmp.Enabled = false;
            btnFirstEmp.Enabled = false;
         }
         if (staffBindingSource.Count == 0)
         {
            btnNextEmp.Enabled = false;
            btnLastEmp.Enabled = false;
            btnPrevEmp.Enabled = false;
            btnFirstEmp.Enabled = false;
         }

         if (qualBindingSource.Position == qualBindingSource.Count - 1)
         {
            btnNextQual.Enabled = false;
            btnLastQual.Enabled = false;
         }
         if (qualBindingSource.Position == 0)
         {
            btnPrevQual.Enabled = false;
            btnFirstQual.Enabled = false;
         }
         if (qualBindingSource.Count == 0)
         {
            btnNextQual.Enabled = false;
            btnLastQual.Enabled = false;
            btnPrevQual.Enabled = false;
            btnFirstQual.Enabled = false;
         }

         if (exBindingSource.Position == exBindingSource.Count - 1)
         {
            btnNextExp.Enabled = false;
            btnLastExp.Enabled = false;
         }
         if (exBindingSource.Position == 0)
         {
            btnPrevExp.Enabled = false;
            btnFirstExp.Enabled = false;
         }
         if (exBindingSource.Count == 0)
         {
            btnNextExp.Enabled = false;
            btnLastExp.Enabled = false;
            btnPrevExp.Enabled = false;
            btnFirstExp.Enabled = false;
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

         RefreshNums();
      }

      private void btnNextEmp_Click(object sender, EventArgs e)
      {
         staffBindingSource.MoveNext();
         LoadQualWorkForStaff();
         RefreshNums();
      }

      private void btnPrevEmp_Click(object sender, EventArgs e)
      {
         staffBindingSource.MovePrevious();
         LoadQualWorkForStaff();
         RefreshNums();
      }

      private void btnLastEmp_Click(object sender, EventArgs e)
      {
         staffBindingSource.Position = staffBindingSource.Count - 1;
         LoadQualWorkForStaff();
         RefreshNums();
      }

      private void btnFirstEmp_Click(object sender, EventArgs e)
      {
         staffBindingSource.Position = 0;
         LoadQualWorkForStaff();
         RefreshNums();
      }
      private void btnNextQual_Click(object sender, EventArgs e)
      {
         qualBindingSource.MoveNext();
         RefreshNums();
      }

      private void btnPrevQual_Click(object sender, EventArgs e)
      {
         qualBindingSource.MovePrevious();
         RefreshNums();
      }

      private void btnLastQual_Click(object sender, EventArgs e)
      {
         qualBindingSource.Position = qualBindingSource.Count - 1;
         RefreshNums();
      }

      private void btnFirstQual_Click(object sender, EventArgs e)
      {
         qualBindingSource.Position = 0;
         RefreshNums();
      }

      private void btnNextExp_Click(object sender, EventArgs e)
      {
         exBindingSource.MoveNext();
         RefreshNums();
      }

      private void btnPrevExp_Click(object sender, EventArgs e)
      {
         exBindingSource.MovePrevious();
         RefreshNums();
      }

      private void btnLastExp_Click(object sender, EventArgs e)
      {
         exBindingSource.Position = exBindingSource.Count - 1;
         RefreshNums();
      }

      private void btnFirstExp_Click(object sender, EventArgs e)
      {
         exBindingSource.Position = 0;
         RefreshNums();
      }

      private void btnSearchAll_Click(object sender, EventArgs e)
      {
         Oracle.LoadAll();
         RefreshNums();
      }
      private void btnExit_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void btnNewEmp_Click(object sender, EventArgs e)
      {
         DataRow r = Oracle.staffTable.NewRow();
         Oracle.staffTable.Rows.Add(r);
         staffBindingSource.MoveLast();
         txtCurEmp.Text = (staffBindingSource.Position + 1) + "/" + staffBindingSource.Count;
         Disable_Buttons('m');
      }

      private void btnSaveEmp_Click(object sender, EventArgs e)
      {
         try
         {
            staffBindingSource.EndEdit();
            Oracle.staffAdapter.Update(Oracle.staffTable);
            RefreshNums();
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
            RefreshNums();
         }
         catch (System.Exception ex)
         {
            System.Windows.Forms.MessageBox.Show(ex.Message);
         }
         btnSaveEmp_Click(null, null);
      }

      private void btnNewQual_Click(object sender, EventArgs e)
      {
         DataRow r = Oracle.qualTable.NewRow();
         Oracle.qualTable.Rows.Add(r);
         qualBindingSource.MoveLast();
         RefreshNums();
         Disable_Buttons('q');
      }

      private void btnSaveQual_Click(object sender, EventArgs e)
      {
         try
         {
            string staffNo = Oracle.staffTable.Rows[staffBindingSource.Position]["StaffNo"].ToString();
            Oracle.qualTable.Rows[qualBindingSource.Position]["StaffNo"] = staffNo;
            qualBindingSource.EndEdit();
            Oracle.qualificationAdapter.Update(Oracle.qualTable);
            RefreshNums();
         }
         catch (System.Exception ex)
         {
            System.Windows.Forms.MessageBox.Show(ex.Message);
         }
      }

      private void btnDeleteQual_Click(object sender, EventArgs e)
      {
         try
         {
            qualBindingSource.RemoveCurrent();
            RefreshNums();
         }
         catch (System.Exception ex)
         {
            System.Windows.Forms.MessageBox.Show(ex.Message);
         }
         btnSaveQual_Click(null, null);
      }

      private void btnNewExp_Click(object sender, EventArgs e)
      {
         DataRow r = Oracle.exTable.NewRow();
         Oracle.exTable.Rows.Add(r);
         exBindingSource.MoveLast();
         RefreshNums();
         Disable_Buttons('x');
      }

      private void btnSaveExp_Click(object sender, EventArgs e)
      {
         try
         {
            string staffNo = Oracle.staffTable.Rows[staffBindingSource.Position]["StaffNo"].ToString();
            Oracle.exTable.Rows[exBindingSource.Position]["StaffNo"] = staffNo;
            exBindingSource.EndEdit();
            Oracle.exAdapter.Update(Oracle.exTable);
            RefreshNums();
         }
         catch (System.Exception ex)
         {
            System.Windows.Forms.MessageBox.Show(ex.Message);
         }
      }

      private void btnDeleteExp_Click(object sender, EventArgs e)
      {
         try
         {
            exBindingSource.RemoveCurrent();
            RefreshNums();
         }
         catch (System.Exception ex)
         {
            System.Windows.Forms.MessageBox.Show(ex.Message);
         }
         btnSaveExp_Click(null, null);
      }

      private void Disable_Buttons(char c)
      {
         btnNextEmp.Enabled = false;
         btnLastEmp.Enabled = false;
         btnPrevEmp.Enabled = false;
         btnFirstEmp.Enabled = false;
         btnNewEmp.Enabled = false;

         btnNextQual.Enabled = false;
         btnLastQual.Enabled = false;
         btnPrevQual.Enabled = false;
         btnFirstQual.Enabled = false;
         btnNewQual.Enabled = false;

         btnNextExp.Enabled = false;
         btnLastExp.Enabled = false;
         btnPrevExp.Enabled = false;
         btnFirstExp.Enabled = false;
         btnNewExp.Enabled = false;

         btnSearch.Enabled = false;
         btnSearchAll.Enabled = false;

         if (c != 'm')
         {
            btnSaveEmp.Enabled = false;
            btnDeleteEmp.Enabled = false;
         }
         if (c != 'q')
         {
            btnSaveQual.Enabled = false;
            btnDeleteQual.Enabled = false;
         }
         if (c != 'x')
         {
            btnSaveExp.Enabled = false;
            btnDeleteExp.Enabled = false;
         }
      }
      

   }
}


