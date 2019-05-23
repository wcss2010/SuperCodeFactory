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
        private int _total = 100;
        /// <summary>
        /// 最大值
        /// </summary>
        public int MaximumProgress
        {
            get { return _total; }
            set { _total = value; }
        }

        private int _value = 0;
        /// <summary>
        /// 当前值
        /// </summary>
        public int CurrentProgress
        {
            get { return _value; }
            set {
                if (value > _total)
                {
                    return;
                }
                else
                {
                    _value = value;
                    Invalidate();
                }                
            }
        }

        private Color progressBarColor = Color.Gray;
        /// <summary>
        /// 进度条颜色
        /// </summary>
        public Color ProgressBarColor
        {
            get { return progressBarColor; }
            set { progressBarColor = value; }
        }

        public CircleProgressBar()
        {
            InitVariable();
            InitializeComponent();
        }

        #region 私有
        private void InitVariable()
        {
            CurrentProgress = 0;
        }
        private void circleprogressbar_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(Width / 2, Height / 2);
            e.Graphics.RotateTransform(-90);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //进度条颜色
            //var obj_pen = new Pen(Color.GreenYellow);
            var obj_pen = new Pen(ProgressBarColor);
            var rect = new Rectangle(0 - Width / 2 + 20, 0 - Height / 2 + 20, Width - 40, Height - 40);
            e.Graphics.DrawPie(obj_pen, rect, 0, (int)(CurrentProgress * 3.6));
            //e.Graphics.FillPie(new SolidBrush(Color.GreenYellow), rect, 0, (int) (progress * 3.6));
            e.Graphics.FillPie(new SolidBrush(ProgressBarColor), rect, 0, (int)(CurrentProgress * 3.6));

            //背景色
            obj_pen = new Pen(BackColor);
            //obj_pen = new Pen(c[0]);
            rect = new Rectangle(0 - Width / 2 + 30, 0 - Height / 2 + 30, Width - 60, Height - 60);
            e.Graphics.DrawPie(obj_pen, rect, 0, 360);
            e.Graphics.FillPie(new SolidBrush(BackColor), rect, 0, 360);
            //e.Graphics.FillPie(new SolidBrush(c[0]), rect, 0, 360);

            e.Graphics.RotateTransform(90);

            //文字百分比
            var ft = new StringFormat();
            ft.LineAlignment = StringAlignment.Center;
            ft.Alignment = StringAlignment.Center;
            //e.Graphics.DrawString(progress + "%", new Font("Arial", 40), new SolidBrush(Color.GreenYellow), rect, ft);
            e.Graphics.DrawString(CurrentProgress + "%", Font, new SolidBrush(ForeColor), rect, ft);
        }
        #endregion 私有       
    }
}