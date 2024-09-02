namespace LibraryManagement
{
    partial class IssueBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBooks));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnSearch = new Button();
            btnExit = new Button();
            btnRefresh = new Button();
            txtEnrollNo = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label10 = new Label();
            btnIssueBooks = new Button();
            dtpIssdate = new DateTimePicker();
            cmbBookName = new ComboBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtSemester = new TextBox();
            txtDept = new TextBox();
            txtStudentName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 194);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(589, 78);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 1;
            label1.Text = "Issue Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(321, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(txtEnrollNo);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(2, 195);
            panel2.Name = "panel2";
            panel2.Size = new Size(383, 520);
            panel2.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Location = new Point(66, 262);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(226, 44);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "&Search Student";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Location = new Point(197, 383);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(104, 39);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Location = new Point(57, 383);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 39);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "&Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtEnrollNo
            // 
            txtEnrollNo.BorderStyle = BorderStyle.FixedSingle;
            txtEnrollNo.Location = new Point(48, 208);
            txtEnrollNo.Name = "txtEnrollNo";
            txtEnrollNo.Size = new Size(276, 27);
            txtEnrollNo.TabIndex = 0;
            txtEnrollNo.Text = " ";
            txtEnrollNo.KeyDown += txtEnrollNo_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 167);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 4;
            label2.Text = "Enter Enrollment NO";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(120, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(113, 105);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(192, 255, 255);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(btnIssueBooks);
            panel3.Controls.Add(dtpIssdate);
            panel3.Controls.Add(cmbBookName);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtContact);
            panel3.Controls.Add(txtSemester);
            panel3.Controls.Add(txtDept);
            panel3.Controls.Add(txtStudentName);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(386, 196);
            panel3.Name = "panel3";
            panel3.Size = new Size(646, 519);
            panel3.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(220, 479);
            label10.Name = "label10";
            label10.Size = new Size(366, 20);
            label10.TabIndex = 15;
            label10.Text = "Maximum 3 Books can be ISSUED to 1 Student";
            // 
            // btnIssueBooks
            // 
            btnIssueBooks.FlatStyle = FlatStyle.Popup;
            btnIssueBooks.Location = new Point(404, 436);
            btnIssueBooks.Name = "btnIssueBooks";
            btnIssueBooks.Size = new Size(152, 31);
            btnIssueBooks.TabIndex = 7;
            btnIssueBooks.Text = "&Issue Books";
            btnIssueBooks.UseVisualStyleBackColor = true;
            btnIssueBooks.Click += btnIssueBooks_Click;
            // 
            // dtpIssdate
            // 
            dtpIssdate.Location = new Point(242, 396);
            dtpIssdate.Name = "dtpIssdate";
            dtpIssdate.Size = new Size(276, 27);
            dtpIssdate.TabIndex = 6;
            dtpIssdate.KeyDown += dtpIssdate_KeyDown;
            // 
            // cmbBookName
            // 
            cmbBookName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBookName.FormattingEnabled = true;
            cmbBookName.Location = new Point(242, 340);
            cmbBookName.Name = "cmbBookName";
            cmbBookName.Size = new Size(276, 28);
            cmbBookName.TabIndex = 5;
            cmbBookName.KeyDown += cmbBookName_KeyDown;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(242, 282);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(276, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Location = new Point(242, 227);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(276, 27);
            txtContact.TabIndex = 3;
            // 
            // txtSemester
            // 
            txtSemester.BorderStyle = BorderStyle.FixedSingle;
            txtSemester.Location = new Point(242, 169);
            txtSemester.Name = "txtSemester";
            txtSemester.ReadOnly = true;
            txtSemester.Size = new Size(276, 27);
            txtSemester.TabIndex = 2;
            // 
            // txtDept
            // 
            txtDept.BorderStyle = BorderStyle.FixedSingle;
            txtDept.Location = new Point(242, 111);
            txtDept.Name = "txtDept";
            txtDept.ReadOnly = true;
            txtDept.Size = new Size(276, 27);
            txtDept.TabIndex = 1;
            // 
            // txtStudentName
            // 
            txtStudentName.BorderStyle = BorderStyle.FixedSingle;
            txtStudentName.Location = new Point(242, 50);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.ReadOnly = true;
            txtStudentName.Size = new Size(276, 27);
            txtStudentName.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 401);
            label9.Name = "label9";
            label9.Size = new Size(124, 20);
            label9.TabIndex = 14;
            label9.Text = "Book Issue Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 343);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 13;
            label8.Text = "Book Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 285);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 12;
            label7.Text = "Student Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 227);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 11;
            label6.Text = "Student Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 169);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 10;
            label5.Text = "Student Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 111);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 9;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 53);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 8;
            label3.Text = "Student Name";
            // 
            // IssueBooks
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(976, 718);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            Name = "IssueBooks";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += IssueBooks_Load;
            KeyDown += IssueBooks_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox2;
        private Button btnExit;
        private Button btnRefresh;
        private TextBox txtEnrollNo;
        private Label label2;
        private Label label10;
        private Button btnIssueBooks;
        private DateTimePicker dtpIssdate;
        private ComboBox cmbBookName;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtSemester;
        private TextBox txtDept;
        private TextBox txtStudentName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnSearch;
    }
}