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

        private void button2_Click(object sender, EventArgs e)
        {
            //System.Reflection.Assembly.LoadFrom(@"c:\System.Data.SQLite.dll");
            try
            {
                DBSchema.DbSchema schemaObj = DBSchema.DbSchemaFactory.Create("System.Data.SQLite", "Data Source=c:\\myData1.db");
                List<SuperCodeFactory.DBSchema.SchemaObject.SOTable> tableList = schemaObj.GetTableList(schemaObj.GetDatabaseList()[0]);
                foreach (SuperCodeFactory.DBSchema.SchemaObject.SOTable table in tableList)
                {
                    System.Console.WriteLine(table.FullName);
                    foreach (SuperCodeFactory.DBSchema.SchemaObject.SOColumn col in table.ColumnList)
                    {
                        System.Console.WriteLine(table.FullName + "---" + col.FullName + ",,,"+ col.DataType);
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}