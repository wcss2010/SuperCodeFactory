using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using SuperCodeFactory.DBSchema.DbProvider;
using SuperCodeFactoryLib.Utilities;
using System.Data.Common;
using System.Data;
using System.Data.OleDb;
using System.Reflection;
using SuperCodeFactory.DBSchema.Db;

namespace SuperCodeFactory.DBSchema
{
    /// <summary>
    /// 数据库工厂
    /// </summary>
    public static class DatabaseFactory
    {
        /// <summary>
        /// 创建一个数据提供程序实例
        /// </summary>
        /// <param name="connectionStringName"></param>
        /// <returns></returns>
        public static Database Create(string providerName, string connectionString)
        {
            DbProviderFactory providerFactory = null;
            Database db = null;
            switch (providerName)
            {
                case "System.Data.Odbc":
                    db = new OdbcDatabase(connectionString);
                    break;
                case "System.Data.OleDb":
                    db = new OleDbDatabase(connectionString);
                    break;
                case "System.Data.OracleClient":
                    db = new OracleDatabase(connectionString);
                    break;
                case "Oracle.ManagedDataAccess.Client":
                    db = new OracleDatabase(connectionString);
                    break;
                case "Devart.Data.Oracle": //http://evget.com/zh-CN/product/954/feature.aspx  http://www.devart.com/ 
                case "DDTek.Oracle": //http://www.datadirect.com/index.html 由于删除了版权DLL，导致该功能可能无法使用。可在QQ群：122161138中下载source_lib.zip
                    providerFactory = DbProviderFactories.GetFactory(providerName);
                    db = new OracleDatabase(connectionString, providerFactory);
                    break;
                case "System.Data.SQLite":
                    providerFactory = DbProviderFactories.GetFactory(providerName);
                    db = new SQLiteDatabase(connectionString, providerFactory);
                    break;
                case "MySql.Data.MySqlClient":
                    providerFactory = DbProviderFactories.GetFactory(providerName);
                    db = new MySqlDatabase(connectionString, providerFactory);
                    break;
                case "IBM.Data.DB2":
                    providerFactory = DbProviderFactories.GetFactory(providerName);
                    db = new DB2Database(connectionString, providerFactory);
                    break;
                case "FirebirdSql.Data.FirebirdClient":
                    providerFactory = DbProviderFactories.GetFactory(providerName);
                    db = new FirebirdDatabase(connectionString, providerFactory);
                    break;
                default:
                    break;
            }
            return db;
        }
    }
}