﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using SuperCodeFactoryLib.Security;
using SuperCodeFactoryLib.Utilities;

namespace SuperCodeFactoryLib.Extensions
{
    public static class ByteExt
    {
        /// <summary>
        /// 转十六进制
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string ToHex(this byte b)
        {
            return ByteUtil.ToHex(b);
        }

        /// <summary>
        /// 转十六进制
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string ToHex(this IEnumerable<byte> bytes)
        {
            return ByteUtil.ToHex(bytes);
        }

        /// <summary>
        /// 将 8 位无符号整数数组转换为它的等效 System.String 表示形式（使用 Base 64 数字编码）
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ToBase64String(this byte[] data)
        {
            return ByteUtil.ToBase64String(data);
        }

        /// <summary>
        /// 返回由字节数组中指定位置的八个字节转换来的 32 位有符号整数
        /// </summary>
        /// <param name="data"></param>
        /// <param name="startIndex"></param>
        /// <returns></returns>
        public static int ToInt(this byte[] data, int startIndex)
        {
            return ByteUtil.ToInt(data, startIndex);
        }

        /// <summary>
        /// 返回由字节数组中指定位置的八个字节转换来的 64 位有符号整数
        /// </summary>
        /// <param name="data"></param>
        /// <param name="startIndex"></param>
        /// <returns></returns>
        public static long ToInt64(this byte[] data, int startIndex)
        {
            return ByteUtil.ToInt64(data, startIndex);
        }

        /// <summary>
        /// 转换为指定编码字符串
        /// </summary>
        /// <param name="data"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string Decode(this byte[] data, Encoding encoding)
        {
            return ByteUtil.Decode(data, encoding);
        }

        /// <summary>
        /// 保存到文件
        /// </summary>
        /// <param name="data"></param>
        /// <param name="path"></param>
        public static void Save(this byte[] data, string path)
        {
            ByteUtil.Save(data, path);
        }

        /// <summary>
        /// 保存到内存流
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static MemoryStream ToMemoryStream(this byte[] data)
        {
            return ByteUtil.ToMemoryStream(data);
        }

        /// <summary>
        /// 使用指定哈希算法计算哈希值
        /// </summary>
        /// <param name="data"></param>
        /// <param name="hashEnum"></param>
        /// <returns></returns>
        public static byte[] ComputeHash(this byte[] data, HashAlgorithmType hashAlgorithmType)
        {
            return ByteUtil.ComputeHash(data, hashAlgorithmType);
        }

        /// <summary>
        /// 使用默认Hash算法SHA1计算哈希值
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] ComputeHash(this byte[] data)
        {
            return ByteUtil.ComputeHash(data);
        }
    }
}
