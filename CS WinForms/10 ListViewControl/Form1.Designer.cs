namespace _10_ListViewControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.radioDetails = new System.Windows.Forms.RadioButton();
            this.radioList = new System.Windows.Forms.RadioButton();
            this.radioTitle = new System.Windows.Forms.RadioButton();
            this.radioLarge = new System.Windows.Forms.RadioButton();
            this.radioSmall = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(559, 392);
            this.listView1.SmallImageList = this.imageList2;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // radioDetails
            // 
            this.radioDetails.AutoSize = true;
            this.radioDetails.Location = new System.Drawing.Point(605, 103);
            this.radioDetails.Name = "radioDetails";
            this.radioDetails.Size = new System.Drawing.Size(106, 19);
            this.radioDetails.TabIndex = 1;
            this.radioDetails.TabStop = true;
            this.radioDetails.Text = "View.Details";
            this.radioDetails.UseVisualStyleBackColor = true;
            this.radioDetails.CheckedChanged += new System.EventHandler(this.radioDetails_CheckedChanged);
            // 
            // radioList
            // 
            this.radioList.AutoSize = true;
            this.radioList.Location = new System.Drawing.Point(605, 149);
            this.radioList.Name = "radioList";
            this.radioList.Size = new System.Drawing.Size(85, 19);
            this.radioList.TabIndex = 2;
            this.radioList.TabStop = true;
            this.radioList.Text = "View.List";
            this.radioList.UseVisualStyleBackColor = true;
            this.radioList.CheckedChanged += new System.EventHandler(this.radioList_CheckedChanged);
            // 
            // radioTitle
            // 
            this.radioTitle.AutoSize = true;
            this.radioTitle.Location = new System.Drawing.Point(605, 193);
            this.radioTitle.Name = "radioTitle";
            this.radioTitle.Size = new System.Drawing.Size(88, 19);
            this.radioTitle.TabIndex = 3;
            this.radioTitle.TabStop = true;
            this.radioTitle.Text = "View.Title";
            this.radioTitle.UseVisualStyleBackColor = true;
            this.radioTitle.CheckedChanged += new System.EventHandler(this.radioTitle_CheckedChanged);
            // 
            // radioLarge
            // 
            this.radioLarge.AutoSize = true;
            this.radioLarge.Location = new System.Drawing.Point(605, 238);
            this.radioLarge.Name = "radioLarge";
            this.radioLarge.Size = new System.Drawing.Size(126, 19);
            this.radioLarge.TabIndex = 4;
            this.radioLarge.TabStop = true;
            this.radioLarge.Text = "View.LargeIcon";
            this.radioLarge.UseVisualStyleBackColor = true;
            this.radioLarge.CheckedChanged += new System.EventHandler(this.radioLarge_CheckedChanged);
            // 
            // radioSmall
            // 
            this.radioSmall.AutoSize = true;
            this.radioSmall.Location = new System.Drawing.Point(605, 287);
            this.radioSmall.Name = "radioSmall";
            this.radioSmall.Size = new System.Drawing.Size(125, 19);
            this.radioSmall.TabIndex = 5;
            this.radioSmall.TabStop = true;
            this.radioSmall.Text = "View.SmallIcon";
            this.radioSmall.UseVisualStyleBackColor = true;
            this.radioSmall.CheckedChanged += new System.EventHandler(this.radioSmall_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icebear.ico");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "icebear.ico");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 416);
            this.Controls.Add(this.radioSmall);
            this.Controls.Add(this.radioLarge);
            this.Controls.Add(this.radioTitle);
            this.Controls.Add(this.radioList);
            this.Controls.Add(this.radioDetails);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton radioDetails;
        private System.Windows.Forms.RadioButton radioList;
        private System.Windows.Forms.RadioButton radioTitle;
        private System.Windows.Forms.RadioButton radioLarge;
        private System.Windows.Forms.RadioButton radioSmall;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}

