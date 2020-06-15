using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _06_ConnectionPooling
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Sample
    {
        public void TestConnectionPool()
        {
            // 최소 20 Connection 지정
            string strConn = "Data Source=(local);Initial Catalog=pubs;User id=test;Password=1;Min Pool Size=20;";

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                var cmd = new SqlCommand("select * from authors", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
            }

            // ClearAllPools 호출 이전
            // 결과 : 20 커넥션
            ShowPerfCounter();
            Console.WriteLine("Press Enter.");
            Console.ReadLine();

            // ClearAllPools 호출 이후
            // 결과 : 0 커넥션
            SqlConnection.ClearAllPools();
            Console.WriteLine("After ClearAllPools");
            ShowPerfCounter();
        }

        private void ShowPerfCounter()
        {
            string processName = Assembly.GetExecutingAssembly().GetName().Name;
            int pid = Process.GetProcessesByName(processName)[0].Id;
            string instanceName = string.Format("{0}[{1}]", processName, pid);

            // .NET Data Provider for SqlServer 카테고리 안의
            // NumberOfPooledConnections 카운터 측정
            var counter1 = new PerformanceCounter(".NET Data Provider for SqlServer", "NumberOfPooledConnections", instanceName);
            var v1 = counter1.NextValue();
            Console.WriteLine(v1);
        }
    }
}
