using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SqlConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            string strConn = "Data Source=swnote-pc\\sqlexpress;Initial Catalog=mydb;Integrated Security=True";

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                // Do something here
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            // 다음과 같이 바꿀 수 있다.
            //using (SqlConnection conn = new SqlConnection(strConn))
            //{
            //    conn.Open();
            //    // Do something here
            //}
        }
    }
}
