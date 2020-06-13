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

namespace _05_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // DataSet을 가져온다
            DataSet ds = GetData();

            // DataSource 속성을 설정
            dataGridView1.DataSource = ds.Tables[0];
        }

        private DataSet GetData()
        {
            string strConn = "Data Source=swnote-pc\\sqlexpress;Initial Catalog=mydb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customer", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
