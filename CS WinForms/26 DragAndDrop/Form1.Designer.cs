namespace _26_DragAndDrop
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("1번");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("2번");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("3번");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("마지막!");
            this.txtDropSource = new System.Windows.Forms.TextBox();
            this.txtDropTarget = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvwSrc = new System.Windows.Forms.ListView();
            this.lvwTgt = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDropSource
            // 
            this.txtDropSource.Location = new System.Drawing.Point(71, 80);
            this.txtDropSource.Name = "txtDropSource";
            this.txtDropSource.Size = new System.Drawing.Size(249, 25);
            this.txtDropSource.TabIndex = 0;
            this.txtDropSource.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtDropSource_MouseDown);
            // 
            // txtDropTarget
            // 
            this.txtDropTarget.AllowDrop = true;
            this.txtDropTarget.Location = new System.Drawing.Point(392, 80);
            this.txtDropTarget.Name = "txtDropTarget";
            this.txtDropTarget.Size = new System.Drawing.Size(256, 25);
            this.txtDropTarget.TabIndex = 1;
            this.txtDropTarget.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDropTarget_DragDrop);
            this.txtDropTarget.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDropTarget_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "txtDropSource";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "txtDropTarget";
            // 
            // lvwSrc
            // 
            this.lvwSrc.HideSelection = false;
            this.lvwSrc.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lvwSrc.Location = new System.Drawing.Point(71, 160);
            this.lvwSrc.Name = "lvwSrc";
            this.lvwSrc.Size = new System.Drawing.Size(249, 114);
            this.lvwSrc.TabIndex = 4;
            this.lvwSrc.UseCompatibleStateImageBehavior = false;
            this.lvwSrc.View = System.Windows.Forms.View.List;
            this.lvwSrc.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvwSrc_ItemDrag);
            // 
            // lvwTgt
            // 
            this.lvwTgt.AllowDrop = true;
            this.lvwTgt.HideSelection = false;
            this.lvwTgt.Location = new System.Drawing.Point(392, 160);
            this.lvwTgt.Name = "lvwTgt";
            this.lvwTgt.Size = new System.Drawing.Size(256, 114);
            this.lvwTgt.TabIndex = 5;
            this.lvwTgt.UseCompatibleStateImageBehavior = false;
            this.lvwTgt.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvwTgt_DragDrop);
            this.lvwTgt.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvwTgt_DragEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "lvwTgt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "lvwSrc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 314);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvwTgt);
            this.Controls.Add(this.lvwSrc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDropTarget);
            this.Controls.Add(this.txtDropSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDropSource;
        private System.Windows.Forms.TextBox txtDropTarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvwSrc;
        private System.Windows.Forms.ListView lvwTgt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

