namespace LibraryManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnLogin = new Button();
            btnSignup = new Button();
            BtnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(112, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(112, 166);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 18);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(35, 36, 55);
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.White;
            txtUserName.Location = new Point(92, 219);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(198, 19);
            txtUserName.TabIndex = 2;
            txtUserName.Text = "User Name";
            txtUserName.MouseClick += txtUserName_MouseClick;
            txtUserName.KeyDown += txtUserName_KeyDown;
            txtUserName.Validating += txtUserName_Validating;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(35, 36, 55);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(92, 280);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(198, 19);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "Password";
            txtPassword.MouseClick += txtPassword_MouseClick;
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(38, 206);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(38, 274);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(92, 241);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(198, 2);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.Location = new Point(92, 302);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(198, 2);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Cyan;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(76, 355);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(214, 29);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.FromArgb(64, 64, 64);
            btnSignup.FlatStyle = FlatStyle.Popup;
            btnSignup.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = Color.Cyan;
            btnSignup.Location = new Point(76, 407);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(214, 29);
            btnSignup.TabIndex = 9;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.FromArgb(64, 64, 64);
            BtnClose.CausesValidation = false;
            BtnClose.FlatStyle = FlatStyle.Popup;
            BtnClose.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClose.ForeColor = Color.Red;
            BtnClose.Location = new Point(319, 0);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(28, 30);
            BtnClose.TabIndex = 10;
            BtnClose.Text = "X";
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 55);
            ClientSize = new Size(349, 500);
            Controls.Add(BtnClose);
            Controls.Add(btnSignup);
            Controls.Add(btnLogin);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnLogin;
        private Button btnSignup;
        private Button BtnClose;
    }
}
