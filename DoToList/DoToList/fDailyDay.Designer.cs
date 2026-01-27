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
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerDay
            // 
            this.dateTimePickerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerDay.Location = new System.Drawing.Point(139, 55);
            this.dateTimePickerDay.Name = "dateTimePickerDay";
            this.dateTimePickerDay.Size = new System.Drawing.Size(341, 30);
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
            this.menuStripMain.Size = new System.Drawing.Size(621, 28);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // thêmLịchToolStripMenuItem
            // 
            this.thêmLịchToolStripMenuItem.Name = "thêmLịchToolStripMenuItem";
            this.thêmLịchToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.thêmLịchToolStripMenuItem.Text = "Thêm lịch";
            // 
            // hômNayToolStripMenuItem
            // 
            this.hômNayToolStripMenuItem.Name = "hômNayToolStripMenuItem";
            this.hômNayToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.hômNayToolStripMenuItem.Text = "hôm nay";
            // 
            // buttonNextDay
            // 
            this.buttonNextDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonNextDay.Location = new System.Drawing.Point(486, 53);
            this.buttonNextDay.Name = "buttonNextDay";
            this.buttonNextDay.Size = new System.Drawing.Size(121, 38);
            this.buttonNextDay.TabIndex = 2;
            this.buttonNextDay.Text = "Ngày mai";
            this.buttonNextDay.UseVisualStyleBackColor = true;
            // 
            // buttonPrevioursDay
            // 
            this.buttonPrevioursDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonPrevioursDay.Location = new System.Drawing.Point(12, 53);
            this.buttonPrevioursDay.Name = "buttonPrevioursDay";
            this.buttonPrevioursDay.Size = new System.Drawing.Size(121, 38);
            this.buttonPrevioursDay.TabIndex = 3;
            this.buttonPrevioursDay.Text = "Hôm qua";
            this.buttonPrevioursDay.UseVisualStyleBackColor = true;
            // 
            // fDailyDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 549);
            this.Controls.Add(this.buttonPrevioursDay);
            this.Controls.Add(this.buttonNextDay);
            this.Controls.Add(this.dateTimePickerDay);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "fDailyDay";
            this.Text = "Lịch trong ngày";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
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
    }
}