namespace LibraryManagement
{
    partial class AddStudentcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentcs));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtStudentName = new TextBox();
            txtDepartment = new TextBox();
            txtEnrollNo = new TextBox();
            txtSemester = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            btnRefresh = new Button();
            btnSave = new Button();
            btnExit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 131);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(392, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 132);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(392, 558);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(442, 194);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 2;
            label1.Text = "Student Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 260);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 3;
            label2.Text = "Enrollment No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 326);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 4;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(442, 392);
            label4.Name = "label4";
            label4.Size = new Size(155, 21);
            label4.TabIndex = 5;
            label4.Text = "Student Semester";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(442, 458);
            label5.Name = "label5";
            label5.Size = new Size(141, 21);
            label5.TabIndex = 6;
            label5.Text = "Student Contact";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(442, 524);
            label6.Name = "label6";
            label6.Size = new Size(125, 21);
            label6.TabIndex = 7;
            label6.Text = "Student Email";
            // 
            // txtStudentName
            // 
            txtStudentName.BorderStyle = BorderStyle.FixedSingle;
            txtStudentName.Location = new Point(654, 191);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(297, 28);
            txtStudentName.TabIndex = 0;
            txtStudentName.KeyDown += txtStudentName_KeyDown;
            // 
            // txtDepartment
            // 
            txtDepartment.BorderStyle = BorderStyle.FixedSingle;
            txtDepartment.Location = new Point(654, 319);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(297, 28);
            txtDepartment.TabIndex = 2;
            txtDepartment.KeyDown += txtDepartment_KeyDown;
            // 
            // txtEnrollNo
            // 
            txtEnrollNo.BorderStyle = BorderStyle.FixedSingle;
            txtEnrollNo.Location = new Point(654, 253);
            txtEnrollNo.Name = "txtEnrollNo";
            txtEnrollNo.Size = new Size(297, 28);
            txtEnrollNo.TabIndex = 1;
            txtEnrollNo.KeyDown += txtEnrollNo_KeyDown;
            // 
            // txtSemester
            // 
            txtSemester.BorderStyle = BorderStyle.FixedSingle;
            txtSemester.Location = new Point(654, 385);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(297, 28);
            txtSemester.TabIndex = 3;
            txtSemester.KeyDown += txtSemester_KeyDown;
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Location = new Point(654, 451);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(297, 28);
            txtContact.TabIndex = 4;
            txtContact.KeyDown += txtContact_KeyDown;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(654, 524);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(297, 28);
            txtEmail.TabIndex = 5;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Century", 10.8F, FontStyle.Bold);
            btnRefresh.Location = new Point(548, 618);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 37);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Century", 10.8F, FontStyle.Bold);
            btnSave.Location = new Point(712, 618);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 37);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save Info";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Century", 10.8F, FontStyle.Bold);
            btnExit.Location = new Point(876, 618);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 37);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // AddStudentcs
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1044, 688);
            ControlBox = false;
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnRefresh);
            Controls.Add(txtEmail);
            Controls.Add(txtContact);
            Controls.Add(txtSemester);
            Controls.Add(txtEnrollNo);
            Controls.Add(txtDepartment);
            Controls.Add(txtStudentName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "AddStudentcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudentcs";
            Load += AddStudentcs_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtStudentName;
        private TextBox txtDepartment;
        private TextBox txtEnrollNo;
        private TextBox txtSemester;
        private TextBox txtContact;
        private TextBox txtEmail;
        private Button btnRefresh;
        private Button btnSave;
        private Button btnExit;
    }
}