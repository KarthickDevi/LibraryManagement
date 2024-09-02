using System;
using System.Data.SqlClient;
using System.Data;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        Connection connection = new Connection();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserName.Text == "User Name")
            {
                txtUserName.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnLogin.Enabled == true)
                {

                    //SqlConnection con = new SqlConnection();
                    ////con.Open();
                    //con.ConnectionString = "data source = KARTHI\\SQLEXPRESS;database = library;integrated security = True";
                    //SqlCommand Cmd = new SqlCommand();
                    //Cmd.Connection = con;
                    //Cmd.CommandText = "Select * From logintable where username = '" + txtUserName.Text + "' and pass = '" + txtPassword.Text + "'";
                    string Sql = "Select * From logintable where username = '" + txtUserName.Text + "' and pass = '" + txtPassword.Text + "'";
                    SqlCommand cmd = new SqlCommand(Sql, connection.GetConnection());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        this.Hide();
                        Dashboard dsa = new Dashboard();
                        dsa.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (btnLogin.Enabled == false && txtUserName.Text.ToString().Trim() != "" && txtPassword.Text.ToString().Trim() != "")
            {
                string sql = "insert into logintable(username,pass) values ('" + txtUserName.Text.ToString().Trim() + "',";
                sql = sql + "'" + txtPassword.Text.ToString().Trim() + "')";
                SqlCommand cmd = new SqlCommand(sql, connection.GetConnection());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Login Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Text = "";
                txtUserName.Text = "";
                btnLogin.Enabled = true;
                txtUserName.Focus();
            }
            else
            {
                btnLogin.Enabled = false;
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtUserName.Focus();

            }
        }

        private void txtUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (btnLogin.Enabled == false && txtUserName.Text.ToString().Trim() != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from logintable Where username ='" + txtUserName.Text.ToString() + "'";
                cmd.Connection = connection.GetConnection();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("User Name Already Exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //                    e.Cancel = true;
                    return;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
        //System.Diagnostics.Process.Start();
    }
}
