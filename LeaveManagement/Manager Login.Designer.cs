
namespace LeaveManagement
{
    partial class Manager_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.employeeIdLbl = new System.Windows.Forms.Label();
            this.securityIdLbl = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.employeeIdtxt = new System.Windows.Forms.TextBox();
            this.securityIdtxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(189, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // employeeIdLbl
            // 
            this.employeeIdLbl.AutoSize = true;
            this.employeeIdLbl.Location = new System.Drawing.Point(80, 246);
            this.employeeIdLbl.Name = "employeeIdLbl";
            this.employeeIdLbl.Size = new System.Drawing.Size(65, 13);
            this.employeeIdLbl.TabIndex = 1;
            this.employeeIdLbl.Text = "Employee Id";
            // 
            // securityIdLbl
            // 
            this.securityIdLbl.AutoSize = true;
            this.securityIdLbl.Location = new System.Drawing.Point(83, 320);
            this.securityIdLbl.Name = "securityIdLbl";
            this.securityIdLbl.Size = new System.Drawing.Size(57, 13);
            this.securityIdLbl.TabIndex = 2;
            this.securityIdLbl.Text = "Security Id";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(381, 187);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 3;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // employeeIdtxt
            // 
            this.employeeIdtxt.Location = new System.Drawing.Point(189, 246);
            this.employeeIdtxt.Name = "employeeIdtxt";
            this.employeeIdtxt.Size = new System.Drawing.Size(156, 20);
            this.employeeIdtxt.TabIndex = 4;
            // 
            // securityIdtxt
            // 
            this.securityIdtxt.Location = new System.Drawing.Point(189, 320);
            this.securityIdtxt.Name = "securityIdtxt";
            this.securityIdtxt.Size = new System.Drawing.Size(156, 20);
            this.securityIdtxt.TabIndex = 5;
            this.securityIdtxt.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(253, 409);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(93, 409);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Manager_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(485, 539);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.securityIdtxt);
            this.Controls.Add(this.employeeIdtxt);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.securityIdLbl);
            this.Controls.Add(this.employeeIdLbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Manager_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager_Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label employeeIdLbl;
        private System.Windows.Forms.Label securityIdLbl;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.TextBox employeeIdtxt;
        private System.Windows.Forms.TextBox securityIdtxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button backBtn;
    }
}