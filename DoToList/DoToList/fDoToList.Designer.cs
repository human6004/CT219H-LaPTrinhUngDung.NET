namespace DoToList
{
    partial class fDoToList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMonth = new System.Windows.Forms.Panel();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.buttonToday = new System.Windows.Forms.Button();
            this.buttonMonday = new System.Windows.Forms.Button();
            this.buttonTuesday = new System.Windows.Forms.Button();
            this.buttonWednesday = new System.Windows.Forms.Button();
            this.buttonThursday = new System.Windows.Forms.Button();
            this.buttonFriday = new System.Windows.Forms.Button();
            this.buttonSaturday = new System.Windows.Forms.Button();
            this.buttonSunday = new System.Windows.Forms.Button();
            this.buttonPreviours = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.checkBoxNotify = new System.Windows.Forms.CheckBox();
            this.numericUpDownNotify = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotify)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.numericUpDownNotify);
            this.panel1.Controls.Add(this.checkBoxNotify);
            this.panel1.Controls.Add(this.buttonToday);
            this.panel1.Controls.Add(this.dateTimePickerDate);
            this.panel1.Location = new System.Drawing.Point(12, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 51);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonNext);
            this.panel2.Controls.Add(this.buttonPreviours);
            this.panel2.Controls.Add(this.buttonSunday);
            this.panel2.Controls.Add(this.buttonSaturday);
            this.panel2.Controls.Add(this.buttonFriday);
            this.panel2.Controls.Add(this.buttonThursday);
            this.panel2.Controls.Add(this.buttonWednesday);
            this.panel2.Controls.Add(this.buttonTuesday);
            this.panel2.Controls.Add(this.buttonMonday);
            this.panel2.Location = new System.Drawing.Point(12, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 54);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelMonth
            // 
            this.panelMonth.Location = new System.Drawing.Point(119, 110);
            this.panelMonth.Name = "panelMonth";
            this.panelMonth.Size = new System.Drawing.Size(746, 392);
            this.panelMonth.TabIndex = 2;
            this.panelMonth.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerDate.Location = new System.Drawing.Point(303, 9);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(353, 30);
            this.dateTimePickerDate.TabIndex = 0;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // buttonToday
            // 
            this.buttonToday.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToday.Location = new System.Drawing.Point(705, 5);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(136, 43);
            this.buttonToday.TabIndex = 1;
            this.buttonToday.Text = "Hôm nay";
            this.buttonToday.UseVisualStyleBackColor = true;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            // 
            // buttonMonday
            // 
            this.buttonMonday.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonMonday.Location = new System.Drawing.Point(107, 0);
            this.buttonMonday.Name = "buttonMonday";
            this.buttonMonday.Size = new System.Drawing.Size(101, 47);
            this.buttonMonday.TabIndex = 0;
            this.buttonMonday.Text = "thứ 2";
            this.buttonMonday.UseVisualStyleBackColor = true;
            // 
            // buttonTuesday
            // 
            this.buttonTuesday.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonTuesday.Location = new System.Drawing.Point(214, 0);
            this.buttonTuesday.Name = "buttonTuesday";
            this.buttonTuesday.Size = new System.Drawing.Size(101, 47);
            this.buttonTuesday.TabIndex = 1;
            this.buttonTuesday.Text = "thứ 3";
            this.buttonTuesday.UseVisualStyleBackColor = true;
            // 
            // buttonWednesday
            // 
            this.buttonWednesday.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonWednesday.Location = new System.Drawing.Point(321, 0);
            this.buttonWednesday.Name = "buttonWednesday";
            this.buttonWednesday.Size = new System.Drawing.Size(101, 47);
            this.buttonWednesday.TabIndex = 2;
            this.buttonWednesday.Text = "thứ 4";
            this.buttonWednesday.UseVisualStyleBackColor = true;
            // 
            // buttonThursday
            // 
            this.buttonThursday.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThursday.Location = new System.Drawing.Point(428, 0);
            this.buttonThursday.Name = "buttonThursday";
            this.buttonThursday.Size = new System.Drawing.Size(101, 47);
            this.buttonThursday.TabIndex = 3;
            this.buttonThursday.Text = "thứ 5";
            this.buttonThursday.UseVisualStyleBackColor = true;
            // 
            // buttonFriday
            // 
            this.buttonFriday.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonFriday.Location = new System.Drawing.Point(535, 0);
            this.buttonFriday.Name = "buttonFriday";
            this.buttonFriday.Size = new System.Drawing.Size(101, 47);
            this.buttonFriday.TabIndex = 4;
            this.buttonFriday.Text = "thứ 6";
            this.buttonFriday.UseVisualStyleBackColor = true;
            // 
            // buttonSaturday
            // 
            this.buttonSaturday.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonSaturday.Location = new System.Drawing.Point(642, 0);
            this.buttonSaturday.Name = "buttonSaturday";
            this.buttonSaturday.Size = new System.Drawing.Size(101, 47);
            this.buttonSaturday.TabIndex = 5;
            this.buttonSaturday.Text = "thứ 7";
            this.buttonSaturday.UseVisualStyleBackColor = true;
            // 
            // buttonSunday
            // 
            this.buttonSunday.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonSunday.Location = new System.Drawing.Point(749, 0);
            this.buttonSunday.Name = "buttonSunday";
            this.buttonSunday.Size = new System.Drawing.Size(104, 47);
            this.buttonSunday.TabIndex = 6;
            this.buttonSunday.Text = "chủ nhật";
            this.buttonSunday.UseVisualStyleBackColor = true;
            this.buttonSunday.Click += new System.EventHandler(this.buttonSunday_Click);
            // 
            // buttonPreviours
            // 
            this.buttonPreviours.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonPreviours.Location = new System.Drawing.Point(0, 0);
            this.buttonPreviours.Name = "buttonPreviours";
            this.buttonPreviours.Size = new System.Drawing.Size(101, 47);
            this.buttonPreviours.TabIndex = 7;
            this.buttonPreviours.Text = "Tháng trước";
            this.buttonPreviours.UseVisualStyleBackColor = true;
            this.buttonPreviours.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonNext.Location = new System.Drawing.Point(857, 0);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(104, 47);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = "Tháng sau";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotify
            // 
            this.checkBoxNotify.AutoSize = true;
            this.checkBoxNotify.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBoxNotify.Location = new System.Drawing.Point(11, 13);
            this.checkBoxNotify.Name = "checkBoxNotify";
            this.checkBoxNotify.Size = new System.Drawing.Size(134, 28);
            this.checkBoxNotify.TabIndex = 2;
            this.checkBoxNotify.Text = "Thông báo";
            this.checkBoxNotify.UseVisualStyleBackColor = true;
            // 
            // numericUpDownNotify
            // 
            this.numericUpDownNotify.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericUpDownNotify.Location = new System.Drawing.Point(160, 12);
            this.numericUpDownNotify.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDownNotify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNotify.Name = "numericUpDownNotify";
            this.numericUpDownNotify.Size = new System.Drawing.Size(47, 30);
            this.numericUpDownNotify.TabIndex = 3;
            this.numericUpDownNotify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fDoToList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 549);
            this.Controls.Add(this.panelMonth);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fDoToList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thời gian biểu";
            this.Load += new System.EventHandler(this.fDoToList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotify)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMonth;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Button buttonToday;
        private System.Windows.Forms.Button buttonMonday;
        private System.Windows.Forms.Button buttonSunday;
        private System.Windows.Forms.Button buttonSaturday;
        private System.Windows.Forms.Button buttonFriday;
        private System.Windows.Forms.Button buttonThursday;
        private System.Windows.Forms.Button buttonWednesday;
        private System.Windows.Forms.Button buttonTuesday;
        private System.Windows.Forms.Button buttonPreviours;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.CheckBox checkBoxNotify;
        private System.Windows.Forms.NumericUpDown numericUpDownNotify;
    }
}

