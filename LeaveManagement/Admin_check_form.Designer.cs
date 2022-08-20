
namespace LeaveManagement
{
    partial class Admin_check_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_check_form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.employeeIdBtn = new System.Windows.Forms.Label();
            this.employeeIdtxt = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.employeeName = new System.Windows.Forms.Label();
            this.fromDateLbl = new System.Windows.Forms.Label();
            this.employeeNametxt = new System.Windows.Forms.TextBox();
            this.designationtxt = new System.Windows.Forms.TextBox();
            this.toDateLbl = new System.Windows.Forms.Label();
            this.designationLbl = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.rejectBtn = new System.Windows.Forms.Button();
            this.fromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(59, 185);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 1;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 257);
            this.dataGridView1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(862, 226);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // employeeIdBtn
            // 
            this.employeeIdBtn.AutoSize = true;
            this.employeeIdBtn.Location = new System.Drawing.Point(223, 502);
            this.employeeIdBtn.Name = "employeeIdBtn";
            this.employeeIdBtn.Size = new System.Drawing.Size(16, 13);
            this.employeeIdBtn.TabIndex = 4;
            this.employeeIdBtn.Text = "Id";
            // 
            // employeeIdtxt
            // 
            this.employeeIdtxt.Location = new System.Drawing.Point(327, 502);
            this.employeeIdtxt.Name = "employeeIdtxt";
            this.employeeIdtxt.Size = new System.Drawing.Size(100, 20);
            this.employeeIdtxt.TabIndex = 5;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(462, 500);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 6;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.ok_Click);
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.Location = new System.Drawing.Point(94, 546);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(84, 13);
            this.employeeName.TabIndex = 7;
            this.employeeName.Text = "Employee Name";
            // 
            // fromDateLbl
            // 
            this.fromDateLbl.AutoSize = true;
            this.fromDateLbl.Location = new System.Drawing.Point(97, 596);
            this.fromDateLbl.Name = "fromDateLbl";
            this.fromDateLbl.Size = new System.Drawing.Size(56, 13);
            this.fromDateLbl.TabIndex = 8;
            this.fromDateLbl.Text = "From Date";
            // 
            // employeeNametxt
            // 
            this.employeeNametxt.Location = new System.Drawing.Point(194, 546);
            this.employeeNametxt.Name = "employeeNametxt";
            this.employeeNametxt.Size = new System.Drawing.Size(100, 20);
            this.employeeNametxt.TabIndex = 9;
            // 
            // designationtxt
            // 
            this.designationtxt.Location = new System.Drawing.Point(527, 546);
            this.designationtxt.Name = "designationtxt";
            this.designationtxt.Size = new System.Drawing.Size(100, 20);
            this.designationtxt.TabIndex = 13;
            // 
            // toDateLbl
            // 
            this.toDateLbl.AutoSize = true;
            this.toDateLbl.Location = new System.Drawing.Point(430, 596);
            this.toDateLbl.Name = "toDateLbl";
            this.toDateLbl.Size = new System.Drawing.Size(46, 13);
            this.toDateLbl.TabIndex = 12;
            this.toDateLbl.Text = "To Date";
            // 
            // designationLbl
            // 
            this.designationLbl.AutoSize = true;
            this.designationLbl.Location = new System.Drawing.Point(427, 546);
            this.designationLbl.Name = "designationLbl";
            this.designationLbl.Size = new System.Drawing.Size(63, 13);
            this.designationLbl.TabIndex = 11;
            this.designationLbl.Text = "Designation";
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(338, 645);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 23);
            this.acceptBtn.TabIndex = 15;
            this.acceptBtn.Text = "Accept";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // rejectBtn
            // 
            this.rejectBtn.Location = new System.Drawing.Point(442, 645);
            this.rejectBtn.Name = "rejectBtn";
            this.rejectBtn.Size = new System.Drawing.Size(75, 23);
            this.rejectBtn.TabIndex = 16;
            this.rejectBtn.Text = "Reject";
            this.rejectBtn.UseVisualStyleBackColor = true;
            this.rejectBtn.Click += new System.EventHandler(this.rejectBtn_Click);
            // 
            // fromTimePicker
            // 
            this.fromTimePicker.Location = new System.Drawing.Point(194, 596);
            this.fromTimePicker.Name = "fromTimePicker";
            this.fromTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromTimePicker.TabIndex = 17;
            // 
            // toTimePicker
            // 
            this.toTimePicker.Location = new System.Drawing.Point(527, 596);
            this.toTimePicker.Name = "toTimePicker";
            this.toTimePicker.Size = new System.Drawing.Size(200, 20);
            this.toTimePicker.TabIndex = 18;
            // 
            // Admin_check_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(974, 696);
            this.Controls.Add(this.toTimePicker);
            this.Controls.Add(this.fromTimePicker);
            this.Controls.Add(this.rejectBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.designationtxt);
            this.Controls.Add(this.toDateLbl);
            this.Controls.Add(this.designationLbl);
            this.Controls.Add(this.employeeNametxt);
            this.Controls.Add(this.fromDateLbl);
            this.Controls.Add(this.employeeName);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.employeeIdtxt);
            this.Controls.Add(this.employeeIdBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Admin_check_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_check_form";
            this.Load += new System.EventHandler(this.Admin_check_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label employeeIdBtn;
        private System.Windows.Forms.TextBox employeeIdtxt;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.Label fromDateLbl;
        private System.Windows.Forms.TextBox employeeNametxt;
        private System.Windows.Forms.TextBox designationtxt;
        private System.Windows.Forms.Label toDateLbl;
        private System.Windows.Forms.Label designationLbl;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button rejectBtn;
        private System.Windows.Forms.DateTimePicker fromTimePicker;
        private System.Windows.Forms.DateTimePicker toTimePicker;
    }
}