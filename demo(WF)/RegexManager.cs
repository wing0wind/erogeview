using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace demo_WF_
{
    enum RegexKind
    {
        Yuanhua,
        Jiaoben,
        Zhongyangzhi,
        Huishe,
        Biaoqian,
        Shengyou,
    }
    class RegexManager
    {
        static string _yuanhua = "\\u539F\\u753B(?<1>.*?)</td>";
        static string _jiaoben = "\\u30B7\\u30CA\\u30EA\\u30AA(?<1>.*?)</td>";
        static string _biaoqian = ">\\u30B8\\u30E3\\u30F3\\u30EB(?<1>.*?)</td>";
        static string _huishe = "\\u30D6\\u30E9\\u30F3\\u30C9</th>\n(?<1>.*?)</td>";
        static string _huishe1 = "\">(?<1>.*?)</a>";
        static string _zhongweishu = "\\u4E2D\\u592E\\u5024</th><td>(?<1>.*?)</td>";
        static string _japanese = "[\\p{IsCJKUnifiedIdeographs}\\p{IsHiragana}\\p{IsKatakana}]*";
        static string _shengyou = "\\u58F0\\u512A(?<1>.*?)</td>";
        static string _shengyou1 = "\">(?<1>[^<]*)</a>[^(]*(?<2>[^<]*)";
        public static string getSlipt(string str, RegexKind num)
        {
            string temp = "";
            string temp1 = "";
            if (num == RegexKind.Yuanhua)
            {
                temp1 = Regex.Match(str, _yuanhua).Groups[1].ToString();
                //Console.WriteLine(temp1); 
            }else if (num == RegexKind.Jiaoben)
            {
                temp1 = Regex.Match(str, _jiaoben).Groups[1].ToString();
            }else if (num == RegexKind.Biaoqian)
            {
                temp1 = Regex.Match(str, _biaoqian).Groups[1].ToString();
                //Console.WriteLine(temp1);
            }else if (num == RegexKind.Huishe)
            {
                temp1 = Regex.Match(str, _huishe).Groups[1].ToString();
                //Console.WriteLine(temp1);
                temp1 = Regex.Match(temp1, _huishe1).Groups[1].ToString();
                //Console.WriteLine(temp1);
                return temp1;
            }else if (num == RegexKind.Zhongyangzhi)
            {
                temp1 = Regex.Match(str, _zhongweishu).Groups[1].ToString();
                //Console.WriteLine(temp1);
                return temp1;
            }else if (num == RegexKind.Shengyou)
            {
                temp1 = Regex.Match(str, _shengyou).Groups[1].ToString();
                var its = Regex.Matches(temp1, _shengyou1);
                foreach (Match item in its)
                {
                    temp = temp + item.Groups[1] + item.Groups[2] + " "; 
                }
                return temp;
            }
            var items = Regex.Matches(temp1, _japanese);
            foreach (var item in items)
            {
                if (item.ToString() != "")
                {
                    temp = temp + item.ToString() + " ";
                }
            }
            return temp;
        }
    }
}
