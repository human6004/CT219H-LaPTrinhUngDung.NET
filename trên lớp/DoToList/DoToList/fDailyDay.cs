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
    public partial class fDailyDay : Form
    {
        private DateTime date;
        private PlanData job;
        private DateTime dateTime;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public PlanData Job
        {
            get { return job; }
            set { job = value; }
        }

        public fDailyDay(DateTime date, PlanData job)
        {
            InitializeComponent();

            this.date = date;
            this.job = job;

            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            panelJobs.Controls.Add(flowLayoutPanel);
            flowLayoutPanel.Width = panelJobs.Width;
            flowLayoutPanel.Height = panelJobs.Height;

            if (job != null && job.Job != null)
            {
                var jobsForTheDay = job.Job.Where(j => j.Date.Date == date.Date).ToList();
                foreach (var planItem in jobsForTheDay)
                {
                    //ADayJob aDayJobControl = new ADayJob(planItem);
                    //    flowLayoutPanel.Controls.Add(aDayJobControl);
                }
            }

            dateTimePickerDay.Value = date;

        }
        private void dateTimePickerDay_ValueChanged(object sender, EventArgs e)
        {
            ShowJobsByDate(dateTimePickerDay.Value);
        }

        public fDailyDay()
        {
        }

        public fDailyDay(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        private void fDailyDay_Load(object sender, EventArgs e)
        {
            ShowJobsByDate(dateTimePickerDay.Value);
        }

        //private void ShowJobsByDate(DateTime date)
        //{
        //    //panelJobs.Controls.Clear();
        //    //FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();

        //    //if (job != null && job.Job != null)
        //    //{
        //    //    List<PlanItem> todayJob = GetJobDay(date);
        //    //    var jobsForTheDay = job.Job.Where(j => j.Date.Date == date.Date).ToList();
        //    //    foreach (var planItem in GetJobDay(Date))
        //    //    {
        //    //        ADayJob aDayJobControl = new ADayJob(planItem);
        //    //        flowLayoutPanel.Controls.Add(aDayJobControl);
        //    //    }
        //    //}
        //    if (job != null && job.Job != null)
        //    {
        //        List<PlanItem> todayJob = GetJobDay(date);
        //        for(int i = 0; i < todayJob.Count; i++)
        //        {
        //            ADayJob aDayJobControl = new ADayJob(todayJob[i]);
        //            panelJobs.Controls.Add(aDayJobControl);
        //        }
        //    }
        //}
        private void ShowJobsByDate(DateTime date)
        {
            panelJobs.Controls.Clear();   // 🔑 BẮT BUỘC

            if (job != null && job.Job != null)
            {
                List<PlanItem> todayJob = GetJobDay(date);

                for (int i = 0; i < todayJob.Count; i++)
                {
                    //ADayJob aDayJobControl = new ADayJob(todayJob[i]);
                    //panelJobs.Controls.Add(aDayJobControl);
                }
            }
        }

        List<PlanItem> GetJobDay(DateTime date)
        {
            //    if (job != null && job.Job != null)
            //    {
            //        return job.Job.Where(j => j.Date.Date == date.Date).ToList();
            //        //return job.Job.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();

            //    }
            //return new List<PlanItem>();
            //return job.Job.Where(j => j.Date.Date == date.Date).ToList();
            return job.Job.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();
        }
        //private void fDailyDay_VisibleChanged(object sender, EventArgs e)
        //{
        //    ShowJobsByDate((sender as DateTimePicker).Value);
        //}
        private void fDailyDay_VisibleChanged(object sender, EventArgs e)
        {
            ShowJobsByDate(dateTimePickerDay.Value);
        }
        //private void fDailyDay_VisibleChanged(object sender, EventArgs e)
        //{
        //    ShowJobsByDate(dateTimePickerDay.Value);
        //}

        private void fDailyDay_Validated(object sender, EventArgs e)
        {

        }

        private void fDailyDay_Validating(object sender, CancelEventArgs e)
        {

        }

        private void buttonNextDay_Click(object sender, EventArgs e)
        {
            dateTimePickerDay.Value = dateTimePickerDay.Value.AddDays(1);
        }

        private void buttonPrevioursDay_Click(object sender, EventArgs e)
        {
            dateTimePickerDay.Value = dateTimePickerDay.Value.AddDays(-1);
        }

        private void menuStripMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
