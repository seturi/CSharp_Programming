namespace _04_ComboBoxControl
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
            this.comboSimple = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDropDown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboDropDownList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboSimple
            // 
            this.comboSimple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboSimple.FormattingEnabled = true;
            this.comboSimple.Location = new System.Drawing.Point(50, 95);
            this.comboSimple.Name = "comboSimple";
            this.comboSimple.Size = new System.Drawing.Size(121, 150);
            this.comboSimple.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simple";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "DropDown";
            // 
            // comboDropDown
            // 
            this.comboDropDown.FormattingEnabled = true;
            this.comboDropDown.Location = new System.Drawing.Point(228, 95);
            this.comboDropDown.Name = "comboDropDown";
            this.comboDropDown.Size = new System.Drawing.Size(121, 23);
            this.comboDropDown.TabIndex = 2;
            this.comboDropDown.SelectedIndexChanged += new System.EventHandler(this.comboDropDown_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "DropDownList";
            // 
            // comboDropDownList
            // 
            this.comboDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDropDownList.FormattingEnabled = true;
            this.comboDropDownList.Location = new System.Drawing.Point(403, 95);
            this.comboDropDownList.Name = "comboDropDownList";
            this.comboDropDownList.Size = new System.Drawing.Size(121, 23);
            this.comboDropDownList.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 288);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboDropDownList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSimple);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSimple;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDropDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboDropDownList;
    }
}

