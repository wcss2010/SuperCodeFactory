using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SuperCodeFactoryUILib.Forms
{
    /// <summary>
    /// 圆形进度条显示对话框
    /// </summary>
    public partial class CircleProgressBarDialog : Form
    {
        #region Variable
        private int _MaxWaitTime;
        private int _WaitTime;
        private IAsyncResult _AsyncResult;
        private EventHandler<EventArgs> _Method;
        private bool _IsShown = true;
        private bool _IsClose = false;
        private readonly int _EffectCount = 10;
        private readonly int _EffectTime = 500;

        /// <summary>
        /// 控制界面显示的特性
        /// </summary>
        private System.Windows.Forms.Timer _Timer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        public string Message { get; private set; }
        public int TimeSpan { get; set; }
        public bool FormEffectEnable { get; set; }

        private Font _defaultLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        /// <summary>
        /// 初始标签字体
        /// </summary>
        public Font DefaultLabelFont
        {
            get { return _defaultLabelFont; }
            set { _defaultLabelFont = value; }
        }
        private Color _defaultLabelForeColor = System.Drawing.Color.LightBlue;
        /// <summary>
        /// 初始标签字体色
        /// </summary>
        public Color DefaultLabelForeColor
        {
            get { return _defaultLabelForeColor; }
            set { _defaultLabelForeColor = value; }
        }

        private bool _IsSupportedTimoutClose = false;
        /// <summary>
        /// 是否支持超时自动结束
        /// </summary>
        public bool IsSupportedTimoutClose
        {
            get { return _IsSupportedTimoutClose; }
            set { _IsSupportedTimoutClose = value; }
        }


        #endregion Variable

        #region Constructor
        public CircleProgressBarDialog() { }
        #endregion Constructor

        #region publicMethod
        public void Progression(EventHandler<EventArgs> method, int maxWaitTime, string waitMessage, Font waitMessageFont, Color waitMessageForeColor)
        {
            maxWaitTime *= 1000;
            Initialize(method, maxWaitTime, waitMessage, waitMessageFont, waitMessageForeColor);
        }
        public void Progression(EventHandler<EventArgs> method, int maxWaitTime, string waitMessage)
        {
            Progression(method, maxWaitTime, waitMessage, DefaultLabelFont, DefaultLabelForeColor);
        }
        public void Progression(EventHandler<EventArgs> method, int maxWaitTime)
        {
            maxWaitTime *= 1000;
            string waitMessage = "请稍后";
            Initialize(method, maxWaitTime, waitMessage, DefaultLabelFont, DefaultLabelForeColor);
        }
        public void Progression(EventHandler<EventArgs> method, string waitMessage)
        {
            int maxWaitTime = 90 * 1000;
            Initialize(method, maxWaitTime, waitMessage, DefaultLabelFont, DefaultLabelForeColor);
        }
        public void Progression(EventHandler<EventArgs> method)
        {
            int maxWaitTime = 90 * 1000;
            string waitMessage = "请稍后";
            Initialize(method, maxWaitTime, waitMessage, DefaultLabelFont, DefaultLabelForeColor);
        }
        /// <summary>
        /// ProgressUpdateNumber
        /// </summary>
        /// <param name="progress">currentNumber,maxNum:100</param>
        public void ProgressUpdate(int progress)
        {
            ThreadPool.QueueUserWorkItem((state) =>
            {
                if (!_IsClose)
                {
                    pb_progressbar.Invoke((MethodInvoker)delegate { pb_progressbar.updateProgress(progress); });
                }
            });
        }
        /// <summary>
        /// ProgressUpdateNumber
        /// </summary>
        /// <param name="progress">support Int Value</param>
        /// <param name="total">support Int Value</param>
        public void ProgressUpdate(double progress,double total)
        {
            ThreadPool.QueueUserWorkItem((state) =>
            {
                if (!_IsClose)
                {
                    pb_progressbar.Invoke((MethodInvoker)delegate { pb_progressbar.updateProgress((int)Math.Ceiling((progress * 100) / total)); });
                }
            });
        }
        #endregion publicMethod

        #region Initialize
        private void Initialize(EventHandler<EventArgs> method, int maxWaitTime, string waitMessage, Font waitMessageFont, Color waitMessageForeColor)
        {
            InitializeComponent();
            //initialize form
            this.lbMessage.Text = waitMessage;
            this.lbMessage.ForeColor = waitMessageForeColor;
            this.lbMessage.Font = waitMessageFont;
            _IsClose = false;
            //_Timer = new Timer();
            _Timer.Interval = _EffectTime / _EffectCount;
            _Timer.Tick += _Timer_Tick;
            this.Opacity = 0;
            FormEffectEnable = true;
            //para
            TimeSpan = 500;
            Message = string.Empty;
            _MaxWaitTime = maxWaitTime;
            _WaitTime = 0;
            _Method = method;

            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.timer1.Interval = TimeSpan;
            this.timer1.Start();
        }
        #endregion Initialize

        #region Events
        private void timer1_Tick(object sender, EventArgs e)
        {
            _WaitTime += TimeSpan;
            if (this._AsyncResult != null)
            {
                if (!this._AsyncResult.IsCompleted)
                {
                    if (IsSupportedTimoutClose)
                    {
                        if (_WaitTime > _MaxWaitTime)
                        {
                            Message = string.Format("处理数据超时{0}秒，结束当前操作！", _MaxWaitTime / 1000);
                            _IsClose = true;
                            this.Close();
                        }
                    }
                }
                else
                {
                    this.Message = string.Empty;
                    _IsClose = true;
                    this.Close();
                }
            }
        }

        private void dlgCircle_progressBar_Shown(object sender, EventArgs e)
        {
            _AsyncResult = _Method.BeginInvoke(null, null, null, null);
            //Effect
            if (FormEffectEnable)
            {
                _Timer.Start();
            }
            else
                this.Opacity = 1;
        }

        private void dlgCircle_progressBar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormEffectEnable)
            {
                if (this.Opacity >= 1)
                    e.Cancel = true;
                _Timer.Start();
            }
        }

        private void _Timer_Tick(object sender, EventArgs e)
        {
            if (_IsShown && !this.IsDisposed)
            {
                if (this.Opacity >= 1)
                {
                    _Timer.Stop();
                    _IsShown = false;
                }
                this.Opacity += 1.00 / _EffectCount;
            }
            else
            {
                if (this.Opacity <= 0)
                {
                    _Timer.Stop();
                    _IsShown = true;
                    _IsClose = true;
                    this.Close();
                }
                this.Opacity -= 1.00 / _EffectCount;
            }
        }
        #endregion Events
    }
}