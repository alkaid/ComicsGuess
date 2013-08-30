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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using System.Collections;
using DevExpress.XtraEditors.Repository;


namespace Editor
{
    public partial class MainForm : RibbonForm
    {
        /// <summary>
        /// 是否存在未提交的新增数据
        /// </summary>
        private bool existUnCommitAdd = false;
        private string dbPath = string.Empty;
        private AllData allData;
        private DataSet ds;
        private Hashtable Images = new Hashtable();
        string ImageDir = @"\Export\imgs\";

        //private enum CurrentMouseRightClickIn { none,catalog,stage,subject}
        //private CurrentMouseRightClickIn currentMouseRightClickIn = CurrentMouseRightClickIn.none;
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
            ds = (DataSet)fullDataBindingSource.DataSource;
        }

        private void iOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择一个.db文件";
            ofd.Filter = "SqlliteDB|*.db";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //加载DB
                dbPath = ofd.FileName;
                allData = new AllData(dbPath, ds);
            }
            //AllData allData = new AllData(AllData.FLAG_TABLE_catalog | AllData.FLAG_TABLE_stage | AllData.FLAG_TABLE_subject);
            //bindingSource1.DataSource = allData.dataSet;
            //gridControl.DataSource = bindingSource1;
            //gridControl.DataMember = "stage";
            //AllData.fill(ds, AllData.FLAG_TABLE_catalog | AllData.FLAG_TABLE_stage | AllData.FLAG_TABLE_subject);
            
        }

        private void iSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.Base.BaseView view = gridControl.FocusedView;
            if (!(view.PostEditor() && view.UpdateCurrentRow()))
            {
                return;
            }
            if (ds == null || ds.Tables.Count == 0 || ds.Tables["catalog"].Rows.Count==0)
                return;
            MessageBox.Show("保存成功");
            allData.update();
            if (existUnCommitAdd)
            {
                ds.Clear();
                allData = new AllData(dbPath, ds);
                existUnCommitAdd = false;
            }
        }

        private void showContextMenu_MouseRightClick(MouseEventArgs e)
        {
            //var view = sender as GridView;
            //if (view == null) return;
            //DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hi = this.gridView1.CalcHitInfo(e.Location);
            if (/*hi.InRow && */e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {
            //if(currentMouseRightClickIn==CurrentMouseRightClickIn.none)
            //    currentMouseRightClickIn = CurrentMouseRightClickIn.catalog;
            showContextMenu_MouseRightClick(e);
        }
        private void stage_MouseUp(object sender, MouseEventArgs e)
        {
            //currentMouseRightClickIn = CurrentMouseRightClickIn.stage;
            showContextMenu_MouseRightClick(e);
        }
        private void subject_MouseUp(object sender, MouseEventArgs e)
        {
            //currentMouseRightClickIn = CurrentMouseRightClickIn.subject;
            showContextMenu_MouseRightClick(e);
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ColumnView currentView = gridControl.FocusedView as ColumnView;
            if (((ContextMenuStrip)sender).Items[0] == e.ClickedItem)
            {
                currentView.AddNewRow();
            }
            else if (((ContextMenuStrip)sender).Items[1] == e.ClickedItem)
            {
                currentView.DeleteSelectedRows();
            }
            
            //currentMouseRightClickIn = CurrentMouseRightClickIn.none;
            
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            ds.Clear();
            allData = new AllData(dbPath, ds);
        }

        private void layoutView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "imgDisplay" && e.IsGetData)
            {
                GridView view = sender as GridView;
                string fileName = null;
                object dbFileName = ((DataRowView)e.Row)["resImg"];
                if (dbFileName is System.DBNull)
                    return;
                fileName = (string)((DataRowView)e.Row)["resImg"];
                if (!Images.ContainsKey(fileName))
                {
                    Image img = null;
                    try
                    {
                        //string filePath = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, ImageDir + fileName, false);
                        img = Image.FromFile(Application.StartupPath+ ImageDir + fileName);
                    }
                    catch
                    {
                        
                    }
                    Images.Add(fileName, img);
                }
                e.Value = Images[fileName];
            }
        }

        private void layoutView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "imgDisplay")
            {
                GridView view = sender as GridView;
                string fileName = null;
                if (null == e.Value)
                    return;
                Image img = (Image)e.Value;
                int stageId = (int)(view.GetRowCellValue(e.RowHandle,view.Columns["stage"]));
                coodroid.Model.model.stage s = new coodroid.BLL.model.stage().GetModel(stageId);
                int catalogId = s.catalog;
            }
        }

        private void layoutView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "imgDisplay")
            {
                RepositoryItemPictureEdit picEdit = (RepositoryItemPictureEdit)e.RepositoryItem;
                picEdit.LoadCompleted += new EventHandler(picEdit_LoadCompleted);
            }
        }

        void picEdit_LoadCompleted(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        

        

    }
}