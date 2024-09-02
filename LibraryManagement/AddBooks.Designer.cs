namespace LibraryManagement
{
    partial class AddBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooks));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtBookName = new TextBox();
            txtAuthorName = new TextBox();
            txtBookPublish = new TextBox();
            txtBookPrice = new TextBox();
            txtBookQuantity = new TextBox();
            dtpPurchaseDate = new DateTimePicker();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(354, 428);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 90);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(468, 30);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 1;
            label1.Text = "Add Book";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(357, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(106, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Location = new Point(354, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(616, 428);
            panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.5783119F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.4216881F));
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 5);
            tableLayoutPanel1.Controls.Add(txtBookName, 1, 0);
            tableLayoutPanel1.Controls.Add(txtAuthorName, 1, 1);
            tableLayoutPanel1.Controls.Add(txtBookPublish, 1, 2);
            tableLayoutPanel1.Controls.Add(txtBookPrice, 1, 4);
            tableLayoutPanel1.Controls.Add(txtBookQuantity, 1, 5);
            tableLayoutPanel1.Controls.Add(dtpPurchaseDate, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 6);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(57, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(498, 428);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10.2F);
            label3.Location = new Point(3, 81);
            label3.Name = "label3";
            label3.Size = new Size(216, 21);
            label3.TabIndex = 1;
            label3.Text = "Book Author Name";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Century", 10.2F);
            label4.Location = new Point(3, 142);
            label4.Name = "label4";
            label4.Size = new Size(216, 21);
            label4.TabIndex = 2;
            label4.Text = "Book Publication";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10.2F);
            label5.Location = new Point(3, 203);
            label5.Name = "label5";
            label5.Size = new Size(216, 21);
            label5.TabIndex = 3;
            label5.Text = "Book Purchase Date";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Century", 10.2F);
            label6.Location = new Point(3, 264);
            label6.Name = "label6";
            label6.Size = new Size(216, 21);
            label6.TabIndex = 4;
            label6.Text = "Book Price";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Century", 10.2F);
            label7.Location = new Point(3, 325);
            label7.Name = "label7";
            label7.Size = new Size(216, 21);
            label7.TabIndex = 5;
            label7.Text = "Book Quantity";
            // 
            // txtBookName
            // 
            txtBookName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBookName.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtBookName.Location = new Point(225, 17);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(270, 27);
            txtBookName.TabIndex = 0;
            txtBookName.TextChanged += txtBookName_TextChanged;
            txtBookName.KeyDown += txtBookName_KeyDown;
            txtBookName.Validating += txtBookName_Validating;
            txtBookName.Validated += txtBookName_Validated;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAuthorName.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtAuthorName.Location = new Point(225, 78);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(270, 27);
            txtAuthorName.TabIndex = 1;
            txtAuthorName.KeyDown += txtAuthorName_KeyDown;
            // 
            // txtBookPublish
            // 
            txtBookPublish.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBookPublish.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtBookPublish.Location = new Point(225, 139);
            txtBookPublish.Name = "txtBookPublish";
            txtBookPublish.Size = new Size(270, 27);
            txtBookPublish.TabIndex = 2;
            txtBookPublish.KeyDown += txtBookPublish_KeyDown;
            // 
            // txtBookPrice
            // 
            txtBookPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBookPrice.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtBookPrice.Location = new Point(225, 261);
            txtBookPrice.Name = "txtBookPrice";
            txtBookPrice.Size = new Size(270, 27);
            txtBookPrice.TabIndex = 4;
            txtBookPrice.KeyDown += txtBookPrice_KeyDown;
            txtBookPrice.KeyPress += txtBookPrice_KeyPress;
            // 
            // txtBookQuantity
            // 
            txtBookQuantity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBookQuantity.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtBookQuantity.Location = new Point(225, 322);
            txtBookQuantity.Name = "txtBookQuantity";
            txtBookQuantity.Size = new Size(270, 27);
            txtBookQuantity.TabIndex = 5;
            txtBookQuantity.KeyDown += txtBookQuantity_KeyDown;
            // 
            // dtpPurchaseDate
            // 
            dtpPurchaseDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpPurchaseDate.Font = new Font("Microsoft Sans Serif", 10.2F);
            dtpPurchaseDate.Location = new Point(225, 200);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.Size = new Size(270, 27);
            dtpPurchaseDate.TabIndex = 3;
            dtpPurchaseDate.KeyDown += dtpPurchaseDate_KeyDown;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnSave, 0, 0);
            tableLayoutPanel2.Controls.Add(btnCancel, 1, 0);
            tableLayoutPanel2.Location = new Point(225, 369);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(266, 56);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Century", 10.2F, FontStyle.Bold);
            btnSave.Location = new Point(3, 13);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(127, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.CausesValidation = false;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Century", 10.2F, FontStyle.Bold);
            btnCancel.Location = new Point(136, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(127, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10.2F);
            label2.Location = new Point(3, 20);
            label2.Name = "label2";
            label2.Size = new Size(216, 21);
            label2.TabIndex = 0;
            label2.Text = "Book Name";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(968, 524);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AddBooks";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBooks";
            Load += AddBooks_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtBookName;
        private TextBox txtAuthorName;
        private TextBox txtBookPublish;
        private TextBox txtBookPrice;
        private TextBox txtBookQuantity;
        private DateTimePicker dtpPurchaseDate;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnSave;
        private Button btnCancel;
    }
}