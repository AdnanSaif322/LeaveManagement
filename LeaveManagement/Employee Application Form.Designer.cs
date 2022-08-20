
namespace LeaveManagement
{
    partial class Employee_Application_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Application_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.applicationformLbl = new System.Windows.Forms.Label();
            this.employeeIdLbl = new System.Windows.Forms.Label();
            this.securityIdLbl = new System.Windows.Forms.Label();
            this.designationLbl = new System.Windows.Forms.Label();
            this.employeeNameLbl = new System.Windows.Forms.Label();
            this.fromDateLbl = new System.Windows.Forms.Label();
            this.leaveStatusLbl = new System.Windows.Forms.Label();
            this.toDateLbl = new System.Windows.Forms.Label();
            this.employeeIdtxt = new System.Windows.Forms.TextBox();
            this.securityIdtxt = new System.Windows.Forms.TextBox();
            this.employeeNametxt = new System.Windows.Forms.TextBox();
            this.designationtxt = new System.Windows.Forms.TextBox();
            this.fromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkStatusBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.leaveStatusComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(13, 163);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(75, 23);
            this.logOutBtn.TabIndex = 1;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // applicationformLbl
            // 
            this.applicationformLbl.AutoSize = true;
            this.applicationformLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.applicationformLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationformLbl.Location = new System.Drawing.Point(182, 190);
            this.applicationformLbl.Name = "applicationformLbl";
            this.applicationformLbl.Size = new System.Drawing.Size(152, 22);
            this.applicationformLbl.TabIndex = 2;
            this.applicationformLbl.Text = "Application Form";
            // 
            // employeeIdLbl
            // 
            this.employeeIdLbl.AutoSize = true;
            this.employeeIdLbl.Location = new System.Drawing.Point(93, 255);
            this.employeeIdLbl.Name = "employeeIdLbl";
            this.employeeIdLbl.Size = new System.Drawing.Size(65, 13);
            this.employeeIdLbl.TabIndex = 3;
            this.employeeIdLbl.Text = "Employee Id";
            // 
            // securityIdLbl
            // 
            this.securityIdLbl.AutoSize = true;
            this.securityIdLbl.Location = new System.Drawing.Point(96, 296);
            this.securityIdLbl.Name = "securityIdLbl";
            this.securityIdLbl.Size = new System.Drawing.Size(57, 13);
            this.securityIdLbl.TabIndex = 4;
            this.securityIdLbl.Text = "Security Id";
            // 
            // designationLbl
            // 
            this.designationLbl.AutoSize = true;
            this.designationLbl.Location = new System.Drawing.Point(96, 372);
            this.designationLbl.Name = "designationLbl";
            this.designationLbl.Size = new System.Drawing.Size(63, 13);
            this.designationLbl.TabIndex = 6;
            this.designationLbl.Text = "Designation";
            // 
            // employeeNameLbl
            // 
            this.employeeNameLbl.AutoSize = true;
            this.employeeNameLbl.Location = new System.Drawing.Point(93, 331);
            this.employeeNameLbl.Name = "employeeNameLbl";
            this.employeeNameLbl.Size = new System.Drawing.Size(84, 13);
            this.employeeNameLbl.TabIndex = 5;
            this.employeeNameLbl.Text = "Employee Name";
            // 
            // fromDateLbl
            // 
            this.fromDateLbl.AutoSize = true;
            this.fromDateLbl.Location = new System.Drawing.Point(96, 455);
            this.fromDateLbl.Name = "fromDateLbl";
            this.fromDateLbl.Size = new System.Drawing.Size(56, 13);
            this.fromDateLbl.TabIndex = 8;
            this.fromDateLbl.Text = "From Date";
            // 
            // leaveStatusLbl
            // 
            this.leaveStatusLbl.AutoSize = true;
            this.leaveStatusLbl.Location = new System.Drawing.Point(93, 414);
            this.leaveStatusLbl.Name = "leaveStatusLbl";
            this.leaveStatusLbl.Size = new System.Drawing.Size(70, 13);
            this.leaveStatusLbl.TabIndex = 7;
            this.leaveStatusLbl.Text = "Leave Status";
            // 
            // toDateLbl
            // 
            this.toDateLbl.AutoSize = true;
            this.toDateLbl.Location = new System.Drawing.Point(93, 491);
            this.toDateLbl.Name = "toDateLbl";
            this.toDateLbl.Size = new System.Drawing.Size(46, 13);
            this.toDateLbl.TabIndex = 9;
            this.toDateLbl.Text = "To Date";
            // 
            // employeeIdtxt
            // 
            this.employeeIdtxt.Location = new System.Drawing.Point(186, 255);
            this.employeeIdtxt.Name = "employeeIdtxt";
            this.employeeIdtxt.Size = new System.Drawing.Size(132, 20);
            this.employeeIdtxt.TabIndex = 10;
            // 
            // securityIdtxt
            // 
            this.securityIdtxt.Location = new System.Drawing.Point(186, 296);
            this.securityIdtxt.Name = "securityIdtxt";
            this.securityIdtxt.Size = new System.Drawing.Size(132, 20);
            this.securityIdtxt.TabIndex = 11;
            this.securityIdtxt.UseSystemPasswordChar = true;
            this.securityIdtxt.TextChanged += new System.EventHandler(this.securityIdtxt_TextChanged);
            // 
            // employeeNametxt
            // 
            this.employeeNametxt.Location = new System.Drawing.Point(186, 331);
            this.employeeNametxt.Name = "employeeNametxt";
            this.employeeNametxt.Size = new System.Drawing.Size(132, 20);
            this.employeeNametxt.TabIndex = 12;
            // 
            // designationtxt
            // 
            this.designationtxt.Location = new System.Drawing.Point(186, 372);
            this.designationtxt.Name = "designationtxt";
            this.designationtxt.Size = new System.Drawing.Size(132, 20);
            this.designationtxt.TabIndex = 13;
            // 
            // fromTimePicker
            // 
            this.fromTimePicker.Location = new System.Drawing.Point(186, 455);
            this.fromTimePicker.Name = "fromTimePicker";
            this.fromTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromTimePicker.TabIndex = 15;
            // 
            // toTimePicker
            // 
            this.toTimePicker.Location = new System.Drawing.Point(186, 491);
            this.toTimePicker.Name = "toTimePicker";
            this.toTimePicker.Size = new System.Drawing.Size(200, 20);
            this.toTimePicker.TabIndex = 16;
            // 
            // checkStatusBtn
            // 
            this.checkStatusBtn.Location = new System.Drawing.Point(438, 225);
            this.checkStatusBtn.Name = "checkStatusBtn";
            this.checkStatusBtn.Size = new System.Drawing.Size(108, 23);
            this.checkStatusBtn.TabIndex = 17;
            this.checkStatusBtn.Text = "Check Status";
            this.checkStatusBtn.UseVisualStyleBackColor = true;
            this.checkStatusBtn.Click += new System.EventHandler(this.checkStatusBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(245, 556);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 18;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(438, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // leaveStatusComboBox
            // 
            this.leaveStatusComboBox.FormattingEnabled = true;
            this.leaveStatusComboBox.Items.AddRange(new object[] {
            "Half-Day",
            "Full-Day"});
            this.leaveStatusComboBox.Location = new System.Drawing.Point(186, 414);
            this.leaveStatusComboBox.Name = "leaveStatusComboBox";
            this.leaveStatusComboBox.Size = new System.Drawing.Size(132, 21);
            this.leaveStatusComboBox.TabIndex = 20;
            // 
            // Employee_Application_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(568, 617);
            this.Controls.Add(this.leaveStatusComboBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.checkStatusBtn);
            this.Controls.Add(this.toTimePicker);
            this.Controls.Add(this.fromTimePicker);
            this.Controls.Add(this.designationtxt);
            this.Controls.Add(this.employeeNametxt);
            this.Controls.Add(this.securityIdtxt);
            this.Controls.Add(this.employeeIdtxt);
            this.Controls.Add(this.toDateLbl);
            this.Controls.Add(this.fromDateLbl);
            this.Controls.Add(this.leaveStatusLbl);
            this.Controls.Add(this.designationLbl);
            this.Controls.Add(this.employeeNameLbl);
            this.Controls.Add(this.securityIdLbl);
            this.Controls.Add(this.employeeIdLbl);
            this.Controls.Add(this.applicationformLbl);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Employee_Application_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Application_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Label applicationformLbl;
        private System.Windows.Forms.Label employeeIdLbl;
        private System.Windows.Forms.Label securityIdLbl;
        private System.Windows.Forms.Label designationLbl;
        private System.Windows.Forms.Label employeeNameLbl;
        private System.Windows.Forms.Label fromDateLbl;
        private System.Windows.Forms.Label leaveStatusLbl;
        private System.Windows.Forms.Label toDateLbl;
        private System.Windows.Forms.TextBox employeeIdtxt;
        private System.Windows.Forms.TextBox securityIdtxt;
        private System.Windows.Forms.TextBox employeeNametxt;
        private System.Windows.Forms.TextBox designationtxt;
        private System.Windows.Forms.DateTimePicker fromTimePicker;
        private System.Windows.Forms.DateTimePicker toTimePicker;
        private System.Windows.Forms.Button checkStatusBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox leaveStatusComboBox;
    }
}