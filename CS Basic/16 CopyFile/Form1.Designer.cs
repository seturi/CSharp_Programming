namespace _16_CopyFile
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
            this.btnCopy = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblPct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(255, 81);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(194, 111);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "파일 복사 시작";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(61, 224);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(599, 37);
            this.progressBar1.TabIndex = 1;
            // 
            // lblPct
            // 
            this.lblPct.AutoSize = true;
            this.lblPct.Location = new System.Drawing.Point(344, 279);
            this.lblPct.Name = "lblPct";
            this.lblPct.Size = new System.Drawing.Size(26, 15);
            this.lblPct.TabIndex = 2;
            this.lblPct.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 416);
            this.Controls.Add(this.lblPct);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnCopy);
            this.Name = "Form1";
            this.Text = "파일복사 프로그램";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopy;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label lblPct;
    }
}

