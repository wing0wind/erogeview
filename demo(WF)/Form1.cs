using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace demo_WF_
{
    public partial class Form1 : Form
    {
        string url = "http://erogamescape.dyndns.org/~ap2/ero/toukei_kaiseki/kensaku.php?category=game&word_category=name&word=nameMode&mode=normal";
        string result;
        string gameUrl = "http://erogamescape.dyndns.org/~ap2/ero/toukei_kaiseki/game";
        public Form1()
        {
            docManager.init();
            InitializeComponent();
        }

        private void sreach_Click(object sender, EventArgs e)
        {
            action.Text = "waiting";
            if (sreach.Text != null)
            {
                string urlTemp;
                urlTemp = url.Replace("nameMode", textBox1.Text.ToString());
                //Console.WriteLine(urlTemp);
                try
                {
                    result = WebDown.WebDownload(urlTemp);
                    dictManager.addString(result);
                    listBox1.BeginUpdate();
                    listBox1.Items.Clear();
                    Dictionary<string, string> dict = dictManager.myDict;
                    foreach (var item in dict.Keys)
                    {
                        listBox1.Items.Add(item.ToString());
                    }
                    listBox1.EndUpdate();
                    action.Text = "finish";
                }
                catch (System.Exception ex)
                {
                    if (ex is WebException)
                    {
                        Console.WriteLine("网络异常");
                        action.Text = "网络超时";
                    }
                    else
                        action.Text = "未知错误";
                }
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            action.Text = "waiting";
            if (listBox1.SelectedItem == null)
            {
                return;
            }
            string temp = listBox1.SelectedItem.ToString();
            //Console.WriteLine(temp);
            string gameUrlTemp = gameUrl + dictManager.myDict[temp];
            //Console.WriteLine(gameUrl);
            //Process.Start(gameUrlTemp);    
            try
            {
                name.Text = temp;
                string result = WebDown.WebDownload(gameUrlTemp, "test1.html");
                huishe.Text = RegexManager.getSlipt(result, RegexKind.Huishe);
                yuanhua.Text = RegexManager.getSlipt(result, RegexKind.Yuanhua);
                jiaoben.Text = RegexManager.getSlipt(result, RegexKind.Jiaoben);
                biaoqian.Text = RegexManager.getSlipt(result, RegexKind.Biaoqian);
                shengyou.Text = RegexManager.getSlipt(result, RegexKind.Shengyou);
                zhongyangzhi.Text = RegexManager.getSlipt(result, RegexKind.Zhongyangzhi);
            }
            catch (System.Exception ex)
            {
                if (ex is WebException)
                {
                    Console.WriteLine("网络异常");
                    action.Text = "网络超时";
                }
                else
                    action.Text = "未知错误";
            }
            action.Text = "finish";
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            address.Text = path;
            string[] temp = path.Split('\\');
            textBox1.Text = temp[temp.Length - 1];
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Console.WriteLine(openFileDialog1.FileName);
                address.Text = openFileDialog1.FileName;
                //Console.WriteLine(openFileDialog1.SafeFileName);
                string path = openFileDialog1.SafeFileName;
                path = path.Split('.')[0];
                //Console.WriteLine(path);
                textBox1.Text = path;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                Process.Start("http://erogamescape.dyndns.org/~ap2/ero/toukei_kaiseki/");
                return;
            }
            string temp = listBox1.SelectedItem.ToString();
            string gameUrlTemp = gameUrl + dictManager.myDict[temp];
            Process.Start(gameUrlTemp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = name.Text + "|" + yuanhua.Text + "|" + jiaoben.Text + "|" + shengyou.Text + "|" + zhongyangzhi.Text + "|" + huishe.Text + "|" + biaoqian.Text + "|" + address.Text;
            docManager.add(temp.Split('|'));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;            
            System.Diagnostics.Process.Start("mailto://wing0wind@gmail.com");
        }
    }
}
