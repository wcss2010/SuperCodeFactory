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
            this.pb_progressbar = new Controls.CircleProgressBar();
            this.SuspendLayout();
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.BackColor = System.Drawing.Color.Gray;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.LightBlue;
            this.lbMessage.Location = new System.Drawing.Point(113, 177);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(140, 20);
            this.lbMessage.TabIndex = 1;
            this.lbMessage.Text = "Circle ProgressBar";
            // 
            // pb_progressbar
            // 
            this.pb_progressbar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pb_progressbar.ForeColor = System.Drawing.SystemColors.Control;
            this.pb_progressbar.Location = new System.Drawing.Point(23, 11);
            this.pb_progressbar.Name = "pb_progressbar";
            this.pb_progressbar.Size = new System.Drawing.Size(300, 277);
            this.pb_progressbar.TabIndex = 0;
            // 
            // dlgCircle_progressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(334, 287);
            this.ControlBox = false;
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.pb_progressbar);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dlgCircle_progressBar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.SystemColors.ControlDark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dlgCircle_progressBar_FormClosing);
            this.Shown += new System.EventHandler(this.dlgCircle_progressBar_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CircleProgressBar pb_progressbar;
        private System.Windows.Forms.Label lbMessage;
    }
}