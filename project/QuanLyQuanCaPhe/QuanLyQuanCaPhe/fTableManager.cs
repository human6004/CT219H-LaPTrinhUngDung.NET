using QuanLyQuanCaPhe.DAO;
using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            loadTable();
        }

        #region Methods 
        void loadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table table in tableList) {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                flowLayoutPanelTable.Controls.Add(btn);
                btn.Text = table.Name + Environment.NewLine + table.Status;
                btn.Tag = table;
                switch (table.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                flowLayoutPanelTable.Controls.Add(btn);
            }
        }
        #endregion


        #region Events

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // đăng xuất tài khoản
            this.Close();

        }

        private void thôngTinCáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show form fAccountProfile
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();

        }
        #endregion


        private void numericUpDownFoodCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonDistCount_Click(object sender, EventArgs e)
        {

        }



        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show form fAdmin
            fAdmin f = new fAdmin();
            f.ShowDialog();

        }

        private void fTableManager_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelTable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
