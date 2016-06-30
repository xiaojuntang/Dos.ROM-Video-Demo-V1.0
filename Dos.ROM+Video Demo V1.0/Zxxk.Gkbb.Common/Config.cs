using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zxxk.Gkbb.Common
{
    public class Config
    {
        /// <summary>
        /// 静态静态地址
        /// </summary>
        public static string Url
        {
            get
            {
                return "";//SettingHelper.GetString("StaticUrl");
            }
        }
    }
}
