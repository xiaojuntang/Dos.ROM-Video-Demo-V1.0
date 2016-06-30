using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zxxk.Gkbb.Common
{
    public interface IJson<T> where T : class, new()
    {
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="jsonStr">字符串</param>
        /// <returns></returns>
        T DeserializeObject(string jsonStr);

        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="model">对象</param>
        /// <returns></returns>
        string SerializeObject(T model);
    }
}
