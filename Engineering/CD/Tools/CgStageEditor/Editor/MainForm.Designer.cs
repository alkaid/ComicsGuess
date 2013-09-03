namespace Editor
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.stageTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new Editor.fullDataSet();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcatalog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.catalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colstageType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkupEditStageType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colunlocked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnearSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.lkupEditSubjectType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.subjectTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lkupEditComicsType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.comicsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glkupEditStage = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.stageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemMyPictureEdit1 = new MyPictureEdit.RepositoryItemMyPictureEdit();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colid2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.coltitle = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colsubjectType = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colcomicsType = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colstage = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.collevel = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colremark = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colresImg = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colresText = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colresAudio = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colcreatdate = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.coltip = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colselectors = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colanswer = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colsorter = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colresolved = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colImgDisplay = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Editor.WaitForm1), true, true);
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.mailGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.inboxItem = new DevExpress.XtraNavBar.NavBarItem();
            this.outboxItem = new DevExpress.XtraNavBar.NavBarItem();
            this.draftsItem = new DevExpress.XtraNavBar.NavBarItem();
            this.trashItem = new DevExpress.XtraNavBar.NavBarItem();
            this.organizerGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.calendarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.tasksItem = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarImageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.navbarImageList = new System.Windows.Forms.ImageList(this.components);
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.appMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.popupControlContainer2 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.buttonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.iNew = new DevExpress.XtraBars.BarButtonItem();
            this.iOpen = new DevExpress.XtraBars.BarButtonItem();
            this.iSave = new DevExpress.XtraBars.BarButtonItem();
            this.iSaveAs = new DevExpress.XtraBars.BarButtonItem();
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.someLabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.someLabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ribbonImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.iImport = new DevExpress.XtraBars.BarButtonItem();
            this.iExport = new DevExpress.XtraBars.BarButtonItem();
            this.iHelp = new DevExpress.XtraBars.BarButtonItem();
            this.iAbout = new DevExpress.XtraBars.BarButtonItem();
            this.siStatus = new DevExpress.XtraBars.BarStaticItem();
            this.siInfo = new DevExpress.XtraBars.BarStaticItem();
            this.alignButtonGroup = new DevExpress.XtraBars.BarButtonGroup();
            this.iBoldFontStyle = new DevExpress.XtraBars.BarButtonItem();
            this.iItalicFontStyle = new DevExpress.XtraBars.BarButtonItem();
            this.iUnderlinedFontStyle = new DevExpress.XtraBars.BarButtonItem();
            this.fontStyleButtonGroup = new DevExpress.XtraBars.BarButtonGroup();
            this.iLeftTextAlign = new DevExpress.XtraBars.BarButtonItem();
            this.iCenterTextAlign = new DevExpress.XtraBars.BarButtonItem();
            this.iRightTextAlign = new DevExpress.XtraBars.BarButtonItem();
            this.rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.homeRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.fileRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.formatRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.skinsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.exitRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.helpRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.helpRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.layoutViewField_colstage = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colcreatdate = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_coltip = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colselectors = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colresolved = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.item1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutViewField_colid2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_coltitle = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colsubjectType = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colcomicsType = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colsorter = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colanswer = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_collevel = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colresImg = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colresText = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colresAudio = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.item2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutViewField_colremark = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupEditStageType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupEditSubjectType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupEditComicsType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comicsTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkupEditStage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMyPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer2)).BeginInit();
            this.popupControlContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colstage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcreatdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coltip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colselectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colresolved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coltitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colsubjectType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcomicsType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colsorter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colanswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_collevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colresImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colresText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colresAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colremark)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemGridLookUpEdit1
            // 
            repositoryItemGridLookUpEdit1.AutoHeight = false;
            repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            repositoryItemGridLookUpEdit1.DataSource = this.stageTypeBindingSource;
            repositoryItemGridLookUpEdit1.DisplayMember = "name";
            repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            repositoryItemGridLookUpEdit1.ValueMember = "id";
            repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // stageTypeBindingSource
            // 
            this.stageTypeBindingSource.DataMember = "stageType";
            this.stageTypeBindingSource.DataSource = this.fullDataBindingSource;
            // 
            // fullDataBindingSource
            // 
            this.fullDataBindingSource.DataSource = this.fullDataSet;
            this.fullDataBindingSource.Position = 0;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "fullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colname1,
            this.colcatalog,
            this.colstageType,
            this.colunlocked,
            this.colnearSubject});
            this.gridView2.GridControl = this.gridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.stage_MouseUp);
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            this.colid1.OptionsColumn.AllowEdit = false;
            this.colid1.Visible = true;
            this.colid1.VisibleIndex = 0;
            // 
            // colname1
            // 
            this.colname1.FieldName = "name";
            this.colname1.Name = "colname1";
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 1;
            // 
            // colcatalog
            // 
            this.colcatalog.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colcatalog.FieldName = "catalog";
            this.colcatalog.Name = "colcatalog";
            this.colcatalog.Visible = true;
            this.colcatalog.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.catalogBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "id";
            // 
            // catalogBindingSource
            // 
            this.catalogBindingSource.DataMember = "catalog";
            this.catalogBindingSource.DataSource = this.fullDataBindingSource;
            // 
            // colstageType
            // 
            this.colstageType.ColumnEdit = this.lkupEditStageType;
            this.colstageType.FieldName = "stageType";
            this.colstageType.Name = "colstageType";
            this.colstageType.Visible = true;
            this.colstageType.VisibleIndex = 3;
            // 
            // lkupEditStageType
            // 
            this.lkupEditStageType.AutoHeight = false;
            this.lkupEditStageType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkupEditStageType.DataSource = this.stageTypeBindingSource;
            this.lkupEditStageType.DisplayMember = "name";
            this.lkupEditStageType.Name = "lkupEditStageType";
            this.lkupEditStageType.ValueMember = "id";
            // 
            // colunlocked
            // 
            this.colunlocked.FieldName = "unlocked";
            this.colunlocked.Name = "colunlocked";
            this.colunlocked.Visible = true;
            this.colunlocked.VisibleIndex = 4;
            // 
            // colnearSubject
            // 
            this.colnearSubject.FieldName = "nearSubject";
            this.colnearSubject.Name = "colnearSubject";
            this.colnearSubject.Visible = true;
            this.colnearSubject.VisibleIndex = 5;
            // 
            // gridControl
            // 
            this.gridControl.DataMember = "catalog";
            this.gridControl.DataSource = this.fullDataBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode2.LevelTemplate = this.layoutView1;
            gridLevelNode2.RelationName = "stage_subject";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            gridLevelNode1.RelationName = "catalog_stage";
            this.gridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl.Location = new System.Drawing.Point(2, 2);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemLookUpEdit1,
            repositoryItemGridLookUpEdit1,
            this.lkupEditStageType,
            this.lkupEditSubjectType,
            this.lkupEditComicsType,
            this.glkupEditStage,
            this.repositoryItemPictureEdit1,
            this.repositoryItemMyPictureEdit1});
            this.gridControl.Size = new System.Drawing.Size(914, 506);
            this.gridControl.TabIndex = 0;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.layoutView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseUp);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // lkupEditSubjectType
            // 
            this.lkupEditSubjectType.AutoHeight = false;
            this.lkupEditSubjectType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkupEditSubjectType.DataSource = this.subjectTypeBindingSource;
            this.lkupEditSubjectType.DisplayMember = "name";
            this.lkupEditSubjectType.Name = "lkupEditSubjectType";
            this.lkupEditSubjectType.ValueMember = "id";
            // 
            // subjectTypeBindingSource
            // 
            this.subjectTypeBindingSource.DataMember = "subjectType";
            this.subjectTypeBindingSource.DataSource = this.fullDataBindingSource;
            // 
            // lkupEditComicsType
            // 
            this.lkupEditComicsType.AutoHeight = false;
            this.lkupEditComicsType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkupEditComicsType.DataSource = this.comicsTypeBindingSource;
            this.lkupEditComicsType.DisplayMember = "name";
            this.lkupEditComicsType.Name = "lkupEditComicsType";
            this.lkupEditComicsType.ValueMember = "id";
            // 
            // comicsTypeBindingSource
            // 
            this.comicsTypeBindingSource.DataMember = "comicsType";
            this.comicsTypeBindingSource.DataSource = this.fullDataBindingSource;
            // 
            // glkupEditStage
            // 
            this.glkupEditStage.AutoHeight = false;
            this.glkupEditStage.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glkupEditStage.DataSource = this.stageBindingSource;
            this.glkupEditStage.DisplayMember = "name";
            this.glkupEditStage.Name = "glkupEditStage";
            this.glkupEditStage.ValueMember = "id";
            this.glkupEditStage.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // stageBindingSource
            // 
            this.stageBindingSource.DataMember = "stage";
            this.stageBindingSource.DataSource = this.fullDataBindingSource;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Appearance.BorderColor = System.Drawing.Color.Black;
            this.repositoryItemPictureEdit1.Appearance.Options.UseBorderColor = true;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // repositoryItemMyPictureEdit1
            // 
            this.repositoryItemMyPictureEdit1.FileName = null;
            this.repositoryItemMyPictureEdit1.Name = "repositoryItemMyPictureEdit1";
            this.repositoryItemMyPictureEdit1.ImageLoaded += new MyPictureEdit.ImageLoadedEventHandler(this.repositoryItemMyPictureEdit1_ImageLoaded);
            // 
            // layoutView1
            // 
            this.layoutView1.CardMinSize = new System.Drawing.Size(503, 363);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colid2,
            this.coltitle,
            this.colsubjectType,
            this.colcomicsType,
            this.colstage,
            this.collevel,
            this.colremark,
            this.colresImg,
            this.colresText,
            this.colresAudio,
            this.colcreatdate,
            this.coltip,
            this.colselectors,
            this.colanswer,
            this.colsorter,
            this.colresolved,
            this.colImgDisplay});
            this.layoutView1.GridControl = this.gridControl;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsMultiRecordMode.MultiRowScrollBarOrientation = DevExpress.XtraGrid.Views.Layout.ScrollBarOrientation.Vertical;
            this.layoutView1.OptionsSelection.MultiSelect = true;
            this.layoutView1.OptionsView.ShowCardExpandButton = false;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            this.layoutView1.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCustomRowCellEditEventHandler(this.layoutView1_CustomRowCellEdit);
            this.layoutView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.layoutView1_CellValueChanged);
            this.layoutView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.layoutView1_CustomUnboundColumnData);
            // 
            // colid2
            // 
            this.colid2.FieldName = "id";
            this.colid2.LayoutViewField = this.layoutViewField_colid2;
            this.colid2.Name = "colid2";
            this.colid2.OptionsColumn.AllowEdit = false;
            // 
            // coltitle
            // 
            this.coltitle.FieldName = "title";
            this.coltitle.LayoutViewField = this.layoutViewField_coltitle;
            this.coltitle.Name = "coltitle";
            // 
            // colsubjectType
            // 
            this.colsubjectType.ColumnEdit = this.lkupEditSubjectType;
            this.colsubjectType.FieldName = "subjectType";
            this.colsubjectType.LayoutViewField = this.layoutViewField_colsubjectType;
            this.colsubjectType.Name = "colsubjectType";
            // 
            // colcomicsType
            // 
            this.colcomicsType.ColumnEdit = this.lkupEditComicsType;
            this.colcomicsType.FieldName = "comicsType";
            this.colcomicsType.LayoutViewField = this.layoutViewField_colcomicsType;
            this.colcomicsType.Name = "colcomicsType";
            // 
            // colstage
            // 
            this.colstage.ColumnEdit = this.glkupEditStage;
            this.colstage.FieldName = "stage";
            this.colstage.LayoutViewField = this.layoutViewField_colstage;
            this.colstage.Name = "colstage";
            // 
            // collevel
            // 
            this.collevel.FieldName = "level";
            this.collevel.LayoutViewField = this.layoutViewField_collevel;
            this.collevel.Name = "collevel";
            // 
            // colremark
            // 
            this.colremark.FieldName = "remark";
            this.colremark.LayoutViewField = this.layoutViewField_colremark;
            this.colremark.Name = "colremark";
            // 
            // colresImg
            // 
            this.colresImg.FieldName = "resImg";
            this.colresImg.LayoutViewField = this.layoutViewField_colresImg;
            this.colresImg.Name = "colresImg";
            // 
            // colresText
            // 
            this.colresText.FieldName = "resText";
            this.colresText.LayoutViewField = this.layoutViewField_colresText;
            this.colresText.Name = "colresText";
            // 
            // colresAudio
            // 
            this.colresAudio.FieldName = "resAudio";
            this.colresAudio.LayoutViewField = this.layoutViewField_colresAudio;
            this.colresAudio.Name = "colresAudio";
            // 
            // colcreatdate
            // 
            this.colcreatdate.FieldName = "creatdate";
            this.colcreatdate.LayoutViewField = this.layoutViewField_colcreatdate;
            this.colcreatdate.Name = "colcreatdate";
            // 
            // coltip
            // 
            this.coltip.FieldName = "tip";
            this.coltip.LayoutViewField = this.layoutViewField_coltip;
            this.coltip.Name = "coltip";
            // 
            // colselectors
            // 
            this.colselectors.FieldName = "selectors";
            this.colselectors.LayoutViewField = this.layoutViewField_colselectors;
            this.colselectors.Name = "colselectors";
            // 
            // colanswer
            // 
            this.colanswer.FieldName = "answer";
            this.colanswer.LayoutViewField = this.layoutViewField_colanswer;
            this.colanswer.Name = "colanswer";
            // 
            // colsorter
            // 
            this.colsorter.FieldName = "sorter";
            this.colsorter.LayoutViewField = this.layoutViewField_colsorter;
            this.colsorter.Name = "colsorter";
            // 
            // colresolved
            // 
            this.colresolved.FieldName = "resolved";
            this.colresolved.LayoutViewField = this.layoutViewField_colresolved;
            this.colresolved.Name = "colresolved";
            // 
            // colImgDisplay
            // 
            this.colImgDisplay.Caption = "资源图";
            this.colImgDisplay.ColumnEdit = this.repositoryItemMyPictureEdit1;
            this.colImgDisplay.FieldName = "imgDisplay";
            this.colImgDisplay.LayoutViewField = this.layoutViewField_layoutViewColumn1;
            this.colImgDisplay.Name = "colImgDisplay";
            this.colImgDisplay.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 147);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainerControl.Panel1.Controls.Add(this.navBarControl);
            this.splitContainerControl.Panel1.Text = "Panel1";
            this.splitContainerControl.Panel2.Controls.Add(this.panelMain);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(1100, 522);
            this.splitContainerControl.SplitterPosition = 165;
            this.splitContainerControl.TabIndex = 0;
            this.splitContainerControl.Text = "splitContainerControl1";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.mailGroup;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.mailGroup,
            this.organizerGroup});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.inboxItem,
            this.outboxItem,
            this.draftsItem,
            this.trashItem,
            this.calendarItem,
            this.tasksItem});
            this.navBarControl.LargeImages = this.navbarImageListLarge;
            this.navBarControl.Location = new System.Drawing.Point(0, 0);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 165;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar;
            this.navBarControl.Size = new System.Drawing.Size(165, 510);
            this.navBarControl.SmallImages = this.navbarImageList;
            this.navBarControl.StoreDefaultPaintStyleName = true;
            this.navBarControl.TabIndex = 0;
            this.navBarControl.Text = "navBarControl1";
            // 
            // mailGroup
            // 
            this.mailGroup.Caption = "Mail";
            this.mailGroup.Expanded = true;
            this.mailGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.inboxItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.outboxItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.draftsItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.trashItem)});
            this.mailGroup.LargeImageIndex = 0;
            this.mailGroup.Name = "mailGroup";
            // 
            // inboxItem
            // 
            this.inboxItem.Caption = "Main";
            this.inboxItem.Name = "inboxItem";
            this.inboxItem.SmallImageIndex = 0;
            // 
            // outboxItem
            // 
            this.outboxItem.Caption = "Outbox";
            this.outboxItem.Name = "outboxItem";
            this.outboxItem.SmallImageIndex = 1;
            // 
            // draftsItem
            // 
            this.draftsItem.Caption = "Drafts";
            this.draftsItem.Name = "draftsItem";
            this.draftsItem.SmallImageIndex = 2;
            // 
            // trashItem
            // 
            this.trashItem.Caption = "Trash";
            this.trashItem.Name = "trashItem";
            this.trashItem.SmallImageIndex = 3;
            // 
            // organizerGroup
            // 
            this.organizerGroup.Caption = "Organizer";
            this.organizerGroup.Expanded = true;
            this.organizerGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.calendarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.tasksItem)});
            this.organizerGroup.LargeImageIndex = 1;
            this.organizerGroup.Name = "organizerGroup";
            // 
            // calendarItem
            // 
            this.calendarItem.Caption = "Calendar";
            this.calendarItem.Name = "calendarItem";
            this.calendarItem.SmallImageIndex = 4;
            // 
            // tasksItem
            // 
            this.tasksItem.Caption = "Tasks";
            this.tasksItem.Name = "tasksItem";
            this.tasksItem.SmallImageIndex = 5;
            // 
            // navbarImageListLarge
            // 
            this.navbarImageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("navbarImageListLarge.ImageStream")));
            this.navbarImageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageListLarge.Images.SetKeyName(0, "Mail_16x16.png");
            this.navbarImageListLarge.Images.SetKeyName(1, "Organizer_16x16.png");
            // 
            // navbarImageList
            // 
            this.navbarImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("navbarImageList.ImageStream")));
            this.navbarImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageList.Images.SetKeyName(0, "Inbox_16x16.png");
            this.navbarImageList.Images.SetKeyName(1, "Outbox_16x16.png");
            this.navbarImageList.Images.SetKeyName(2, "Drafts_16x16.png");
            this.navbarImageList.Images.SetKeyName(3, "Trash_16x16.png");
            this.navbarImageList.Images.SetKeyName(4, "Calendar_16x16.png");
            this.navbarImageList.Images.SetKeyName(5, "Tasks_16x16.png");
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.gridControl);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(918, 510);
            this.panelMain.TabIndex = 1;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonDropDownControl = this.appMenu;
            this.ribbonControl.ApplicationButtonText = null;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.ExpandCollapseItem.Name = "";
            this.ribbonControl.Images = this.ribbonImageCollection;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.iNew,
            this.iOpen,
            this.iImport,
            this.iExport,
            this.iSave,
            this.iSaveAs,
            this.iExit,
            this.iHelp,
            this.iAbout,
            this.siStatus,
            this.siInfo,
            this.alignButtonGroup,
            this.iBoldFontStyle,
            this.iItalicFontStyle,
            this.iUnderlinedFontStyle,
            this.fontStyleButtonGroup,
            this.iLeftTextAlign,
            this.iCenterTextAlign,
            this.iRightTextAlign,
            this.rgbiSkins,
            this.barStaticItem1,
            this.barStaticItem2});
            this.ribbonControl.LargeImages = this.ribbonImageCollectionLarge;
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 67;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageHeaderItemLinks.Add(this.iAbout);
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.homeRibbonPage,
            this.helpRibbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl.Size = new System.Drawing.Size(1100, 147);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.Toolbar.ItemLinks.Add(this.iNew);
            this.ribbonControl.Toolbar.ItemLinks.Add(this.iOpen);
            this.ribbonControl.Toolbar.ItemLinks.Add(this.iSave);
            this.ribbonControl.Toolbar.ItemLinks.Add(this.iSaveAs);
            this.ribbonControl.Toolbar.ItemLinks.Add(this.iHelp);
            // 
            // appMenu
            // 
            this.appMenu.BottomPaneControlContainer = this.popupControlContainer2;
            this.appMenu.ItemLinks.Add(this.iNew);
            this.appMenu.ItemLinks.Add(this.iOpen);
            this.appMenu.ItemLinks.Add(this.iSave);
            this.appMenu.ItemLinks.Add(this.iSaveAs);
            this.appMenu.ItemLinks.Add(this.iExit);
            this.appMenu.Name = "appMenu";
            this.appMenu.Ribbon = this.ribbonControl;
            this.appMenu.RightPaneControlContainer = this.popupControlContainer1;
            this.appMenu.ShowRightPane = true;
            // 
            // popupControlContainer2
            // 
            this.popupControlContainer2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.popupControlContainer2.Appearance.Options.UseBackColor = true;
            this.popupControlContainer2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer2.Controls.Add(this.buttonEdit);
            this.popupControlContainer2.Location = new System.Drawing.Point(238, 289);
            this.popupControlContainer2.Name = "popupControlContainer2";
            this.popupControlContainer2.Ribbon = this.ribbonControl;
            this.popupControlContainer2.Size = new System.Drawing.Size(118, 28);
            this.popupControlContainer2.TabIndex = 3;
            this.popupControlContainer2.Visible = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.EditValue = "Some Text";
            this.buttonEdit.Location = new System.Drawing.Point(3, 5);
            this.buttonEdit.MenuManager = this.ribbonControl;
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit.Size = new System.Drawing.Size(100, 20);
            this.buttonEdit.TabIndex = 0;
            // 
            // iNew
            // 
            this.iNew.Caption = "New";
            this.iNew.Description = "Creates a new, blank file.";
            this.iNew.Hint = "Creates a new, blank file";
            this.iNew.Id = 1;
            this.iNew.ImageIndex = 0;
            this.iNew.LargeImageIndex = 0;
            this.iNew.Name = "iNew";
            // 
            // iOpen
            // 
            this.iOpen.Caption = "导入DB";
            this.iOpen.Description = "Opens a file.";
            this.iOpen.Hint = "Opens a file";
            this.iOpen.Id = 2;
            this.iOpen.ImageIndex = 1;
            this.iOpen.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.iOpen.LargeImageIndex = 1;
            this.iOpen.Name = "iOpen";
            this.iOpen.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.iOpen.ShortcutKeyDisplayString = "ctrl+o";
            this.iOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iOpen_ItemClick);
            // 
            // iSave
            // 
            this.iSave.Caption = "&Save";
            this.iSave.Description = "Saves the active document.";
            this.iSave.Hint = "Saves the active document";
            this.iSave.Id = 16;
            this.iSave.ImageIndex = 4;
            this.iSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.iSave.LargeImageIndex = 4;
            this.iSave.Name = "iSave";
            this.iSave.ShortcutKeyDisplayString = "ctrl+s";
            this.iSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iSave_ItemClick);
            // 
            // iSaveAs
            // 
            this.iSaveAs.Caption = "Save As";
            this.iSaveAs.Description = "Saves the active document in a different location.";
            this.iSaveAs.Hint = "Saves the active document in a different location";
            this.iSaveAs.Id = 17;
            this.iSaveAs.ImageIndex = 5;
            this.iSaveAs.LargeImageIndex = 5;
            this.iSaveAs.Name = "iSaveAs";
            // 
            // iExit
            // 
            this.iExit.Caption = "刷新";
            this.iExit.Description = "Closes this program after prompting you to save unsaved data.";
            this.iExit.Hint = "Closes this program after prompting you to save unsaved data";
            this.iExit.Id = 20;
            this.iExit.ImageIndex = 6;
            this.iExit.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.iExit.LargeImageIndex = 6;
            this.iExit.Name = "iExit";
            this.iExit.ShortcutKeyDisplayString = "F5";
            this.iExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iExit_ItemClick);
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.popupControlContainer1.Appearance.Options.UseBackColor = true;
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Controls.Add(this.someLabelControl2);
            this.popupControlContainer1.Controls.Add(this.someLabelControl1);
            this.popupControlContainer1.Location = new System.Drawing.Point(111, 197);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Ribbon = this.ribbonControl;
            this.popupControlContainer1.Size = new System.Drawing.Size(76, 70);
            this.popupControlContainer1.TabIndex = 2;
            this.popupControlContainer1.Visible = false;
            // 
            // someLabelControl2
            // 
            this.someLabelControl2.Location = new System.Drawing.Point(3, 57);
            this.someLabelControl2.Name = "someLabelControl2";
            this.someLabelControl2.Size = new System.Drawing.Size(57, 14);
            this.someLabelControl2.TabIndex = 0;
            this.someLabelControl2.Text = "Some Info";
            // 
            // someLabelControl1
            // 
            this.someLabelControl1.Location = new System.Drawing.Point(3, 3);
            this.someLabelControl1.Name = "someLabelControl1";
            this.someLabelControl1.Size = new System.Drawing.Size(57, 14);
            this.someLabelControl1.TabIndex = 0;
            this.someLabelControl1.Text = "Some Info";
            // 
            // ribbonImageCollection
            // 
            this.ribbonImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollection.ImageStream")));
            this.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_New_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Open_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Close_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(3, "Ribbon_Find_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(4, "Ribbon_Save_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(5, "Ribbon_SaveAs_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(6, "Ribbon_Exit_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(7, "Ribbon_Content_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(8, "Ribbon_Info_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(9, "Ribbon_Bold_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(10, "Ribbon_Italic_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(11, "Ribbon_Underline_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(12, "Ribbon_AlignLeft_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(13, "Ribbon_AlignCenter_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(14, "Ribbon_AlignRight_16x16.png");
            // 
            // iImport
            // 
            this.iImport.Caption = "导入资源";
            this.iImport.Description = "Closes the active document.";
            this.iImport.Hint = "Closes the active document";
            this.iImport.Id = 3;
            this.iImport.ImageIndex = 1;
            this.iImport.LargeImageIndex = 2;
            this.iImport.Name = "iImport";
            this.iImport.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.iImport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iImport_ItemClick);
            // 
            // iExport
            // 
            this.iExport.Caption = "导出";
            this.iExport.Description = "Searches for the specified info.";
            this.iExport.Hint = "Searches for the specified info";
            this.iExport.Id = 15;
            this.iExport.ImageIndex = 2;
            this.iExport.LargeImageIndex = 3;
            this.iExport.Name = "iExport";
            this.iExport.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // iHelp
            // 
            this.iHelp.Caption = "Help";
            this.iHelp.Description = "Start the program help system.";
            this.iHelp.Hint = "Start the program help system";
            this.iHelp.Id = 22;
            this.iHelp.ImageIndex = 7;
            this.iHelp.LargeImageIndex = 7;
            this.iHelp.Name = "iHelp";
            // 
            // iAbout
            // 
            this.iAbout.Caption = "About";
            this.iAbout.Description = "Displays general program information.";
            this.iAbout.Hint = "Displays general program information";
            this.iAbout.Id = 24;
            this.iAbout.ImageIndex = 8;
            this.iAbout.LargeImageIndex = 8;
            this.iAbout.Name = "iAbout";
            // 
            // siStatus
            // 
            this.siStatus.Caption = "Some Status Info";
            this.siStatus.Id = 31;
            this.siStatus.Name = "siStatus";
            this.siStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // siInfo
            // 
            this.siInfo.Caption = "Some Info";
            this.siInfo.Id = 32;
            this.siInfo.Name = "siInfo";
            this.siInfo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // alignButtonGroup
            // 
            this.alignButtonGroup.Caption = "Align Commands";
            this.alignButtonGroup.Id = 52;
            this.alignButtonGroup.ItemLinks.Add(this.iBoldFontStyle);
            this.alignButtonGroup.ItemLinks.Add(this.iItalicFontStyle);
            this.alignButtonGroup.ItemLinks.Add(this.iUnderlinedFontStyle);
            this.alignButtonGroup.Name = "alignButtonGroup";
            // 
            // iBoldFontStyle
            // 
            this.iBoldFontStyle.Caption = "Bold";
            this.iBoldFontStyle.Id = 53;
            this.iBoldFontStyle.ImageIndex = 9;
            this.iBoldFontStyle.Name = "iBoldFontStyle";
            // 
            // iItalicFontStyle
            // 
            this.iItalicFontStyle.Caption = "Italic";
            this.iItalicFontStyle.Id = 54;
            this.iItalicFontStyle.ImageIndex = 10;
            this.iItalicFontStyle.Name = "iItalicFontStyle";
            // 
            // iUnderlinedFontStyle
            // 
            this.iUnderlinedFontStyle.Caption = "Underlined";
            this.iUnderlinedFontStyle.Id = 55;
            this.iUnderlinedFontStyle.ImageIndex = 11;
            this.iUnderlinedFontStyle.Name = "iUnderlinedFontStyle";
            // 
            // fontStyleButtonGroup
            // 
            this.fontStyleButtonGroup.Caption = "Font Style";
            this.fontStyleButtonGroup.Id = 56;
            this.fontStyleButtonGroup.ItemLinks.Add(this.iLeftTextAlign);
            this.fontStyleButtonGroup.ItemLinks.Add(this.iCenterTextAlign);
            this.fontStyleButtonGroup.ItemLinks.Add(this.iRightTextAlign);
            this.fontStyleButtonGroup.Name = "fontStyleButtonGroup";
            // 
            // iLeftTextAlign
            // 
            this.iLeftTextAlign.Caption = "Left";
            this.iLeftTextAlign.Id = 57;
            this.iLeftTextAlign.ImageIndex = 12;
            this.iLeftTextAlign.Name = "iLeftTextAlign";
            // 
            // iCenterTextAlign
            // 
            this.iCenterTextAlign.Caption = "Center";
            this.iCenterTextAlign.Id = 58;
            this.iCenterTextAlign.ImageIndex = 13;
            this.iCenterTextAlign.Name = "iCenterTextAlign";
            // 
            // iRightTextAlign
            // 
            this.iRightTextAlign.Caption = "Right";
            this.iRightTextAlign.Id = 59;
            this.iRightTextAlign.ImageIndex = 14;
            this.iRightTextAlign.Name = "iRightTextAlign";
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Caption = "Skins";
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Gallery.AllowHoverImages = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Gallery.ColumnCount = 4;
            this.rgbiSkins.Gallery.FixedHoverImageSize = false;
            this.rgbiSkins.Gallery.ImageSize = new System.Drawing.Size(32, 17);
            this.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
            this.rgbiSkins.Gallery.RowCount = 4;
            this.rgbiSkins.Id = 60;
            this.rgbiSkins.Name = "rgbiSkins";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "添加";
            this.barStaticItem1.Id = 62;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "删除";
            this.barStaticItem2.Id = 63;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ribbonImageCollectionLarge
            // 
            this.ribbonImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.ribbonImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollectionLarge.ImageStream")));
            this.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Open_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Close_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(3, "Ribbon_Find_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(4, "Ribbon_Save_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Exit_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_Content_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Info_32x32.png");
            // 
            // homeRibbonPage
            // 
            this.homeRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.fileRibbonPageGroup,
            this.formatRibbonPageGroup,
            this.skinsRibbonPageGroup,
            this.exitRibbonPageGroup});
            this.homeRibbonPage.Name = "homeRibbonPage";
            this.homeRibbonPage.Text = "Home";
            // 
            // fileRibbonPageGroup
            // 
            this.fileRibbonPageGroup.ItemLinks.Add(this.iNew);
            this.fileRibbonPageGroup.ItemLinks.Add(this.iOpen);
            this.fileRibbonPageGroup.ItemLinks.Add(this.iImport);
            this.fileRibbonPageGroup.ItemLinks.Add(this.iExport);
            this.fileRibbonPageGroup.ItemLinks.Add(this.iSave);
            this.fileRibbonPageGroup.ItemLinks.Add(this.iSaveAs);
            this.fileRibbonPageGroup.Name = "fileRibbonPageGroup";
            this.fileRibbonPageGroup.Text = "File";
            // 
            // formatRibbonPageGroup
            // 
            this.formatRibbonPageGroup.ItemLinks.Add(this.alignButtonGroup);
            this.formatRibbonPageGroup.ItemLinks.Add(this.fontStyleButtonGroup);
            this.formatRibbonPageGroup.Name = "formatRibbonPageGroup";
            this.formatRibbonPageGroup.Text = "Format";
            // 
            // skinsRibbonPageGroup
            // 
            this.skinsRibbonPageGroup.ItemLinks.Add(this.rgbiSkins);
            this.skinsRibbonPageGroup.Name = "skinsRibbonPageGroup";
            this.skinsRibbonPageGroup.ShowCaptionButton = false;
            this.skinsRibbonPageGroup.Text = "Skins";
            // 
            // exitRibbonPageGroup
            // 
            this.exitRibbonPageGroup.ItemLinks.Add(this.iExit);
            this.exitRibbonPageGroup.Name = "exitRibbonPageGroup";
            this.exitRibbonPageGroup.Text = "Exit";
            // 
            // helpRibbonPage
            // 
            this.helpRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.helpRibbonPageGroup});
            this.helpRibbonPage.Name = "helpRibbonPage";
            this.helpRibbonPage.Text = "Help";
            // 
            // helpRibbonPageGroup
            // 
            this.helpRibbonPageGroup.ItemLinks.Add(this.iHelp);
            this.helpRibbonPageGroup.ItemLinks.Add(this.iAbout);
            this.helpRibbonPageGroup.Name = "helpRibbonPageGroup";
            this.helpRibbonPageGroup.Text = "Help";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.siStatus);
            this.ribbonStatusBar.ItemLinks.Add(this.siInfo);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 669);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1100, 31);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem1.Text = "添加";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem2.Text = "删除";
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colstage,
            this.layoutViewField_colcreatdate,
            this.layoutViewField_coltip,
            this.layoutViewField_colselectors,
            this.layoutViewField_colresolved,
            this.layoutViewField_layoutViewColumn1,
            this.item1,
            this.layoutViewField_colid2,
            this.layoutViewField_coltitle,
            this.layoutViewField_colsubjectType,
            this.layoutViewField_colcomicsType,
            this.layoutViewField_colsorter,
            this.layoutViewField_colanswer,
            this.layoutViewField_collevel,
            this.layoutViewField_colresImg,
            this.layoutViewField_colresText,
            this.layoutViewField_colresAudio,
            this.item2,
            this.layoutViewField_colremark});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // layoutViewField_colstage
            // 
            this.layoutViewField_colstage.EditorPreferredWidth = 398;
            this.layoutViewField_colstage.Location = new System.Drawing.Point(0, 140);
            this.layoutViewField_colstage.Name = "layoutViewField_colstage";
            this.layoutViewField_colstage.Size = new System.Drawing.Size(483, 20);
            this.layoutViewField_colstage.TextSize = new System.Drawing.Size(76, 14);
            this.layoutViewField_colstage.TextToControlDistance = 5;
            // 
            // layoutViewField_colcreatdate
            // 
            this.layoutViewField_colcreatdate.EditorPreferredWidth = 398;
            this.layoutViewField_colcreatdate.Location = new System.Drawing.Point(0, 160);
            this.layoutViewField_colcreatdate.Name = "layoutViewField_colcreatdate";
            this.layoutViewField_colcreatdate.Size = new System.Drawing.Size(483, 20);
            this.layoutViewField_colcreatdate.TextSize = new System.Drawing.Size(76, 14);
            this.layoutViewField_colcreatdate.TextToControlDistance = 5;
            // 
            // layoutViewField_coltip
            // 
            this.layoutViewField_coltip.EditorPreferredWidth = 398;
            this.layoutViewField_coltip.Location = new System.Drawing.Point(0, 180);
            this.layoutViewField_coltip.Name = "layoutViewField_coltip";
            this.layoutViewField_coltip.Size = new System.Drawing.Size(483, 20);
            this.layoutViewField_coltip.TextSize = new System.Drawing.Size(76, 14);
            this.layoutViewField_coltip.TextToControlDistance = 5;
            // 
            // layoutViewField_colselectors
            // 
            this.layoutViewField_colselectors.EditorPreferredWidth = 398;
            this.layoutViewField_colselectors.Location = new System.Drawing.Point(0, 200);
            this.layoutViewField_colselectors.Name = "layoutViewField_colselectors";
            this.layoutViewField_colselectors.Size = new System.Drawing.Size(483, 20);
            this.layoutViewField_colselectors.TextSize = new System.Drawing.Size(76, 14);
            this.layoutViewField_colselectors.TextToControlDistance = 5;
            // 
            // layoutViewField_colresolved
            // 
            this.layoutViewField_colresolved.EditorPreferredWidth = 157;
            this.layoutViewField_colresolved.Location = new System.Drawing.Point(241, 263);
            this.layoutViewField_colresolved.Name = "layoutViewField_colresolved";
            this.layoutViewField_colresolved.Size = new System.Drawing.Size(242, 20);
            this.layoutViewField_colresolved.TextSize = new System.Drawing.Size(76, 14);
            this.layoutViewField_colresolved.TextToControlDistance = 5;
            // 
            // layoutViewField_layoutViewColumn1
            // 
            this.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 205;
            this.layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            this.layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(290, 140);
            this.layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(76, 14);
            this.layoutViewField_layoutViewColumn1.TextToControlDistance = 5;
            // 
            // item1
            // 
            this.item1.AllowHotTrack = false;
            this.item1.CustomizationFormText = "item1";
            this.item1.Location = new System.Drawing.Point(481, 20);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(2, 120);
            this.item1.Text = "item1";
            // 
            // layoutViewField_colid2
            // 
            this.layoutViewField_colid2.EditorPreferredWidth = 108;
            this.layoutViewField_colid2.Location = new System.Drawing.Point(290, 0);
            this.layoutViewField_colid2.Name = "layoutViewField_colid2";
            this.layoutViewField_colid2.Size = new System.Drawing.Size(193, 20);
            this.layoutViewField_colid2.TextSize = new System.Drawing.Size(76, 14);
            this.layoutViewField_colid2.TextToControlDistance = 5;
            // 
            // layoutViewField_coltitle
            // 
            this.layoutViewField_coltitle.EditorPreferredWidth = 106;
            this.layoutViewField_coltitle.Location = new System.Drawing.Point(290, 20);
            this.layoutViewField_coltitle.Name = "layoutViewField_coltitle";
            this.layoutViewField_coltitle.Size = new System.Drawing.Size(191, 20);
            this.layoutViewField_coltitle.TextSize = new System.Drawing.Size(76, 14);
            this.layoutViewField_coltitle.TextToControlDistance = 5;
            // 
            // layoutViewField_colsubjectType
            // 
            this.layoutViewField_colsubjectType.EditorPreferredWidth = 106;
            this.layoutViewField_colsubjectType.Location = new System.Drawing.Point(290, 40);
            this.layoutViewField_colsubjectType.Name = "layoutViewField_colsubjectType";
            this.layoutViewField_colsubjectType.Size = new System.Drawing.Size(191, 20);
            this.layoutViewField_colsubjectType.TextSize = new System.Drawing.Size(76, 14);
            this.layoutViewField_colsubjectType.TextToControlDistance = 5;
            // 
            // layoutViewField_colcomicsType
            // 
            this.layoutViewField_colcomicsType.EditorPreferredWidth = 106;
            this.layoutViewField_colcomicsType.Location = new System.Drawing.Point(290, 60);
            this.layoutViewField_colcomicsType.Name = "layoutViewField_colcomicsType";
            this.layoutViewField_colcomicsType.Size = new System.Drawing.Size(191, 20);
            this.layoutViewField_colcomicsType.TextSize = new System.Drawing.Size(76, 14);
            this.layoutViewField_colcomicsType.TextToControlDistance = 5;
            // 
            // layoutViewField_colsorter
            // 
            this.layoutViewField_colsorter.EditorPreferredWidth = 106;
            this.layoutViewField_colsorter.Location = new System.Drawing.Point(290, 100);
            this.layoutViewField_colsorter.Name = "layoutViewField_colsorter";
            this.layoutViewField_colsorter.Size = new System.Drawing.Size(191, 20);
            this.layoutViewField_colsorter.TextSize = new System.Drawing.Size(76, 14);
            this.layoutViewField_colsorter.TextToControlDistance = 5;
            // 
            // layoutViewField_colanswer
            // 
            this.layoutViewField_colanswer.EditorPreferredWidth = 106;
            this.layoutViewField_colanswer.Location = new System.Drawing.Point(290, 120);
            this.layoutViewField_colanswer.Name = "layoutViewField_colanswer";
            this.layoutViewField_colanswer.Size = new System.Drawing.Size(191, 20);
            this.layoutViewField_colanswer.TextSize = new System.Drawing.Size(76, 14);
            this.layoutViewField_colanswer.TextToControlDistance = 5;
            // 
            // layoutViewField_collevel
            // 
            this.layoutViewField_collevel.EditorPreferredWidth = 106;
            this.layoutViewField_collevel.Location = new System.Drawing.Point(290, 80);
            this.layoutViewField_collevel.Name = "layoutViewField_collevel";
            this.layoutViewField_collevel.Size = new System.Drawing.Size(191, 20);
            this.layoutViewField_collevel.TextSize = new System.Drawing.Size(76, 14);
            this.layoutViewField_collevel.TextToControlDistance = 5;
            // 
            // layoutViewField_colresImg
            // 
            this.layoutViewField_colresImg.EditorPreferredWidth = 156;
            this.layoutViewField_colresImg.Location = new System.Drawing.Point(0, 263);
            this.layoutViewField_colresImg.Name = "layoutViewField_colresImg";
            this.layoutViewField_colresImg.Size = new System.Drawing.Size(241, 20);
            this.layoutViewField_colresImg.TextSize = new System.Drawing.Size(76, 14);
            this.layoutViewField_colresImg.TextToControlDistance = 5;
            // 
            // layoutViewField_colresText
            // 
            this.layoutViewField_colresText.EditorPreferredWidth = 156;
            this.layoutViewField_colresText.Location = new System.Drawing.Point(0, 303);
            this.layoutViewField_colresText.Name = "layoutViewField_colresText";
            this.layoutViewField_colresText.Size = new System.Drawing.Size(241, 20);
            this.layoutViewField_colresText.TextSize = new System.Drawing.Size(76, 14);
            this.layoutViewField_colresText.TextToControlDistance = 5;
            // 
            // layoutViewField_colresAudio
            // 
            this.layoutViewField_colresAudio.EditorPreferredWidth = 156;
            this.layoutViewField_colresAudio.Location = new System.Drawing.Point(0, 283);
            this.layoutViewField_colresAudio.Name = "layoutViewField_colresAudio";
            this.layoutViewField_colresAudio.Size = new System.Drawing.Size(241, 20);
            this.layoutViewField_colresAudio.TextSize = new System.Drawing.Size(76, 14);
            this.layoutViewField_colresAudio.TextToControlDistance = 5;
            // 
            // item2
            // 
            this.item2.AllowHotTrack = false;
            this.item2.CustomizationFormText = "item2";
            this.item2.Location = new System.Drawing.Point(0, 220);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(483, 43);
            this.item2.Text = "item2";
            this.item2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutViewField_colremark
            // 
            this.layoutViewField_colremark.EditorPreferredWidth = 157;
            this.layoutViewField_colremark.Location = new System.Drawing.Point(241, 283);
            this.layoutViewField_colremark.Name = "layoutViewField_colremark";
            this.layoutViewField_colremark.Size = new System.Drawing.Size(242, 40);
            this.layoutViewField_colremark.TextSize = new System.Drawing.Size(76, 14);
            this.layoutViewField_colremark.TextToControlDistance = 5;
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.splitContainerControl);
            this.Controls.Add(this.ribbonControl);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.popupControlContainer2);
            this.Controls.Add(this.ribbonStatusBar);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupEditStageType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupEditSubjectType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupEditComicsType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comicsTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkupEditStage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMyPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer2)).EndInit();
            this.popupControlContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            this.popupControlContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colstage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcreatdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coltip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colselectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colresolved)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coltitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colsubjectType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcomicsType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colsorter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colanswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_collevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colresImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colresText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colresAudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colremark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem iNew;
        private DevExpress.XtraBars.BarButtonItem iOpen;
        private DevExpress.XtraBars.BarButtonItem iImport;
        private DevExpress.XtraBars.BarButtonItem iExport;
        private DevExpress.XtraBars.BarButtonItem iSave;
        private DevExpress.XtraBars.BarButtonItem iSaveAs;
        private DevExpress.XtraBars.BarButtonItem iExit;
        private DevExpress.XtraBars.BarButtonItem iHelp;
        private DevExpress.XtraBars.BarButtonItem iAbout;
        private DevExpress.XtraBars.BarStaticItem siStatus;
        private DevExpress.XtraBars.BarStaticItem siInfo;
        private DevExpress.XtraBars.BarButtonGroup alignButtonGroup;
        private DevExpress.XtraBars.BarButtonItem iBoldFontStyle;
        private DevExpress.XtraBars.BarButtonItem iItalicFontStyle;
        private DevExpress.XtraBars.BarButtonItem iUnderlinedFontStyle;
        private DevExpress.XtraBars.BarButtonGroup fontStyleButtonGroup;
        private DevExpress.XtraBars.BarButtonItem iLeftTextAlign;
        private DevExpress.XtraBars.BarButtonItem iCenterTextAlign;
        private DevExpress.XtraBars.BarButtonItem iRightTextAlign;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbiSkins;
        private DevExpress.XtraBars.Ribbon.RibbonPage homeRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup fileRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup formatRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup skinsRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup exitRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage helpRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup helpRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu appMenu;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;
        private DevExpress.XtraEditors.LabelControl someLabelControl2;
        private DevExpress.XtraEditors.LabelControl someLabelControl1;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer2;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.Utils.ImageCollection ribbonImageCollection;
        private DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup mailGroup;
        private DevExpress.XtraNavBar.NavBarGroup organizerGroup;
        private DevExpress.XtraNavBar.NavBarItem inboxItem;
        private DevExpress.XtraNavBar.NavBarItem outboxItem;
        private DevExpress.XtraNavBar.NavBarItem draftsItem;
        private DevExpress.XtraNavBar.NavBarItem trashItem;
        private DevExpress.XtraNavBar.NavBarItem calendarItem;
        private DevExpress.XtraNavBar.NavBarItem tasksItem;
        private System.Windows.Forms.ImageList navbarImageList;
        private System.Windows.Forms.ImageList navbarImageListLarge;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colname1;
        private DevExpress.XtraGrid.Columns.GridColumn colcatalog;
        private DevExpress.XtraGrid.Columns.GridColumn colstageType;
        private DevExpress.XtraGrid.Columns.GridColumn colunlocked;
        private DevExpress.XtraGrid.Columns.GridColumn colnearSubject;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private System.Windows.Forms.BindingSource fullDataBindingSource;
        private fullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource catalogBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource stageTypeBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkupEditStageType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkupEditSubjectType;
        private System.Windows.Forms.BindingSource subjectTypeBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkupEditComicsType;
        private System.Windows.Forms.BindingSource comicsTypeBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit glkupEditStage;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private System.Windows.Forms.BindingSource stageBindingSource;
        private DevExpress.XtraEditors.PanelControl panelMain;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colid2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn coltitle;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colsubjectType;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colcomicsType;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colstage;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn collevel;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colremark;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colresImg;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colresText;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colresAudio;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colcreatdate;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn coltip;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colselectors;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colanswer;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colsorter;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colresolved;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colImgDisplay;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private MyPictureEdit.RepositoryItemMyPictureEdit repositoryItemMyPictureEdit1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colid2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_coltitle;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colsubjectType;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colcomicsType;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colstage;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_collevel;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colremark;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colresImg;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colresText;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colresAudio;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colcreatdate;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_coltip;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colselectors;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colanswer;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colsorter;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colresolved;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraLayout.SimpleSeparator item1;
        private DevExpress.XtraLayout.EmptySpaceItem item2;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}
