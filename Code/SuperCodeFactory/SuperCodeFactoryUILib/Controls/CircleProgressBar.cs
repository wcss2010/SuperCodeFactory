using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SuperCodeFactoryUILib.Controls
{
    /// <summary>
    /// 圆形进度条控件
    /// </summary>
    public partial class CircleProgressBar : UserControl
    {
        private int progress;
        private Color[] colors;

        public CircleProgressBar()
        {
            InitVariable();
            InitializeComponent();
        }
        #region 私有
        private void InitVariable()
        {
            progress = 0;
            colors = GetRandColor();
        }
        private void circleprogressbar_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(Width / 2, Height / 2);
            e.Graphics.RotateTransform(-90);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //进度条颜色
            //var obj_pen = new Pen(Color.GreenYellow);
            var obj_pen = new Pen(colors[1]);
            var rect = new Rectangle(0 - Width / 2 + 20, 0 - Height / 2 + 20, Width - 40, Height - 40);
            e.Graphics.DrawPie(obj_pen, rect, 0, (int) (progress * 3.6));
            //e.Graphics.FillPie(new SolidBrush(Color.GreenYellow), rect, 0, (int) (progress * 3.6));
            e.Graphics.FillPie(new SolidBrush(colors[1]), rect, 0, (int)(progress * 3.6));

            //背景色
            obj_pen = new Pen(Color.Gray);
            //obj_pen = new Pen(c[0]);
            rect = new Rectangle(0 - Width / 2 + 30, 0 - Height / 2 + 30, Width - 60, Height - 60);
            e.Graphics.DrawPie(obj_pen, rect, 0, 360);
            e.Graphics.FillPie(new SolidBrush(Color.Gray), rect, 0, 360);
            //e.Graphics.FillPie(new SolidBrush(c[0]), rect, 0, 360);

            e.Graphics.RotateTransform(90);
            //文字百分比
            var ft = new StringFormat();
            ft.LineAlignment = StringAlignment.Center;
            ft.Alignment = StringAlignment.Center;
            //e.Graphics.DrawString(progress + "%", new Font("Arial", 40), new SolidBrush(Color.GreenYellow), rect, ft);
            e.Graphics.DrawString(progress + "%", new Font("Arial", 40), new SolidBrush(colors[1]), rect, ft);
        }
        #endregion 私有

        public void updateProgress(int progress)
        {
            this.progress = progress;
            Invalidate();
        }

        #region Color
        private Color[] GetRandColor()
        {
            int rMax = 250;
            int rMin = 20;
            int gMax = 250;
            int gMin = 20;
            int bMax = 250;
            int bMin = 20;
            Random r = new Random(DateTime.Now.Millisecond);
            int r1 = r.Next(rMin, rMax);
            int r2 = r.Next(rMin, rMax);
            int g1 = r.Next(gMin, gMax);
            int g2 = r.Next(gMin, gMax);
            int b1 = r.Next(bMin, bMax);
            int b2 = r.Next(bMin, bMax);
            Color c1 = Color.FromArgb(r1, g1, b1);
            Color c2 = Color.FromArgb(r2, g2, b2);

            Color[] c = { c1, c2 };
            return c;
        }
        #endregion
    }
}