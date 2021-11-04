using CsharpHttpHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C2_Client_Ui
{
    class Http
    {
        private Encode encode = new Encode();
        /// <summary>
        /// 忽略https证书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cert"></param>
        /// <param name="chain"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        private static bool RemoteCertificateValidate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error)
        {
            return true;
        }
        public (int, string) Get(string url, string proxystr)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidate;//忽略https证书
            HttpHelper http = new HttpHelper();
            //创建Httphelper参数对象
            HttpItem item = new HttpItem()
            {
                URL = url,//URL     必需项    
                SecurityProtocol = SecurityProtocolType.Tls,
                Method = "get",//URL     可选项 默认为Get   
                ContentType = "text/html",//返回类型    可选项有默认值   
                Timeout = 12000,
                UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:18.0) Gecko/20100101 Firefox/18.0",
                ProxyIp = proxystr,
                //  Method = "post",//URL     可选项 默认为Get   
                // ContentType = "application/x-www-form-urlencoded",//返回类型    可选项有默认值
                //  PostDataType = PostDataType.String,//默认为字符串，同时支持Byte和文件方法
                //PostEncoding = System.Text.Encoding.UTF8,//默认为Default，
                //Postdata = data,//Post要发送的数据

            };
            //请求的返回值对象
            HttpResult result = http.GetHtml(item);
            //获取请请求的Html

            string html = result.Html;
            int code = (int)result.StatusCode;
            //获取请求的Cookie

            string cookie = result.Cookie;
            return (code, html);
        }
        public (int, string) Post(string url, string postdata,string token, string token2)
        {
            //string jmkey = token.Substring(0, 8);
            // System.Windows.Forms.MessageBox.Show(postdata);
            HttpHelper http = new HttpHelper();
            //创建Httphelper参数对象
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidate;//忽略https证书
            HttpItem item = new HttpItem()
            {
                URL = url,//URL     必需项    
                Method = "post",//URL     可选项 默认为Get   
                Timeout = 10000,
                SecurityProtocol = SecurityProtocolType.Tls,
                ContentType = "application/x-www-form-urlencoded",//返回类型    可选项有默认值
                Postdata = postdata,//Post要发送的数据
               // ProxyIp = "192.168.101.5:8899",

            };
            item.Header.Add("token", token);
            item.Header.Add("Authorization", token2);
            HttpResult result = http.GetHtml(item);
            int code = (int)result.StatusCode;
            string html = result.Html;
            //获取请请求的Html
            if (code==200)
            { 
                html = encode.Decodestr(token, html);
                html = html.Replace("\n", null);
                html = html.Replace("\r", null);
                html = html.Replace("\t", null);
            }
         
            //html = Des.DecodeStr(html);
            //System.Windows.Forms.MessageBox.Show(html);
            //获取请求的Cookie
            string cookie = result.Cookie;
          
           
            return (code, html);
        }
        public string Md5Str1 = "asdjkla";//md5加密的第一个盐
        public string Md5Str2 = "asdasd11321zxc";//md5加密的第二个盐
        /// <summary>
        /// 添加签名
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string CrearToken(string str)
        {
            string strmd5 = HttpHelper.ToMD5(Md5Str1 + str + Md5Str2);
            return strmd5;
        }
        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <returns></returns>
        public string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalMilliseconds).ToString();
        }
    }
}
