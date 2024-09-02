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
    public partial class ReturnBooks : Form
    {
        SqlCommand cmd = new SqlCommand ();
        string sql = "";
        Connection conn = new Connection();
        int stuid = 0;
        string strBookName = string.Empty;
        string issuedate = string.Empty;
        //DateTime issuedate;
        public ReturnBooks()
        {
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEnrollNo.Text != "")
            {
                cmd = new SqlCommand();
                sql = "select * from IRBook Where std_enroll ='" + txtEnrollNo.Text.ToString().Trim() + "' and book_return_date is null";
                cmd.CommandText = sql;
                cmd.Connection = conn.GetConnection();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgView.DataSource = ds.Tables[0];
                    dgView.Focus();
                }
                else
                {
                    MessageBox.Show("Enter a Valid EnrollmentNo", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?.Unsaved data will be lose", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Clear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
            txtEnrollNo.Focus();
        }
        public void Clear()
        {
            txtEnrollNo.Text = "";
            txtBookName.Text = "";
            txtIssuedate.Text = "";
            dtpReturnDate.MaxDate = DateTime.Today;
            dtpReturnDate.MinDate = DateTime.Today;
            dtpReturnDate.Value = DateTime.Today;
            panel2.Visible = false;
            dgView.DataSource = null;
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtEnrollNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnrollNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtEnrollNo.Text != "")
                    {
                        cmd = new SqlCommand();
                        sql = "select * from IRBook Where std_enroll ='" + txtEnrollNo.Text.ToString().Trim() + "' and book_return_date is null";
                        cmd.CommandText = sql;
                        cmd.Connection = conn.GetConnection();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            //dgView.DataSource = ds.Tables[0];
                            SendKeys.Send("{tab}");

                        }
                        else
                        {
                            MessageBox.Show("Invalid Enrollment No (or) No Book Issued", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                panel2.Visible = true;
                if (dgView.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    stuid = int.Parse(dgView.Rows[e.RowIndex].Cells[0].Value.ToString());
#pragma warning disable CS8601 // Possible null reference assignment.
                    strBookName = dgView.Rows[e.RowIndex].Cells[7].Value.ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
                    issuedate = dgView.Rows[e.RowIndex].Cells[8].Value.ToString();
#pragma warning restore CS8601 // Possible null reference assignment.

                    cmd = new SqlCommand();
                    sql = "Select book_name,book_issue_date from IRBook Where id = " + stuid + " and book_name ='" + strBookName + "'";
                    sql = sql + " and book_issue_date ='" + issuedate + "'";
                    cmd.CommandText = sql;
                    cmd.Connection = conn.GetConnection();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtBookName.Text = ds.Tables[0].Rows[0][0].ToString();
                        txtIssuedate.Text = ds.Tables[0].Rows[0][1].ToString();
                    }
                    dtpReturnDate.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update IRbook set book_return_date = '" + dtpReturnDate.Text + "' where id = " + stuid + " and ";
                sql = sql + " book_name ='" + strBookName + "' and book_issue_date = '" + issuedate + "'";
                cmd = new SqlCommand(sql, conn.GetConnection());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Returned", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
