using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“downloadDataSet.file”中。您可以根据需要移动或删除它。
            this.fileTableAdapter.Fill(this.downloadDataSet.file);

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        

        private void download_Click(object sender, EventArgs e)
        {

        }

        private void upload_Click(object sender, EventArgs e)
        {

        }
    }
}
