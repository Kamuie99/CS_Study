namespace OOP_Turtle
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
            this.btn_init = new System.Windows.Forms.Button();
            this.rdo_line = new System.Windows.Forms.RadioButton();
            this.rdo_rect = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(87, 34);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(75, 23);
            this.btn_init.TabIndex = 0;
            this.btn_init.Text = "초기화";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // rdo_line
            // 
            this.rdo_line.AutoSize = true;
            this.rdo_line.Location = new System.Drawing.Point(47, 29);
            this.rdo_line.Name = "rdo_line";
            this.rdo_line.Size = new System.Drawing.Size(35, 16);
            this.rdo_line.TabIndex = 1;
            this.rdo_line.TabStop = true;
            this.rdo_line.Text = "선";
            this.rdo_line.UseVisualStyleBackColor = true;
            // 
            // rdo_rect
            // 
            this.rdo_rect.AutoSize = true;
            this.rdo_rect.Location = new System.Drawing.Point(109, 29);
            this.rdo_rect.Name = "rdo_rect";
            this.rdo_rect.Size = new System.Drawing.Size(59, 16);
            this.rdo_rect.TabIndex = 2;
            this.rdo_rect.TabStop = true;
            this.rdo_rect.Text = "사각형";
            this.rdo_rect.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_rect);
            this.groupBox1.Controls.Add(this.rdo_line);
            this.groupBox1.Location = new System.Drawing.Point(28, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "종류";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_init);
            this.Name = "Form1";
            this.Text = "객체지향거북이";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.RadioButton rdo_line;
        private System.Windows.Forms.RadioButton rdo_rect;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

