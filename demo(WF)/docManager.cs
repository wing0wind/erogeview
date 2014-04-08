using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace demo_WF_
{
    class doc
    {
        public doc(string[] items)
        {
            _name = items[0];
            _yuanhua = items[1];
            _jiaoben = items[2];
            _shengyou = items[3];
            _zhongyanzhi = items[4];
            _huishe = items[5];
            _biaoqian = items[6];
            _address = items[7];
        }
        public bool findname(string key)
        {
            return key == _name;
        }
        public bool find(string key)
        {
            string temp = _name + _yuanhua + _jiaoben + _zhongyanzhi + _shengyou + _huishe + _biaoqian;
            temp = temp.ToLower();
            key = key.ToLower();
            return temp.IndexOf(key) != -1;
        }
        public override string ToString()
        {
            return _name + "|" + _yuanhua + "|" + _jiaoben + "|" + _zhongyanzhi + "|" + _shengyou + "|" + _huishe + "|" + _biaoqian + "|" + _address;
            //return "test";
        }
        public string _name;
        public string _yuanhua;
        public string _jiaoben;
        public string _zhongyanzhi;
        public string _shengyou;
        public string _huishe;
        public string _biaoqian;
        public string _address;
    }
    class docManager
    {
        static public List<doc> doclist = new List<doc>();
        static public void add(string[] str)
        {
            doclist.Add(new doc(str));
        }
        static public void del(string key)
        {
            doclist.Remove(doclist.Find(s => s.find(key)));
        }
        static public doc find(string key)
        {
            return doclist.Find(s => s.find(key));
        }
        static public void init()
        {
                using (StreamReader sr = new StreamReader("sav.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        doclist.Add(new doc(line.Split('|')));
                    }
                }
        }
    }
}
