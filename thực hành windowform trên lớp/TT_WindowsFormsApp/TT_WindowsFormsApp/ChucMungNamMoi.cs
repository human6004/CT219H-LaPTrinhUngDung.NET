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
    public partial class ChucMungNamMoi : Form
    {
        public ChucMungNamMoi()
        {
            InitializeComponent();
        }
        string text = "Chúc mừng năm mới - Happy New Year";
        int index = 0;
        private void ChucMungNamMoi_Load(object sender, EventArgs e)
        {
            label1.Text="";
            timer1.Start();   // chạy ngay khi mở form
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 200;
            if (index < text.Length)
            {
                label1.Text += text[index];
                index++;
            }
            else
            {
                timer1.Stop(); // chạy xong thì dừng
                buttonDung.Text = "Chạy";
            }
        }

        private void buttonDung_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                buttonDung.Text = "Chạy";
            }
            else
            {
                timer1.Start();
                buttonDung.Text = "Dừng";
            }
        }
    }
}
