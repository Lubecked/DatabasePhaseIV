namespace Assignment10
{
   partial class FormClassLogin
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.txtBoxUsername = new System.Windows.Forms.TextBox();
         this.txtBoxHost = new System.Windows.Forms.TextBox();
         this.txtBoxPassword = new System.Windows.Forms.TextBox();
         this.btnLogin = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // txtBoxUsername
         // 
         this.txtBoxUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txtBoxUsername.Location = new System.Drawing.Point(337, 63);
         this.txtBoxUsername.Name = "txtBoxUsername";
         this.txtBoxUsername.Size = new System.Drawing.Size(100, 20);
         this.txtBoxUsername.TabIndex = 0;
         // 
         // txtBoxHost
         // 
         this.txtBoxHost.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txtBoxHost.Location = new System.Drawing.Point(337, 200);
         this.txtBoxHost.Name = "txtBoxHost";
         this.txtBoxHost.Size = new System.Drawing.Size(100, 20);
         this.txtBoxHost.TabIndex = 2;
         // 
         // txtBoxPassword
         // 
         this.txtBoxPassword.Location = new System.Drawing.Point(337, 138);
         this.txtBoxPassword.Name = "txtBoxPassword";
         this.txtBoxPassword.PasswordChar = '*';
         this.txtBoxPassword.Size = new System.Drawing.Size(100, 20);
         this.txtBoxPassword.TabIndex = 1;
         // 
         // btnLogin
         // 
         this.btnLogin.Location = new System.Drawing.Point(152, 293);
         this.btnLogin.Name = "btnLogin";
         this.btnLogin.Size = new System.Drawing.Size(75, 23);
         this.btnLogin.TabIndex = 3;
         this.btnLogin.Text = "Login";
         this.btnLogin.UseVisualStyleBackColor = true;
         this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.Location = new System.Drawing.Point(520, 293);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 4;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(337, 44);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(57, 13);
         this.label1.TabIndex = 5;
         this.label1.Text = "UserName";
         this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(337, 119);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(53, 13);
         this.label2.TabIndex = 6;
         this.label2.Text = "Password";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(337, 181);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(59, 13);
         this.label3.TabIndex = 7;
         this.label3.Text = "Host String";
         this.label3.Click += new System.EventHandler(this.label3_Click);
         // 
         // FormClassLogin
         // 
         this.AcceptButton = this.btnLogin;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = global::Assignment10.Properties.Resources.o_SLEEPY_CAT_WATERMELON_facebook;
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.ClientSize = new System.Drawing.Size(825, 393);
         this.ControlBox = false;
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnLogin);
         this.Controls.Add(this.txtBoxPassword);
         this.Controls.Add(this.txtBoxHost);
         this.Controls.Add(this.txtBoxUsername);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FormClassLogin";
         this.Text = "Login";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtBoxUsername;
      private System.Windows.Forms.TextBox txtBoxHost;
      private System.Windows.Forms.TextBox txtBoxPassword;
      private System.Windows.Forms.Button btnLogin;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
   }
}