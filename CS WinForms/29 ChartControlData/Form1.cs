using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_ChartControlData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            // (1) Y값 배열 데이타바인딩
            double[] scores = new double[] { 80, 90, 85, 70, 95 };
            chart1.Series[0].Points.DataBindY(scores);

            // (2) X, Y값 List<T> 데이타바인딩
            List<string> x = new List<string> { "철수", "영희", "길동", "재동", "민희" };
            List<double> y = new List<double> { 80, 90, 85, 70, 95 };
            chart2.Series[0].Points.DataBindXY(x, y);

            // (3) 객체 컬렉션에 대한 데이타바인딩
            List<Student> students = new List<Student>();
            students.Add(new Student("철수", 80));
            students.Add(new Student("영희", 90));
            students.Add(new Student("길동", 85));

            // X축: Name, Y축: Score
            chart3.Series[0].Points.DataBind(students, "Name", "Score", null);

            // (참고) DataBindTable() 사용시. (X축: Name, Y축: 자동검색)
            // chart3.DataBindTable(students, "Name"); 
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }

    class Student
    {
        public string Name { get; set; }
        public double Score { get; set; }

        public Student(string name, double score)
        {
            this.Name = name;
            this.Score = score;
        }
    }
}
