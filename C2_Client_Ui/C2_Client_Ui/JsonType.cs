using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Client_Ui
{

    public class LoginInfo
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 网站名称
        /// </summary>
        // public string SiteName { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
        public string Time { get; set; }
    }
    /// <summary>
    /// 登录包返回的json格式
    /// </summary>
    public class LoginJson
    {
        public string data { get; set; }
        public int status { get; set; }
    }
    public class GetInfo  //获取信息所需要的结构体
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
        public string Time { get; set; }
    }
    public class GetInfoUuid  //获取信息所需要的结构体,发包
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
        /// 
        public string Time { get; set; }
        public string Cmdtype { get; set; }
        public string Msg { get; set; }
        public string Uuid { get; set; }
    }
    public class AddMsgtype 
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
        /// 
        public string Time { get; set; }
        public string Cmdtype { get; set; }
        public string Msg { get; set; }
        public string Uuid { get; set; }
        public string Address { get; set; }
        public string Jwttoken { get; set; }
    }
    public class HostListInfo
    {
        public string id { get; set; }
        public string uuid { get; set; }
        public string ip { get; set; }
        public string hostname { get; set; }

        public string localip { get; set; } //内网ip
        public string os { get; set; }
        public string av { get; set; }
        public string version { get; set; }
        public string remarks { get; set; }
        public string sleeptime { get; set; }
        public string online { get; set; }
        public string ctime { get; set; }
        public string utime { get; set; }
    }

    public class GetHostJson
    {
        public IList<HostListInfo> data { get; set; }
        public string message { get; set; }
        public int status { get; set; }
    }
    /// <summary>
    /// 获取截图
    /// </summary>
    public class GetScreetlist
    {
        public string img { get; set; }
        public string message { get; set; }
        public int status { get; set; }
        // public string time { get; set; }
    }
    /// <summary>
    /// 获取命令执行的结果
    /// </summary>
    public class GetCmdstr
    {
        public string data { get; set; }
        public string message { get; set; }
        public int status { get; set; }
        // public string time { get; set; }
    }
    class JsonType
    {
    }
}
