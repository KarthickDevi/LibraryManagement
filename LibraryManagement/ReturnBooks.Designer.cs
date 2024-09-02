namespace LibraryManagement
{
    partial class ReturnBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBooks));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtEnrollNo = new TextBox();
            label4 = new Label();
            btnExit = new Button();
            btnRefresh = new Button();
            btnSearch = new Button();
            panel2 = new Panel();
            btnCancel = new Button();
            btnReturn = new Button();
            dtpReturnDate = new DateTimePicker();
            txtIssuedate = new TextBox();
            txtBookName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtEnrollNo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnSearch);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 548);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(112, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txtEnrollNo
            // 
            txtEnrollNo.BorderStyle = BorderStyle.FixedSingle;
            txtEnrollNo.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEnrollNo.Location = new Point(51, 278);
            txtEnrollNo.Name = "txtEnrollNo";
            txtEnrollNo.Size = new Size(271, 28);
            txtEnrollNo.TabIndex = 0;
            txtEnrollNo.TextChanged += txtEnrollNo_TextChanged;
            txtEnrollNo.KeyDown += txtEnrollNo_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(87, 232);
            label4.Name = "label4";
            label4.Size = new Size(179, 21);
            label4.TabIndex = 3;
            label4.Text = "Enter Enrollment No";
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(204, 446);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(118, 41);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(51, 446);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(118, 41);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "&Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(66, 333);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(235, 46);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "&Search Student";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnReturn);
            panel2.Controls.Add(dtpReturnDate);
            panel2.Controls.Add(txtIssuedate);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(384, 566);
            panel2.Name = "panel2";
            panel2.Size = new Size(1015, 292);
            panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Century", 10.2F);
            btnCancel.Location = new Point(675, 148);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnReturn
            // 
            btnReturn.FlatStyle = FlatStyle.Popup;
            btnReturn.Font = new Font("Century", 10.2F);
            btnReturn.Location = new Point(675, 72);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 29);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Retur&n";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Font = new Font("Century", 10.2F);
            dtpReturnDate.Location = new Point(294, 185);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(271, 28);
            dtpReturnDate.TabIndex = 5;
            // 
            // txtIssuedate
            // 
            txtIssuedate.BorderStyle = BorderStyle.FixedSingle;
            txtIssuedate.Enabled = false;
            txtIssuedate.Font = new Font("Century", 10.2F);
            txtIssuedate.Location = new Point(294, 115);
            txtIssuedate.Name = "txtIssuedate";
            txtIssuedate.Size = new Size(271, 28);
            txtIssuedate.TabIndex = 4;
            // 
            // txtBookName
            // 
            txtBookName.BorderStyle = BorderStyle.FixedSingle;
            txtBookName.Enabled = false;
            txtBookName.Font = new Font("Century", 10.2F);
            txtBookName.Location = new Point(294, 42);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(271, 28);
            txtBookName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10.2F);
            label3.Location = new Point(116, 185);
            label3.Name = "label3";
            label3.Size = new Size(154, 21);
            label3.TabIndex = 2;
            label3.Text = "Book Return Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10.2F);
            label2.Location = new Point(116, 115);
            label2.Name = "label2";
            label2.Size = new Size(140, 21);
            label2.TabIndex = 1;
            label2.Text = "Book Issue Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 10.2F);
            label1.Location = new Point(116, 47);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 0;
            label1.Text = "Book Name";
            // 
            // dgView
            // 
            dgView.AllowUserToAddRows = false;
            dgView.AllowUserToDeleteRows = false;
            dgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgView.Location = new Point(384, 12);
            dgView.Name = "dgView";
            dgView.RowHeadersWidth = 51;
            dgView.Size = new Size(1015, 548);
            dgView.TabIndex = 2;
            dgView.CellDoubleClick += dgView_CellDoubleClick;
            // 
            // ReturnBooks
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1416, 558);
            ControlBox = false;
            Controls.Add(dgView);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ReturnBooks";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnBooks";
            Load += ReturnBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DateTimePicker dtpReturnDate;
        private TextBox txtIssuedate;
        private TextBox txtBookName;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgView;
        private PictureBox pictureBox1;
        private TextBox txtEnrollNo;
        private Label label4;
        private Button btnExit;
        private Button btnRefresh;
        private Button btnSearch;
        private Button btnCancel;
        private Button btnReturn;
    }
}