namespace DoToList
{
    partial class ADayJob
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxDone = new System.Windows.Forms.CheckBox();
            this.textBoxJob = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownFromHours = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFromMinute = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownToMinute = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownToHours = new System.Windows.Forms.NumericUpDown();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFromHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFromMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToHours)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.comboBoxStatus);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBoxJob);
            this.panel1.Controls.Add(this.checkBoxDone);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 43);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxDone
            // 
            this.checkBoxDone.AutoSize = true;
            this.checkBoxDone.Location = new System.Drawing.Point(3, 13);
            this.checkBoxDone.Name = "checkBoxDone";
            this.checkBoxDone.Size = new System.Drawing.Size(18, 17);
            this.checkBoxDone.TabIndex = 0;
            this.checkBoxDone.UseVisualStyleBackColor = true;
            // 
            // textBoxJob
            // 
            this.textBoxJob.Location = new System.Drawing.Point(27, 9);
            this.textBoxJob.Name = "textBoxJob";
            this.textBoxJob.Size = new System.Drawing.Size(354, 22);
            this.textBoxJob.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDownToMinute);
            this.panel2.Controls.Add(this.numericUpDownToHours);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.numericUpDownFromMinute);
            this.panel2.Controls.Add(this.numericUpDownFromHours);
            this.panel2.Location = new System.Drawing.Point(387, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 33);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // numericUpDownFromHours
            // 
            this.numericUpDownFromHours.Location = new System.Drawing.Point(12, 5);
            this.numericUpDownFromHours.Name = "numericUpDownFromHours";
            this.numericUpDownFromHours.Size = new System.Drawing.Size(49, 22);
            this.numericUpDownFromHours.TabIndex = 0;
            // 
            // numericUpDownFromMinute
            // 
            this.numericUpDownFromMinute.Location = new System.Drawing.Point(67, 5);
            this.numericUpDownFromMinute.Name = "numericUpDownFromMinute";
            this.numericUpDownFromMinute.Size = new System.Drawing.Size(49, 22);
            this.numericUpDownFromMinute.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đến";
            // 
            // numericUpDownToMinute
            // 
            this.numericUpDownToMinute.Location = new System.Drawing.Point(214, 5);
            this.numericUpDownToMinute.Name = "numericUpDownToMinute";
            this.numericUpDownToMinute.Size = new System.Drawing.Size(49, 22);
            this.numericUpDownToMinute.TabIndex = 4;
            // 
            // numericUpDownToHours
            // 
            this.numericUpDownToHours.Location = new System.Drawing.Point(159, 5);
            this.numericUpDownToHours.Name = "numericUpDownToHours";
            this.numericUpDownToHours.Size = new System.Drawing.Size(49, 22);
            this.numericUpDownToHours.TabIndex = 3;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(656, 11);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(143, 24);
            this.comboBoxStatus.TabIndex = 3;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(805, 9);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Sửa";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(886, 9);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // ADayJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ADayJob";
            this.Size = new System.Drawing.Size(1023, 43);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFromHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFromMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxJob;
        private System.Windows.Forms.CheckBox checkBoxDone;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDownToMinute;
        private System.Windows.Forms.NumericUpDown numericUpDownToHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownFromMinute;
        private System.Windows.Forms.NumericUpDown numericUpDownFromHours;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
    }
}
