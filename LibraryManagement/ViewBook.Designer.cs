namespace LibraryManagement
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtvBookName = new TextBox();
            btnRefresh = new Button();
            dataView = new DataGridView();
            panel2 = new Panel();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dtpPurchasedate = new DateTimePicker();
            txtBookQuantity = new TextBox();
            txtBookPrice = new TextBox();
            txtBookPublish = new TextBox();
            txtAuthorName = new TextBox();
            txtBookName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Font = new Font("Century", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1422, 137);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(844, 52);
            label1.Name = "label1";
            label1.Size = new Size(148, 28);
            label1.TabIndex = 1;
            label1.Text = "View Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(601, -26);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(481, 158);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 1;
            label2.Text = "Book Name";
            // 
            // txtvBookName
            // 
            txtvBookName.BorderStyle = BorderStyle.FixedSingle;
            txtvBookName.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtvBookName.Location = new Point(616, 155);
            txtvBookName.Name = "txtvBookName";
            txtvBookName.Size = new Size(305, 28);
            txtvBookName.TabIndex = 2;
            txtvBookName.TextChanged += txtvBookName_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Century", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(946, 155);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(99, 30);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataView
            // 
            dataView.AllowUserToAddRows = false;
            dataView.AllowUserToDeleteRows = false;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataView.Location = new Point(2, 191);
            dataView.Name = "dataView";
            dataView.RowHeadersWidth = 51;
            dataView.Size = new Size(1422, 402);
            dataView.TabIndex = 4;
            dataView.CellClick += dataView_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(dtpPurchasedate);
            panel2.Controls.Add(txtBookQuantity);
            panel2.Controls.Add(txtBookPrice);
            panel2.Controls.Add(txtBookPublish);
            panel2.Controls.Add(txtAuthorName);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(2, 610);
            panel2.Name = "panel2";
            panel2.Size = new Size(1422, 352);
            panel2.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.CausesValidation = false;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Century", 10.8F, FontStyle.Bold);
            btnCancel.Location = new Point(1149, 269);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.CausesValidation = false;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Century", 10.8F, FontStyle.Bold);
            btnDelete.Location = new Point(1002, 269);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Century", 10.8F, FontStyle.Bold);
            btnUpdate.Location = new Point(861, 269);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dtpPurchasedate
            // 
            dtpPurchasedate.Location = new Point(907, 28);
            dtpPurchasedate.Name = "dtpPurchasedate";
            dtpPurchasedate.Size = new Size(294, 26);
            dtpPurchasedate.TabIndex = 9;
            dtpPurchasedate.KeyDown += dtpPurchasedate_KeyDown;
            // 
            // txtBookQuantity
            // 
            txtBookQuantity.Location = new Point(907, 200);
            txtBookQuantity.Name = "txtBookQuantity";
            txtBookQuantity.Size = new Size(291, 26);
            txtBookQuantity.TabIndex = 11;
            txtBookQuantity.KeyDown += txtBookQuantity_KeyDown;
            // 
            // txtBookPrice
            // 
            txtBookPrice.Location = new Point(907, 114);
            txtBookPrice.Name = "txtBookPrice";
            txtBookPrice.Size = new Size(291, 26);
            txtBookPrice.TabIndex = 10;
            txtBookPrice.KeyDown += txtBookPrice_KeyDown;
            // 
            // txtBookPublish
            // 
            txtBookPublish.Location = new Point(315, 200);
            txtBookPublish.Name = "txtBookPublish";
            txtBookPublish.Size = new Size(291, 26);
            txtBookPublish.TabIndex = 8;
            txtBookPublish.KeyDown += txtBookPublish_KeyDown;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(315, 114);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(291, 26);
            txtAuthorName.TabIndex = 7;
            txtAuthorName.KeyDown += txtAuthorName_KeyDown;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(315, 28);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(291, 26);
            txtBookName.TabIndex = 6;
            txtBookName.KeyDown += txtBookName_KeyDown;
            txtBookName.Validating += txtBookName_Validating;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 10.8F);
            label8.Location = new Point(693, 200);
            label8.Name = "label8";
            label8.Size = new Size(133, 22);
            label8.TabIndex = 5;
            label8.Text = "Book Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 10.8F);
            label7.Location = new Point(693, 114);
            label7.Name = "label7";
            label7.Size = new Size(100, 22);
            label7.TabIndex = 4;
            label7.Text = "Book Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 10.8F);
            label6.Location = new Point(693, 28);
            label6.Name = "label6";
            label6.Size = new Size(179, 22);
            label6.TabIndex = 3;
            label6.Text = "Book Purchase Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10.8F);
            label5.Location = new Point(58, 200);
            label5.Name = "label5";
            label5.Size = new Size(153, 22);
            label5.TabIndex = 2;
            label5.Text = "Book Publication";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 10.8F);
            label4.Location = new Point(61, 28);
            label4.Name = "label4";
            label4.Size = new Size(107, 22);
            label4.TabIndex = 1;
            label4.Text = "Book Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10.8F);
            label3.Location = new Point(58, 114);
            label3.Name = "label3";
            label3.Size = new Size(171, 22);
            label3.TabIndex = 0;
            label3.Text = "Book Author Name";
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            CausesValidation = false;
            ClientSize = new Size(1427, 625);
            Controls.Add(panel2);
            Controls.Add(dataView);
            Controls.Add(btnRefresh);
            Controls.Add(txtvBookName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ViewBook";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBook";
            Load += ViewBook_Load;
            KeyDown += ViewBook_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
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
        private TextBox txtvBookName;
        private Button btnRefresh;
        private DataGridView dataView;
        private Panel panel2;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtBookName;
        private TextBox txtBookPublish;
        private TextBox txtAuthorName;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private DateTimePicker dtpPurchasedate;
        private TextBox txtBookQuantity;
        private TextBox txtBookPrice;
    }
}