using _05_DataGridView.mydbDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_DataGridView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'mydbDataSet.Customer' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.customerTableAdapter.Fill(this.mydbDataSet.Customer);
        }

        // 갱신 데이터 저장
        private void btnSave_Click(object sender, EventArgs e)
        {
            //DataSource로부터 DataSet 객체를 추출
            //TestDBDataSet은 자동 생성된 DataSet 파생클래스
            BindingSource bs = (BindingSource)dataGridView1.DataSource;
            mydbDataSet ds = bs.DataSource as mydbDataSet;

            // 자동 생성된 TableAdapter 클래스의 Update() 호출. 
            // 갱신데이타 소스인 DataTable을 파라미터로 넘김
            this.customerTableAdapter.Update(ds.Customer);
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Row헤더, Column헤더인 경우 그냥 리턴
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            // 오른쪽 마우스 버튼인 경우
            if (e.Button == MouseButtons.Right)
            {
                var grid = sender as DataGridView;

                // 마우스 RightClick해도 현재 Cell 을 선택함
                grid.CurrentCell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }
    }
}
