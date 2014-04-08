using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace demo_WF_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebDown.time = int.Parse(time.Text);
            if (WebDown.time < 100)
            {
                WebDown.time = 1000;
            }
            Close();
        }

        private void Form3_Enter(object sender, EventArgs e)
        {
            time.Text = WebDown.time.ToString();
        }

        private void Form3_VisibleChanged(object sender, EventArgs e)
        {
            time.Text = WebDown.time.ToString();
        }
    }
}
