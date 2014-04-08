using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace webDown
{
    class Program
    {
        static void Main(string[] args)
        {
            string gameName;
            gameName = Console.ReadLine();
            String test = "http://erogamescape.dyndns.org/~ap2/ero/toukei_kaiseki/kensaku.php?category=game&word_category=name&word=nameMode&mode=normal";
            Console.WriteLine(test);
            test = test.Replace("nameMode", gameName);
            Console.WriteLine(test);
            string url = "http://erogamescape.dyndns.org/~ap2/ero/toukei_kaiseki/game.php?game=13933#ad";
            string result = null;
            string _japanese = "[\\p{IsCJKUnifiedIdeographs}\\p{IsHiragana}\\p{IsKatakana}]*";

            WebResponse response = null;
            StreamReader reader = null;
            //StreamWriter sw;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);     
                request.Timeout = 1000;
                request.MaximumAutomaticRedirections = 4;
                request.MaximumResponseHeadersLength = 4;
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(),
                    Encoding.UTF8);
                result = reader.ReadToEnd();
                Console.WriteLine(result);
                response.Close();
            }
            catch (System.Exception ex)
            {
                if (ex is WebException)
                {
                    Console.WriteLine("网络异常");
                }
            }
            if (result != null)
            {
                File.WriteAllText("test.html", result);
                /*string HRefPattern = "<a\\s*href\\s*=\\s*(?:\"game(?<1>[^\"]*)\")";*/
                //string HRefPattern = "<a\\s*href\\s*=\\s*(?:\"game(?<1>[^\"]*)\")[^>]*>(?<2>[^<]*)</a><(?(span[^(]*(?<3>[^)]*))|(?<3>[^>]*))";
                //Regex r = new Regex(@"<a\s*href=(?:"(?<1>[^""]*)"|(?<1>\S+))");
                string HRefPattern = "\\u539F\\u753B(?<item>.*?)</td>";
                Match m;
                m = Regex.Match(result, _japanese, RegexOptions.IgnoreCase | RegexOptions.Compiled);
                while (m.Success)
                {
                    //Console.WriteLine(m.Groups[1] + " " + m.Groups[2]);
                    //Console.WriteLine(m.Groups[3]);
                    Console.WriteLine(m.ToString());
                    m = m.NextMatch();
                }
            }
            
        }
    }
}
