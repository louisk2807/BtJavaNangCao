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
using MySql.Data.MySqlClient;

namespace DieuHuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string mySqlConnection = "server= localhost; user id= root; password= ; database= c#";
        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_category";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, mySqlConnection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "tbl_category");
            dgvCategory.DataSource = dataset.Tables["tbl_category"].DefaultView;

            string sqlPrd = "SELECT tbl_product.prd_id, tbl_product.prd_name, tbl_product.prd_price, tbl_product.prd_image, tbl_product.prd_quantity, tbl_category.cate_name " +
                            "FROM tbl_product INNER JOIN tbl_category ON tbl_product.cate_id = tbl_category.cate_id";
            MySqlDataAdapter adapterPrd = new MySqlDataAdapter(sqlPrd, mySqlConnection);
            DataTable tablePrd = new DataTable();
            adapterPrd.Fill(tablePrd);
            dgvProduct.DataSource = tablePrd;

        }

        private void btnAddCate_Click(object sender, EventArgs e)
        {
            lbCateName.Enabled = true;
            tbCateName.Enabled = true;
            btnAddCate.Enabled = false;
            btnSaveCate.Enabled = true;

        }

        private void btnSaveCate_Click(object sender, EventArgs e)
        {
            string cate_name = tbCateName.Text;
            
            MySqlConnection connection = new MySqlConnection(mySqlConnection);
            string sql = "INSERT INTO tbl_category(cate_name) VALUES ('" + cate_name + "')";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Form1_Load(null, null);
        }


        private void cel(object sender, DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void cellClickCate(object sender, DataGridViewCellEventArgs e)
        {
            btnEditCate.Enabled = true;
            btnDeleteCates.Enabled = true;
            lbCateName.Enabled = true;
            tbCateName.Enabled = true;
            btnAddCate.Enabled = false;
            string cate_id = dgvCategory.Rows[e.RowIndex].Cells["cate_id"].Value.ToString();
            string cate_name = dgvCategory.Rows[e.RowIndex].Cells["cate_name"].Value.ToString();
            
            tbCateId.Text = cate_id;
            tbCateName.Text = cate_name;
        }

        private void btnEditCate_Click(object sender, EventArgs e)
        {
            string cate_name = tbCateName.Text;
            int cate_id = Int32.Parse(tbCateId.Text);
            MySqlConnection connection = new MySqlConnection(mySqlConnection);
            string sql = "UPDATE tbl_category SET cate_name = '" + cate_name + "'" + "WHERE cate_id = '" + cate_id +
                         "'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Form1_Load(null,null);
            
        }

        private void btnDeleteCate_Click(object sender, EventArgs e)
        {
            int cate_id = Int32.Parse(tbCateId.Text);
            MySqlConnection connection = new MySqlConnection(mySqlConnection);
            string sql = "DELETE FROM tbl_category WHERE cate_id = '" + cate_id + "'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Form1_Load(null,null);
        }

        private void getCategory()
        {
            MySqlConnection connection = new MySqlConnection(mySqlConnection);
            string sql = "SELECT * FROM tbl_category";
            MySqlDataAdapter query = new MySqlDataAdapter(sql, connection);
            DataTable item = new DataTable();
            query.Fill(item);
            cbPrdCateId.DataSource = item;
            cbPrdCateId.DisplayMember = "cate_name";
            cbPrdCateId.SelectedValue = "cate_id";
        }

        private void btnAddPrd_Click(object sender, EventArgs e)
        {
            lbPrdName.Enabled = true;
            lbPrdPrice.Enabled = true; 
            lbPrdImage.Enabled = true;
            lbPrdQuantity. Enabled = true;
            lbPrdCateId. Enabled = true;
            tbPrdName.Enabled = true;
            tbPrdPrice.Enabled = true;
            tbPrdImage.Enabled = true;
            tbPrdQuantity. Enabled = true;
            cbPrdCateId.Enabled = true;
            btnSavePrd.Enabled = true;
            btnAddPrd.Enabled = false;
            // Lay du lieu tu category do vao combobox
            getCategory();
        }


        private void btnSavePrd_Click(object sender, EventArgs e)
        {
            string prd_name = tbPrdName.Text;
            string prd_price = tbPrdPrice.Text;
            string prd_image = tbPrdImage.Text;
            string prd_quantity = tbPrdQuantity.Text;
            string cate_id = cbPrdCateId. SelectedValue.ToString();
            MySqlConnection connection = new MySqlConnection (mySqlConnection);
            string sql = "INSERT INTO tbl_product" +
                         "(prd_name,prd_price,prd_image,prd_quantity,cate_id)" +
                         "VALUES " +
                         "('" + prd_name + "','" + prd_price + "','" + prd_image + "','" + prd_quantity + "''" +
                         cate_id + "')";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Form1_Load(null,null);
        }

        

        private void CellClickPrd(object sender, DataGridViewCellEventArgs e)
        {
            string cate_id = dgvProduct.Rows[e.RowIndex].Cells["cate_id"].Value.ToString();
            getCategory();
            cbPrdCateId.SelectedValue = cbPrdCateId.FindString(cate_id);
        }

        private void btnEditPrd_Click(object sender, EventArgs e)
        {
            string prd_name = tbPrdName.Text;
            int prd_id = Int32.Parse(tbPrdId.Text);
            decimal prd_price = Decimal.Parse(tbPrdPrice.Text);
            int prd_quantity = Int32.Parse(tbPrdQuantity.Text);
            string cate_id = cbPrdCateId.SelectedValue.ToString(); // Use SelectedValue.ToString() instead of Int32.Parse

            MySqlConnection connection = new MySqlConnection(mySqlConnection);
            string sql = "UPDATE tbl_product SET prd_name = '" + prd_name + "', prd_price = " + prd_price +
                         ", prd_quantity = " + prd_quantity + ", cate_id = '" + cate_id + "' WHERE prd_id = " + prd_id;

            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Form1_Load(null, null);
        }

        private void btnDeletePrd_Click(object sender, EventArgs e)
        {
            int prd_id = Int32.Parse(tbPrdId.Text);
            MySqlConnection connection = new MySqlConnection(mySqlConnection);
            string sql = "DELETE FROM tbl_product WHERE prd_id = " + prd_id; // Remove single quotes around prd_id

            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Form1_Load(null, null);
        }

    }
}