﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SuperCodeFactoryLib.Utilities
{
    /// <summary>
    /// 文件操作类 
    /// </summary>
    public sealed class IOUtil
    {
        /// <summary>
        /// 获取目录下文件数量
        /// </summary>
        /// <param name="dirInfo">目录</param>
        /// <param name="extention">扩展名如：*.tt</param>
        /// <returns></returns>
        public static int GetFilesCount(DirectoryInfo dirInfo, string extention = null)
        {

            int totalFile = 0;
            if (string.IsNullOrEmpty(extention))
            {
                totalFile += dirInfo.GetFiles().Length;//获取全部文件
            }
            else
            {
                totalFile += dirInfo.GetFiles(extention).Length;//获取某种格式
            }
            foreach (System.IO.DirectoryInfo subdir in dirInfo.GetDirectories())
            {
                totalFile += GetFilesCount(subdir, extention);
            }
            return totalFile;
        }

        /// <summary>
        /// 复制目录
        /// </summary>
        /// <param name="SourcePath"></param>
        /// <param name="DestinationPath"></param>
        /// <param name="overwriteexisting"></param>
        /// <returns></returns>
        public static bool CopyDirectory(string SourcePath, string DestinationPath, bool overwriteexisting)
        {
            bool ret = false;
            try
            {
                SourcePath = SourcePath.EndsWith(@"\") ? SourcePath : SourcePath + @"\";
                DestinationPath = DestinationPath.EndsWith(@"\") ? DestinationPath : DestinationPath + @"\";

                if (Directory.Exists(SourcePath))
                {
                    if (Directory.Exists(DestinationPath) == false)
                        Directory.CreateDirectory(DestinationPath);

                    foreach (string fls in Directory.GetFiles(SourcePath))
                    {
                        FileInfo flinfo = new FileInfo(fls);
                        flinfo.CopyTo(DestinationPath + flinfo.Name, overwriteexisting);
                    }
                    foreach (string drs in Directory.GetDirectories(SourcePath))
                    {
                        DirectoryInfo drinfo = new DirectoryInfo(drs);
                        if (CopyDirectory(drs, DestinationPath + drinfo.Name, overwriteexisting) == false)
                            ret = false;
                    }
                }
                ret = true;
            }
            catch (Exception ex)
            {
                ret = false;
            }
            return ret;
        }
    }
}