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
using System.IO;
using DevExpress.XtraBars.Alerter;


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
        string exportDir = @"\Export\";
        string backupDir = @"\Backup\";

        private enum CurrentMouseRightClickIn { none, catalog, stage, subject };
        private CurrentMouseRightClickIn currentMouseRightClickIn = CurrentMouseRightClickIn.none;
        private bool isMouseUpEventConsume;/*代表鼠标右键事件是否已消费*/

        private enum Tab { main, stageType, subjectType, comicsType };
        private Tab currentTab;

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
            switchTab(Tab.main);
            exportDir = Application.StartupPath + exportDir;
            backupDir = Application.StartupPath + backupDir;
            if (!Directory.Exists(backupDir))
            {
                Directory.CreateDirectory(backupDir);
            }
            ds = (DataSet)fullDataBindingSource.DataSource;
            //查找Export下是否存在DB
            DirectoryInfo info = new DirectoryInfo(exportDir);
            if (Directory.Exists(exportDir))
            {
                foreach (FileSystemInfo fsi in info.GetFileSystemInfos())
                {
                    if (fsi is System.IO.FileInfo && fsi.Name.Contains(".db"))
                    {   //如果是DB，加载DB
                        splashScreenManager1.ShowWaitForm();
                        allData = new AllData(fsi.FullName, ds);
                        splashScreenManager1.CloseWaitForm();
                        AlertInfo ainfo = new AlertInfo("提示", "成功载人DB，您的工作路径为：" + exportDir);
                        alertControl1.Show(this, ainfo);
                        return;
                    }
                }
            }
            AlertInfo binfo = new AlertInfo("提示", "成功载人DB，您的工作路径为：\r\n" + "工作路径下没有找到sqlite文件，请点击\"导入DB\".（工作路径:" + exportDir + "）");
            alertControl1.Show(this, binfo);
        }

        private void iOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择一个.db文件";
            ofd.Filter = "SqlliteDB|*.db";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName.Replace(ofd.SafeFileName,"")==exportDir) {
                    MessageBox.Show("不允许选择Export目录下的db文件");
                    return;
                }
                //备份并删除原Export
                if (Directory.Exists(exportDir))
                {
                    DeleteFile(backupDir, false);
                    CopyDirectory(exportDir, backupDir,true);
                    DeleteFile(exportDir,true);
                }
                //复制DB到Export路径
                string dbDestFile = Path.Combine(exportDir, ofd.SafeFileName);
                if (!Directory.Exists(exportDir))
                {
                    Directory.CreateDirectory(exportDir);
                }
                File.Copy(ofd.FileName, dbDestFile, true);
                //复制图片资源
                //String sourceParentPath = ofd.FileName.Replace(ofd.SafeFileName, "");
                //String imgSourcePath = sourceParentPath + imgDir;
                //if (Directory.Exists(imgSourcePath))
                //{
                //    CopyDirectory(imgSourcePath, exportDir);
                //}
                //else
                //{

                //}
                
                //加载DB
                splashScreenManager1.ShowWaitForm();
                dbPath = dbDestFile;
                allData = new AllData(dbPath, ds);
                splashScreenManager1.CloseWaitForm();
                AlertInfo ainfo = new AlertInfo("提示", "DB加载成功,原工作目录已删除并备份。您尚未导入图片、音频等资源文件，请点击\"导入资源\"按钮。（工作目录:" + exportDir + "）");
                alertControl1.Show(this, ainfo);
            }
            //AllData allData = new AllData(AllData.FLAG_TABLE_catalog | AllData.FLAG_TABLE_stage | AllData.FLAG_TABLE_subject);
            //bindingSource1.DataSource = allData.dataSet;
            //gridControl.DataSource = bindingSource1;
            //gridControl.DataMember = "stage";
            //AllData.fill(ds, AllData.FLAG_TABLE_catalog | AllData.FLAG_TABLE_stage | AllData.FLAG_TABLE_subject);
            
        }

        private void iImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("导入资源将会清空工作目录下的同名资源目录，是否确定导入?", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                FolderBrowserDialog ofd = new FolderBrowserDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //清除工作路径下的对应资源
                    string folderName = ofd.SelectedPath.Substring(ofd.SelectedPath.LastIndexOf("\\") + 1);
                    DeleteFile(exportDir + folderName, true);
                    //复制资源到Export路径
                    int count = CopyDirectory(ofd.SelectedPath, exportDir, true);
                    AlertInfo ainfo = new AlertInfo("提示", ofd.SelectedPath + "目录已拷贝至 工作目录下,共导入了" + count + "个文件。（工作目录：" + exportDir + "）");
                    alertControl1.Show(this, ainfo);
                }
            }
        }

        private void iSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            save();
        }

        private void save()
        {
            GridControl currentGrid = null;
            switch (currentTab)
            {
                case Tab.comicsType:
                    currentGrid = gridControlComicsType;
                    break;
                case Tab.main:
                    currentGrid = gridControl;
                    break;
                case Tab.stageType:
                    currentGrid = gridControlStageType;
                    break;
                case Tab.subjectType:
                    currentGrid = gridControlSubjectType;
                    break;
            }
            DevExpress.XtraGrid.Views.Base.BaseView view = currentGrid.FocusedView;
            if (!(view.PostEditor() && view.UpdateCurrentRow()))
            {
                return;
            }
            if (ds == null || ds.Tables.Count == 0 || ds.Tables["catalog"].Rows.Count == 0)
            {
                AlertInfo einfo = new AlertInfo("提示", "表中无数据，无法保存");
                alertControl1.Show(this, einfo);
                return;
            }
            allData.update();
            AlertInfo ainfo = new AlertInfo("提示", "保存成功");
            alertControl1.Show(this, ainfo);
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
            if (!isMouseUpEventConsume)
            {
                currentMouseRightClickIn = CurrentMouseRightClickIn.catalog;
                showContextMenu_MouseRightClick(e);
            }
            isMouseUpEventConsume = false;
        }
        private void gridView2_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isMouseUpEventConsume)
            {
                currentMouseRightClickIn = CurrentMouseRightClickIn.stage;
                showContextMenu_MouseRightClick(e);
                isMouseUpEventConsume = true;
            }
        }
        private void layoutView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isMouseUpEventConsume)
            {
                currentMouseRightClickIn = CurrentMouseRightClickIn.subject;
                showContextMenu_MouseRightClick(e);
                isMouseUpEventConsume = true;
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            ColumnView currentView = gridControl.FocusedView as ColumnView;
            int currentRowHandler=currentView.FocusedRowHandle;
            //添加
            if (((ContextMenuStrip)sender).Items[0] == e.ClickedItem)
            {
                currentView.AddNewRow();
            }
            //删除
            else if (((ContextMenuStrip)sender).Items[1] == e.ClickedItem)
            {
                currentView.DeleteSelectedRows();
            }
            //添加子项
            else if (((ContextMenuStrip)sender).Items[2] == e.ClickedItem)
            {
                if (currentMouseRightClickIn == CurrentMouseRightClickIn.stage || currentMouseRightClickIn == CurrentMouseRightClickIn.catalog)
                {
                    GridView view = (GridView)currentView;
                    view.ExpandMasterRow(currentRowHandler);
                    ColumnView childView = (ColumnView)view.GetDetailView(currentRowHandler, 0);
                    childView.AddNewRow();
                }

            }

            currentMouseRightClickIn = CurrentMouseRightClickIn.none;
            
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            ds.Clear();
            allData = new AllData(dbPath, ds);
        }

        //自定义非绑定列 这里包括图片资源和音频资源播放
        private void layoutView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (!e.IsGetData)
                return;
            if (e.Column.FieldName == "imgDisplay")
            {
                GridView view = sender as GridView;
                string fileName = null;
                object dbFileName = ((DataRowView)e.Row)["resImg"];
                if (dbFileName is System.DBNull)
                {
                    e.Value = Resource1.Icon_Simple_Error;
                    return;
                }
                fileName = (string)dbFileName;
                if (!Images.ContainsKey(fileName))
                {
                    Image img = null;
                    try
                    {
                        //string filePath = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, ImageDir + fileName, false);
                        img = Image.FromFile(exportDir + fileName);
                    }
                    catch
                    {
                        e.Value = Resource1.Icon_Simple_Error;
                        return;
                    }
                    Images.Add(fileName, img);
                }
                e.Value = Images[fileName];
            }
            else if (e.Column.FieldName=="audioDisplay")
            {
                GridView view = sender as GridView;
                string fileName = null;
                object dbFileName = ((DataRowView)e.Row)["resAudio"];
                //无数据时指定该音频的icon
                if (dbFileName is System.DBNull)
                {
                    e.Value = Resource1.icon_unplay;
                    return;
                }
                fileName = (string)dbFileName;
                //文件存在时指定该音频icon
                if (File.Exists(exportDir + fileName))
                {
                    e.Value = Resource1.icon_play;
                }
                else
                {
                    e.Value = Resource1.icon_unplay;
                }
            }
            
        }

        private void layoutView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            //if (e.Column.FieldName == "imgDisplay")
            //{
            //    GridView view = sender as GridView;
            //    string fileName = null;
            //    //if (null == e.Value)
            //    //    return;
            //    Image img = (Image)e.Value;
            //    //获得stageId、catalogId、subjectId
            //    int subjectId = (int)(view.GetRowCellValue(e.RowHandle, view.Columns["id"]));
            //    int stageId = (int)(view.GetRowCellValue(e.RowHandle,view.Columns["stage"]));
            //    coodroid.Model.model.stage s = new coodroid.BLL.model.stage().GetModel(stageId);
            //    int catalogId = s.catalog;
            //    //获得原resImg字段
            //    object objResImg = view.GetRowCellValue(e.RowHandle, view.Columns["resImg"]);
            //    string resImg = "";
            //    if (null == objResImg || objResImg is System.DBNull) { }
            //    else
            //    {
            //        resImg = objResImg.ToString();
            //    }
            //    //删除原图
            //    if (resImg != "")
            //    {
            //        File.Delete(exportDir + resImg);
            //    }
            //    //生成图片名称 保存新图
            //    string imgName = generateFileName(catalogId, stageId, subjectId, "img");
            //    resImg = imgDir + catalogId + "\\" + imgName;
            //    string imgPath = exportDir + resImg;
            //    save();
            //}
        }

        private void repositoryItemMyPictureEdit1_ImageLoaded(object sender, MyPictureEdit.ImageLoadedEventArgs e)
        {
            MyPictureEdit.RepositoryItemMyPictureEdit repoPicEdit = (MyPictureEdit.RepositoryItemMyPictureEdit)sender;
            //repositoryItemMyPictureEdit1.FileName = e.FileName;
            ColumnView currentView = gridControl.FocusedView as ColumnView;
            int r=currentView.FocusedRowHandle;
            //获得stageId、catalogId、subjectId
            int subjectId = Convert.ToInt32(currentView.GetRowCellValue(r, currentView.Columns["id"]));
            int stageId = Convert.ToInt32(currentView.GetRowCellValue(r,currentView.Columns["stage"]));
            coodroid.Model.model.stage s = new coodroid.BLL.model.stage().GetModel(stageId);
            int catalogId = s.catalog;
            //获得原resImg字段
            object objResImg = currentView.GetRowCellValue(r, currentView.Columns["resImg"]);
            string resImg = "";
            if (null == objResImg || objResImg is System.DBNull) { }
            else
            {
                resImg = objResImg.ToString();
            }
            
            string oldResImg = resImg;
            
            //生成图片名称 保存新图
            string ext = e.FileName.Substring(e.FileName.LastIndexOf(".")); //由原文件获得扩展名
            string imgName = generateFileName(catalogId, stageId, subjectId, "img") + ext;
            resImg = catalogId + "/" + imgName;
            string imgPath = exportDir + resImg;
            File.Copy(e.FileName, imgPath, true);
            
            //更新resImg字段
            currentView.SetRowCellValue(r, currentView.Columns["resImg"], resImg);//执行此句代码时，会触发layoutView1_CustomUnboundColumnData事件，就会自动更新imgDisplay列，所以屏蔽下面代码
            //save();
            
            //更新Images 更新imgDisplay
            /*Image img = null;
            try
            {
                //string filePath = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, ImageDir + fileName, false);
                img = Image.FromFile(imgPath);
                Images.Add(resImg, img);
            }
            catch
            {
                img = Resource1.Icon_Simple_Error;
            }
            currentView.SetRowCellValue(r, currentView.Columns["imgDisplay"], img);*/
            //删除原图
            if (oldResImg != "")
            {
                Image old = (Image)Images[oldResImg];
                Images.Remove(oldResImg);
                old.Dispose();
                File.Delete(exportDir + oldResImg);
            }
            
        }

        private void layoutView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCustomRowCellEditEventArgs e)
        {
            //if (e.Column.FieldName == "imgDisplay")
            //{
            //    RepositoryItemPictureEdit picEdit = (RepositoryItemPictureEdit)e.RepositoryItem;
            //}
        }

        private void switchTab(Tab tab)
        {
            currentTab = tab;
            switch (tab)
            {
                case Tab.main:
                    panelMain.Dock = DockStyle.Fill;
                    gridControl.Dock = DockStyle.Fill;
                    panelMain.Visible = true;
                    panelComicsType.Visible = false;
                    panelStageType.Visible = false;
                    panelSubjectType.Visible = false;
                    break;
                case Tab.comicsType:
                    panelComicsType.Dock = DockStyle.Fill;
                    gridControlComicsType.Dock = DockStyle.Fill;
                    panelComicsType.Visible = true;
                    panelMain.Visible = false;
                    panelStageType.Visible = false;
                    panelSubjectType.Visible = false;
                    break;
                case Tab.stageType:
                    panelStageType.Dock = DockStyle.Fill;
                    gridControlStageType.Dock = DockStyle.Fill;
                    panelStageType.Visible = true;
                    panelComicsType.Visible = false;
                    panelMain.Visible = false;
                    panelSubjectType.Visible = false;
                    break;
                case Tab.subjectType:
                    panelSubjectType.Dock = DockStyle.Fill;
                    gridControlSubjectType.Dock = DockStyle.Fill;
                    panelSubjectType.Visible = true;
                    panelComicsType.Visible = false;
                    panelStageType.Visible = false;
                    panelMain.Visible = false;
                    break;
            }
        }


        /// <summary>
        /// 复制文件夹（及文件夹下所有子文件夹和文件）
        /// </summary>
        /// <param name="sourcePath">待复制的文件夹路径</param>
        /// <param name="destinationPath">目标路径</param>
        /// /// <param name="isCopyRoot">是否连跟目录一起复制</param>
        public static int CopyDirectory(String sourcePath, String destinationPath, bool isCopyRoot)
        {
            int i = 0;
            DirectoryInfo info = new DirectoryInfo(sourcePath);
            if (isCopyRoot)
            {
                if (sourcePath.Length - 1 == sourcePath.LastIndexOf("\\"))
                {
                    sourcePath = sourcePath.Substring(0, sourcePath.Length - 1);
                }
                String souceRoot = sourcePath.Substring(sourcePath.LastIndexOf("\\") + 1);
                destinationPath += souceRoot;
            }
            Directory.CreateDirectory(destinationPath);
            
            foreach (FileSystemInfo fsi in info.GetFileSystemInfos())
            {
                String destName = Path.Combine(destinationPath, fsi.Name);

                if (fsi is System.IO.FileInfo)
                {          //如果是文件，复制文件
                    File.Copy(fsi.FullName, destName);
                    i++;
                }
                else                                    //如果是文件夹，新建文件夹，递归
                {
                    Directory.CreateDirectory(destName);
                    i+=CopyDirectory(fsi.FullName, destName,false);
                }
            }
            return i;
        }
        /// <summary>
        /// 递归(删除文件夹下的所有文件)
        /// </summary>
        /// <param name="dirRoot">目录地址</param>
        public static void DeleteFile(string dirRoot,bool isDeleteRoot)
        {
            //string deleteFileName = "_desktop.ini";//要删除的文件名称
            try
            {
                string[] rootDirs = Directory.GetDirectories(dirRoot); //当前目录的子目录：
                string[] rootFiles = Directory.GetFiles(dirRoot);        //当前目录下的文件：

                foreach (string s2 in rootFiles)
                {
                    File.Delete(s2);                      //删除文件                    
                }
                foreach (string s1 in rootDirs)
                {
                    DeleteFile(s1, true);
                }
                if (isDeleteRoot)
                {
                    Directory.Delete(dirRoot);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        private string generateFileName(int catalogId, int stageId, int subjectId,string type)
        {
            return catalogId + "_" + stageId + "_" + subjectId + "_" + type +"_" + GetRnd(4, true, true, true, false, "");
        }

        ///<summary>
        ///生成随机字符串
        ///</summary>
        ///<param name="length">目标字符串的长度</param>
        ///<param name="useNum">是否包含数字，1=包含，默认为包含</param>
        ///<param name="useLow">是否包含小写字母，1=包含，默认为包含</param>
        ///<param name="useUpp">是否包含大写字母，1=包含，默认为包含</param>
        ///<param name="useSpe">是否包含特殊字符，1=包含，默认为不包含</param>
        ///<param name="custom">要包含的自定义字符，直接输入要包含的字符列表</param>
        ///<returns>指定长度的随机字符串</returns>
        private string GetRnd(int length, bool useNum, bool useLow, bool useUpp, bool useSpe, string custom)
        {
            byte[] b = new byte[4];
            new System.Security.Cryptography.RNGCryptoServiceProvider().GetBytes(b);
            Random r = new Random(BitConverter.ToInt32(b, 0));
            string s = null, str = custom;
            if (useNum == true) { str += "0123456789"; }
            if (useLow == true) { str += "abcdefghijklmnopqrstuvwxyz"; }
            if (useUpp == true) { str += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; }
            if (useSpe == true) { str += "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~"; }
            for (int i = 0; i < length; i++)
            {
                s += str.Substring(r.Next(0, str.Length - 1), 1);
            }
            return s;
        }

        private void subjectItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            switchTab(Tab.main);
        }

        private void stageTypeItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            switchTab(Tab.stageType);
        }

        private void subjectTypeItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            switchTab(Tab.subjectType);
        }

        private void comicsTypeItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            switchTab(Tab.comicsType);
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
             OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择一个音频文件";
            ofd.Filter = "音频|*.wma,*.mp3,*.wav";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //repositoryItemMyPictureEdit1.FileName = e.FileName;
                ColumnView currentView = gridControl.FocusedView as ColumnView;
                int r = currentView.FocusedRowHandle;
                //获得stageId、catalogId、subjectId
                int subjectId = Convert.ToInt32(currentView.GetRowCellValue(r, currentView.Columns["id"]));
                int stageId = Convert.ToInt32(currentView.GetRowCellValue(r, currentView.Columns["stage"]));
                coodroid.Model.model.stage s = new coodroid.BLL.model.stage().GetModel(stageId);
                int catalogId = s.catalog;
                //获得原resAudio字段
                object objresAudio = currentView.GetRowCellValue(r, currentView.Columns["resAudio"]);
                string resAudio = "";
                if (null == objresAudio || objresAudio is System.DBNull) { }
                else
                {
                    resAudio = objresAudio.ToString();
                }

                string oldresAudio = resAudio;

                //生成音频名称 保存新音频
                string ext = ofd.FileName.Substring(ofd.FileName.LastIndexOf(".")); //由原文件获得扩展名
                string audionName = generateFileName(catalogId, stageId, subjectId, "audio") + ext;
                resAudio = catalogId + "/" + audionName;
                string audioPath = exportDir + resAudio;
                File.Copy(ofd.FileName, audioPath, true);

                //更新resAudio字段
                currentView.SetRowCellValue(r, currentView.Columns["resAudio"], resAudio);//执行此句代码时，会触发layoutView1_CustomUnboundColumnData事件，就会自动更新audioDisplay列，所以屏蔽下面代码
                //save();
                //删除原音频
                if (oldresAudio != "")
                {
                    //Image old = (Image)Images[oldResImg];
                    //Images.Remove(oldResImg);
                    //old.Dispose();
                    File.Delete(exportDir + oldresAudio);
                }
            }
        }

        private void repoPicEditAudio_Click(object sender, EventArgs e)
        {
            ColumnView currentView = gridControl.FocusedView as ColumnView;
            int r = currentView.FocusedRowHandle;
            string fileName = null;
            object dbFileName = currentView.GetRowCellValue(r,currentView.Columns["resAudio"]);
            //无数据时指定该音频的icon
            if (dbFileName is System.DBNull)
            {
                return;
            }
            fileName = (string)dbFileName;
            //文件存在时指定该音频icon
            if (File.Exists(exportDir + fileName))
            {
                //TODO 播放
            }
        }

       
   
    }
}