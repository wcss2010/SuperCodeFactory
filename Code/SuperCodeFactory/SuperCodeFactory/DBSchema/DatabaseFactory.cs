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
        public static Database Create(DatabaseProviderType providerType, string connectionString)
        {
            DbProviderFactory providerFactory = null;
            Database db = null;
            string providerName = Enum.GetName(typeof(DatabaseProviderType), providerType).Replace("_", ".");

            switch (providerType)
            {
                case DatabaseProviderType.System_Data_Odbc:
                    db = new OdbcDatabase(connectionString);
                    break;
                case DatabaseProviderType.System_Data_OleDb:
                    db = new OleDbDatabase(connectionString);
                    break;
                case DatabaseProviderType.System_Data_OracleClient:
                    db = new OracleDatabase(connectionString);
                    break;
                case DatabaseProviderType.Oracle_ManagedDataAccess_Client:
                    db = new OracleDatabase(connectionString);
                    break;
                case DatabaseProviderType.Devart_Data_Oracle: //http://evget.com/zh-CN/product/954/feature.aspx  http://www.devart.com/ 
                case DatabaseProviderType.DDTek_Oracle: //http://www.datadirect.com/index.html 由于删除了版权DLL，导致该功能可能无法使用。可在QQ群：122161138中下载source_lib.zip
                    providerFactory = DbProviderFactories.GetFactory(providerName);
                    db = new OracleDatabase(connectionString, providerFactory);
                    break;
                case DatabaseProviderType.System_Data_SQLite:
                    providerFactory = DbProviderFactories.GetFactory(providerName);
                    db = new SQLiteDatabase(connectionString, providerFactory);
                    break;
                case DatabaseProviderType.MySql_Data_MySqlClient:
                    providerFactory = DbProviderFactories.GetFactory(providerName);
                    db = new MySqlDatabase(connectionString, providerFactory);
                    break;
                case DatabaseProviderType.IBM_Data_DB2:
                    providerFactory = DbProviderFactories.GetFactory(providerName);
                    db = new DB2Database(connectionString, providerFactory);
                    break;
                case DatabaseProviderType.FirebirdSql_Data_FirebirdClient:
                    providerFactory = DbProviderFactories.GetFactory(providerName);
                    db = new FirebirdDatabase(connectionString, providerFactory);
                    break;
                default:
                    break;
            }

            return db;
        }
    }

    /// <summary>
    /// 数据库适配器类型
    /// </summary>
    public enum DatabaseProviderType
    {
        System_Data_Odbc,
        System_Data_OleDb,
        System_Data_OracleClient,
        Oracle_ManagedDataAccess_Client,
        Devart_Data_Oracle,
        DDTek_Oracle,
        System_Data_SQLite,
        MySql_Data_MySqlClient,
        IBM_Data_DB2,
        FirebirdSql_Data_FirebirdClient
    }
}