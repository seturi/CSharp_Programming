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

namespace _07_DataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // DataSet 클래스
        public void Sample1()
        {
            string strConn = "Data Source=swnote-pc\\sqlexpress;Initial Catalog=mydb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customer", conn);

            // DataSet에 테이블 데이타를 넣음
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Customer");

            conn.Close();
        }

        // DataTable 클래스
        public void Sample2()
        {
            string strConn = "Data Source=swnote-pc\\sqlexpress;Initial Catalog=mydb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customer", conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Tab1");
            DataTable dt = ds.Tables["Tab1"];
        }

        // DataView 클래스
        public void Sample3()
        {
            string strConn = "Data Source=swnote-pc\\sqlexpress;Initial Catalog=mydb;Integrated Security=True";
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM AAA", conn);
                adpt.Fill(ds, "AAA");
            }

            // DataTable.DefaultView를 사용하여
            // 필터링 (name컬럼이 L로 시직하는 경우)
            DataTable dt = ds.Tables["AAA"];
            dt.DefaultView.RowFilter = "name like 'L%'";

            dataGridView1.DataSource = dt;
        }
    }
}
