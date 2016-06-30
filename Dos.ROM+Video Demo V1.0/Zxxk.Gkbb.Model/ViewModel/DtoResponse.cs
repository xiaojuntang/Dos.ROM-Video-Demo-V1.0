using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zxxk.Gkbb.Model
{

    /// <summary>
    /// 接口与异步返回类
    /// </summary>
    [Serializable]
    public class DtoResponse<T> where T : class, new()
    {
        /// <summary>
        /// 返回代码.具体见方法返回值说明
        /// </summary>
        public Codes Code { get; set; }

        /// <summary>
        /// 返回消息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 返回数据
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public DtoResponse()
        {
            Code = Codes.Success;
            Message = "成功";
        }
    }

    /// <summary>
    /// 代码类
    /// </summary>
    [Serializable]
    public enum Codes
    {
        /// <summary>
        /// 成功 0
        /// </summary>
        Success = 0,
        /// <summary>
        /// 失败 1
        /// </summary>
        Failure = 1,
        /// <summary>
        /// 错误 2
        /// </summary>
        Error = 2,
        /// <summary>
        /// 无数据 3
        /// </summary>
        Empty = 3,
        /// <summary>
        /// 参数错误
        /// </summary>
        ParamError = 4
    }

    /// <summary>
    /// 分页参数 可任务基数
    /// </summary>
    [Serializable]
    public class Paging
    {
        /// <summary>
        /// 当前页。从1计数
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 每页记录数。默认20
        /// </summary>
        public int PageSize { get; set; }

        public Paging()
        {
            PageIndex = 1;
            PageSize = 10;
        }
    }

    /// <summary>
    /// 分页类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class PagingResponse<T> where T : class
    {
        /// <summary>
        /// 总记录数
        /// </summary>
        public int TotalNumber;

        /// <summary>
        /// 当前页记录列表
        /// </summary>
        public List<T> Items { get; set; }

        /// <summary>
        /// 分页
        /// </summary>
        public string PageNavigate { get; set; }
    }
}
