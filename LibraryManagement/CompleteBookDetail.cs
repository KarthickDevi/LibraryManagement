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
    public partial class CompleteBookDetail : Form
    {
        SqlCommand cmd = new SqlCommand();
        String sql = "";
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        Connection conn = new Connection();
        bool issue, ret = false;
        public CompleteBookDetail()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            try
            {
                sql = "Select * from IRBook Where Book_return_date is null";
                cmd = new SqlCommand(sql,conn.GetConnection ());
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                issue = false;

                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgIssBook.DataSource = ds.Tables[0];
                    issue = true;
                }
                sql = "Select * From IRBook where book_return_date is not null";
                cmd = new SqlCommand(sql,conn.GetConnection ());
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                ret = false;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgRetBook.DataSource = ds.Tables[0];
                    ret = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CompleteBookDetail_Load(object sender, EventArgs e)
        {
            LoadData();
            if (ret == false && issue == false)
            {
                MessageBox.Show("No Books Issued or Returned", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void CompleteBookDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
