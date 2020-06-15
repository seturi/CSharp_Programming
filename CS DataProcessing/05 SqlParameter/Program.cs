using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SqlParameter
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Sample
    {
        // SqlParameter 클래스
        public DataSet GetEmp(string city, DateTime date)
        {
            DataSet ds = new DataSet();
            string strConn = "Data Source=swnote-pc\\sqlexpress;Initial Catalog=mydb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            // 2개의 파라미터 정의 (항상 @로 시작)
            string sql = "SELECT * FROM Employees WHERE City=@city AND [Hire Date]>=@date";
            SqlCommand cmd = new SqlCommand(sql, conn);

            // 각 파라미터 타입 및 값 입력
            SqlParameter paramCity = new SqlParameter("@city", SqlDbType.NVarChar, 15);
            paramCity.Value = city;
            
            // SqlCommand 객체의 Parameters 속성에 추가
            cmd.Parameters.Add(paramCity);

            SqlParameter paramHire = new SqlParameter("@date", SqlDbType.DateTime);
            paramHire.Value = date;
            cmd.Parameters.Add(paramHire);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();
            return ds;
        }

        // parameter 지정하는 다양한 표현들
        public void ParameterDesignation()
        {
            string strConn = "Data Source=swnote-pc\\sqlexpress;Initial Catalog=mydb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("Insert tbl Values (@name, @age, @date, @image)", conn);

            // (A) nvarchar(15) 인 name 컬럼값 지정 예
            SqlParameter paramName = new SqlParameter("@name", SqlDbType.NVarChar, 15);
            paramName.Value = "Tom";
            cmd.Parameters.Add(paramName);

            // (B) 정수컬럼 지정 예
            var paramAge = new SqlParameter("@age", SqlDbType.Int).Value = 20;
            cmd.Parameters.Add(paramName);

            // (C) AddWithValue()를 써서 데이타타입 지정없이 날짜 값을 직접 지정한 경우
            cmd.Parameters.AddWithValue("@date", DateTime.Today);

            // (D) 이미지를 varbinary(MAX) 에 지정하는 경우
            var paramImage = new SqlParameter("@image", SqlDbType.VarBinary, -1);
            // paramImage.Value = imageBytes;  // 이미지를 byte[]로 지정함
            cmd.Parameters.Add(paramImage);
            
            // (E) AddWithValue를 써서 이미지 지정 (자동으로 인식됨)
            // cmd.Parameters.AddWithValue("@picture", imageBytes);

            cmd.ExecuteNonQuery();
        }

        // 호출: H를 포함하는 이름들
        // var ds = QueryByName("H");
        private DataSet QueryByName(string name)
        {
            DataSet ds = new DataSet();

            string strConn = "Data Source=.;Initial Catalog=MyDB;Integrated Security=SSPI;";

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                string sql = "SELECT * FROM Customer WHERE Name LIKE @Name";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", "%" + name + "%"); //name을 포함하는 문자열
                                                                        // cmd.Parameters.AddWithValue("@Name", name + "%");   //name으로 시작하는 문자열

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
            }

            return ds;
        }


        // 저장 프로시져의 파라미터
        static void Run()
        {
            string strCn = "Data Source=.;Initial Catalog=MyDB;Integrated Security=true";

            using (SqlConnection conn = new SqlConnection(strCn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_GetNext", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Input param
                SqlParameter pInput = new SqlParameter("@in", SqlDbType.Int);
                pInput.Direction = ParameterDirection.Input;
                pInput.Value = 1;
                cmd.Parameters.Add(pInput);

                // Output param
                SqlParameter pOutput = new SqlParameter("@out", SqlDbType.Int);
                pOutput.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOutput);

                // Return value
                SqlParameter pReturn = new SqlParameter();
                pReturn.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(pReturn);

                // Run SP
                cmd.ExecuteNonQuery();

                Console.WriteLine(pOutput.Value); // output
                Console.WriteLine(pReturn.Value); // return value
            }
        }

        // SP TABLE 데이타와 OUTPUT 파라미터 리턴
        static void Run2()
        {
            string strCn = "Data Source=.;Initial Catalog=MyDB;Integrated Security=true";

            using (SqlConnection conn = new SqlConnection(strCn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_GetData", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parameter 지정
                var _param = new[] {
            new SqlParameter {
                ParameterName="@range1",
                Direction = ParameterDirection.Input,
                Value = 1
            },
            new SqlParameter {
                ParameterName="@range2",
                Direction = ParameterDirection.Input,
                Value = 3
            },
            new SqlParameter {
                ParameterName="@sum",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.Int
            }
        };
                cmd.Parameters.AddRange(_param);

                // SP 실행. 테이블 데이타 사용
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0]);
                    }
                }

                // OUTPUT 파라미터 사용
                int sum = (int)cmd.Parameters["@sum"].Value;
                Console.WriteLine(sum);
            }
        }
    }
}
