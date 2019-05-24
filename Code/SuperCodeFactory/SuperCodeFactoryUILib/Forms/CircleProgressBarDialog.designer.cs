namespace SuperCodeFactoryUILib.Forms
{
    partial class CircleProgressBarDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bwProgressReport = new System.ComponentModel.BackgroundWorker();
            this.cpbProgressBar = new SuperCodeFactoryUILib.Controls.CircleProgressBar();
            this.lbMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bwProgressReport
            // 
            this.bwProgressReport.WorkerReportsProgress = true;
            this.bwProgressReport.WorkerSupportsCancellation = true;
            this.bwProgressReport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwProgressReport_DoWork);
            // 
            // cpbProgressBar
            // 
            this.cpbProgressBar.BackColor = System.Drawing.Color.Gray;
            this.cpbProgressBar.CurrentProgress = 0;
            this.cpbProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpbProgressBar.Font = new System.Drawing.Font("宋体", 60F);
            this.cpbProgressBar.ForeColor = System.Drawing.Color.White;
            this.cpbProgressBar.Location = new System.Drawing.Point(0, 0);
            this.cpbProgressBar.Margin = new System.Windows.Forms.Padding(14);
            this.cpbProgressBar.MaximumProgress = 100;
            this.cpbProgressBar.Name = "cpbProgressBar";
            this.cpbProgressBar.ProgressBarColor = System.Drawing.Color.DodgerBlue;
            this.cpbProgressBar.Size = new System.Drawing.Size(344, 325);
            this.cpbProgressBar.TabIndex = 0;
            // 
            // lbMessage
            // 
            this.lbMessage.BackColor = System.Drawing.Color.Transparent;
            this.lbMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbMessage.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMessage.ForeColor = System.Drawing.Color.White;
            this.lbMessage.Location = new System.Drawing.Point(0, 325);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(344, 40);
            this.lbMessage.TabIndex = 1;
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CircleProgressBarDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(344, 365);
            this.Controls.Add(this.cpbProgressBar);
            this.Controls.Add(this.lbMessage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CircleProgressBarDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "进度条";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bwProgressReport;
        private Controls.CircleProgressBar cpbProgressBar;
        private System.Windows.Forms.Label lbMessage;
    }
}