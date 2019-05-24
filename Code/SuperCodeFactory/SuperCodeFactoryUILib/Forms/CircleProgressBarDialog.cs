using SuperCodeFactoryUILib.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperCodeFactoryUILib.Forms
{
    /// <summary>
    /// 进度条对话框
    /// </summary>
    public partial class CircleProgressBarDialog : Form
    {
        /// <summary>
        /// 线程事件
        /// </summary>
        private event EventHandler<CircleProgressBarEventArgs> doWork;

        /// <summary>
        /// 错误日志
        /// </summary>
        public event EventHandler<CircleProgressBarErrorEventArgs> OnError;

        /// <summary>
        /// 消息控件
        /// </summary>
        public Label MessageLabel
        {
            get
            { 
                return lbMessage;
            }
        }

        /// <summary>
        /// 进度条控件
        /// </summary>
        public CircleProgressBar ProgressBar
        {
            get
            { 
                return cpbProgressBar;
            }
        }

        /// <summary>
        /// 是否正在运行(只读)
        /// </summary>
        public bool IsBusy
        {
            get
            {
                if (IsDisposed)
                {
                    return false;
                }
                else
                {
                    return bwProgressReport.IsBusy;
                }
            }
        }

        /// <summary>
        /// 指示应用程序是否已请求停止后台操作(只读)
        /// </summary>
        public bool CancellationPending
        {
            get { return bwProgressReport.CancellationPending; }
        }

        public CircleProgressBarDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 开始
        /// </summary>
        public void Start(EventHandler<CircleProgressBarEventArgs> doworkEvent)
        {
            //判断是否正在工作中
            if (bwProgressReport.IsBusy)
            {
                return;
            }

            //设置事件
            doWork = doworkEvent;

            //开始运持
            bwProgressReport.RunWorkerAsync();

            //显示窗体
            Show();
        }

        /// <summary>
        /// 结束
        /// </summary>
        public void Stop()
        {
            bwProgressReport.CancelAsync();
        }

        /// <summary>
        /// 后台线程事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bwProgressReport_DoWork(object sender, DoWorkEventArgs e)
        {
            //运行执行体
            try
            {
                if (doWork != null)
                {
                    doWork(this, new CircleProgressBarEventArgs());
                }
            }
            catch (Exception ex)
            {
                if (OnError != null)
                {
                    OnError(this, new CircleProgressBarErrorEventArgs(ex));
                }
            }

            //关闭窗体
            if (IsHandleCreated)
            {
                try
                {
                    Invoke(new MethodInvoker(delegate()
                        {
                            try
                            {
                                Close();
                            }
                            catch (Exception ex)
                            {
                                if (OnError != null)
                                {
                                    OnError(this, new CircleProgressBarErrorEventArgs(ex));
                                }
                            }
                        }));
                }
                catch (Exception ex)
                {
                    if (OnError != null)
                    {
                        OnError(this, new CircleProgressBarErrorEventArgs(ex));
                    }
                }
            }
        }

        /// <summary>
        /// 显示进度
        /// </summary>
        /// <param name="value">当前进度</param>
        /// <param name="max">总量</param>
        public void ReportProgress(int value,int max)
        {
            if (IsBusy && IsHandleCreated)
            {
                Invoke(new MethodInvoker(delegate()
                    {
                        //当前进度
                        cpbProgressBar.CurrentProgress = value;

                        //总量
                        cpbProgressBar.MaximumProgress = max;
                    }));
            }
        }

        /// <summary>
        /// 显示提示
        /// </summary>
        /// <param name="s">提示文本</param>
        public void ReportInfo(string s)
        {
            if (IsBusy && IsHandleCreated)
            {
                Invoke(new MethodInvoker(delegate()
                {
                    //显示提示文本
                    lbMessage.Text = s;
                }));
            }
        }
    }

    /// <summary>
    /// 进度条事件
    /// </summary>
    public class CircleProgressBarEventArgs:EventArgs
    {
    }

    /// <summary>
    /// 错误事件
    /// </summary>
    public class CircleProgressBarErrorEventArgs : EventArgs
    {
        public CircleProgressBarErrorEventArgs(Exception errors)
        {
            ErrorException = errors;
        }

        /// <summary>
        /// 错误对象
        /// </summary>
        public Exception ErrorException { get; private set; }
    }
}