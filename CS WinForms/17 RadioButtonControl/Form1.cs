using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_RadioButtonControl
{
    public partial class Form1 : Form
    {
        enum Meat
        {
            등심,
            안심,
            갈비
        }

        private Meat _selectedMeat;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this._selectedMeat = Meat.등심;
            DisplayMenu();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this._selectedMeat = Meat.안심;
            DisplayMenu();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this._selectedMeat = Meat.갈비;
            DisplayMenu();
        }

        private void DisplayMenu()
        {
            lblMsg.Text = string.Format("{0} 메뉴를 선택하셨습니다." ,this._selectedMeat.ToString());
        }
    }
}
