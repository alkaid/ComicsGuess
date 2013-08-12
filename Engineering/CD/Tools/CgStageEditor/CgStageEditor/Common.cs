using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CgStageEditor
{
    public abstract class Common
    {
        public static void DisplayMsg(string sCaption, string sMsg)
        {
            sMsg = sMsg.TrimEnd('!').TrimEnd('！') + " !";
            MessageBox.Show(sMsg, sCaption);
        }

        public static bool IsNullOrEmptyObject(object oSource)
        {
            if (oSource != null)
            {
                return string.IsNullOrEmpty(oSource.ToString());
            }

            return true;
        }

    }
}
