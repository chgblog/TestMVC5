using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class clsGuoLv
    {
        #region 表单过滤
        /// <summary>
        /// 表单过滤
        /// </summary>
        /// <param name="str">准备过滤的字符串</param>
        /// <returns>过滤后的字符串</returns>
        public static string BiaoDanGuoLv(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }
            str = str.Trim();
            str = str.Replace("'", "‘");

            return str;
        } 
        #endregion

        #region 表单过滤
        /// <summary>
        /// 表单过滤
        /// </summary>
        /// <param name="arr">准备过滤的字符串数组</param>
        /// <returns>过滤后的字符串</returns>
        public static string[] BiaoDanGuoLv(this string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].BiaoDanGuoLv();
            }
            return arr;
        }
        #endregion

    }
}
