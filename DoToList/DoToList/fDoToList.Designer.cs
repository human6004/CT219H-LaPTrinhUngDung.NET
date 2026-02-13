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
            this.numericUpDownNotify = new System.Windows.Forms.NumericUpDown();
            this.checkBoxNotify = new System.Windows.Forms.CheckBox();
            this.buttonToday = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPreviours = new System.Windows.Forms.Button();
            this.buttonSunday = new System.Windows.Forms.Button();
            this.buttonSaturday = new System.Windows.Forms.Button();
            this.buttonFriday = new System.Windows.Forms.Button();
            this.buttonThursday = new System.Windows.Forms.Button();
            this.buttonWednesday = new System.Windows.Forms.Button();
            this.buttonTuesday = new System.Windows.Forms.Button();
            this.buttonMonday = new System.Windows.Forms.Button();
            this.panelMonth = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotify)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(9, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 41);
            this.panel1.TabIndex = 0;
            // 
            // numericUpDownNotify
            // 
            this.numericUpDownNotify.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericUpDownNotify.Location = new System.Drawing.Point(120, 10);
            this.numericUpDownNotify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.numericUpDownNotify.Size = new System.Drawing.Size(35, 26);
            this.numericUpDownNotify.TabIndex = 3;
            this.numericUpDownNotify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxNotify
            // 
            this.checkBoxNotify.AutoSize = true;
            this.checkBoxNotify.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBoxNotify.Location = new System.Drawing.Point(8, 11);
            this.checkBoxNotify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxNotify.Name = "checkBoxNotify";
            this.checkBoxNotify.Size = new System.Drawing.Size(111, 23);
            this.checkBoxNotify.TabIndex = 2;
            this.checkBoxNotify.Text = "Thông báo";
            this.checkBoxNotify.UseVisualStyleBackColor = true;
            // 
            // buttonToday
            // 
            this.buttonToday.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToday.Location = new System.Drawing.Point(529, 4);
            this.buttonToday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(102, 35);
            this.buttonToday.TabIndex = 1;
            this.buttonToday.Text = "Hôm nay";
            this.buttonToday.UseVisualStyleBackColor = true;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerDate.Location = new System.Drawing.Point(227, 7);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(266, 26);
            this.dateTimePickerDate.TabIndex = 0;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
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
            this.panel2.Location = new System.Drawing.Point(9, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 44);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonNext.Location = new System.Drawing.Point(643, 0);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(78, 38);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = "Tháng sau";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click_1);
            // 
            // buttonPreviours
            // 
            this.buttonPreviours.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonPreviours.Location = new System.Drawing.Point(0, 0);
            this.buttonPreviours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPreviours.Name = "buttonPreviours";
            this.buttonPreviours.Size = new System.Drawing.Size(76, 38);
            this.buttonPreviours.TabIndex = 7;
            this.buttonPreviours.Text = "Tháng trước";
            this.buttonPreviours.UseVisualStyleBackColor = true;
            this.buttonPreviours.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSunday
            // 
            this.buttonSunday.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonSunday.Location = new System.Drawing.Point(562, 0);
            this.buttonSunday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSunday.Name = "buttonSunday";
            this.buttonSunday.Size = new System.Drawing.Size(78, 38);
            this.buttonSunday.TabIndex = 6;
            this.buttonSunday.Text = "chủ nhật";
            this.buttonSunday.UseVisualStyleBackColor = true;
            this.buttonSunday.Click += new System.EventHandler(this.buttonSunday_Click);
            // 
            // buttonSaturday
            // 
            this.buttonSaturday.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonSaturday.Location = new System.Drawing.Point(482, 0);
            this.buttonSaturday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaturday.Name = "buttonSaturday";
            this.buttonSaturday.Size = new System.Drawing.Size(76, 38);
            this.buttonSaturday.TabIndex = 5;
            this.buttonSaturday.Text = "thứ 7";
            this.buttonSaturday.UseVisualStyleBackColor = true;
            // 
            // buttonFriday
            // 
            this.buttonFriday.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonFriday.Location = new System.Drawing.Point(401, 0);
            this.buttonFriday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFriday.Name = "buttonFriday";
            this.buttonFriday.Size = new System.Drawing.Size(76, 38);
            this.buttonFriday.TabIndex = 4;
            this.buttonFriday.Text = "thứ 6";
            this.buttonFriday.UseVisualStyleBackColor = true;
            // 
            // buttonThursday
            // 
            this.buttonThursday.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThursday.Location = new System.Drawing.Point(321, 0);
            this.buttonThursday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonThursday.Name = "buttonThursday";
            this.buttonThursday.Size = new System.Drawing.Size(76, 38);
            this.buttonThursday.TabIndex = 3;
            this.buttonThursday.Text = "thứ 5";
            this.buttonThursday.UseVisualStyleBackColor = true;
            // 
            // buttonWednesday
            // 
            this.buttonWednesday.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonWednesday.Location = new System.Drawing.Point(241, 0);
            this.buttonWednesday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonWednesday.Name = "buttonWednesday";
            this.buttonWednesday.Size = new System.Drawing.Size(76, 38);
            this.buttonWednesday.TabIndex = 2;
            this.buttonWednesday.Text = "thứ 4";
            this.buttonWednesday.UseVisualStyleBackColor = true;
            // 
            // buttonTuesday
            // 
            this.buttonTuesday.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonTuesday.Location = new System.Drawing.Point(160, 0);
            this.buttonTuesday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTuesday.Name = "buttonTuesday";
            this.buttonTuesday.Size = new System.Drawing.Size(76, 38);
            this.buttonTuesday.TabIndex = 1;
            this.buttonTuesday.Text = "thứ 3";
            this.buttonTuesday.UseVisualStyleBackColor = true;
            // 
            // buttonMonday
            // 
            this.buttonMonday.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonMonday.Location = new System.Drawing.Point(80, 0);
            this.buttonMonday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMonday.Name = "buttonMonday";
            this.buttonMonday.Size = new System.Drawing.Size(76, 38);
            this.buttonMonday.TabIndex = 0;
            this.buttonMonday.Text = "thứ 2";
            this.buttonMonday.UseVisualStyleBackColor = true;
            // 
            // panelMonth
            // 
            this.panelMonth.Location = new System.Drawing.Point(89, 89);
            this.panelMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMonth.Name = "panelMonth";
            this.panelMonth.Size = new System.Drawing.Size(560, 318);
            this.panelMonth.TabIndex = 2;
            this.panelMonth.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // fDoToList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 446);
            this.Controls.Add(this.panelMonth);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fDoToList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thời gian biểu";
            this.Load += new System.EventHandler(this.fDoToList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotify)).EndInit();
            this.panel2.ResumeLayout(false);
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

