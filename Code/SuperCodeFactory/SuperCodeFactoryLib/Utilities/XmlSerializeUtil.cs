using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace SuperCodeFactoryLib.Utilities
{
    /// <summary>
    /// XML序列化
    /// </summary>
    public class XmlSerializeUtil
    {
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T">将要序列化或反序列化的类型</typeparam>
        /// <param name="xml">源Xml文本</param>
        /// <returns>反序列化后的实例对象</returns>
        public static T Deserialize<T>(string xml)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            StringReader sr = new StringReader(xml);
            T obj = (T)xs.Deserialize(sr);
            sr.Close();
            sr.Dispose();
            return obj;
        }

        /// <summary>
        /// 序列化
        /// </summary>
        /// <typeparam name="T">将要序列化或反序列化的类型</typeparam>
        /// <param name="t">源对象</param>
        /// <returns>序列化后的XML文本</returns>
        public static string Serializer<T>(T t)
        {
            XmlSerializerNamespaces xsn = new XmlSerializerNamespaces();
            xsn.Add(string.Empty, string.Empty);
            XmlSerializer xs = new XmlSerializer(typeof(T));
            StringWriter sw = new StringWriter();
            xs.Serialize(sw, t, xsn);
            string str = sw.ToString();
            sw.Close();
            sw.Dispose();
            return str;
        }
    }
}