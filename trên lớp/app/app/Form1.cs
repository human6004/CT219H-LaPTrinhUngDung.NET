using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Form_Load là một EVENT (sự kiện) của Form trong WinForms.
        //👉 Nó chạy 1 lần duy nhất, ngay khi Form vừa được mở lên.
        private void Form1_Load(object sender, EventArgs e)
        {
            // ListBox
            listBox1.Items.Add("C#");
            listBox1.Items.Add("Java");

            // ComboBox
            comboBox1.Items.Add("Nam");
            comboBox1.Items.Add("Nữ");
        }

        static void main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f= new Form2();
            f.ShowDialog();

        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ddddToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Pi51KPKPPF8");
        } 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f= new Form2();
            f.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hien tu xin chao
            MessageBox.Show("Xin chào");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // neu chon nu thi hien thi nu
            if (comboBox1.SelectedItem.ToString() == "Nữ")
            {
                MessageBox.Show("Bạn đã chọn Nữ");
            }
            else
            {
                MessageBox.Show("Bạn đã chọn Nam");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Title = "Chọn file";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                MessageBox.Show("Bạn chọn: " + path);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.Title = "Lưu file";
            sfd.FileName = "data.txt"; // tên gợi ý

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, textBox1.Text);
                MessageBox.Show("Lưu thành công!");
            }
        }
    }
}
