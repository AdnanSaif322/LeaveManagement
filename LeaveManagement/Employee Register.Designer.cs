
namespace LeaveManagement
{
    partial class Employee_Register
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
            this.employeeIdLbl = new System.Windows.Forms.Label();
            this.securityIdLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.designation = new System.Windows.Forms.Label();
            this.employeeIdtxt = new System.Windows.Forms.TextBox();
            this.securityIdtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.designationtxt = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeIdLbl
            // 
            this.employeeIdLbl.AutoSize = true;
            this.employeeIdLbl.Location = new System.Drawing.Point(144, 51);
            this.employeeIdLbl.Name = "employeeIdLbl";
            this.employeeIdLbl.Size = new System.Drawing.Size(65, 13);
            this.employeeIdLbl.TabIndex = 0;
            this.employeeIdLbl.Text = "Employee Id";
            // 
            // securityIdLbl
            // 
            this.securityIdLbl.AutoSize = true;
            this.securityIdLbl.Location = new System.Drawing.Point(147, 108);
            this.securityIdLbl.Name = "securityIdLbl";
            this.securityIdLbl.Size = new System.Drawing.Size(57, 13);
            this.securityIdLbl.TabIndex = 1;
            this.securityIdLbl.Text = "Security Id";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(147, 164);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(35, 13);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Name";
            // 
            // designation
            // 
            this.designation.AutoSize = true;
            this.designation.Location = new System.Drawing.Point(147, 221);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(63, 13);
            this.designation.TabIndex = 3;
            this.designation.Text = "Designation";
            // 
            // employeeIdtxt
            // 
            this.employeeIdtxt.Location = new System.Drawing.Point(221, 51);
            this.employeeIdtxt.Name = "employeeIdtxt";
            this.employeeIdtxt.Size = new System.Drawing.Size(159, 20);
            this.employeeIdtxt.TabIndex = 4;
            // 
            // securityIdtxt
            // 
            this.securityIdtxt.Location = new System.Drawing.Point(221, 108);
            this.securityIdtxt.Name = "securityIdtxt";
            this.securityIdtxt.Size = new System.Drawing.Size(159, 20);
            this.securityIdtxt.TabIndex = 5;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(221, 164);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(159, 20);
            this.nametxt.TabIndex = 6;
            // 
            // designationtxt
            // 
            this.designationtxt.Location = new System.Drawing.Point(221, 221);
            this.designationtxt.Name = "designationtxt";
            this.designationtxt.Size = new System.Drawing.Size(159, 20);
            this.designationtxt.TabIndex = 7;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(158, 287);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(291, 287);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 9;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // Employee_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(561, 408);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.designationtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.securityIdtxt);
            this.Controls.Add(this.employeeIdtxt);
            this.Controls.Add(this.designation);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.securityIdLbl);
            this.Controls.Add(this.employeeIdLbl);
            this.Name = "Employee_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeIdLbl;
        private System.Windows.Forms.Label securityIdLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label designation;
        private System.Windows.Forms.TextBox employeeIdtxt;
        private System.Windows.Forms.TextBox securityIdtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox designationtxt;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button okBtn;
    }
}