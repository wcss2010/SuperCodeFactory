using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SuperCodeFactoryLib
{
    /// <summary>
    /// ����������ʽ����֤��
    /// </summary>
    public class RegexValidate
    {
        /// <summary>
        /// �ж��ַ����Ƿ���ָ��������ʽƥ��
        /// </summary>
        /// <param name="input">Ҫ��֤���ַ���</param>
        /// <param name="regularExp">������ʽ</param>
        /// <returns>��֤ͨ������true</returns>
        public static bool IsMatch(string input, string regularExp)
        {
            return Regex.IsMatch(input, regularExp);
        }

        /// <summary>
        /// ��֤�Ǹ������������� + 0��
        /// </summary>
        /// <param name="input">Ҫ��֤���ַ���</param>
        /// <returns>��֤ͨ������true</returns>
        public static bool IsUnMinusInt(string input)
        {
            return Regex.IsMatch(input, RegexConst.UnMinusInteger);
        }

        /// <summary>
        /// ��֤������
        /// </summary>
        /// <param name="input">Ҫ��֤���ַ���</param>
        /// <returns>��֤ͨ������true</returns>
        public static bool IsPlusInt(string input)
        {
            return Regex.IsMatch(input, RegexConst.PlusInteger);
        }

        /// <summary>
        /// ��֤���������������� + 0�� 
        /// </summary>
        /// <param name="input">Ҫ��֤���ַ���</param>
        /// <returns>��֤ͨ������true</returns>
        public static bool IsUnPlusInt(string input)
        {
            return Regex.IsMatch(input, RegexConst.UnPlusInteger);
        }

        /// <summary>
        /// ��֤������
        /// </summary>
        /// <param name="input">Ҫ��֤���ַ���</param>
        /// <returns>��֤ͨ������true</returns>
        public static bool IsMinusInt(string input)
        {
            return Regex.IsMatch(input, RegexConst.MinusInteger);
        }

        /// <summary>
        /// ��֤����
        /// </summary>
        /// <param name="input">Ҫ��֤���ַ���</param>
        /// <returns>��֤ͨ������true</returns>
        public static bool IsInt(string input)
        {
            return Regex.IsMatch(input, RegexConst.Integer);
        }

        /// <summary>
        /// ��֤�Ǹ����������������� + 0��
        /// </summary>
        /// <param name="input">Ҫ��֤���ַ���</param>
        /// <returns>��֤ͨ������true</returns>
        public static bool IsUnMinusFloat(string input)
        {
            return Regex.IsMatch(input, RegexConst.UnMinusFloat);
        }

        /// <summary>
        /// ��֤��������
        /// </summary>
        /// <param name="input">Ҫ��֤���ַ���</param>
        /// <returns>��֤ͨ������true</returns>
        public static bool IsPlusFloat(string input)
        {
            return Regex.IsMatch(input, RegexConst.PlusFloat);
        }

        /// <summary>
        /// ��֤�������������������� + 0��
        /// </summary>
        /// <param name="input">Ҫ��֤���ַ���</param>
        /// <returns>��֤ͨ������true</returns>
        public static bool IsUnPlusFloat(string input)
        {
            return Regex.IsMatch(input, RegexConst.UnPlusFloat);
        }

        /// <summary>
        /// ��֤��������
        /// </summary>
        /// <param name="input">Ҫ��֤���ַ���</param>
        /// <returns>��֤ͨ������true</returns>
        public static bool IsMinusFloat(string input)
        {
            return Regex.IsMatch(input, RegexConst.MinusFloat);
        }

        /// <summary>
        /// ��֤������
        /// </summary>
        /// <param name="input">Ҫ��֤���ַ���</param>
        /// <returns>��֤ͨ������true</returns>
        public static bool IsFloat(string input)
        {
            return Regex.IsMatch(input, RegexConst.Float);
        }

        /// <summary>
        /// ��֤��26��Ӣ����ĸ��ɵ��ַ���
        /// </summary>
        /// <param name="input">Ҫ��֤���ַ���</param>
        /// <returns>��֤ͨ������true</returns>
        public static bool IsLetter(string input)
        {
            return Regex.IsMatch(input, RegexConst.Letter);
        }

        /// <summary>
        /// ��֤��26��Ӣ����ĸ�Ĵ�д��ɵ��ַ���
        /// </summary>
        /// <param name="input">Ҫ��֤���ַ���</param>
        /// <returns>��֤ͨ������true</returns>
        public static bool IsUpperLetter(string input)
        {
            return Regex.IsMatch(input, RegexConst.UpperLetter);
        }

        /// <summary>
        /// ��֤��26��Ӣ����ĸ��Сд��ɵ��ַ���
        /// </summary>
        /// <param name="input">Ҫ��֤���ַ���</param>
        /// <returns>��֤ͨ������true</returns>
        public static bool IsLowerLetter(string input)
        {
            return Regex.IsMatch(input, RegexConst.LowerLetter);
        }

        /// <summary>
        /// ��֤�����ֺ�26��Ӣ����ĸ��ɵ��ַ���
        /// </summary>
        /// <param name="input">Ҫ��֤���ַ���</param>
        /// <returns>��֤ͨ������true</returns>
        public static bool IsNumericOrLetter(string input)
        {
            return Regex.IsMatch(input, RegexConst.NumericOrLetter);
        }

        /// <summary>
        /// ��֤�����֡�26��Ӣ����ĸ�����»�����ɵ��ַ���
        /// </summary>
        /// <param name="input">Ҫ��֤���ַ���</param>
        /// <returns>��֤ͨ������true</returns>
        public static bool IsNumericOrLetterOrUnderline(string input)
        {
            return Regex.IsMatch(input, RegexConst.NumericOrLetterOrUnderline);
        }

        /// <summary>
        /// ��֤email��ַ
        /// </summary>
        /// <param name="input">Ҫ��֤���ַ���</param>
        /// <returns>��֤ͨ������true</returns>
        public static bool IsEmail(string input)
        {
            return Regex.IsMatch(input, RegexConst.Email);
        }

        /// <summary>
        /// ��֤URL
        /// </summary>
        /// <param name="input">Ҫ��֤���ַ���</param>
        /// <returns>��֤ͨ������true</returns>
        public static bool IsUrl(string input)
        {
            return Regex.IsMatch(input, RegexConst.Url);
        }

        /// <summary>
        /// ��֤�绰����
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsTelephone(string input)
        {
            return Regex.IsMatch(input, RegexConst.Telephone);
        }

        /// <summary>
        /// ͨ���ļ���չ����֤ͼ���ʽ
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsImageFormat(string input)
        {
            return Regex.IsMatch(input, RegexConst.ImageFormat);
        }

        /// <summary>
        /// ��֤IP
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsIP(string input)
        {
            return Regex.IsMatch(input, RegexConst.IP);
        }

        /// <summary>
        /// ��֤���ڣ�YYYY-MM-DD��
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsDate(string input)
        {
            return Regex.IsMatch(input, RegexConst.Date);
        }

        /// <summary>
        /// ��֤���ں�ʱ�䣨YYYY-MM-DD HH:MM:SS��
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsDateTime(string input)
        {
            return Regex.IsMatch(input, RegexConst.DateTime);
        }
    }
}
