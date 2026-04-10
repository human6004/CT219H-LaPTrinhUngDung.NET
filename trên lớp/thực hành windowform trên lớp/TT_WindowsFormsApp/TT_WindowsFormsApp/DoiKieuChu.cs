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
    public partial class DoiKieuChu : Form
    {
        public DoiKieuChu()
        {
            InitializeComponent();
            ConvertToUpperCase();
            ConvertToLowerCase();
        }

        private void DoiKieuChu_Load(object sender, EventArgs e)
        {

        }

        void ConvertToUpperCase()
        {   
            string input = textBoxDoiKieuChu.Text;
            string upperCase = input.ToUpper();
            textBoxKQ.Text = upperCase;
        }

        void ConvertToLowerCase()
        {
            string input = textBoxDoiKieuChu.Text;
            string lowerCase = input.ToLower();
            textBoxKQ.Text = lowerCase;
        }



        private void buttonKQ_Click_1(object sender, EventArgs e)
        {
            if (radioButtonChuThuong.Checked)
            {
                ConvertToLowerCase();

            }
            else if (radioButtonInHoa.Checked)
            {
                ConvertToUpperCase();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kiểu chuyển đổi.");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            textBoxDoiKieuChu.Clear();
            textBoxKQ.Clear();
        }
    }
}
