using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Zxxk.Gkbb.Model;

namespace Zxxk.Gkbb.Common
{
    /// <summary>
    /// 工具类
    /// </summary>
    public class Tools
    {
        /// <summary>
        /// 对象转换成URL参数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string GetUrlParam<T>(BaseEntity param) where T : class, new()
        {
            T exam = param as T;
            Dictionary<string, object> papramters = new Dictionary<string, object>();
            Type type = exam.GetType();
            System.Reflection.PropertyInfo[] ps = type.GetProperties();
            foreach (PropertyInfo i in ps)
            {
                string name = i.Name;
                object obj = i.GetValue(exam, null);
                papramters.Add(name, obj == null ? string.Empty : obj);
            }
            IDictionary<string, object> sortedParams = new SortedDictionary<string, object>(papramters);
            IEnumerator<KeyValuePair<string, object>> dem = sortedParams.GetEnumerator();
            StringBuilder query = new StringBuilder();
            while (dem.MoveNext())
            {
                string key = dem.Current.Key;
                object value = dem.Current.Value;
                if (!string.IsNullOrWhiteSpace(key))
                {
                    query.Append(key).Append("=").Append(value).Append("&");
                }
            }
            string paramStr = query.ToString().TrimEnd('&');
            return paramStr;
        }
    }
}
