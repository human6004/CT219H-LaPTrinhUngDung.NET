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
    public partial class BuomBay : Form
    {
        public BuomBay()
        {
            InitializeComponent();
        }
        int dx = 5;   // tốc độ theo trục X
        int dy = 5;   // tốc độ theo trục Y

        bool isOpen = true; // đổi hình bướm

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BuomBay_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /// Di chuyển bướm
            pictureBox1.Left += dx;
            pictureBox1.Top += dy;

            // Đụng biên trái / phải
            if (pictureBox1.Left <= 0 || pictureBox1.Right >= this.ClientSize.Width)
            {
                dx = -dx; // đổi hướng
            }

            // Đụng biên trên / dưới
            if (pictureBox1.Top <= 0 || pictureBox1.Bottom >= this.ClientSize.Height)
            {
                dy = -dy;
            }

            // Đổi hình bướm cho giống bay
            //if (isOpen)
            //    pictureBox1.Image = Image.FromFile("tải xuống.jpg");
            //else
            //    pictureBox1.Image = Image.FromFile("tải xuống.jpg");

            isOpen = !isOpen;
        }
    }
}
