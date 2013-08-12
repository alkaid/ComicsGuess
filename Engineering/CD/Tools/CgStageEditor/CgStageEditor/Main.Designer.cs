namespace CgStageEditor
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCgDB = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenDB = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStageList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStageAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSubjectList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSubjectAdd = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCgDB)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCgDB
            // 
            this.dgvCgDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCgDB.Location = new System.Drawing.Point(12, 40);
            this.dgvCgDB.Name = "dgvCgDB";
            this.dgvCgDB.RowTemplate.Height = 23;
            this.dgvCgDB.Size = new System.Drawing.Size(900, 490);
            this.dgvCgDB.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiStage,
            this.tsmiSubject});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenDB,
            this.tsmiSave});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(44, 21);
            this.tsmiFile.Text = "文件";
            // 
            // tsmiOpenDB
            // 
            this.tsmiOpenDB.Name = "tsmiOpenDB";
            this.tsmiOpenDB.Size = new System.Drawing.Size(152, 22);
            this.tsmiOpenDB.Text = "打开DB";
            this.tsmiOpenDB.Click += new System.EventHandler(this.tsmiOpenDB_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(152, 22);
            this.tsmiSave.Text = "保存";
            // 
            // tsmiStage
            // 
            this.tsmiStage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStageList,
            this.tsmiStageAdd});
            this.tsmiStage.Name = "tsmiStage";
            this.tsmiStage.Size = new System.Drawing.Size(44, 21);
            this.tsmiStage.Text = "关卡";
            // 
            // tsmiStageList
            // 
            this.tsmiStageList.Name = "tsmiStageList";
            this.tsmiStageList.Size = new System.Drawing.Size(100, 22);
            this.tsmiStageList.Text = "列表";
            // 
            // tsmiStageAdd
            // 
            this.tsmiStageAdd.Name = "tsmiStageAdd";
            this.tsmiStageAdd.Size = new System.Drawing.Size(100, 22);
            this.tsmiStageAdd.Text = "新增";
            // 
            // tsmiSubject
            // 
            this.tsmiSubject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSubjectList,
            this.tsmiSubjectAdd});
            this.tsmiSubject.Name = "tsmiSubject";
            this.tsmiSubject.Size = new System.Drawing.Size(44, 21);
            this.tsmiSubject.Text = "题目";
            // 
            // tsmiSubjectList
            // 
            this.tsmiSubjectList.Name = "tsmiSubjectList";
            this.tsmiSubjectList.Size = new System.Drawing.Size(100, 22);
            this.tsmiSubjectList.Text = "列表";
            // 
            // tsmiSubjectAdd
            // 
            this.tsmiSubjectAdd.Name = "tsmiSubjectAdd";
            this.tsmiSubjectAdd.Size = new System.Drawing.Size(100, 22);
            this.tsmiSubjectAdd.Text = "新增";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 542);
            this.Controls.Add(this.dgvCgDB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "ComicsGuess";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCgDB)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCgDB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenDB;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiStage;
        private System.Windows.Forms.ToolStripMenuItem tsmiStageList;
        private System.Windows.Forms.ToolStripMenuItem tsmiStageAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiSubject;
        private System.Windows.Forms.ToolStripMenuItem tsmiSubjectList;
        private System.Windows.Forms.ToolStripMenuItem tsmiSubjectAdd;
    }
}

