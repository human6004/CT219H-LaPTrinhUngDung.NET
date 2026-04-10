namespace DoToList
{
    partial class fDailyDay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePickerDay = new System.Windows.Forms.DateTimePicker();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.thêmLịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hômNayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonNextDay = new System.Windows.Forms.Button();
            this.buttonPrevioursDay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelJobs = new System.Windows.Forms.Panel();
            this.menuStripMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerDay
            // 
            this.dateTimePickerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerDay.Location = new System.Drawing.Point(97, 9);
            this.dateTimePickerDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerDay.Name = "dateTimePickerDay";
            this.dateTimePickerDay.Size = new System.Drawing.Size(257, 26);
            this.dateTimePickerDay.TabIndex = 0;
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmLịchToolStripMenuItem,
            this.hômNayToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(466, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // thêmLịchToolStripMenuItem
            // 
            this.thêmLịchToolStripMenuItem.Name = "thêmLịchToolStripMenuItem";
            this.thêmLịchToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.thêmLịchToolStripMenuItem.Text = "Thêm lịch";
            // 
            // hômNayToolStripMenuItem
            // 
            this.hômNayToolStripMenuItem.Name = "hômNayToolStripMenuItem";
            this.hômNayToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.hômNayToolStripMenuItem.Text = "hôm nay";
            // 
            // buttonNextDay
            // 
            this.buttonNextDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonNextDay.Location = new System.Drawing.Point(357, 7);
            this.buttonNextDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNextDay.Name = "buttonNextDay";
            this.buttonNextDay.Size = new System.Drawing.Size(91, 31);
            this.buttonNextDay.TabIndex = 2;
            this.buttonNextDay.Text = "Ngày mai";
            this.buttonNextDay.UseVisualStyleBackColor = true;
            // 
            // buttonPrevioursDay
            // 
            this.buttonPrevioursDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonPrevioursDay.Location = new System.Drawing.Point(2, 7);
            this.buttonPrevioursDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPrevioursDay.Name = "buttonPrevioursDay";
            this.buttonPrevioursDay.Size = new System.Drawing.Size(91, 31);
            this.buttonPrevioursDay.TabIndex = 3;
            this.buttonPrevioursDay.Text = "Hôm qua";
            this.buttonPrevioursDay.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPrevioursDay);
            this.panel1.Controls.Add(this.buttonNextDay);
            this.panel1.Controls.Add(this.dateTimePickerDay);
            this.panel1.Location = new System.Drawing.Point(7, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 49);
            this.panel1.TabIndex = 4;
            // 
            // panelJobs
            // 
            this.panelJobs.Location = new System.Drawing.Point(8, 90);
            this.panelJobs.Name = "panelJobs";
            this.panelJobs.Size = new System.Drawing.Size(457, 314);
            this.panelJobs.TabIndex = 5;
            // 
            // fDailyDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 446);
            this.Controls.Add(this.panelJobs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fDailyDay";
            this.Text = "Lịch trong ngày";
            this.Load += new System.EventHandler(this.fDailyDay_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDay;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem thêmLịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hômNayToolStripMenuItem;
        private System.Windows.Forms.Button buttonNextDay;
        private System.Windows.Forms.Button buttonPrevioursDay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelJobs;
    }
}