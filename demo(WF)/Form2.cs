using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace demo_WF_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void draw()
        {
            listView1.BeginUpdate();
            listView1.Items.Clear();
            foreach (doc c in docManager.doclist)
            {
                ListViewItem items = new ListViewItem(c._name, 0);
                items.SubItems.Add(c._yuanhua);
                items.SubItems.Add(c._jiaoben);
                items.SubItems.Add(c._shengyou);
                items.SubItems.Add(c._zhongyanzhi);
                items.SubItems.Add(c._biaoqian);
                items.SubItems.Add(c._address);
                listView1.Items.Add(items);
            }
            listView1.EndUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems == null)
            {
                return;
            }
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                string key = item.SubItems[0].Text;
                docManager.del(key);
            }
            draw();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            draw();
        }


        private void Form2_Shown(object sender, EventArgs e)
        {
            draw();
        }

        private void sreachbox_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();
            listView1.Items.Clear();
            foreach (doc c in docManager.doclist)
            {
                if (c.find(search.Text))
                {
                    ListViewItem items = new ListViewItem(c._name, 0);
                    items.SubItems.Add(c._yuanhua);
                    items.SubItems.Add(c._jiaoben);
                    items.SubItems.Add(c._zhongyanzhi);
                    items.SubItems.Add(c._shengyou);
                    items.SubItems.Add(c._biaoqian);
                    items.SubItems.Add(c._address);
                    listView1.Items.Add(items);
                }
            }
            listView1.EndUpdate();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems == null)
            {
                return;
            }
            string path = listView1.SelectedItems[0].SubItems[6].Text;
            if (path == "")
            {
                return;
            }
            path = path.Remove(path.LastIndexOf('\\'));
            Process.Start(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            foreach (doc c in docManager.doclist)
            {
                str.AppendLine(c.ToString());
            }
            StreamWriter outfile = new StreamWriter("sav.txt");
            outfile.Write(str.ToString());
            outfile.Close();
        }
    }
}
