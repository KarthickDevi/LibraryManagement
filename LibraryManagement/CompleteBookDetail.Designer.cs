namespace LibraryManagement
{
    partial class CompleteBookDetail
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
            dgIssBook = new DataGridView();
            dgRetBook = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgIssBook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgRetBook).BeginInit();
            SuspendLayout();
            // 
            // dgIssBook
            // 
            dgIssBook.AllowUserToAddRows = false;
            dgIssBook.AllowUserToDeleteRows = false;
            dgIssBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgIssBook.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgIssBook.Location = new Point(35, 86);
            dgIssBook.Name = "dgIssBook";
            dgIssBook.RowHeadersWidth = 51;
            dgIssBook.Size = new Size(1378, 367);
            dgIssBook.TabIndex = 0;
            // 
            // dgRetBook
            // 
            dgRetBook.AllowUserToAddRows = false;
            dgRetBook.AllowUserToDeleteRows = false;
            dgRetBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRetBook.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgRetBook.Location = new Point(35, 534);
            dgRetBook.Name = "dgRetBook";
            dgRetBook.RowHeadersWidth = 51;
            dgRetBook.Size = new Size(1378, 367);
            dgRetBook.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(631, 36);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 2;
            label1.Text = "Issued Books";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(631, 475);
            label2.Name = "label2";
            label2.Size = new Size(148, 23);
            label2.TabIndex = 3;
            label2.Text = "Return Books";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CompleteBookDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 744);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgRetBook);
            Controls.Add(dgIssBook);
            Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CompleteBookDetail";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CompleteBookDetail";
            Load += CompleteBookDetail_Load;
            KeyDown += CompleteBookDetail_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgIssBook).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgRetBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgIssBook;
        private DataGridView dgRetBook;
        private Label label1;
        private Label label2;
    }
}