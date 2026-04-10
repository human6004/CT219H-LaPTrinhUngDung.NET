namespace TT_WindowsFormsApp
{
    partial class ChucMungNamMoi
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
            this.buttonChay = new System.Windows.Forms.Button();
            this.buttonDung = new System.Windows.Forms.Button();
            this.labelChay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonChay
            // 
            this.buttonChay.Location = new System.Drawing.Point(126, 298);
            this.buttonChay.Name = "buttonChay";
            this.buttonChay.Size = new System.Drawing.Size(75, 23);
            this.buttonChay.TabIndex = 0;
            this.buttonChay.Text = "Chạy";
            this.buttonChay.UseVisualStyleBackColor = true;
            // 
            // buttonDung
            // 
            this.buttonDung.Location = new System.Drawing.Point(570, 298);
            this.buttonDung.Name = "buttonDung";
            this.buttonDung.Size = new System.Drawing.Size(75, 23);
            this.buttonDung.TabIndex = 1;
            this.buttonDung.Text = "dừng";
            this.buttonDung.UseVisualStyleBackColor = true;
            this.buttonDung.Click += new System.EventHandler(this.buttonDung_Click);
            // 
            // labelChay
            // 
            this.labelChay.AutoSize = true;
            this.labelChay.Location = new System.Drawing.Point(164, 104);
            this.labelChay.Name = "labelChay";
            this.labelChay.Size = new System.Drawing.Size(0, 16);
            this.labelChay.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(276, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 68);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChucMungNamMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelChay);
            this.Controls.Add(this.buttonDung);
            this.Controls.Add(this.buttonChay);
            this.Name = "ChucMungNamMoi";
            this.Text = "ChucMungNamMoi";
            this.Load += new System.EventHandler(this.ChucMungNamMoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonChay;
        private System.Windows.Forms.Button buttonDung;
        private System.Windows.Forms.Label labelChay;
        private System.Windows.Forms.Label label1;
    }
}