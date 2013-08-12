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
    public partial class Main : Form
    {
        string sError = string.Empty;
        string dbPath = string.Empty;
        public Main()
        {
            InitializeComponent();
        }

        private void initGrid()
        {
            SqlLiteHelper.ConnSqlLiteDbPath = dbPath;

            sError = string.Empty;
            string sSql = "select * from subject";
            DataTable dt = SqlLiteHelper.GetDataTable(out sError, sSql);
            if (!string.IsNullOrEmpty(sError))
                Common.DisplayMsg(this.Text, sError);

            dgvCgDB.DataSource = dt;
        }

        private void tsmiOpenDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择一个.db文件";
            ofd.Filter = "SqlliteDB|*.db";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dbPath = ofd.FileName;
            }
            initGrid();
        }


    }
}
