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

namespace _17_CustomerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source = (local);Initial Catalog=mydb;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string id = txtNo.Text;
            string name = txtName.Text;
            string email = txtEmail.Text;
            string sql = "INSERT Customer VALUES (" + id + ", N'" + name + "','" + email + "')";
            //string sql = "UPDATE Customer SET Email='kangkc@live.com' WHERE Id=3";
            //string sql = "DELETE FROM Customer WHERE Id>=2";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
