using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace demo_WF_
{
    class dictManager
    {
        public static Dictionary<string, string> myDict
            = new Dictionary<string, string>();
        //private static string HRefPattern = "<a\\s*href\\s*=\\s*(?:\"game(?<1>[^\"]*)\")[^>]*>(?<2>[^<]*)</a>";
        private static string HRefPattern = "<a\\s*href\\s*=\\s*(?:\"game(?<1>[^\"]*)\")[^>]*>(?<2>[^<]*)</a><(?(span[^(]*(?<3>[^)]*))|(?<3>[^>]*))";
        private static void clear()
        {
            myDict.Clear();
        }
        private static void add(string str1, string str2, string str3)
        {
            str2 = str2.Replace("&amp;", "");
            str2 = str2.Replace("&rdquo;", "");
            if (str3[0] == '(')
            {
                str3 = str3.Replace('(', ' ');
                str2 = str2 + str3;
            }
            myDict.Add(str2, str1);
        }
        public static void addString(string str)
        {
            clear();
            Match m;
            m = Regex.Match(str, HRefPattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);
            while (m.Success)
            {
                //MessageBox.Show(m.Groups[1] + " " + m.Groups[2]);
                //Console.WriteLine(m.Groups[1] + " " + m.Groups[2]);
                //Console.WriteLine(m.Groups[3]);
                add(m.Groups[1].ToString(), m.Groups[2].ToString(), m.Groups[3].ToString());
                m = m.NextMatch();
            }
        }
    }
}
