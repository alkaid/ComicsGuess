using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CgStageEditor
{
    public partial class AddSubject : Form
    {
        public AddSubject()
        {
            InitializeComponent();
        }

        private void btnImgBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择一张图片";
            ofd.Filter = "jpg|*.jpg|jpeg|*.jpeg|png|*.png|gif|*.gif|bmp|*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dbPath = ofd.FileName;
            }
        }


    }
}
