namespace TT_WindowsFormsApp
{
    partial class DongHoDemNguoc
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonBatDau = new System.Windows.Forms.Button();
            this.buttonDung = new System.Windows.Forms.Button();
            this.labelDongHo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonBatDau
            // 
            this.buttonBatDau.Location = new System.Drawing.Point(44, 234);
            this.buttonBatDau.Name = "buttonBatDau";
            this.buttonBatDau.Size = new System.Drawing.Size(75, 23);
            this.buttonBatDau.TabIndex = 0;
            this.buttonBatDau.Text = "Bắt đầu";
            this.buttonBatDau.UseVisualStyleBackColor = true;
            this.buttonBatDau.Click += new System.EventHandler(this.buttonBatDau_Click);
            // 
            // buttonDung
            // 
            this.buttonDung.Location = new System.Drawing.Point(399, 234);
            this.buttonDung.Name = "buttonDung";
            this.buttonDung.Size = new System.Drawing.Size(75, 23);
            this.buttonDung.TabIndex = 1;
            this.buttonDung.Text = "Dừng";
            this.buttonDung.UseVisualStyleBackColor = true;
            this.buttonDung.Click += new System.EventHandler(this.buttonDung_Click);
            // 
            // labelDongHo
            // 
            this.labelDongHo.AutoSize = true;
            this.labelDongHo.Location = new System.Drawing.Point(288, 29);
            this.labelDongHo.Name = "labelDongHo";
            this.labelDongHo.Size = new System.Drawing.Size(52, 16);
            this.labelDongHo.TabIndex = 2;
            this.labelDongHo.Text = "bắt đầu";
            this.labelDongHo.Click += new System.EventHandler(this.labelDongHo_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.labelDongHo);
            this.panel1.Controls.Add(this.buttonDung);
            this.panel1.Controls.Add(this.buttonBatDau);
            this.panel1.Location = new System.Drawing.Point(68, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 260);
            this.panel1.TabIndex = 3;
            // 
            // DongHoDemNguoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "DongHoDemNguoc";
            this.Text = "DongHoDemNguoc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonBatDau;
        private System.Windows.Forms.Button buttonDung;
        private System.Windows.Forms.Label labelDongHo;
        private System.Windows.Forms.Panel panel1;
    }
}