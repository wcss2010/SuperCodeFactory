        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="outputDir">输出路径</param>
        /// <param name="connectionUrl">连接字符串</param>
        /// <param name="tables">表名(字典中Key为表名，Value为表格列信息)(string[]的长度为2，第一个为字段名称，第二个为字段类型)</param>
        /// <returns>返回提示信息,成功为ok</returns>
        string make(string outputDir, string connectionUrl, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string[]>> tables)
        {
            return "ok";
        }