using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using Maticsoft.DBUtility;
using coodroid.DAL.model;


namespace Editor
{
    public partial class MainForm : RibbonForm
    {
        private string dbPath = string.Empty;
        private AllData allData;
        public MainForm()
        {
            InitializeComponent();
            InitSkinGallery();
            InitGrid();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        BindingList<Person> gridDataList = new BindingList<Person>();
        void InitGrid()
        {
            //gridDataList.Add(new Person("John", "Smith"));
            //gridDataList.Add(new Person("Gabriel", "Smith"));
            //gridDataList.Add(new Person("Ashley", "Smith", "some comment"));
            //gridDataList.Add(new Person("Adrian", "Smith", "some comment"));
            //gridDataList.Add(new Person("Gabriella", "Smith", "some comment"));
            //gridControl.DataSource = gridDataList;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            

        }

        private void iOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择一个.db文件";
            ofd.Filter = "SqlliteDB|*.db";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dbPath = ofd.FileName;
                DbHelperSQLite.DbPath = dbPath;
            }
            //AllData allData = new AllData(AllData.FLAG_TABLE_catalog | AllData.FLAG_TABLE_stage | AllData.FLAG_TABLE_subject);
            //bindingSource1.DataSource = allData.dataSet;
            //gridControl.DataSource = bindingSource1;
            //gridControl.DataMember = "stage";
            DataSet ds = (DataSet)fullDataBindingSource.DataSource;
            allData = new AllData(ds);
            //AllData.fill(ds, AllData.FLAG_TABLE_catalog | AllData.FLAG_TABLE_stage | AllData.FLAG_TABLE_subject);
        }

        private void iSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.Base.BaseView view = gridControl.FocusedView;
            if (!(view.PostEditor() && view.UpdateCurrentRow()))
            {
                return;
            }
            allData.update();
        }

    }
}