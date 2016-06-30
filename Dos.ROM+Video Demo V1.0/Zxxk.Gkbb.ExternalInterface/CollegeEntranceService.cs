using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zxxk.Gkbb.Model;
using Zxxk.Gkbb.Common;

namespace Zxxk.Gkbb.ExternalInterface
{
    /// <summary>
    /// 高考必备接口
    /// </summary>
    public class CollegeEntranceService
    {
        /// <summary>
        /// 测试方法
        /// </summary>
        /// <returns></returns>
        public static DtoTest GetTest()
        {
            DtoTest t = new DtoTest();
            t.Id = 1;
            t.Name = "TTTT";
            return t;
        }

        /// <summary>
        /// 获取视频列表
        /// </summary>
        /// <param name="url">地址</param>
        /// <param name="param">参数</param>
        /// <returns></returns>
        public static string GetVideoList(string url, string param)
        {
            return WebHelper.GetPostRequestData(url, param);
        }
    }
}
