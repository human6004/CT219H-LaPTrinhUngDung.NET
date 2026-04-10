namespace TT_WindowsFormsApp
{
    partial class @operator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSoThu1 = new System.Windows.Forms.TextBox();
            this.textBoxSoThu2 = new System.Windows.Forms.TextBox();
            this.buttonCong = new System.Windows.Forms.Button();
            this.buttonNhan = new System.Windows.Forms.Button();
            this.buttonChia = new System.Windows.Forms.Button();
            this.buttonTru = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.textBoxKQ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxKQ);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonXoa);
            this.panel1.Controls.Add(this.buttonTru);
            this.panel1.Controls.Add(this.buttonChia);
            this.panel1.Controls.Add(this.buttonNhan);
            this.panel1.Controls.Add(this.buttonCong);
            this.panel1.Controls.Add(this.textBoxSoThu2);
            this.panel1.Controls.Add(this.textBoxSoThu1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(60, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 335);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(58, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "nhập số thứ 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(58, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "nhập số thứ 2:";
            // 
            // textBoxSoThu1
            // 
            this.textBoxSoThu1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxSoThu1.Location = new System.Drawing.Point(261, 63);
            this.textBoxSoThu1.Name = "textBoxSoThu1";
            this.textBoxSoThu1.Size = new System.Drawing.Size(298, 30);
            this.textBoxSoThu1.TabIndex = 2;
            // 
            // textBoxSoThu2
            // 
            this.textBoxSoThu2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxSoThu2.Location = new System.Drawing.Point(261, 129);
            this.textBoxSoThu2.Name = "textBoxSoThu2";
            this.textBoxSoThu2.Size = new System.Drawing.Size(298, 30);
            this.textBoxSoThu2.TabIndex = 3;
            // 
            // buttonCong
            // 
            this.buttonCong.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonCong.Location = new System.Drawing.Point(62, 242);
            this.buttonCong.Name = "buttonCong";
            this.buttonCong.Size = new System.Drawing.Size(76, 36);
            this.buttonCong.TabIndex = 4;
            this.buttonCong.Text = "+";
            this.buttonCong.UseVisualStyleBackColor = true;
            this.buttonCong.Click += new System.EventHandler(this.buttonCong_Click);
            // 
            // buttonNhan
            // 
            this.buttonNhan.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonNhan.Location = new System.Drawing.Point(261, 242);
            this.buttonNhan.Name = "buttonNhan";
            this.buttonNhan.Size = new System.Drawing.Size(76, 36);
            this.buttonNhan.TabIndex = 5;
            this.buttonNhan.Text = "*";
            this.buttonNhan.UseVisualStyleBackColor = true;
            this.buttonNhan.Click += new System.EventHandler(this.buttonNhan_Click);
            // 
            // buttonChia
            // 
            this.buttonChia.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonChia.Location = new System.Drawing.Point(362, 242);
            this.buttonChia.Name = "buttonChia";
            this.buttonChia.Size = new System.Drawing.Size(76, 36);
            this.buttonChia.TabIndex = 6;
            this.buttonChia.Text = "/";
            this.buttonChia.UseVisualStyleBackColor = true;
            this.buttonChia.Click += new System.EventHandler(this.buttonChia_Click);
            // 
            // buttonTru
            // 
            this.buttonTru.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonTru.Location = new System.Drawing.Point(163, 242);
            this.buttonTru.Name = "buttonTru";
            this.buttonTru.Size = new System.Drawing.Size(76, 36);
            this.buttonTru.TabIndex = 7;
            this.buttonTru.Text = "-";
            this.buttonTru.UseVisualStyleBackColor = true;
            this.buttonTru.Click += new System.EventHandler(this.buttonTru_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonXoa.Location = new System.Drawing.Point(462, 242);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(76, 36);
            this.buttonXoa.TabIndex = 8;
            this.buttonXoa.Text = "xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // textBoxKQ
            // 
            this.textBoxKQ.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxKQ.Location = new System.Drawing.Point(261, 186);
            this.textBoxKQ.Name = "textBoxKQ";
            this.textBoxKQ.Size = new System.Drawing.Size(298, 30);
            this.textBoxKQ.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(58, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "kết quả là:";
            // 
            // @operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 421);
            this.Controls.Add(this.panel1);
            this.Name = "@operator";
            this.Text = "@operator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonTru;
        private System.Windows.Forms.Button buttonChia;
        private System.Windows.Forms.Button buttonNhan;
        private System.Windows.Forms.Button buttonCong;
        private System.Windows.Forms.TextBox textBoxSoThu2;
        private System.Windows.Forms.TextBox textBoxSoThu1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKQ;
        private System.Windows.Forms.Label label3;
    }
}