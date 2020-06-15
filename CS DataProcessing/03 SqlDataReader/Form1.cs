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

namespace _03_SqlDataReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySample sample = new MySample();
            SqlDataReader dr = sample.GetDataReader();
            dr.Read();
            String data = dr[0].ToString();
            dr.Close();
        }
    }

    class MySample
    {
        public void Sample()
        {
            string strConn = "Data Source=swnote-pc\\sqlexpress;Initial Catalog=mydb;Integrated Security=True";
            StringBuilder sb = new StringBuilder();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM Customer";

                // SqlDataReader 객체를 리턴
                //SqlDataReader rdr = cmd.ExecuteReader();

                // 문제점 해결 방법: 
                // System.Data.CommandBehavior.CloseConnection
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                // 다음 레코드 계속 가져와서 루핑
                while (rdr.Read())
                {
                    // C# 인덱서를 사용하여
                    // 필드 데이터 엑세스
                    string s = rdr["name"] as string;
                    sb.Append(s);
                }
                // 사용후 닫음
                rdr.Close();

            }
            //... sb 데이터 사용
        }

        // SqlDataReader 객체를 리턴
        public SqlDataReader GetDataReader()
        {
            string strConn = "Data Source=swnote-pc\\sqlexpress;Initial Catalog=mydb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Customer";
            SqlDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }
    }
}
