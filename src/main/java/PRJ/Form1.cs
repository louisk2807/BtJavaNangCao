using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PRJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private string mySqlConnection = "server= localhost; user id= root; password= ; database= prjc#";
        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_category";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, mySqlConnection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "tbl_category");
            dgvCategory.DataSource = dataset.Tables["tbl_category"].DefaultView;
            
            string sqlStu = "SELECT tbl_student.stu_id, tbl_student.stu_name, tbl_student.stu_class,  tbl_category.cate_name " +
                            "FROM tbl_student INNER JOIN tbl_category ON tbl_student.cate_id = tbl_category.cate_id";
            MySqlDataAdapter adapterPrd = new MySqlDataAdapter(sqlStu, mySqlConnection);
            DataTable tablePrd = new DataTable();
            adapterPrd.Fill(tablePrd);
            dgvStudent.DataSource = tablePrd;
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


        private void cellClickCate(object sender, DataGridViewCellEventArgs e)
        {
            btnEditCate.Enabled = true;
            btnDeleteCate.Enabled = true;
            lbCateName.Enabled = true;
            tbCateName.Enabled = true;
            btnAddCate.Enabled = false;
            string cate_id = dgvCategory.Rows[e.RowIndex].Cells["cate_id"].Value.ToString();
            string cate_name = dgvCategory.Rows[e.RowIndex].Cells["cate_name"].Value.ToString();
            
            tbCateId.Text = cate_id;
            tbCateName.Text = cate_name;
        }

        private void getCategory()
        {
            MySqlConnection connection = new MySqlConnection(mySqlConnection);
            string sql = "SELECT * FROM tbl_category";
            MySqlDataAdapter query = new MySqlDataAdapter(sql, connection);
            DataTable item = new DataTable();
            query.Fill(item);
            cbStuCateId.DataSource = item;
            cbStuCateId.DisplayMember = "cate_name";
            cbStuCateId.ValueMember = "cate_id";
        }

        private void btnAddStu_Click(object sender, EventArgs e)
        {
            lbStuName.Enabled = true;
            lbStuClass.Enabled = true;
            lbStuCateId.Enabled = true;
            tbStuName.Enabled = true;
            tbStuClass. Enabled = true;
            cbStuCateId.Enabled = true;
            btnSaveStu.Enabled = true;
            btnAddStu.Enabled = false;
            // Lay du lieu tu category do vao combobox
            getCategory();
        }

        private void btnSaveStu_Click(object sender, EventArgs e)
        {
            string stu_name = tbStuName.Text;
            string stu_class = tbStuClass.Text;
            string cate_id = cbStuCateId.SelectedValue.ToString();
            MySqlConnection connection = new MySqlConnection(mySqlConnection);
            string sql = "INSERT INTO tbl_student (stu_name, stu_class, cate_id) VALUES (@stu_name, @stu_class, @cate_id)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@stu_name", stu_name);
            command.Parameters.AddWithValue("@stu_class", stu_class);
            command.Parameters.AddWithValue("@cate_id", cate_id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Form1_Load(null, null);
            

        }

        private void btnEditStu_Click(object sender, EventArgs e)
        {
            string stu_name = tbStuName.Text;
            int stu_id = Int32.Parse(tbStuId.Text);
            string stu_class = tbStuClass.Text;
            string cate_id = cbStuCateId.SelectedValue.ToString(); 

            MySqlConnection connection = new MySqlConnection(mySqlConnection);
            string sql = "UPDATE tbl_student SET stu_name = '" + stu_name + "', stu_class = '" + stu_class + "', cate_id = '" + cate_id + "' WHERE stu_id = " + stu_id;


            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Form1_Load(null, null);        
        }

        private void btnDeleteStu_Click(object sender, EventArgs e)
        {
            int stu_id = Int32.Parse(tbStuId.Text);
            MySqlConnection connection = new MySqlConnection(mySqlConnection);
            string sql = "DELETE FROM tbl_student WHERE stu_id = " + stu_id; // Remove single quotes around prd_id

            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Form1_Load(null, null);
        }

        private void cellClickStu(object sender, DataGridViewCellEventArgs e)
        {   btnEditStu.Enabled = true;
            btnDeleteStu.Enabled = true;
            lbStuName.Enabled = true;
            lbStuClass.Enabled = true;
            lbStuCateId.Enabled = true;
            
            tbStuName.Enabled = true;
            tbStuClass.Enabled = true;
            cbStuCateId.Enabled = true;
            
            btnSaveStu.Enabled = true;
            btnAddStu.Enabled = false;
            
            string cate_name = dgvStudent.Rows[e.RowIndex].Cells["cate_name"].Value.ToString();
            string stu_id = dgvStudent.Rows[e.RowIndex].Cells["stu_id"].Value.ToString();
            string stu_name = dgvStudent.Rows[e.RowIndex].Cells["stu_name"].Value.ToString();
            string stu_class = dgvStudent.Rows[e.RowIndex].Cells["stu_class"].Value.ToString();
            
            tbStuName.Text = stu_name;
            tbStuClass.Text = stu_class;
            tbStuId.Text = stu_id;
            getCategory();
            int index = cbStuCateId.FindStringExact(cate_name);
            if (index != -1)
            {
                cbStuCateId.SelectedIndex = index;
            }    
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Đăng_Nhập d = new Đăng_Nhập();
            d.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string stuCode = tbSearch.Text;

            MySqlConnection connection = new MySqlConnection(mySqlConnection);
            string sql = "SELECT * FROM tbl_student WHERE stu_id = '" + stuCode + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                tbStuId.Text = table.Rows[0]["stu_id"].ToString();
                tbStuName.Text = table.Rows[0]["stu_name"].ToString();
                tbStuClass.Text = table.Rows[0]["stu_class"].ToString();
                cbStuCateId.SelectedValue = table.Rows[0]["cate_id"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy học sinh có mã " + stuCode);
            }

        }
    }
}