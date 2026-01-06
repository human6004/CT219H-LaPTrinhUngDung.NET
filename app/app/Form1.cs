using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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


        private void Form1_Load(object sender, EventArgs e)
        {
          
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
    }
}
