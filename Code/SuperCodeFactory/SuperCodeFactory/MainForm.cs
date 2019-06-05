using CSScriptLibrary;
using SuperCodeFactory.DBSchema.SchemaObject;
using SuperCodeFactoryUILib.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

            this.cbDbType.Text = "System.Data.SQLite";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {  
        }

        private void btnGetTables_Click(object sender, EventArgs e)
        {
            //清空树列表
            tvTables.Nodes.Clear();

            //根节点
            TreeNode firstNode = new TreeNode();
            firstNode.Text = "数据库";
            tvTables.Nodes.Add(firstNode);

            string dbType = cbDbType.Text;
            string connUrl = txtConnectionUrl.Text;

            CircleProgressBarDialog dialog = new CircleProgressBarDialog();
            dialog.Start(new EventHandler<CircleProgressBarEventArgs>(delegate(object senders, CircleProgressBarEventArgs args)
                {
                    try
                    {
                        DBSchema.DbSchema schemaObj = DBSchema.DbSchemaFactory.Create(dbType, connUrl);

                        if (schemaObj != null)
                        {
                            List<SuperCodeFactory.DBSchema.SchemaObject.SOTable> tableList = schemaObj.GetTableList(schemaObj.GetDatabaseList()[0]);

                            if (tableList != null)
                            {
                                foreach (SuperCodeFactory.DBSchema.SchemaObject.SOTable table in tableList)
                                {
                                    //报告进度
                                    ((CircleProgressBarDialog)senders).ReportProgress((int)(((float)tableList.IndexOf(table) / (float)tableList.Count) * 100), 100);

                                    //添加表格节点
                                    TreeNode tableNode = new TreeNode();
                                    tableNode.Text = "表格(" + table.Name + ")";
                                    tableNode.Tag = table;
                                    
                                    if (IsHandleCreated)
                                    {
                                        Invoke(new MethodInvoker(delegate()
                                        {
                                            firstNode.Nodes.Add(tableNode);
                                        }));
                                    }

                                    if (table.ColumnList != null)
                                    {
                                        foreach (SuperCodeFactory.DBSchema.SchemaObject.SOColumn col in table.ColumnList)
                                        {
                                            //添加字段节点
                                            TreeNode columnNode = new TreeNode();
                                            columnNode.Text = "字段(" + col.Name + "," + col.DataType + ")";
                                            columnNode.Tag = col;
                                            
                                            if (IsHandleCreated)
                                            {
                                                Invoke(new MethodInvoker(delegate()
                                                {
                                                    tableNode.Nodes.Add(columnNode);
                                                }));
                                            }
                                        }
                                    }
                                }
                            }

                            //展开根节点
                            if (IsHandleCreated)
                            {
                                Invoke(new MethodInvoker(delegate()
                                    {
                                        firstNode.Expand();
                                    }));                                
                            }
                        }

                        try
                        {
                            Thread.Sleep(100);
                        }
                        catch (Exception ex) { }
                        
                    }
                    catch (Exception ex)
                    {
                        dialog.TopMost = false;
                        MessageBox.Show("操作失败！Ex:" + ex.ToString());
                    }
                }));            
        }

        private void tvTables_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                TreeNode tableNode = e.Node;
                if (tableNode.Tag is SOColumn)
                {
                    tableNode = e.Node.Parent;
                }

                //表名
                string tableName = ((SOTable)tableNode.Tag).Name;

                //列
                List<string[]> columns = new List<string[]>();
                foreach (TreeNode columnNode in tableNode.Nodes)
                {
                    //输出字段信息
                    columns.Add(new string[] { ((SOColumn)columnNode.Tag).Name, ((SOColumn)columnNode.Tag).DataType.ToString() });
                }

                //常用代码
                try
                {
                    var make = CSScript.CreateFunc<string>(File.ReadAllText(Path.Combine(Application.StartupPath, @"Templetes\script\常用.cs")));
                    txtNormal.Text = make(txtConnectionUrl.Text, tableName, columns);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("生成错误！Ex:" + ex.ToString());
                }

                //单表代码
                try
                {
                    var make = CSScript.CreateFunc<string>(File.ReadAllText(Path.Combine(Application.StartupPath, @"Templetes\script\单表.cs")));
                    txtOneTable.Text = make(txtConnectionUrl.Text, tableName, columns);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("生成错误！Ex:" + ex.ToString());
                }
            }
        }

        private void btnMakeAll_Click(object sender, EventArgs e)
        {
            if (tvTables.Nodes.Count >= 1 && tvTables.Nodes[0].Nodes.Count >= 1)
            {
                #region 准备表格字典
                Dictionary<string, List<string[]>> tables = new Dictionary<string, List<string[]>>();
                foreach (TreeNode tableNode in tvTables.Nodes[0].Nodes)
                {
                    //表名
                    string tableName = ((SOTable)tableNode.Tag).Name;

                    //列
                    List<string[]> columns = new List<string[]>();
                    foreach (TreeNode columnNode in tableNode.Nodes)
                    {
                        //输出字段信息
                        columns.Add(new string[] { ((SOColumn)columnNode.Tag).Name, ((SOColumn)columnNode.Tag).DataType.ToString() });
                    }

                    //添加表格
                    tables[tableName] = columns;
                }
                #endregion

                if (fbdOutputDir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        CircleProgressBarDialog dialog = new CircleProgressBarDialog();
                        dialog.Start(new EventHandler<CircleProgressBarEventArgs>(delegate(object senders, CircleProgressBarEventArgs args)
                            {
                                try
                                {
                                    ((CircleProgressBarDialog)senders).ReportProgress(10, 100);

                                    try
                                    {
                                        Directory.CreateDirectory(fbdOutputDir.SelectedPath);
                                    }
                                    catch (Exception ex) { }

                                    ((CircleProgressBarDialog)senders).ReportProgress(20, 100);

                                    //复制目录
                                    SuperCodeFactoryLib.Utilities.IOUtil.CopyDirectory(Path.Combine(Application.StartupPath, @"Templetes"), fbdOutputDir.SelectedPath, true);
                                    
                                    //删除脚本目录
                                    try
                                    {
                                        Directory.Delete(Path.Combine(fbdOutputDir.SelectedPath, "script"), true);
                                    }
                                    catch (Exception ex) { }

                                    ((CircleProgressBarDialog)senders).ReportProgress(60, 100);

                                    #region 运行动态代码
                                    var make = CSScript.CreateFunc<string>(File.ReadAllText(Path.Combine(Application.StartupPath, @"Templetes\script\总体.cs")));
                                    string result = make(fbdOutputDir.SelectedPath, txtConnectionUrl.Text, tables);

                                    ((CircleProgressBarDialog)senders).TopMost = false;
                                    MessageBox.Show(result);
                                    #endregion

                                    ((CircleProgressBarDialog)senders).ReportProgress(100, 100);
                                }
                                catch (Exception ex)
                                {
                                    ((CircleProgressBarDialog)senders).TopMost = false;
                                    MessageBox.Show("生成错误！Ex:" + ex.ToString());
                                }
                            }));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("生成错误！Ex:" + ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("对不起，请先配置数据库连接！");
            }
        }

        private void btnScriptDir_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Path.Combine(Application.StartupPath, @"Templetes\script"));
            }
            catch (Exception ex) { }
        }
    }
}