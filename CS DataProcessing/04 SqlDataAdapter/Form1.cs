using _03_SqlDataAdapter;
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

namespace _04_SqlDataAdapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            // GetData 메서드 호출하여 DataSet 가져옴
            MySample sample = new MySample();
            DataSet dataSet = sample.GetData();

            // DataSet을 DataGridView 컨트롤에 바인딩
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }

    class MySample
    {
        string strConn = "Data Source=swnote-pc\\sqlexpress;Initial Catalog=mydb;Integrated Security=True";

        public DataSet GetData()
        {
            DataSet ds = new DataSet();

            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            string sql = "SELECT * FROM Customer ORDER BY id";

            // SqlDataAdapter 초기화
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            // Fill 메서드 실행하여 결과 DataSet을 리턴받음
            adapter.Fill(ds);

            conn.Close();
            return ds;
        }
    }
}
