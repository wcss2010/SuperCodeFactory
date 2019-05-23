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
            this.lbMessage = new System.Windows.Forms.Label();
            this.pb_progressbar = new SuperCodeFactoryUILib.Controls.CircleProgressBar();
            this.SuspendLayout();
            // 
            // lbMessage
            // 
            this.lbMessage.BackColor = System.Drawing.Color.Gray;
            this.lbMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbMessage.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbMessage.Location = new System.Drawing.Point(0, 320);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(320, 40);
            this.lbMessage.TabIndex = 1;
            this.lbMessage.Text = "Circle ProgressBar";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_progressbar
            // 
            this.pb_progressbar.BackColor = System.Drawing.Color.Transparent;
            this.pb_progressbar.CurrentProgress = 0;
            this.pb_progressbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_progressbar.Font = new System.Drawing.Font("宋体", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pb_progressbar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pb_progressbar.Location = new System.Drawing.Point(0, 0);
            this.pb_progressbar.Margin = new System.Windows.Forms.Padding(16, 17, 16, 17);
            this.pb_progressbar.MaximumProgress = 100;
            this.pb_progressbar.Name = "pb_progressbar";
            this.pb_progressbar.ProgressBarColor = System.Drawing.Color.MidnightBlue;
            this.pb_progressbar.Size = new System.Drawing.Size(320, 320);
            this.pb_progressbar.TabIndex = 0;
            // 
            // CircleProgressBarDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(320, 360);
            this.ControlBox = false;
            this.Controls.Add(this.pb_progressbar);
            this.Controls.Add(this.lbMessage);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CircleProgressBarDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.SystemColors.ControlDark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dlgCircle_progressBar_FormClosing);
            this.Shown += new System.EventHandler(this.dlgCircle_progressBar_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CircleProgressBar pb_progressbar;
        private System.Windows.Forms.Label lbMessage;
    }
}