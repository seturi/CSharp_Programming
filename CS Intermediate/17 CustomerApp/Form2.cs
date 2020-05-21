using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_CustomerApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataSet ds = GetData();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private DataSet GetData()
        {
            string connStr = "Data Source = (local);Initial Catalog=mydb;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            // 데이터 가져오기
            //string sql = "SELECT * FROM Customer";
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //SqlDataReader rdr = cmd.ExecuteReader();
            //while (rdr.Read())
            //{
            //    string rowData = rdr["Id"] + ": " + rdr[1] + ", " + rdr["Email"];
            //    Debug.WriteLine(rowData);
            //}
            //rdr.Close();

            DataSet ds = new DataSet();
            string sql = "SELECT * FROM Customer";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(ds);
            conn.Close();

            return ds;
        }
    }
}
