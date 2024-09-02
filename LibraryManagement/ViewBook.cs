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
    public partial class ViewBook : Form
    {
        Connection Conn = new Connection();
        string sql = "";
        public ViewBook()
        {
            InitializeComponent();
        }

        private void ViewBook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            try
            {
                panel2.Visible = false;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conn.GetConnection();
                cmd.CommandText = "Select * from newbook";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataView.DataSource = ds.Tables[0];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int bid;
        private void dataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                bid = int.Parse(dataView.Rows[e.RowIndex].Cells[0].Value.ToString());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conn.GetConnection();
                cmd.CommandText = "Select * from newbook with(nolock) where bid = " + bid;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                txtBookName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtAuthorName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtBookPublish.Text = ds.Tables[0].Rows[0][3].ToString();
                dtpPurchasedate.Value = DateTime.Parse(ds.Tables[0].Rows[0][4].ToString());
                txtBookPrice.Text = ds.Tables[0].Rows[0][6].ToString();
                txtBookQuantity.Text = ds.Tables[0].Rows[0][7].ToString();

                panel2.Visible = true;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtBookName.Text = "";
            txtBookPrice.Text = "";
            txtAuthorName.Text = "";
            txtBookPublish.Text = "";
            txtBookQuantity.Text = "";
            btnRefresh.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            Refreshing();

        }

        private void Refreshing()
        {

            panel2.Visible = false;
            txtBookName.Text = "";
            txtAuthorName.Text = "";
            txtBookPrice.Text = "";
            txtBookQuantity.Text = "";
            txtBookPublish.Text = "";

            sql = "select * from newbook";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = Conn.GetConnection();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataView.DataSource = ds.Tables[0];
        }
        private void txtvBookName_TextChanged(object sender, EventArgs e)
        {
            if (txtvBookName.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conn.GetConnection();
                cmd.CommandText = "Select * from newbook where bname like '%" + txtvBookName.Text.ToString() + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataView.DataSource = ds.Tables[0];
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conn.GetConnection();
                cmd.CommandText = "Select * from newbook";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataView.DataSource = ds.Tables[0];

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Updated. Confirm", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {


                string bname = txtBookName.Text;
                string bAuthor = txtAuthorName.Text;
                string bpublish = txtBookPublish.Text;
                string bPurdate = dtpPurchasedate.Text;
                DateTime bdate = dtpPurchasedate.Value;
                int bprice = int.Parse(txtBookPrice.Text.ToString());
                int bQuan = int.Parse(txtBookQuantity.Text.ToString());


                sql = "Update newbook set bname ='" + bname + "',bauthor='" + bAuthor + "',bpubl='" + bpublish + "'";
                sql = sql + ",bpdate='" + bPurdate + "',bprice =" + bprice + ",bquantity = " + bQuan + "";
                sql = sql + " where bid = " + bid + "";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conn.GetConnection();
                cmd.CommandText = sql;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Refreshing();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted. Confirm ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                sql = "delete from newbook where bid = " + bid + "";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = Conn.GetConnection();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Refreshing();
            }
        }

        private void txtBookName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void txtAuthorName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void txtBookPublish_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void dtpPurchasedate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void txtBookPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void txtBookQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void txtBookName_Validating(object sender, CancelEventArgs e)
        {
            if (txtBookName.Text.ToString() == "")
            {
                //e.Cancel = true;
            }
        }
        
    }
}
