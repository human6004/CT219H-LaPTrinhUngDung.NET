using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoToList
{
    public partial class fDoToList : Form
    {
        public List<List<Button>> Matrix { get; private set; }
        #region Peoperties
        #endregion List<List<Button>>  Matrix;
        public fDoToList()
        {
            InitializeComponent();
            LoadMatrix();
        }

        DateTime currentDate;
        DateTime? selectedDate = null;


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            ////AddNumberInToMatrixByDate((sender as DateTimePicker).Value);
            //DateTimePicker dtp = sender as DateTimePicker;

            //// 👉 ngày được chọn
            //selectedDate = dtp.Value.Date;

            //// 👉 vẽ lại lịch
            //AddNumberInToMatrixByDate(dtp.Value);


            currentDate = dateTimePickerDate.Value;
            AddNumberInToMatrixByDate(currentDate);

        }


        void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (string.IsNullOrEmpty(btn.Text)) return;

            int day = int.Parse(btn.Text);

            selectedDate = new DateTime(
                currentDate.Year,
                currentDate.Month,
                day
            );

            // 🔥 Đồng bộ DateTimePicker theo ngày được chọn
            dateTimePickerDate.Value = selectedDate.Value;

            AddNumberInToMatrixByDate(currentDate);
        }








        private void buttonSunday_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        void LoadMatrix()
        {
            Matrix = new List<List<Button>>();

            Button oldbtn = new Button()
            {
                Width = 0,
                Height = 0,
                Location = new Point(-Cons.margin, 0)
            };

            for (int i = 0; i < Cons.dayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());

                for (int j = 0; j < Cons.dayOfWeek; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.dateButtonWith,
                        Height = Cons.dateButtonHeight
                    };

                    btn.Location = new Point(
                        oldbtn.Location.X + oldbtn.Width + Cons.margin,
                        oldbtn.Location.Y
                    );

                    btn.Click += Btn_Click;

                    panelMonth.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldbtn = btn;
                }

                oldbtn = new Button()
                {
                    Width = 0,
                    Height = 0,
                    Location = new Point(-Cons.margin,
                        oldbtn.Location.Y + Cons.dateButtonHeight)
                };
            }

            // 👉 CHỈ GỌI SAU KHI MATRIX ĐÃ TỒN TẠI
            currentDate = dateTimePickerDate.Value;
            AddNumberInToMatrixByDate(currentDate);
        }



        bool isEqualDate(DateTime date1, DateTime date2)
        {
            return date1.Day == date2.Day && date1.Month == date2.Month && date1.Year == date2.Year;
        }

        void AddNumberInToMatrixByDate(DateTime date)
        {
            DateTime firstDay = new DateTime(date.Year, date.Month, 1);
            int startColumn = ((int)firstDay.DayOfWeek + 6) % 7;
            int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

            DateTime today = DateTime.Today;

            for (int i = 0; i < Cons.dayOfColumn; i++)
            {
                for (int j = 0; j < Cons.dayOfWeek; j++)
                {
                    Button btn = Matrix[i][j];

                    int index = i * Cons.dayOfWeek + j;
                    int day = index - startColumn + 1;

                    if (day >= 1 && day <= daysInMonth)
                    {
                        btn.Text = day.ToString();
                        DateTime cellDate = new DateTime(date.Year, date.Month, day);

                        // 🟠 NGÀY ĐƯỢC CHỌN (CAM)
                        if (selectedDate.HasValue &&
                            isEqualDate(cellDate, selectedDate.Value))
                        {
                            btn.BackColor = Color.Orange;
                            btn.ForeColor = Color.White;
                        }
                        // 🔵 TODAY (XANH – LUÔN GIỮ)
                        else if (isEqualDate(cellDate, today))
                        {
                            btn.BackColor = Color.DodgerBlue;
                            btn.ForeColor = Color.White;
                        }
                        // ⚪ NGÀY THƯỜNG
                        else
                        {
                            btn.BackColor = Color.White;
                            btn.ForeColor = Color.Black;
                        }
                    }
                    else
                    {
                        btn.Text = "";
                        btn.BackColor = Color.LightGray;
                        btn.ForeColor = Color.Black;
                    }
                }
            }
        }




        void setDefaultDate()
        {
            dateTimePickerDate.Value = DateTime.Now;
        }

        private void fDoToList_Load(object sender, EventArgs e)
        {

        }

        //private void buttonNext_Click(object sender, EventArgs e)
        //{
        //    dateTimePickerDate.Value = dateTimePickerDate.Value.AddMonths(1);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePickerDate.Value = dateTimePickerDate.Value.AddMonths(-1);
        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            currentDate = DateTime.Today;
            dateTimePickerDate.Value = currentDate;

            // 🔥 XOÁ NGÀY ĐƯỢC CHỌN
            selectedDate = null;

            AddNumberInToMatrixByDate(currentDate);
        }

        private void buttonNext_Click_1(object sender, EventArgs e)
        {
            dateTimePickerDate.Value = dateTimePickerDate.Value.AddMonths(1);

        }

    }
}
