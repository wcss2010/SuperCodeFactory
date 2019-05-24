using SuperCodeFactoryUILib.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SuperCodeFactory
{
    public partial class MainForm : Form
    {
        CircleProgressBarDialog bar = new CircleProgressBarDialog();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {  
            bar.Start(new EventHandler<CircleProgressBarEventArgs>(delegate(object thisObj, CircleProgressBarEventArgs argss)
            {
                for (int k = 1; k <= 100; k++)
                {
                    if (bar.CancellationPending)
                    {
                        break;
                    }

                    bar.ReportProgress(k, 100);
                    Thread.Sleep(1000);
                    bar.ReportInfo("当前值:" + k);
                }
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bar.Stop();
        }
    }
}