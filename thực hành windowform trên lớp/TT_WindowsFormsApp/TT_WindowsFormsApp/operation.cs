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
    public partial class @operator : Form
    {
        public @operator()
        {
            InitializeComponent();
        }

        private void buttonCong_Click(object sender, EventArgs e)
        {
            // nếu định dạng truyền vô là sai thì sẽ về sai định dạng

            double so1 = double.Parse(textBoxSoThu1.Text);
            double so2 = double.Parse(textBoxSoThu2.Text);
            double ketqua = so1 + so2;
            textBoxKQ.Text = ketqua.ToString();

        }

        private void buttonTru_Click(object sender, EventArgs e)
        {
            double so1 = double.Parse(textBoxSoThu1.Text);
            double so2 = double.Parse(textBoxSoThu2.Text);
            double ketqua = so1 - so2;
            textBoxKQ.Text = ketqua.ToString();
        }

        private void buttonNhan_Click(object sender, EventArgs e)
        {
            double so1 = double.Parse(textBoxSoThu1.Text);
            double so2 = double.Parse(textBoxSoThu2.Text);
            double ketqua = so1 * so2;
            textBoxKQ.Text = ketqua.ToString();
        }

        private void buttonChia_Click(object sender, EventArgs e)
        {
            double so1 = double.Parse(textBoxSoThu1.Text);
            double so2 = double.Parse(textBoxSoThu2.Text);
            double ketqua = so1 / so2;
            textBoxKQ.Text = ketqua.ToString();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            // Xóa nội dung trong các TextBox
            textBoxSoThu1.Clear();
            textBoxSoThu2.Clear();
            textBoxKQ.Clear();
        }
    }
}
