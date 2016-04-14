using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class clsJSON
    {
        /// <summary>
        /// JSON序列化
        /// </summary>
        /// <typeparam name="T">需要JSON序列化的类</typeparam>
        /// <param name="t">需要JSON序列化的类的实例</param>
        public static string XuLieHua<T>(T t)
        {
            return JsonConvert.SerializeObject(t, Formatting.Indented);
        }

        /// <summary>
        /// JSON反序列化
        /// </summary>
        /// <typeparam name="T">需要JSON反序列化的类</typeparam>
        /// <param name="jsonString">JSON串</param>
        public static T FanXuLieHua<T>(string jsonString)
        {
            return (T)JsonConvert.DeserializeObject(jsonString, typeof(T));
        }

    }
}
