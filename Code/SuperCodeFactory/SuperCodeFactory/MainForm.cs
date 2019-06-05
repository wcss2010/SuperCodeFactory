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
    }
}