using System.Collections.Concurrent;
using System.Configuration;
using System.Text;
using System.Web;


    /// <summary>
    /// 内容映射，可以讲相对路径的css,js,image图片映射为绝对路径
    /// </summary>
    public class ContentMap
    {
        /// <summary>
        /// css根路径
        /// </summary>
        private static string cssRoot = null;

        /// <summary>
        /// js跟路径
        /// </summary>
        private static string jsRoot = null;

        /// <summary>
        /// image跟路径
        /// </summary>
        private static string imageRoot = null;

        public static string fileVersion = ConfigurationManager.AppSettings["FileVersion"];

        static ContentMap()
        {
            var context = HttpContext.Current;

            #region css

            cssRoot = System.Configuration.ConfigurationManager.AppSettings["contenturl"];
            cssRoot = GetContentUrl(context, cssRoot);

            #endregion

            #region js

            jsRoot = System.Configuration.ConfigurationManager.AppSettings["contenturl"];
            jsRoot = GetContentUrl(context, jsRoot);

            #endregion

            #region image

            imageRoot = System.Configuration.ConfigurationManager.AppSettings["contenturl"];
            imageRoot = GetContentUrl(context, imageRoot);

            #endregion
        }

        private static string GetContentUrl(HttpContext context, string root)
        {
            if (string.IsNullOrEmpty(cssRoot))
            {
                root = "/";
            }
            if (!root.EndsWith("/"))
            {
                root = root + "/";
            }

            if (!root.StartsWith("http"))
            {
                if (!root.StartsWith("/"))
                {
                    root = "/" + root;
                }
                //root = "http://" + context.Request.Url.Host + root;
            }

            return root;
        }

        /// <summary>
        /// css路径
        /// </summary>
        /// <param name="cssUrl">css相对路径</param>
        /// <returns>css绝对路径</returns>
        public static string CssContent(string cssUrl, bool changeThemes = false)
        {
            //if (changeThemes==true)
            //{
            //    if (UserObj.IsEBusiness)
            //        return cssRoot + string.Format(cssUrl, "red") + "?v=" + fileVersion;
            //    else
            //        return cssRoot + string.Format(cssUrl, "blue") + "?v=" + fileVersion; 

            //}
            //else
            //{
            return cssRoot + cssUrl + "?v=" + fileVersion;
            //}
        }


        /// <summary>
        /// js路径
        /// </summary>
        /// <param name="jsUrl">js相对路径</param>
        /// <returns>js绝对路径</returns>
        public static string JsContent(string jsUrl)
        {
            return jsRoot + jsUrl + "?v=" + fileVersion;
        }

        public static string JsContentNoVersion(string jsUrl)
        {
            return jsRoot + jsUrl;
        }


        private static ConcurrentDictionary<string, string> jsCombineCache = new ConcurrentDictionary<string, string>();

        private static ConcurrentDictionary<string, string> cssCombineCache = new ConcurrentDictionary<string, string>();

        private static string buildJs(string jsUrls)
        {
            var builder = new StringBuilder();
            foreach (var url in jsUrls.Split(','))
            {
                var js = JsContent(url);
                builder.Append("<script src='" + js + "' type='text/javascript'></script>");
            }
            return builder.ToString();
        }

        private static string buildCss(string cssUrls)
        {
            var builder = new StringBuilder();
            foreach (var url in cssUrls.Split(','))
            {
                var css = JsContent(url);
                builder.Append("<link href='" + css + "' rel='stylesheet' type='text/css' />");
            }
            return builder.ToString();
        }

        /// <summary>
        /// 图片路径
        /// </summary>
        /// <param name="imageUrl">image相对路径</param>
        /// <returns>image绝对路径</returns>
        public static string ImageConent(string imageUrl)
        {
            return imageRoot + imageUrl;
        }
    }

