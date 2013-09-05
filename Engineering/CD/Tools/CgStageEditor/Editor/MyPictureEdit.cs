using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

namespace MyPictureEdit
{
    public class MyPictureEdit : PictureEdit
    {
        static MyPictureEdit()
        {
            RepositoryItemMyPictureEdit.Register();
        }

        public override string EditorTypeName
        {
            get { return RepositoryItemMyPictureEdit.EditorName; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyPictureEdit Properties
        {
            get { return base.Properties as RepositoryItemMyPictureEdit; }
        }

        PictureMenu menu;
        protected override PictureMenu Menu
        {
            get
            {
                if (menu == null)
                    menu = new MyPictureMenu(this);

                return menu;
            }
        }
    }

    public delegate void ImageLoadedEventHandler(object sender, ImageLoadedEventArgs e);

    [UserRepositoryItem("Register")]
    public class RepositoryItemMyPictureEdit : RepositoryItemPictureEdit
    {
        static RepositoryItemMyPictureEdit()
        {
            Register();
        }
        public static void Register()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(MyPictureEdit),
                typeof(RepositoryItemMyPictureEdit), typeof(PictureEditViewInfo),
                new PictureEditPainter(), true, null));
        }

        public RepositoryItemMyPictureEdit()
        {
        }

        public override void Assign(RepositoryItem item)
        {
            base.Assign(item);
            RepositoryItemMyPictureEdit src = item as RepositoryItemMyPictureEdit;
            if (src == null)
                return;

            this.ImageLoaded = src.ImageLoaded;
        }

        public event ImageLoadedEventHandler ImageLoaded;
        protected internal virtual void RaiseImageLoaded(string fileName)
        {
            if (ImageLoaded != null)
                ImageLoaded(this, new ImageLoadedEventArgs(fileName));
        }

        internal const string EditorName = "MyPictureEdit";
        public override string EditorTypeName
        {
            get { return EditorName; }
        }

        public string FileName { get; set; }
    }

    public class MyPictureMenu : PictureMenu
    {
        public MyPictureMenu(IPictureMenu menuControl)
            : base(menuControl)
        {
        }

        protected override void PasteImage(Image im)
        {
            FieldInfo fi = typeof(PictureMenu).GetField("openFile", BindingFlags.Instance | BindingFlags.NonPublic);
            if (fi == null)
                return;

            OpenFileDialog openDialog = fi.GetValue(this) as OpenFileDialog;
            string fileName = openDialog.FileName;

            base.PasteImage(im);

            MyPictureEdit pictEdit = this.MenuControl as MyPictureEdit;
            if (pictEdit == null)
                return;

            pictEdit.Properties.RaiseImageLoaded(fileName);
        }
    }

    public class ImageLoadedEventArgs : EventArgs
    {
        private string fileName;

        public ImageLoadedEventArgs(string imageFileName)
        {
            fileName = imageFileName;
        }

        public string FileName
        {
            get { return fileName; }
        }
    }
}
