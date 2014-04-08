namespace demo_WF_
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yuanhua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jiaoben = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zhongyangzhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shengyou = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.biaoqian = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.sreachbox = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.yuanhua,
            this.jiaoben,
            this.zhongyangzhi,
            this.shengyou,
            this.biaoqian,
            this.address});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(678, 194);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // name
            // 
            this.name.Text = "名称";
            // 
            // yuanhua
            // 
            this.yuanhua.Text = "原画";
            // 
            // jiaoben
            // 
            this.jiaoben.Text = "脚本";
            // 
            // zhongyangzhi
            // 
            this.zhongyangzhi.Text = "中央值";
            // 
            // shengyou
            // 
            this.shengyou.Text = "声优";
            this.shengyou.Width = 110;
            // 
            // biaoqian
            // 
            this.biaoqian.Text = "标签";
            this.biaoqian.Width = 124;
            // 
            // address
            // 
            this.address.Text = "位置";
            this.address.Width = 162;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sreachbox
            // 
            this.sreachbox.Location = new System.Drawing.Point(207, 246);
            this.sreachbox.Name = "sreachbox";
            this.sreachbox.Size = new System.Drawing.Size(75, 23);
            this.sreachbox.TabIndex = 2;
            this.sreachbox.Text = "搜索";
            this.sreachbox.UseVisualStyleBackColor = true;
            this.sreachbox.Click += new System.EventHandler(this.sreachbox_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(101, 246);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 21);
            this.search.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "模糊搜索";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 289);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.sreachbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Form2";
            this.Text = "黄油管理";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader yuanhua;
        private System.Windows.Forms.ColumnHeader jiaoben;
        private System.Windows.Forms.ColumnHeader zhongyangzhi;
        private System.Windows.Forms.ColumnHeader biaoqian;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader shengyou;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sreachbox;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}