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

namespace _03_SqlDataAdapter
{
    public partial class Form2 : Form
    {
        const int PAGE_SIZE = 10;
        int pageStartPosition = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var ds = GetData(pageStartPosition);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (pageStartPosition - PAGE_SIZE < 0) return;

            pageStartPosition -= PAGE_SIZE;

            var ds = GetData(pageStartPosition);

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Sales";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pageStartPosition += PAGE_SIZE;
            var ds = GetData(pageStartPosition);

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Sales";
        }

        private DataSet GetData(int pageStart = 0, int pageSize = PAGE_SIZE)
        {
            string strConn = "Data Source=swnote-pc\\sqlexpress;Initial Catalog=mydb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Sales ORDER BY id", conn);
            DataSet ds = new DataSet();

            // 페이지 처음 위치(pageStart)와 페이지 크기(pageSize) 지정
            adapter.Fill(ds, pageStart, pageSize, "Sales");

            return ds;
        }
    }
}
