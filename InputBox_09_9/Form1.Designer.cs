namespace InputBox_09_9
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
            this.btn_string = new System.Windows.Forms.Button();
            this.btn_int = new System.Windows.Forms.Button();
            this.btn_float = new System.Windows.Forms.Button();
            this.tb_string = new System.Windows.Forms.TextBox();
            this.tb_int = new System.Windows.Forms.TextBox();
            this.tb_float = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_string
            // 
            this.btn_string.Location = new System.Drawing.Point(66, 83);
            this.btn_string.Name = "btn_string";
            this.btn_string.Size = new System.Drawing.Size(84, 23);
            this.btn_string.TabIndex = 0;
            this.btn_string.Text = "문자열 입력";
            this.btn_string.UseVisualStyleBackColor = true;
            this.btn_string.Click += new System.EventHandler(this.btn_string_Click);
            // 
            // btn_int
            // 
            this.btn_int.Location = new System.Drawing.Point(66, 147);
            this.btn_int.Name = "btn_int";
            this.btn_int.Size = new System.Drawing.Size(84, 23);
            this.btn_int.TabIndex = 1;
            this.btn_int.Text = "정수 입력";
            this.btn_int.UseVisualStyleBackColor = true;
            this.btn_int.Click += new System.EventHandler(this.btn_int_Click);
            // 
            // btn_float
            // 
            this.btn_float.Location = new System.Drawing.Point(66, 216);
            this.btn_float.Name = "btn_float";
            this.btn_float.Size = new System.Drawing.Size(84, 23);
            this.btn_float.TabIndex = 2;
            this.btn_float.Text = "실수 입력";
            this.btn_float.UseVisualStyleBackColor = true;
            this.btn_float.Click += new System.EventHandler(this.btn_float_Click);
            // 
            // tb_string
            // 
            this.tb_string.Location = new System.Drawing.Point(222, 85);
            this.tb_string.Name = "tb_string";
            this.tb_string.Size = new System.Drawing.Size(100, 21);
            this.tb_string.TabIndex = 3;
            // 
            // tb_int
            // 
            this.tb_int.Location = new System.Drawing.Point(222, 149);
            this.tb_int.Name = "tb_int";
            this.tb_int.Size = new System.Drawing.Size(100, 21);
            this.tb_int.TabIndex = 4;
            // 
            // tb_float
            // 
            this.tb_float.Location = new System.Drawing.Point(222, 218);
            this.tb_float.Name = "tb_float";
            this.tb_float.Size = new System.Drawing.Size(100, 21);
            this.tb_float.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 343);
            this.Controls.Add(this.tb_float);
            this.Controls.Add(this.tb_int);
            this.Controls.Add(this.tb_string);
            this.Controls.Add(this.btn_float);
            this.Controls.Add(this.btn_int);
            this.Controls.Add(this.btn_string);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_string;
        private System.Windows.Forms.Button btn_int;
        private System.Windows.Forms.Button btn_float;
        private System.Windows.Forms.TextBox tb_string;
        private System.Windows.Forms.TextBox tb_int;
        private System.Windows.Forms.TextBox tb_float;
    }
}

