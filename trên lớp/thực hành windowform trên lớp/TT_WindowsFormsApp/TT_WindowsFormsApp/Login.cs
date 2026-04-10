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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text != "admin" || textBoxPassword.Text != "1")
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {


                // hiện thi form fTableManager
                ManHinhChinh mhc = new ManHinhChinh();

                this.Hide();
                mhc.ShowDialog();
                this.Show();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //            if (MessageBox.Show("bạn có thật sự muốn thoát chương trình", "thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
            //else
            //    {
            //    Application.ExitThread();
            //}

            if(MessageBox.Show("bạn có thật sự muốn thoát chương trình", "thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Application.ExitThread();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("bạn có thật sự muốn thoát chương trình", "thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;

            }
            else
            {
                Application.ExitThread();
            }
        }
    }
}
