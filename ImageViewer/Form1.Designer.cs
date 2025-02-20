namespace ImageViewer
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
            this.tree_pet = new System.Windows.Forms.TreeView();
            this.cb_original = new System.Windows.Forms.CheckBox();
            this.pb_pet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pet)).BeginInit();
            this.SuspendLayout();
            // 
            // tree_pet
            // 
            this.tree_pet.Location = new System.Drawing.Point(49, 55);
            this.tree_pet.Name = "tree_pet";
            this.tree_pet.Size = new System.Drawing.Size(250, 300);
            this.tree_pet.TabIndex = 0;
            this.tree_pet.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_pet_AfterSelect);
            // 
            // cb_original
            // 
            this.cb_original.AutoSize = true;
            this.cb_original.Location = new System.Drawing.Point(489, 33);
            this.cb_original.Name = "cb_original";
            this.cb_original.Size = new System.Drawing.Size(100, 16);
            this.cb_original.TabIndex = 1;
            this.cb_original.Text = "원본크기 보기";
            this.cb_original.UseVisualStyleBackColor = true;
            this.cb_original.CheckedChanged += new System.EventHandler(this.cb_original_CheckedChanged);
            // 
            // pb_pet
            // 
            this.pb_pet.Location = new System.Drawing.Point(382, 55);
            this.pb_pet.Name = "pb_pet";
            this.pb_pet.Size = new System.Drawing.Size(300, 300);
            this.pb_pet.TabIndex = 2;
            this.pb_pet.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 406);
            this.Controls.Add(this.pb_pet);
            this.Controls.Add(this.cb_original);
            this.Controls.Add(this.tree_pet);
            this.Name = "Form1";
            this.Text = "이미지뷰어";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_pet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tree_pet;
        private System.Windows.Forms.CheckBox cb_original;
        private System.Windows.Forms.PictureBox pb_pet;
    }
}

