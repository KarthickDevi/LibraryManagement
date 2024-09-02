using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class IssueBooks : Form
    {
        Connection conn = new Connection();
        SqlConnection con = new SqlConnection();
        clsIssueBook IBook = new clsIssueBook();
        SqlCommand cmd = new SqlCommand();
        string sql = "";
        int count = 0;
        public IssueBooks()
        {
            InitializeComponent();
        }

        private void IssueBooks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            Books_Load();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEnrollNo.Text != "")
            {
                string enroll = txtEnrollNo.Text.ToString();
                cmd = new SqlCommand();
                cmd.Connection = con;
                sql = "select * from newstudent where enroll = '" + enroll + "'";
                cmd.CommandText = sql;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds);

                cmd.CommandText = "Select count(1) from IRBook where std_enroll='" + enroll + "' and book_return_date is null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                if (count >= 3)
                {
                    MessageBox.Show("Maximum Books Already Issued", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    return;
                }
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtStudentName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDept.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtSemester.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                    cmbBookName.Focus();
                }
                else
                {
                    Clear();
                    MessageBox.Show("Invalid Enrollment No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void Clear()
        {
            txtEmail.Text = "";
            txtStudentName.Text = "";
            txtEnrollNo.Text = "";
            txtDept.Text = "";
            txtSemester.Text = "";
            txtContact.Text = "";
            Books_Load();
            dtpIssdate.MinDate = DateTime.Today;
            dtpIssdate.MaxDate = DateTime.Today;
        }
        private void Books_Load()
        {
            con = conn.GetConnection();
            // con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from newbook";
            SqlDataReader sdr = cmd.ExecuteReader();
            cmbBookName.Items.Clear();
            while (sdr.Read())
            {
                //for (int i = 0; i < sdr.FieldCount; i++)
                //{
                cmbBookName.Items.Add(sdr.GetString("bname"));
                //}
            }

            sdr.Close();
            con.Close();
        }

        private void btnIssueBooks_Click(object sender, EventArgs e)
        {
            try
            {

                if (count >= 3)
                {

                    MessageBox.Show("Maximum Books Limit Already reached", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (cmbBookName.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select Book Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (txtStudentName.Text != "" && cmbBookName.SelectedIndex != -1 && count <= 2)
                {

                    sql = "Select * from IRBook Where std_enroll='" + txtEnrollNo.Text + "' and std_name ='" + txtStudentName.Text.ToString() + "'";
                    sql = sql + " and book_name ='" + cmbBookName.Text.ToString() + "' and book_return_date is null";
                    cmd = new SqlCommand(sql, conn.GetConnection());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("This Book is Already Issued for this Student", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbBookName.Focus();
                        return;
                    }

                    IBook.stuName = txtStudentName.Text.ToString().Trim();
                    IBook.stuDept = txtDept.Text.ToString().Trim();
                    IBook.stuSem = txtSemester.Text.ToString().Trim();
                    IBook.stuContact = txtContact.Text.ToString().Trim();
                    IBook.stuEmail = txtEmail.Text.ToString().Trim();
                    IBook.book_Name = cmbBookName.Text.ToString().Trim();
                    IBook.BookIssdate = dtpIssdate.Value;

                    DataTable dtIBook = new DataTable();
                    dtIBook.Columns.Add("StuEnrollNo", typeof(string));
                    dtIBook.Columns.Add("StuName", typeof(string));
                    dtIBook.Columns.Add("StuDept", typeof(string));
                    dtIBook.Columns.Add("StuSem", typeof(string));
                    dtIBook.Columns.Add("StuContact", typeof(string));
                    dtIBook.Columns.Add("StuEmail", typeof(string));
                    dtIBook.Columns.Add("BookName", typeof(string));
                    dtIBook.Columns.Add("BookIssDate", typeof(DateTime));

                    DataRow row = dtIBook.NewRow();
                    row["StuEnrollNo"] = txtEnrollNo.Text.ToString().Trim().ToUpper();
                    row["StuName"] = IBook.stuName;
                    row["StuDept"] = IBook.stuDept;
                    row["StuSem"] = IBook.stuSem;
                    row["StuContact"] = IBook.stuContact;
                    row["StuEmail"] = IBook.stuEmail;
                    row["BookName"] = IBook.book_Name;
                    row["BookIssDate"] = IBook.BookIssdate;

                    dtIBook.Rows.Add(row);

                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.SaveIRbook";
                    cmd.Connection = conn.GetConnection();
                    SqlParameter parameter = new SqlParameter();
                    parameter.ParameterName = "@IRBookData";
                    parameter.SqlDbType = SqlDbType.Structured;
                    parameter.TypeName = "dbo.UDT_IRBook";
                    parameter.Value = dtIBook;
                    cmd.Parameters.Add(parameter);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    txtEnrollNo.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEnrollNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                 btnSearch.Focus();
            }
        }

        private void cmbBookName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //SendKeys.Send("{tab}");
                dtpIssdate.Focus();
            }
        }

        private void dtpIssdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //SendKeys.Send("{tab}");
                btnIssueBooks.Focus();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
            txtEnrollNo.Focus();
        }
    }
}
