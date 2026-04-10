using System;
using System.Linq;
using System.Windows.Forms;

namespace DeTai_QuanLySinhVien
{
    internal static class MdiChildManager
    {
        public static Form FindByType(Form mdiParent, Type formType)
        {
            if (mdiParent == null || formType == null)
            {
                return null;
            }

            return mdiParent.MdiChildren.FirstOrDefault(child => child.GetType() == formType);
        }

        public static void ShowSingleChild<T>(Form mdiParent) where T : Form, new()
        {
            Form existing = FindByType(mdiParent, typeof(T));
            if (existing != null)
            {
                existing.Activate();
                return;
            }

            T form = new T();
            form.MdiParent = mdiParent;
            form.Show();
        }

        public static void CloseChildrenExcept(Form mdiParent, params Type[] keptTypes)
        {
            if (mdiParent == null)
            {
                return;
            }

            foreach (Form child in mdiParent.MdiChildren.ToArray())
            {
                bool keepChild = keptTypes != null && keptTypes.Any(type => type == child.GetType());
                if (!keepChild)
                {
                    child.Close();
                }
            }
        }
    }
}
