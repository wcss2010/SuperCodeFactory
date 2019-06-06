        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="dbType">数据库类型</param>
		/// <param name="namespaceStr">命名空间</param>
		/// <param name="classBefore">类名前缀</param>
		/// <param name="classAfter">类名后缀</param>
		/// <param name="connectionUrl">连接字符串</param>
        /// <param name="tableName">表名</param>
        /// <param name="columns">字段(string[]的长度为2，第一个为字段名称，第二个为字段类型)</param>
        /// <returns>生成后的代码</returns>
        string make(string dbType,string namespaceStr,string classBefore,string classAfter,string connectionUrl, string tableName, System.Collections.Generic.List<string[]> columns)
        {
            return "常用";
        }