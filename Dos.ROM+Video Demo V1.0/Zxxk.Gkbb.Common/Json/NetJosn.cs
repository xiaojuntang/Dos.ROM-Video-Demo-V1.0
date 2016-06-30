using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zxxk.Gkbb.Common
{
    public class NetJosn<T> where T : class, new()
    {
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="jsonStr">字符串</param>
        /// <returns></returns>
        public static T DeserializeObject(string jsonStr)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonStr);
        }

        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="model">对象</param>
        /// <returns></returns>
        public static string SerializeObject(T model)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(model);
        }
    }
}
