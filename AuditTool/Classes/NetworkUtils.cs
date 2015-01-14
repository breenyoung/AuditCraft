using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;


namespace AuditTool.Classes
{
    public class NetworkUtils
    {
        private CookieContainer _sitecookies = new CookieContainer();

        public string GetWebpage(string url)
        {
            return HttpGet(url);
        }

        private string HttpGet(string URI)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(URI);
                req.CookieContainer = _sitecookies;

                HttpWebResponse myResponse = (HttpWebResponse)req.GetResponse();
                StreamReader sr = new StreamReader(myResponse.GetResponseStream());

                string output = sr.ReadToEnd().Trim();
                myResponse.Close();
                return output;

                //return sr.ReadToEnd().Trim();
            }
            catch (System.Exception ex)
            {
                return "ERROR";
            }
        }

        private string HttpPost(string uri, string parameters, string referer)
        {
            StreamWriter myWriter = null;
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uri);
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded";
                req.Referer = referer;
                req.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1)";

                //byte [] bytes = Encoding.ASCII.GetBytes(Parameters);
                req.ContentLength = parameters.Length;
                req.CookieContainer = _sitecookies;

                //Stream newStream = myRequest.GetRequestStream();
                //newStream.Write(bytes, 0, bytes.Length);
                //newStream.Close();

                myWriter = new StreamWriter(req.GetRequestStream());
                myWriter.Write(parameters);
                myWriter.Close();

                HttpWebResponse myResponse = (HttpWebResponse)req.GetResponse();
                StreamReader sr = new StreamReader(myResponse.GetResponseStream());

                string output = sr.ReadToEnd().Trim();
                myResponse.Close();
                return output;


                //return sr.ReadToEnd().Trim();

                //return "";

                //WebResponse myResponse = myRequest.GetResponse();
                //if (myResponse== null) { return null; }
                //StreamReader sr = new StreamReader(myResponse.GetResponseStream());
                //return sr.ReadToEnd().Trim();

            }
            catch (Exception ex)
            {
                return "ERROR";
            }

        }
    }
}
