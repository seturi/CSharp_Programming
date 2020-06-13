namespace _02_CheckBoxControl
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkEvents = new System.Windows.Forms.CheckBox();
            this.checkEvent1 = new System.Windows.Forms.CheckBox();
            this.checkEvent2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(77, 82);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "정기 뉴스 메일 수신";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkEvents
            // 
            this.checkEvents.AutoSize = true;
            this.checkEvents.Checked = true;
            this.checkEvents.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkEvents.Location = new System.Drawing.Point(77, 117);
            this.checkEvents.Name = "checkEvents";
            this.checkEvents.Size = new System.Drawing.Size(144, 19);
            this.checkEvents.TabIndex = 1;
            this.checkEvents.Text = "특별 이벤트 수신";
            this.checkEvents.UseVisualStyleBackColor = true;
            this.checkEvents.CheckedChanged += new System.EventHandler(this.checkEvents_CheckedChanged);
            // 
            // checkEvent1
            // 
            this.checkEvent1.AutoSize = true;
            this.checkEvent1.Checked = true;
            this.checkEvent1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEvent1.Location = new System.Drawing.Point(102, 153);
            this.checkEvent1.Name = "checkEvent1";
            this.checkEvent1.Size = new System.Drawing.Size(82, 19);
            this.checkEvent1.TabIndex = 2;
            this.checkEvent1.Text = "이벤트1";
            this.checkEvent1.UseVisualStyleBackColor = true;
            // 
            // checkEvent2
            // 
            this.checkEvent2.AutoSize = true;
            this.checkEvent2.Location = new System.Drawing.Point(102, 178);
            this.checkEvent2.Name = "checkEvent2";
            this.checkEvent2.Size = new System.Drawing.Size(82, 19);
            this.checkEvent2.TabIndex = 3;
            this.checkEvent2.Text = "이벤트2";
            this.checkEvent2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 283);
            this.Controls.Add(this.checkEvent2);
            this.Controls.Add(this.checkEvent1);
            this.Controls.Add(this.checkEvents);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkEvents;
        private System.Windows.Forms.CheckBox checkEvent1;
        private System.Windows.Forms.CheckBox checkEvent2;
    }
}

