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
         txtStaffNo.DataBindings.Add("Text", Oracle.staffTable, "staffNo");
         txtFName.DataBindings.Add("Text", Oracle.staffTable, "fName");
         txtLName.DataBindings.Add("Text", Oracle.staffTable, "lName");
         txtStreet.DataBindings.Add("Text", Oracle.staffTable, "street");
         txtCity.DataBindings.Add("Text", Oracle.staffTable, "city");
         txtState.DataBindings.Add("Text", Oracle.staffTable, "state");
         txtZIP.DataBindings.Add("Text", Oracle.staffTable, "zip");
         txtPhone.DataBindings.Add("Text", Oracle.staffTable, "phone");
         dtpDOB.DataBindings.Add("Text", Oracle.staffTable, "DOB");
         txtGender.DataBindings.Add("Text", Oracle.staffTable, "gender");
         txtNIN.DataBindings.Add("Text", Oracle.staffTable, "NIN");
         txtPosition.DataBindings.Add("Text", Oracle.staffTable, "position");
         txtCurSalary.DataBindings.Add("Text", Oracle.staffTable, "curSalary");
         txtSalaryScale.DataBindings.Add("Text", Oracle.staffTable, "salaryScale");
         txtHours.DataBindings.Add("Text", Oracle.staffTable, "hrsPerWk");
         txtPosPermTemp.DataBindings.Add("Text", Oracle.staffTable, "posPermTemp");
         txtTypePay.DataBindings.Add("Text", Oracle.staffTable, "typeOfPay");
      }
      
   }
}
