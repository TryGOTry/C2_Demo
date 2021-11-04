using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C2_Client_Ui
{
    class Encode
	{
		/// <summary>
		/// base64加密
		/// </summary>
		/// <param name="s1"></param>
		/// <param name="str"></param>
		/// <returns></returns>
		public string Encodestr(string s1 ,string str) {
			string key1 = s1.Substring(s1.Length - 18);
			string key2 = s1.Substring(s1.Length - 10);
			byte[] byteArray1 = System.Text.Encoding.Default.GetBytes(key1);
			string a = Convert.ToBase64String(byteArray1);//
			byte[] byteArray2 = System.Text.Encoding.Default.GetBytes(key2);
			string b = Convert.ToBase64String(byteArray2);//
			byte[] byteArray3 = System.Text.Encoding.Default.GetBytes(str);
			string c = Convert.ToBase64String(byteArray3);//
			return a + c + b;
		}

		public string Decodestr(string s1,string str) {
			string key1 = s1.Substring(s1.Length - 18);
			string key2 = s1.Substring(s1.Length - 10);
			byte[] byteArray1 = System.Text.Encoding.Default.GetBytes(key1);
			string a = Convert.ToBase64String(byteArray1);//
            byte[] byteArray2 = System.Text.Encoding.Default.GetBytes(key2);
			string b = Convert.ToBase64String(byteArray2);//
            string str1 = str.Replace(a,null);
			string str2 = str1.Replace(b, null);
			string cstr = Base64Decode(Encoding.UTF8, str2);
      
            return cstr;

		}
		public static string Base64Decode(Encoding encodeType, string result)
		{
			string decode = string.Empty;
			byte[] bytes = Convert.FromBase64String(result);
			try
			{
				decode = encodeType.GetString(bytes);
			}
			catch
			{
				decode = result;
			}
			return decode;
		}
		
    }
}
