using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _02_SqlCommand
{
    class Program
    {
        // SqlCommand 클래스
        public void Sample1()
        {
            string strConn = "Data Source=swnote-pc\\sqlexpress;Initial Catalog=mydb;Integrated Security=True";
            string sql = "SELECT * FROM Customer";

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                // TSQL문장과 Connection 객체를 지정   
                SqlCommand cmd = new SqlCommand(sql, conn);

                // 데이타는 서버에서 가져오도록 실행
                SqlDataReader rdr = cmd.ExecuteReader();
            }
        }

        // SqlCommand.ExecuteNonQuery 사용
        public void Sample2()
        {
            string strConn = "Data Source=swnote-pc\\sqlexpress;Initial Catalog=mydb;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT Table1 VALUES(1, N'광화문')";
                cmd.ExecuteNonQuery();
            }

        }

        // SqlCommand.ExecuteReader 사용
        public void Sample3()
        {
            string strConn = "Data Source=swnote-pc\\sqlexpress;Initial Catalog=mydb;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM Table1";
                SqlDataReader rdr = cmd.ExecuteReader();
                //... Display 데이터
            }
        }

        // SqlCommand.ExecuteScalar 사용
        public void Sample4()
        {
            string strConn = "Data Source=swnote-pc\\sqlexpress;Initial Catalog=mydb;Integrated Security=True";
            int count = 0;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT COUNT(*) FROM Table1";
                object scalarValue = cmd.ExecuteScalar();
                count = (int)scalarValue;
            }
            Console.WriteLine("레코드수 : {0}", count);
        }

        // SqlCommand.ExecuteXmlReader 사용
        public void Sample5()
        {
            string strConn = "Data Source=swnote-pc\\sqlexpress;Initial Catalog=mydb;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT XmlData FROM TabX WHERE Id=1 FOR XML AUTO";

                // XML 데이타를 리턴받아 XmlReader객체에 넣는다.
                XmlReader xdr = cmd.ExecuteXmlReader();
                xdr.MoveToContent();
                Debug.WriteLine(xdr.ReadInnerXml());
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
