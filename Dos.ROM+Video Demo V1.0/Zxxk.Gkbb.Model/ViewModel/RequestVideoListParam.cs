using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zxxk.Gkbb.Model
{
    /// <summary>
    /// 视频列表请求对象
    /// </summary>
    public class RequestVideoList : BaseEntity
    {
        public int userID { get; set; }
        public string version { get; set; }
        public string phoneMo { get; set; }
        public string ispage { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
        public int sortID { get; set; }
        public int parentID { get; set; }
    }

    /// <summary>
    /// 视频列表请求响应对象
    /// </summary>
    public class ReplyVideoList
    {
        public int VideoID { get; set; }
        public int VideoSortID { get; set; }
        public string Title { get; set; }
        public string IconPathSmall { get; set; }
        public int PlayNumber { get; set; }
        public int Hit { get; set; }
        public int DownloadNumber { get; set; }
        public int Flowers { get; set; }
        public int ChildCount { get; set; }
        public string FilePath { get; set; }
        public int ParentID { get; set; }
    }
}
