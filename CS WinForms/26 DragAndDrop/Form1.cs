using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_DragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDropSource_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(txtDropSource.Text, DragDropEffects.Copy);
            //txtDropSource.Text = "";  // 만약 Move 이면 소스를 이렇게 지움
        }

        private void txtDropTarget_DragEnter(object sender, DragEventArgs e)
        {
            // 데이타가 문자열 타입이면 복사하고, 아니면 Drop 무효처리
            if (e.Data.GetDataPresent(typeof(string)))
            {
                // Drop하여 복사함
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                // Drop 할 수 없음
                e.Effect = DragDropEffects.None;
            }
        }

        private void txtDropTarget_DragDrop(object sender, DragEventArgs e)
        {
            // e.Data.GetData() 메서드는 드래그-앤-드롭에서 전달된 데이타를 가져옴.
            // 타켓컨트롤(txtDropTarget)에 드랍 데이타 지정
            txtDropTarget.Text = (string)e.Data.GetData(DataFormats.StringFormat);
        }

        // Drop Source: ItemDrag 이벤트 핸들러에서 DoDragDrop 호출
        private void lvwSrc_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        // Drop Target: DragEnter 핸들러에서 해당 소스가 ListViewItem 인지 체크
        private void lvwTgt_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // Drop Target: DragDrop 핸들러에서 복사 실행
        private void lvwTgt_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                // 드래그된 소스 ListViewItem
                var item = e.Data.GetData(typeof(ListViewItem)) as ListViewItem;

                // ListViewItem를 Clone하여 추가
                lvwTgt.Items.Add(item.Clone() as ListViewItem);
            }
        }
    }
}
