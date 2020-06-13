using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_ComboBoxControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] data = { "사과", "토마토", "포도", "배", "복숭아" };

            // 각 콤보박스에 데이타를 초기화
            comboSimple.Items.AddRange(data);
            comboDropDown.Items.AddRange(data);
            comboDropDownList.Items.AddRange(data);

            // 처음 선택값 지정. 첫째 아이템 선택
            comboSimple.SelectedIndex = 0;
            comboDropDown.SelectedIndex = 0;
            comboDropDownList.SelectedIndex = 0;
        }

        private void comboDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDropDown.SelectedIndex >= 0)
            {
                this.itemSelected = comboDropDown.SelectedItem as string;
            }
        }

        private string itemSelected;
    }
}
