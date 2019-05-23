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
        private System.Windows.Forms.Timer _timerA = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer _timerB = new System.Windows.Forms.Timer();
        public string Message { get; private set; }
        public int TimeSpan { get; set; }
        public bool FormEffectEnable { get; set; }

        private Font _defaultLabelFont = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        /// <summary>
        /// 初始标签字体
        /// </summary>
        public Font DefaultLabelFont
        {
            get { return _defaultLabelFont; }
            set { _defaultLabelFont = value; }
        }
        private Color _defaultLabelForeColor = System.Drawing.Color.MidnightBlue;
        /// <summary>
        /// 初始标签字体色
        /// </summary>
        public Color DefaultLabelForeColor
        {
            get { return _defaultLabelForeColor; }
            set { _defaultLabelForeColor = value; }
        }

        private bool _IsSupportedTimoutClose = true;
        /// <summary>
        /// 是否支持超时自动结束
        /// </summary>
        public bool IsSupportedTimoutClose
        {
            get { return _IsSupportedTimoutClose; }
            set { _IsSupportedTimoutClose = value; }
        }

        /// <summary>
        /// 消息标签对象
        /// </summary>
        public Label MessageLabel { get { return lbMessage; } }

        private Color _progressBarColor = Color.MidnightBlue;
        /// <summary>
        /// 进度条颜色
        /// </summary>
        public Color ProgressBarColor
        {
            get { return _progressBarColor; }
            set { _progressBarColor = value; }
        }

        private Color _progressBarBackColor = Color.Transparent;
        /// <summary>
        /// 进度条背景色
        /// </summary>
        public Color ProgressBarBackColor
        {
            get { return _progressBarBackColor; }
            set { _progressBarBackColor = value; }
        }

        private Color _progressBarFontColor = Color.MidnightBlue;
        /// <summary>
        /// 进度条字体色
        /// </summary>
        public Color ProgressBarFontColor
        {
            get { return _progressBarFontColor; }
            set { _progressBarFontColor = value; }
        }

        private Font _progressBarFont = new System.Drawing.Font("宋体", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        /// <summary>
        /// 进度条字体
        /// </summary>
        public Font ProgressBarFont
        {
            get { return _progressBarFont; }
            set { _progressBarFont = value; }
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
            RunUIMethod(delegate(object thisObj, EventArgs argess1)
            {
                pb_progressbar.CurrentProgress = progress;
            });
        }

        /// <summary>
        /// ProgressUpdateNumber
        /// </summary>
        /// <param name="progress">support Int Value</param>
        /// <param name="total">support Int Value</param>
        public void ProgressUpdate(double progress,double total)
        {
            RunUIMethod(delegate(object thisObj, EventArgs argess1)
            {
                pb_progressbar.CurrentProgress = ((int)Math.Ceiling((progress * 100) / total));
            });
        }

        /// <summary>
        /// LabelUpdateText
        /// </summary>
        /// <param name="text"></param>
        public void ProgressUpdate(string text)
        {
            RunUIMethod(delegate(object thisObj, EventArgs argess1)
            {
                lbMessage.Text = text;
            });
        }

        /// <summary>
        /// 关闭对话框
        /// </summary>
        private void CloseProgressBarForm()
        {
            _IsClose = true;
            this.Close();
        }

        /// <summary>
        /// 关闭进度条对话框
        /// </summary>
        public void CloseProgressBarDialog()
        {
            RunUIMethod(delegate(object thisObj, EventArgs argess1)
            {
                if (IsDisposed)
                {
                    return;
                }
                else
                {
                    CloseProgressBarForm();
                }
            });
        }
        
        /// <summary>
        /// 显示进度条对话框
        /// </summary>
        /// <param name="method"></param>
        /// <param name="waitMessage"></param>
        public DialogResult ShowProgressBarDialog(EventHandler<EventArgs> method, string waitMessage)
        {
            //超时后不关闭
            IsSupportedTimoutClose = false;

            //设置异步事件
            Progression(method, -1, waitMessage);

            //显示对话框
            return ShowDialog();//开启等待窗口
        }

        /// <summary>
        /// 运行UI函数
        /// </summary>
        /// <param name="method"></param>
        public void RunUIMethod(EventHandler<EventArgs> method)
        {
            try
            {
                ThreadPool.QueueUserWorkItem((state) =>
                {
                    if (!_IsClose)
                    {
                        if (IsHandleCreated)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                if (method != null)
                                {
                                    method(this, new EventArgs());
                                }
                            });
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
        }

        #endregion publicMethod

        #region Initialize
        private void Initialize(EventHandler<EventArgs> method, int maxWaitTime, string waitMessage, Font waitMessageFont, Color waitMessageForeColor)
        {
            InitializeComponent();

            this.lbMessage.BackColor = this.BackColor;
            this.TransparencyKey = this.BackColor;

            //init progressbar
            this.pb_progressbar.ProgressBarColor = ProgressBarColor;
            this.pb_progressbar.BackColor = ProgressBarBackColor;
            this.pb_progressbar.Font = ProgressBarFont;
            this.pb_progressbar.ForeColor = ProgressBarFontColor;

            //initialize form
            this.lbMessage.Text = waitMessage;
            this.lbMessage.ForeColor = waitMessageForeColor;
            this.lbMessage.Font = waitMessageFont;

            _IsClose = false;

            //_Timer = new Timer();
            _timerA.Interval = _EffectTime / _EffectCount;
            _timerA.Tick += _timerA_Tick;
            this.Opacity = 0;
            FormEffectEnable = true;

            //para
            TimeSpan = 500;
            Message = string.Empty;
            _MaxWaitTime = maxWaitTime;
            _WaitTime = 0;
            _Method = method;

            this._timerB.Interval = 1000;
            this._timerB.Tick += new System.EventHandler(this._timerB_Tick);
            this._timerB.Interval = TimeSpan;
            this._timerB.Start();
        }
        #endregion Initialize

        #region Events
        private void _timerB_Tick(object sender, EventArgs e)
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

                            //关闭对话框
                            CloseProgressBarForm();
                        }
                    }
                }
                else
                {
                    this.Message = string.Empty;

                    //关闭对话框
                    CloseProgressBarForm();
                }
            }
        }



        private void dlgCircle_progressBar_Shown(object sender, EventArgs e)
        {
            _AsyncResult = _Method.BeginInvoke(null, null, null, null);
            //Effect
            if (FormEffectEnable)
            {
                _timerA.Start();
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
                _timerA.Start();
            }
        }

        private void _timerA_Tick(object sender, EventArgs e)
        {
            if (_IsShown && !this.IsDisposed)
            {
                if (this.Opacity >= 1)
                {
                    _timerA.Stop();
                    _IsShown = false;
                }
                this.Opacity += 1.00 / _EffectCount;
            }
            else
            {
                if (this.Opacity <= 0)
                {
                    _timerA.Stop();
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