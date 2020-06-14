namespace _18_TextBoxControl
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
            this.txtSingleLine = new System.Windows.Forms.TextBox();
            this.txtMultiLine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSingleLine
            // 
            this.txtSingleLine.Location = new System.Drawing.Point(112, 100);
            this.txtSingleLine.Name = "txtSingleLine";
            this.txtSingleLine.Size = new System.Drawing.Size(270, 25);
            this.txtSingleLine.TabIndex = 0;
            this.txtSingleLine.TextChanged += new System.EventHandler(this.txtSingleLine_TextChanged);
            // 
            // txtMultiLine
            // 
            this.txtMultiLine.Location = new System.Drawing.Point(112, 183);
            this.txtMultiLine.Multiline = true;
            this.txtMultiLine.Name = "txtMultiLine";
            this.txtMultiLine.Size = new System.Drawing.Size(270, 162);
            this.txtMultiLine.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Multiline=false";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Multiline=true";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 455);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMultiLine);
            this.Controls.Add(this.txtSingleLine);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSingleLine;
        private System.Windows.Forms.TextBox txtMultiLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

