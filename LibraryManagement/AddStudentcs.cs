using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{

    public partial class AddStudentcs : Form
    {
        Connection Conn = new Connection();
        public AddStudentcs()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm ?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
            txtStudentName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStudentName.Text != "" && txtEnrollNo.Text != "" && txtDepartment.Text != "" && txtSemester.Text != "" && txtContact.Text != "" && txtEmail.Text != "")
                {
                    String sName = txtStudentName.Text;
                    string sEnrollno = txtEnrollNo.Text;
                    string sDept = txtDepartment.Text;
                    string sSem = txtSemester.Text;
                    Int64 sContact = Int64.Parse(txtContact.Text.ToString());
                    string sEmail = txtEmail.Text;

                    SqlCommand cmd = new SqlCommand();
                    //string sql;
                    //sql = "insert into newstudent (sname,enroll,dept,sem,contact,email) values (";
                    //sql = sql + "'" + sName + "','" + sEnrollno + "','" + sDept + "','" + sSem + "',";
                    //sql = sql + sContact + ",'" + sEmail + "')";
                    //cmd.CommandText = sql;
                    //cmd.Connection = Conn.GetConnection();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = Conn.GetConnection();
                    cmd.CommandText = "AddStudent";
                    cmd.Parameters.AddWithValue("@sname", sName);
                    cmd.Parameters.AddWithValue("@enroll", sEnrollno);
                    cmd.Parameters.AddWithValue("@dept", sDept);
                    cmd.Parameters.AddWithValue("@sem", sSem);
                    cmd.Parameters.AddWithValue("@contact", sContact);
                    cmd.Parameters.AddWithValue("@email", sEmail);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    txtStudentName.Focus();
                }
                else
                {
                    MessageBox.Show("Please Fill the Empty Fields", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtStudentName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
;
            }

        }
        private void Clear()
        {
            txtStudentName.Text = "";
            txtEnrollNo.Text = "";
            txtDepartment.Text = "";
            txtSemester.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtStudentName.Clear();
        }

        private void txtStudentName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void txtEnrollNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void txtDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void txtSemester_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void txtContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void AddStudentcs_Load(object sender, EventArgs e)
        {

        }
    }
}
