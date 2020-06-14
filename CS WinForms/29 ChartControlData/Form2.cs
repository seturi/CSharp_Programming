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

namespace _29_ChartControlData
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            // (1) DataBindTable() 사용
            string strConn = "Data Source=swnote-pc\\sqlexpress;Initial Catalog=mydb;Integrated Security=True";
            string sql = "SELECT store, sales FROM Sales";

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                // IDataReader 객체와 X축 필드를 지정한다
                chart5.DataBindTable(dataReader, "store");
            }

            // (2) DataSource와 DataBind() 사용
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(ds);

                // DataTable 객체를 DataSource에 지정하고,
                // X,Y축 컬럼을 XValueMember와 YValueMembers에 지정
                chart6.DataSource = ds.Tables[0];
                chart6.Series[0].XValueMember = "store";
                chart6.Series[0].YValueMembers = "sales";
                chart6.DataBind();
            }

            // (3) Points.DataBind() 사용
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                // IDataReader 객체와 X, Y축 컬럼 지정. 
                // 4번째 Param: 툴팁과 같은 다른 필드 지정가능. 여기선 sales 컬럼값을 툴팁에 표시
                chart7.Series[0].Points.DataBind(dataReader, "store", "sales", "Tooltip=sales");
            }
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
