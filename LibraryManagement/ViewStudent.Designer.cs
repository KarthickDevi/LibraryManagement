namespace LibraryManagement
{
    partial class ViewStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudent));
            panel1 = new Panel();
            label9 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtEnrollmentno = new TextBox();
            btnRefresh = new Button();
            dgView = new DataGridView();
            panel2 = new Panel();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtSemester = new TextBox();
            txtDept = new TextBox();
            txtEnroll = new TextBox();
            txtStudentName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(4, 1);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1429, 204);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Century", 12F, FontStyle.Bold);
            label9.Location = new Point(839, 100);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(91, 23);
            label9.TabIndex = 2;
            label9.Text = "Student";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century", 12F, FontStyle.Bold);
            label1.Location = new Point(839, 77);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 23);
            label1.TabIndex = 1;
            label1.Text = "View";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(622, 1);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 222);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 1;
            label2.Text = "Enrollment No";
            // 
            // txtEnrollmentno
            // 
            txtEnrollmentno.BorderStyle = BorderStyle.FixedSingle;
            txtEnrollmentno.Location = new Point(622, 220);
            txtEnrollmentno.Margin = new Padding(4);
            txtEnrollmentno.Name = "txtEnrollmentno";
            txtEnrollmentno.Size = new Size(261, 28);
            txtEnrollmentno.TabIndex = 2;
            txtEnrollmentno.TextChanged += txtEnrollmentno_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Location = new Point(900, 220);
            btnRefresh.Margin = new Padding(4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(118, 30);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgView
            // 
            dgView.AllowUserToAddRows = false;
            dgView.AllowUserToDeleteRows = false;
            dgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgView.Location = new Point(4, 272);
            dgView.Margin = new Padding(4);
            dgView.Name = "dgView";
            dgView.RowHeadersWidth = 51;
            dgView.Size = new Size(1429, 356);
            dgView.TabIndex = 4;
            dgView.CellDoubleClick += dgView_CellDoubleClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(txtSemester);
            panel2.Controls.Add(txtDept);
            panel2.Controls.Add(txtEnroll);
            panel2.Controls.Add(txtStudentName);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(4, 636);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1429, 374);
            panel2.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Location = new Point(1245, 306);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(122, 40);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Location = new Point(1042, 306);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(122, 40);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Location = new Point(839, 306);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(122, 40);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Century", 10.8F);
            txtEmail.Location = new Point(934, 218);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(296, 29);
            txtEmail.TabIndex = 11;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Font = new Font("Century", 10.8F);
            txtContact.Location = new Point(934, 128);
            txtContact.Margin = new Padding(4);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(296, 29);
            txtContact.TabIndex = 10;
            txtContact.KeyDown += txtContact_KeyDown;
            // 
            // txtSemester
            // 
            txtSemester.BorderStyle = BorderStyle.FixedSingle;
            txtSemester.Font = new Font("Century", 10.8F);
            txtSemester.Location = new Point(934, 35);
            txtSemester.Margin = new Padding(4);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(296, 29);
            txtSemester.TabIndex = 9;
            txtSemester.KeyDown += txtSemester_KeyDown;
            // 
            // txtDept
            // 
            txtDept.BorderStyle = BorderStyle.FixedSingle;
            txtDept.Font = new Font("Century", 10.8F);
            txtDept.Location = new Point(264, 218);
            txtDept.Margin = new Padding(4);
            txtDept.Name = "txtDept";
            txtDept.Size = new Size(296, 29);
            txtDept.TabIndex = 8;
            txtDept.KeyDown += txtDept_KeyDown;
            // 
            // txtEnroll
            // 
            txtEnroll.BorderStyle = BorderStyle.FixedSingle;
            txtEnroll.Font = new Font("Century", 10.8F);
            txtEnroll.Location = new Point(264, 128);
            txtEnroll.Margin = new Padding(4);
            txtEnroll.Name = "txtEnroll";
            txtEnroll.Size = new Size(296, 29);
            txtEnroll.TabIndex = 7;
            txtEnroll.KeyDown += txtEnroll_KeyDown;
            // 
            // txtStudentName
            // 
            txtStudentName.BorderStyle = BorderStyle.FixedSingle;
            txtStudentName.Font = new Font("Century", 10.8F);
            txtStudentName.Location = new Point(268, 35);
            txtStudentName.Margin = new Padding(4);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(296, 29);
            txtStudentName.TabIndex = 6;
            txtStudentName.KeyDown += txtStudentName_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(714, 221);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(125, 21);
            label8.TabIndex = 5;
            label8.Text = "Student Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(714, 131);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(141, 21);
            label7.TabIndex = 4;
            label7.Text = "Student Contact";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(714, 38);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(155, 21);
            label6.TabIndex = 3;
            label6.Text = "Student Semester";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 221);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 2;
            label5.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 131);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(128, 21);
            label4.TabIndex = 1;
            label4.Text = "Enrollment No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 38);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 21);
            label3.TabIndex = 0;
            label3.Text = "Student Name";
            // 
            // ViewStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1427, 619);
            Controls.Add(panel2);
            Controls.Add(dgView);
            Controls.Add(btnRefresh);
            Controls.Add(txtEnrollmentno);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            Name = "ViewStudent";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewStudent";
            Load += ViewStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtEnrollmentno;
        private Button btnRefresh;
        private DataGridView dgView;
        private Panel panel2;
        private TextBox txtStudentName;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtSemester;
        private TextBox txtDept;
        private TextBox txtEnroll;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private Label label9;
    }
}