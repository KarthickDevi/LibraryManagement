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
    public partial class ViewStudent : Form
    {
        Connection conn = new Connection();
        int stuid = 0;
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void txtStudentName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void txtEnroll_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void txtDept_KeyDown(object sender, KeyEventArgs e)
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

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
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

        private void txtEnrollmentno_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Image image = Image.FromFile("D:\\Pictures\\Liberay Management System\\Search1.gif");
                pictureBox1.Image = image;
                label1.Visible = false;
                string sql;
                if (txtEnrollmentno.Text != "")
                {
                    sql = "Select * from newstudent where enroll like '%" + txtEnrollmentno.Text + "%'";
                }
                else
                {
                    sql = "select * from newstudent";
                }

                SqlCommand cmd = new SqlCommand(sql, conn.GetConnection());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgView.DataSource = ds.Tables[0];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            panel2.Visible = false;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from newstudent";
            cmd.Connection = conn.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgView.DataSource = ds.Tables[0];
            txtEnroll.Text = string.Empty;
            txtEnrollmentno.Text = "";
            txtStudentName.Text = "";
            txtSemester.Text = "";
            txtDept.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";

        }

        private void dgView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgView.Rows[e.RowIndex].Cells[0].Value != null)
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                stuid = int.Parse(dgView.Rows[e.RowIndex].Cells[0].Value.ToString());
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn.GetConnection();
                cmd.CommandText = "select * from newstudent where stuid =" + stuid;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                txtStudentName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtEnroll.Text = ds.Tables[0].Rows[0][2].ToString();
                txtDept.Text = ds.Tables[0].Rows[0][3].ToString();
                txtSemester.Text = ds.Tables[0].Rows[0][4].ToString();
                txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                panel2.Visible = true;

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Clear();
            //txtEnrollmentno.Focus();
            if (MessageBox.Show("Unsaved Data will be lost?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Data will be Updated?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string sname = txtStudentName.Text.ToString();
                    string senroll = txtEnroll.Text.ToString();
                    string sdept = txtDept.Text.ToString();
                    string ssem = txtSemester.Text.ToString();
                    string scontact = txtContact.Text.ToString();
                    string semail = txtEmail.Text.ToString();

                    string sql = "Update Newstudent set sname ='" + sname + "',enroll='" + senroll + "',dept='" + sdept + "',sem='" + ssem + "',";
                    sql = sql + "contact =" + scontact + ",email='" + semail + "' where stuid = " + stuid + "";
                    SqlCommand cmd = new SqlCommand(sql);
                    cmd.Connection = conn.GetConnection();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    txtEnrollmentno.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Record will be DELETED ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string sql = "delete from newstudent where stuid =" + stuid + "";
                    SqlCommand cmd = new SqlCommand(sql, conn.GetConnection());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    txtEnrollmentno.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
