using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_ListBoxControl
{
    public partial class Form1 : Form
    {
        // 멤버쉽 Enum 타입
        public enum MemberType
        {
            VIP = 0,
            Regular,
            Associate,
            DayPass
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("VIP 회원");
            listBox1.Items.Add("정회원");
            listBox1.Items.Add("준회원");
            listBox1.Items.Add("일일 회원");

            // 정회원이 기본 선택
            listBox1.SelectedIndex = 1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            memberType = (MemberType)listBox1.SelectedIndex;
        }

        private MemberType memberType;
    }
}
