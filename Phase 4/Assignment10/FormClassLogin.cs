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
   public partial class FormClassLogin : Form
   {
      public FormClassLogin()
      {
         InitializeComponent();
      }

      private void label1_Click(object sender, EventArgs e)
      {

      }

      private void label3_Click(object sender, EventArgs e)
      {

      }

      private void btnLogin_Click(object sender, EventArgs e)
      {
         Oracle.UserName = txtBoxUsername.Text;
         Oracle.PassWd = txtBoxPassword.Text;
         Oracle.Server = txtBoxHost.Text;

         Oracle.Result = Oracle.ResponseType.OK;
         this.Close();
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         Oracle.Result = Oracle.ResponseType.Cancel;
         this.Close();
      }
   }
}
