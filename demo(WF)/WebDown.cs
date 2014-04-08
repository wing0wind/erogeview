using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace demo_WF_
{
    class WebDown
    {
        public static int time = 1000;
        public static string WebDownload(string url, string filename = "test.html")
        {
            WebResponse response = null;
            StreamReader reader = null;
            string result;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            //request.Referer = url;
            request.Timeout = time;
            request.MaximumAutomaticRedirections = 4;
            request.MaximumResponseHeadersLength = 4;
            request.Method = "GET";
            response = request.GetResponse();
            reader = new StreamReader(response.GetResponseStream(),
                Encoding.UTF8);
            result = reader.ReadToEnd();
            //Console.WriteLine(result);
            //File.WriteAllText(filename, result);
            response.Close();
            return result;
        }
    }
}
