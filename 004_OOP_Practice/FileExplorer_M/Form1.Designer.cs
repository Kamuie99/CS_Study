namespace Exam17
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
            this.tb_folder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbox_folders = new System.Windows.Forms.ListBox();
            this.lbox_files = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tb_folder
            // 
            this.tb_folder.BackColor = System.Drawing.Color.Khaki;
            this.tb_folder.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_folder.Location = new System.Drawing.Point(91, 9);
            this.tb_folder.Name = "tb_folder";
            this.tb_folder.Size = new System.Drawing.Size(461, 29);
            this.tb_folder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "현재 폴더";
            // 
            // lbox_folders
            // 
            this.lbox_folders.FormattingEnabled = true;
            this.lbox_folders.ItemHeight = 12;
            this.lbox_folders.Location = new System.Drawing.Point(16, 56);
            this.lbox_folders.Name = "lbox_folders";
            this.lbox_folders.Size = new System.Drawing.Size(241, 412);
            this.lbox_folders.TabIndex = 5;
            this.lbox_folders.SelectedIndexChanged += new System.EventHandler(this.lbox_folders_SelectedIndexChanged);
            // 
            // lbox_files
            // 
            this.lbox_files.FormattingEnabled = true;
            this.lbox_files.ItemHeight = 12;
            this.lbox_files.Location = new System.Drawing.Point(282, 56);
            this.lbox_files.Name = "lbox_files";
            this.lbox_files.Size = new System.Drawing.Size(271, 412);
            this.lbox_files.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 480);
            this.Controls.Add(this.lbox_files);
            this.Controls.Add(this.lbox_folders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_folder);
            this.Name = "Form1";
            this.Text = "파일 탐색기 비슷한 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_folder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbox_folders;
        private System.Windows.Forms.ListBox lbox_files;
    }
}

