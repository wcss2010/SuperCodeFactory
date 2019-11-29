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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.plTopBar = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtConnectionUrl = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMakeAll = new System.Windows.Forms.Button();
            this.btnScriptDir = new System.Windows.Forms.Button();
            this.btnGetTables = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtClassAfter = new System.Windows.Forms.TextBox();
            this.txtClassBefore = new System.Windows.Forms.TextBox();
            this.txtNameSpace = new System.Windows.Forms.TextBox();
            this.cbDbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvTables = new System.Windows.Forms.TreeView();
            this.tcCodes = new System.Windows.Forms.TabControl();
            this.tpNormal = new System.Windows.Forms.TabPage();
            this.txtNormal = new System.Windows.Forms.RichTextBox();
            this.tpOneTable = new System.Windows.Forms.TabPage();
            this.txtOneTable = new System.Windows.Forms.RichTextBox();
            this.fbdOutputDir = new System.Windows.Forms.FolderBrowserDialog();
            this.plTopBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tcCodes.SuspendLayout();
            this.tpNormal.SuspendLayout();
            this.tpOneTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // plTopBar
            // 
            this.plTopBar.Controls.Add(this.panel2);
            this.plTopBar.Controls.Add(this.panel1);
            this.plTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTopBar.Location = new System.Drawing.Point(0, 0);
            this.plTopBar.Name = "plTopBar";
            this.plTopBar.Size = new System.Drawing.Size(1025, 133);
            this.plTopBar.TabIndex = 0;
            this.plTopBar.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtConnectionUrl);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(393, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(629, 113);
            this.panel2.TabIndex = 5;
            // 
            // txtConnectionUrl
            // 
            this.txtConnectionUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConnectionUrl.Location = new System.Drawing.Point(113, 10);
            this.txtConnectionUrl.Multiline = true;
            this.txtConnectionUrl.Name = "txtConnectionUrl";
            this.txtConnectionUrl.Size = new System.Drawing.Size(356, 93);
            this.txtConnectionUrl.TabIndex = 2;
            this.txtConnectionUrl.Text = "Data Source=";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMakeAll);
            this.panel3.Controls.Add(this.btnScriptDir);
            this.panel3.Controls.Add(this.btnGetTables);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(469, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 93);
            this.panel3.TabIndex = 6;
            // 
            // btnMakeAll
            // 
            this.btnMakeAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMakeAll.Location = new System.Drawing.Point(0, 60);
            this.btnMakeAll.Name = "btnMakeAll";
            this.btnMakeAll.Size = new System.Drawing.Size(150, 33);
            this.btnMakeAll.TabIndex = 4;
            this.btnMakeAll.Text = "生成所有";
            this.btnMakeAll.UseVisualStyleBackColor = true;
            this.btnMakeAll.Click += new System.EventHandler(this.btnMakeAll_Click);
            // 
            // btnScriptDir
            // 
            this.btnScriptDir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScriptDir.Location = new System.Drawing.Point(0, 30);
            this.btnScriptDir.Name = "btnScriptDir";
            this.btnScriptDir.Size = new System.Drawing.Size(150, 30);
            this.btnScriptDir.TabIndex = 5;
            this.btnScriptDir.Text = "编辑代码生成脚本";
            this.btnScriptDir.UseVisualStyleBackColor = true;
            this.btnScriptDir.Click += new System.EventHandler(this.btnScriptDir_Click);
            // 
            // btnGetTables
            // 
            this.btnGetTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGetTables.Location = new System.Drawing.Point(0, 0);
            this.btnGetTables.Name = "btnGetTables";
            this.btnGetTables.Size = new System.Drawing.Size(150, 30);
            this.btnGetTables.TabIndex = 3;
            this.btnGetTables.Text = "获得数据库中的所有表格";
            this.btnGetTables.UseVisualStyleBackColor = true;
            this.btnGetTables.Click += new System.EventHandler(this.btnGetTables_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 93);
            this.label2.TabIndex = 0;
            this.label2.Text = "数据库连接代码：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtClassAfter);
            this.panel1.Controls.Add(this.txtClassBefore);
            this.panel1.Controls.Add(this.txtNameSpace);
            this.panel1.Controls.Add(this.cbDbType);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(390, 113);
            this.panel1.TabIndex = 4;
            // 
            // txtClassAfter
            // 
            this.txtClassAfter.Location = new System.Drawing.Point(87, 73);
            this.txtClassAfter.Name = "txtClassAfter";
            this.txtClassAfter.Size = new System.Drawing.Size(295, 21);
            this.txtClassAfter.TabIndex = 2;
            // 
            // txtClassBefore
            // 
            this.txtClassBefore.Location = new System.Drawing.Point(87, 50);
            this.txtClassBefore.Name = "txtClassBefore";
            this.txtClassBefore.Size = new System.Drawing.Size(295, 21);
            this.txtClassBefore.TabIndex = 2;
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Location = new System.Drawing.Point(87, 27);
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(295, 21);
            this.txtNameSpace.TabIndex = 2;
            this.txtNameSpace.Text = "CodeFactory.DB";
            // 
            // cbDbType
            // 
            this.cbDbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDbType.FormattingEnabled = true;
            this.cbDbType.Items.AddRange(new object[] {
            "System.Data.Odbc",
            "System.Data.OleDb",
            "System.Data.OracleClient",
            "Oracle.ManagedDataAccess.Client",
            "System.Data.SQLite",
            "MySql.Data.MySqlClient",
            "IBM.Data.DB2",
            "FirebirdSql.Data.FirebirdClient"});
            this.cbDbType.Location = new System.Drawing.Point(87, 2);
            this.cbDbType.Name = "cbDbType";
            this.cbDbType.Size = new System.Drawing.Size(295, 20);
            this.cbDbType.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "  类名后缀：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "  类名前缀：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "  命名空间：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库类型：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 133);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvTables);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tcCodes);
            this.splitContainer1.Size = new System.Drawing.Size(1025, 436);
            this.splitContainer1.SplitterDistance = 341;
            this.splitContainer1.TabIndex = 1;
            // 
            // tvTables
            // 
            this.tvTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTables.FullRowSelect = true;
            this.tvTables.HideSelection = false;
            this.tvTables.Location = new System.Drawing.Point(0, 0);
            this.tvTables.Name = "tvTables";
            this.tvTables.Size = new System.Drawing.Size(341, 436);
            this.tvTables.TabIndex = 0;
            this.tvTables.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTables_AfterSelect);
            // 
            // tcCodes
            // 
            this.tcCodes.Controls.Add(this.tpNormal);
            this.tcCodes.Controls.Add(this.tpOneTable);
            this.tcCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCodes.Location = new System.Drawing.Point(0, 0);
            this.tcCodes.Name = "tcCodes";
            this.tcCodes.SelectedIndex = 0;
            this.tcCodes.Size = new System.Drawing.Size(680, 436);
            this.tcCodes.TabIndex = 0;
            // 
            // tpNormal
            // 
            this.tpNormal.Controls.Add(this.txtNormal);
            this.tpNormal.Location = new System.Drawing.Point(4, 22);
            this.tpNormal.Name = "tpNormal";
            this.tpNormal.Padding = new System.Windows.Forms.Padding(3);
            this.tpNormal.Size = new System.Drawing.Size(672, 410);
            this.tpNormal.TabIndex = 1;
            this.tpNormal.Text = "常用代码";
            this.tpNormal.UseVisualStyleBackColor = true;
            // 
            // txtNormal
            // 
            this.txtNormal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNormal.Location = new System.Drawing.Point(3, 3);
            this.txtNormal.Name = "txtNormal";
            this.txtNormal.Size = new System.Drawing.Size(666, 404);
            this.txtNormal.TabIndex = 0;
            this.txtNormal.Text = "";
            // 
            // tpOneTable
            // 
            this.tpOneTable.Controls.Add(this.txtOneTable);
            this.tpOneTable.Location = new System.Drawing.Point(4, 22);
            this.tpOneTable.Name = "tpOneTable";
            this.tpOneTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpOneTable.Size = new System.Drawing.Size(672, 410);
            this.tpOneTable.TabIndex = 2;
            this.tpOneTable.Text = "单表代码";
            this.tpOneTable.UseVisualStyleBackColor = true;
            // 
            // txtOneTable
            // 
            this.txtOneTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOneTable.Location = new System.Drawing.Point(3, 3);
            this.txtOneTable.Name = "txtOneTable";
            this.txtOneTable.Size = new System.Drawing.Size(666, 404);
            this.txtOneTable.TabIndex = 1;
            this.txtOneTable.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 569);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.plTopBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperCodeFactory V1.2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.plTopBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tcCodes.ResumeLayout(false);
            this.tpNormal.ResumeLayout(false);
            this.tpOneTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox plTopBar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvTables;
        private System.Windows.Forms.TabControl tcCodes;
        private System.Windows.Forms.TabPage tpNormal;
        private System.Windows.Forms.ComboBox cbDbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnectionUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetTables;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMakeAll;
        private System.Windows.Forms.FolderBrowserDialog fbdOutputDir;
        private System.Windows.Forms.TabPage tpOneTable;
        private System.Windows.Forms.RichTextBox txtNormal;
        private System.Windows.Forms.RichTextBox txtOneTable;
        private System.Windows.Forms.Button btnScriptDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClassAfter;
        private System.Windows.Forms.TextBox txtClassBefore;
        private System.Windows.Forms.TextBox txtNameSpace;
        private System.Windows.Forms.Panel panel3;

    }
}

