namespace SuperCodeFactory
{
    partial class MainForm
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
            this.plTopBar = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvTables = new System.Windows.Forms.TreeView();
            this.tcCodes = new System.Windows.Forms.TabControl();
            this.tpColumnList = new System.Windows.Forms.TabPage();
            this.tpCodes = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDbType = new System.Windows.Forms.ComboBox();
            this.txtConnectionUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetTables = new System.Windows.Forms.Button();
            this.plTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tcCodes.SuspendLayout();
            this.SuspendLayout();
            // 
            // plTopBar
            // 
            this.plTopBar.Controls.Add(this.btnGetTables);
            this.plTopBar.Controls.Add(this.txtConnectionUrl);
            this.plTopBar.Controls.Add(this.cbDbType);
            this.plTopBar.Controls.Add(this.label2);
            this.plTopBar.Controls.Add(this.label1);
            this.plTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTopBar.Location = new System.Drawing.Point(0, 0);
            this.plTopBar.Name = "plTopBar";
            this.plTopBar.Size = new System.Drawing.Size(1025, 104);
            this.plTopBar.TabIndex = 0;
            this.plTopBar.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 104);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvTables);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tcCodes);
            this.splitContainer1.Size = new System.Drawing.Size(1025, 465);
            this.splitContainer1.SplitterDistance = 341;
            this.splitContainer1.TabIndex = 1;
            // 
            // tvTables
            // 
            this.tvTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTables.Location = new System.Drawing.Point(0, 0);
            this.tvTables.Name = "tvTables";
            this.tvTables.Size = new System.Drawing.Size(341, 465);
            this.tvTables.TabIndex = 0;
            // 
            // tcCodes
            // 
            this.tcCodes.Controls.Add(this.tpColumnList);
            this.tcCodes.Controls.Add(this.tpCodes);
            this.tcCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCodes.Location = new System.Drawing.Point(0, 0);
            this.tcCodes.Name = "tcCodes";
            this.tcCodes.SelectedIndex = 0;
            this.tcCodes.Size = new System.Drawing.Size(680, 465);
            this.tcCodes.TabIndex = 0;
            // 
            // tpColumnList
            // 
            this.tpColumnList.Location = new System.Drawing.Point(4, 22);
            this.tpColumnList.Name = "tpColumnList";
            this.tpColumnList.Padding = new System.Windows.Forms.Padding(3);
            this.tpColumnList.Size = new System.Drawing.Size(672, 439);
            this.tpColumnList.TabIndex = 0;
            this.tpColumnList.Text = "字段";
            this.tpColumnList.UseVisualStyleBackColor = true;
            // 
            // tpCodes
            // 
            this.tpCodes.Location = new System.Drawing.Point(4, 22);
            this.tpCodes.Name = "tpCodes";
            this.tpCodes.Padding = new System.Windows.Forms.Padding(3);
            this.tpCodes.Size = new System.Drawing.Size(672, 439);
            this.tpCodes.TabIndex = 1;
            this.tpCodes.Text = "代码";
            this.tpCodes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库类型：";
            // 
            // cbDbType
            // 
            this.cbDbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDbType.FormattingEnabled = true;
            this.cbDbType.Items.AddRange(new object[] {
            "System.Data.OleDb",
            "System.Data.OracleClient",
            "Oracle.ManagedDataAccess.Client",
            "System.Data.SQLite",
            "MySql.Data.MySqlClient"});
            this.cbDbType.Location = new System.Drawing.Point(89, 14);
            this.cbDbType.Name = "cbDbType";
            this.cbDbType.Size = new System.Drawing.Size(211, 20);
            this.cbDbType.TabIndex = 1;
            // 
            // txtConnectionUrl
            // 
            this.txtConnectionUrl.Location = new System.Drawing.Point(89, 40);
            this.txtConnectionUrl.Multiline = true;
            this.txtConnectionUrl.Name = "txtConnectionUrl";
            this.txtConnectionUrl.Size = new System.Drawing.Size(924, 58);
            this.txtConnectionUrl.TabIndex = 2;
            this.txtConnectionUrl.Text = "Data Source=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "  连接代码：";
            // 
            // btnGetTables
            // 
            this.btnGetTables.Location = new System.Drawing.Point(306, 14);
            this.btnGetTables.Name = "btnGetTables";
            this.btnGetTables.Size = new System.Drawing.Size(160, 20);
            this.btnGetTables.TabIndex = 3;
            this.btnGetTables.Text = "获得数据库中的所有表格";
            this.btnGetTables.UseVisualStyleBackColor = true;
            this.btnGetTables.Click += new System.EventHandler(this.btnGetTables_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 569);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.plTopBar);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperCodeFactory";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.plTopBar.ResumeLayout(false);
            this.plTopBar.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tcCodes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox plTopBar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvTables;
        private System.Windows.Forms.TabControl tcCodes;
        private System.Windows.Forms.TabPage tpColumnList;
        private System.Windows.Forms.TabPage tpCodes;
        private System.Windows.Forms.ComboBox cbDbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnectionUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetTables;

    }
}

