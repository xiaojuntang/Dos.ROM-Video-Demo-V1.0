using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Zxxk.Gkbb.Common
{
    /// <summary>
    /// 常量类
    /// </summary>
    public class Const
    {
        /// <summary>
        /// 接口地址或域名
        /// </summary>
        public static string URL = string.Empty;
        /// <summary>
        /// 视频接口
        /// </summary>
        public static string URL_VIDEO = string.Empty;

        static Const()
        {
            URL = ConfigurationManager.AppSettings["InterfaceUrl"].ToString();
            URL_VIDEO = URL + "VideoApi/GetVideoList";
        }
    }
}
