using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zxxk.Gkbb.Model;
using Zxxk.Gkbb.ExternalInterface;
using Zxxk.Gkbb.Common;
using Newtonsoft.Json;

namespace Zxxk.Gkbb.BusinessLayer
{
    public class CollegeEntranceLayer : ICollegeEntranceLayer
    {
        public DtoResponse<List<ReplyVideoList>> GetVideoList()
        {
            string str = WebHelper.GetRequest("https://ewt.zxxk.com:800/");


            DtoResponse<List<ReplyVideoList>> response = new DtoResponse<List<ReplyVideoList>>();
            RequestVideoList param = new RequestVideoList();
            param.userID = 1;
            param.version = "test";
            param.phoneMo = "app";
            param.ispage = "yes";
            param.pageIndex = 1;
            param.pageSize = 10;
            param.sortID = 8;
            param.parentID = 91;
            string postData = Tools.GetUrlParam<RequestVideoList>(param);
            string result = WebHelper.GetPostRequestData(Const.URL_VIDEO, postData);
            if (result.Equals("error"))
            {
                response.Code = Codes.Error;
            }
            else
            {
                List<ReplyVideoList> videoList = NetJosn<List<ReplyVideoList>>.DeserializeObject(result);
                response.Data = videoList;
            }
            return response;
        }
    }
}
