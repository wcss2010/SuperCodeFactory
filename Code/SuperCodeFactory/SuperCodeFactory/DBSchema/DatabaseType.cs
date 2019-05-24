﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCodeFactory.DBSchema
{
    /// <summary>
    /// 所支持的数据库类型
    /// </summary>
    public enum DatabaseType
    {
        Odbc,
        OleDb,
        SqlServer,
        Oracle,
        MySql,
        DB2,
        SQLite,
        Firebird,
        PostgreSql
    }
}
