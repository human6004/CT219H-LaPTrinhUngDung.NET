using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoToList
{
    public partial class fDoToList : Form
    {
        public fDoToList()
        {
            InitializeComponent();
            LoadMatrix();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonToday_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSunday_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        void LoadMatrix()
        {
            Button oldbtn = new Button() { Width = 0, Height =0, Location = new Point(-Cons.margin,0) }; 
            for (int i = 0; i < Cons.dayOfColumn; i++)
            {
                for (int j = 0; j < Cons.dayOfWeek; j++)
                { 
                    Button btn = new Button() { Width = Cons.dateButtonWith , Height = Cons.dateButtonHeight};
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width + Cons.margin, oldbtn.Location.Y);
                    panelMonth.Controls.Add(btn);
                    oldbtn = btn;
                }
                oldbtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldbtn.Location.Y + Cons.dateButtonHeight) };
            }

        }

        private void fDoToList_Load(object sender, EventArgs e)
        {

        }
    }
}
