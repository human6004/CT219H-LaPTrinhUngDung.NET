using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT_WindowsFormsApp
{
    public partial class DongHoDemNguoc : Form
    {
        public DongHoDemNguoc()
        {
            InitializeComponent();
        }
        int i = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelDongHo.Text = i.ToString();
            i--;
            if(i <0)
            {
                this.timer1.Enabled = false;
                this.labelDongHo.Text = "hết giờ";
                i = 10;
            }

        }

        private void buttonBatDau_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void labelDongHo_Click(object sender, EventArgs e)
        {

        }

        private void buttonDung_Click(object sender, EventArgs e)
        {
            Application.Exit();   
        }
    }
}
