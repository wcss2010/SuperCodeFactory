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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CircleProgressBarDialog bar = new CircleProgressBarDialog();
            bar.BackColor = Color.Gray;
            bar.ProgressBarColor = Color.MediumPurple;
            bar.ProgressBarBackColor = Color.Gray;
            bar.ProgressBarFontColor = Color.Red;
            bar.DefaultLabelForeColor = Color.Blue;
            bar.DefaultLabelFont = new System.Drawing.Font("宋体", 20);

            bar.ShowProgressBarDialog((obj, args) =>
            {
                for (var currNum = 0; currNum <= 99; currNum++)
                {
                    bar.ProgressUpdate(currNum, 99);//处理过程中改变百分比
                    Thread.Sleep(500);//耗时操作

                    if (currNum == 20)
                    {
                        bar.ProgressUpdate("AAAAAAAAAAAAAAAA");
                    }

                    if (currNum == 30)
                    {
                        bar.ProgressUpdate("BBBBBBBBBBBBBBB");
                    }

                    if (currNum == 40)
                    {
                        bar.ProgressUpdate("CCCCCCCCCCCCCC");
                    }

                    if (currNum == 50)
                    {
                        bar.CloseProgressBarDialog();
                    }
                }
            }, "AAA");
        }
    }
}