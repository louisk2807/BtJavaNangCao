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

namespace DemoWindowForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string sqlConnection = "server= localhost; user id= root; password= ; database= c#";
        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(sqlConnection);
            string sql = "SELECT * FROM  tbl_user";
            MySqlDataAdapter query = new MySqlDataAdapter(sql, connection);
            DataSet item = new DataSet();
            query.Fill(item, "tbl_user");
            dgvUser.DataSource = item.Tables["tbl_user"].DefaultView;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }


        

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullname = tbFullname.Text;
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string rePassword = tbRePassword.Text;
            string address = tbAddress.Text;
            string phone = tbPhone.Text;
            MySqlConnection connection = new MySqlConnection(sqlConnection);
    
            if (password == rePassword)
            {
                string sql = "INSERT INTO tbl_user " +
                             "(fullname, username, password, address, phone) " +
                             "VALUES " +
                             "('" + fullname + "','" + username + "','" + password + "','" + address + "','" + phone + "')";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                Form1_Load(null, null);
            }   
            else
            {
                MessageBox.Show("Nhap lai mat khau khong dung !");
            }
        }



        private void btnADD_Click_1(object sender, EventArgs e)
        {
            lbFullname.Enabled = true;
            lbUsername.Enabled = true;
            lbPassword.Enabled = true;
            lbRePassword.Enabled = true;
            lbAddess.Enabled = true;
            lbPhone.Enabled = true;
            tbFullname.Enabled = true;
            tbUsername.Enabled = true;
            tbPassword.Enabled = true;
            tbRePassword.Enabled = true;
            tbAddress.Enabled = true;
            tbPhone.Enabled = true;
            btnSave.Enabled = true;
            btnADD.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvUser.SelectedRows[0];
                int userId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection connection = new MySqlConnection(sqlConnection))
                    {
                        string deleteSql = "DELETE FROM tbl_user WHERE id = @id";
                        MySqlCommand command = new MySqlCommand(deleteSql, connection);
                        command.Parameters.AddWithValue("@id", userId);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    
                }
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }
    }
}