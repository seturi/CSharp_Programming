using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DataSetMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        
        // DataSet 테이블 병합
        public void Sample1()
        {
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();

            string strConn1 = "Data Source=(local);Initial catalog=pubs;Integrated Security=SSPI;";
            string strConn2 = "Data Source=(local);Initial catalog=pubs2;Integrated Security=SSPI;";

            string sql = "SELECT * FROM authors";

            // pubs DB에서 authors 테이블 가져오기 (23개 rows).
            SqlDataAdapter adpt1 = new SqlDataAdapter(sql, strConn1);
            adpt1.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adpt1.Fill(ds1);
            adpt1.Dispose();

            // pubs2 DB에서 authors 테이블 가져오기.
            // (24개 rows : 1개 row가 추가되었고, 1 row가 Update됨)
            SqlDataAdapter adpt2 = new SqlDataAdapter(sql, strConn2);
            adpt2.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adpt2.Fill(ds2);
            adpt2.Dispose();

            // Merge후 authors에는 1개 추가 row와 갱신된 1개 row가 있음.
            Console.WriteLine("Before Merge: {0}", ds1.Tables[0].Rows.Count);
            ds1.Merge(ds2);
            Console.WriteLine("After Merge: {0}", ds1.Tables[0].Rows.Count);

            foreach (DataRow r in ds1.Tables[0].Rows)
            {
                Console.WriteLine("{0}: {1} {2}", r[0], r[1], r[2]);
            }
        }

        // DataSet 테이블 추가 병합
        public void Sample2()
        {
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            string strConn1 = "Data Source=(local);Initial catalog=pubs;Integrated Security=SSPI;";

            // ds1 에는 authors 테이블
            string sql = "SELECT * FROM authors";

            SqlDataAdapter adpt1 = new SqlDataAdapter(sql, strConn1);
            adpt1.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adpt1.Fill(ds1);
            adpt1.Dispose();

            // ds2 에는 titles 테이블과 employee 테이블 2개
            sql = "SELECT * FROM titles; SELECT * FROM employee";

            SqlDataAdapter adpt2 = new SqlDataAdapter(sql, strConn1);
            adpt2.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adpt2.Fill(ds2);
            adpt2.Dispose();

            // ds2의 두 테이블을 ds1으로 병합
            ds1.Merge(ds2);

            // 병합 후 ds1에는 총 3개의 테이블이 존재
            foreach (DataRow r in ds1.Tables[0].Rows)
            {
                Console.WriteLine(r[0]);
            }
            foreach (DataRow r in ds1.Tables[1].Rows)
            {
                Console.WriteLine(r[0]);
            }
            foreach (DataRow r in ds1.Tables[2].Rows)
            {
                Console.WriteLine(r[0]);
            }
        }

        // 특정 DataTable 병합
        public void Sample3()
        {
            DataSet ds1 = new DataSet();
            string strConn2 = "Data Source=(local);Initial catalog=pubs2;Integrated Security=SSPI;";

            // authors 테이블을 authors1 DataTable에 채움
            string sql = "SELECT * FROM authors";
            SqlDataAdapter adpt = new SqlDataAdapter(sql, strConn2);
            adpt.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adpt.Fill(ds1, "authors1");

            // authors2 테이블을 authors2 DataTable에 채움
            sql = "SELECT * FROM authors2";
            adpt = new SqlDataAdapter(sql, strConn2);
            adpt.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adpt.Fill(ds1, "authors2");

            // authors2 DataTable을 authors1 DataTable에 병합
            ds1.Tables["authors1"].Merge(ds1.Tables["authors2"]);

            foreach (DataRow r in ds1.Tables["authors1"].Rows)
            {
                Console.WriteLine("{0}: {1} {2}", r[0], r[1], r[2]);
            }
        }
    }
}
