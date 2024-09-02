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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtBookName.Text.Trim() != "" && txtAuthorName.Text.Trim() != "" && txtBookPrice.Text.Trim() != "" && txtBookPublish.Text.Trim() != "" && txtBookQuantity.Text.Trim() != "")
            {
                String bName = txtBookName.Text;
                String bAuthor = txtAuthorName.Text;
                String bPublish = txtBookPublish.Text;
                String bDate = dtpPurchaseDate.Text;
                //DateTime bPubdate = DateTime.TryParse(dtpPurchaseDate.Text ) ;
                Int64 bPrice = Int64.Parse(txtBookPrice.Text);
                Int64 bQuantity = Int64.Parse(txtBookQuantity.Text);

                Connection connection = new Connection();

                //SqlConnection con = new SqlConnection();
                //con.ConnectionString = "data source = KARTHI\\SQLEXPRESS;database = library;Integrated Security = True";

                //cmd.Connection = conn;
                //conn.Open();
                string sql = "insert into newbook(bname,bauthor,bpubl,bpdate,bprice,bquantity) values";
                sql = sql + " ('" + bName + "','" + bAuthor + "','" + bPublish + "','" + bDate + "',";
                //sql = sql + "'" + DateTime.TryParse(bdate)  + "'";
                sql = sql + "" + bPrice + "," + bQuantity + ")";

                //cmd.CommandText = "insert into newbook(bname,bauthor,bpubl,bpdate,bpubdate,bprice,bquan) values  ('" + bName + "','" + bAuthor + "','" + bPublish + "','" + bDate + "'," + bPrice + "," + bQuantity + ")";
                //cmd.CommandText = sql;
                SqlCommand cmd = new SqlCommand(sql, connection.GetConnection());
                cmd.ExecuteNonQuery();
                //conn.Close();
                connection.Getclose();
                MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear();
            }
            else
            {
                MessageBox.Show("Empty text NOT Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dtpPurchaseDate_KeyDown(object sender, KeyEventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will DELETE your Unsaved Data", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void AddBooks_Load(object sender, EventArgs e)
        {
            dtpPurchaseDate.Value = DateTime.Today;
            dtpPurchaseDate.MinDate = DateTime.Today;
            dtpPurchaseDate.MaxDate = DateTime.Today;
        }

        private void Clear()
        {
            txtBookName.Text = "";
            txtAuthorName.Text = "";
            txtBookPublish.Text = "";
            txtBookPrice.Text = "";
            txtBookQuantity.Text = "";
            dtpPurchaseDate.Value = DateTime.Today;
            dtpPurchaseDate.MaxDate = DateTime.Today;
            dtpPurchaseDate.MinDate = DateTime.Today;
            txtBookName.Focus();
        }

        private void txtBookPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBookName_Validating(object sender, CancelEventArgs e)
        {
            //if (txtBookName.Text == "")
            //{
            //    e.Cancel = true;
            //}
        }

        private void txtBookName_Validated(object sender, EventArgs e)
        {

        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
