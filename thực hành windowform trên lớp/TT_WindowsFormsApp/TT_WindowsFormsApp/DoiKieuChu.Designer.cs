namespace TT_WindowsFormsApp
{
    partial class DoiKieuChu
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
            this.textBoxDoiKieuChu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonChuThuong = new System.Windows.Forms.RadioButton();
            this.radioButtonInHoa = new System.Windows.Forms.RadioButton();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonKQ = new System.Windows.Forms.Button();
            this.textBoxKQ = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDoiKieuChu
            // 
            this.textBoxDoiKieuChu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxDoiKieuChu.Location = new System.Drawing.Point(239, 31);
            this.textBoxDoiKieuChu.Name = "textBoxDoiKieuChu";
            this.textBoxDoiKieuChu.Size = new System.Drawing.Size(367, 30);
            this.textBoxDoiKieuChu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập họ và tên: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxKQ);
            this.panel1.Controls.Add(this.buttonKQ);
            this.panel1.Controls.Add(this.buttonXoa);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxDoiKieuChu);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 402);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonInHoa);
            this.groupBox1.Controls.Add(this.radioButtonChuThuong);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(59, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 174);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn kiểu chữ";
            // 
            // radioButtonChuThuong
            // 
            this.radioButtonChuThuong.AutoSize = true;
            this.radioButtonChuThuong.Location = new System.Drawing.Point(74, 64);
            this.radioButtonChuThuong.Name = "radioButtonChuThuong";
            this.radioButtonChuThuong.Size = new System.Drawing.Size(148, 28);
            this.radioButtonChuThuong.TabIndex = 0;
            this.radioButtonChuThuong.TabStop = true;
            this.radioButtonChuThuong.Text = "Chữ thường";
            this.radioButtonChuThuong.UseVisualStyleBackColor = true;
            // 
            // radioButtonInHoa
            // 
            this.radioButtonInHoa.AutoSize = true;
            this.radioButtonInHoa.Location = new System.Drawing.Point(79, 125);
            this.radioButtonInHoa.Name = "radioButtonInHoa";
            this.radioButtonInHoa.Size = new System.Drawing.Size(135, 28);
            this.radioButtonInHoa.TabIndex = 1;
            this.radioButtonInHoa.TabStop = true;
            this.radioButtonInHoa.Text = "Chữ in hoa";
            this.radioButtonInHoa.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonXoa.Location = new System.Drawing.Point(568, 141);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(121, 162);
            this.buttonXoa.TabIndex = 3;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonKQ
            // 
            this.buttonKQ.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonKQ.Location = new System.Drawing.Point(63, 330);
            this.buttonKQ.Name = "buttonKQ";
            this.buttonKQ.Size = new System.Drawing.Size(160, 55);
            this.buttonKQ.TabIndex = 4;
            this.buttonKQ.Text = "Kết quả";
            this.buttonKQ.UseVisualStyleBackColor = true;
            this.buttonKQ.Click += new System.EventHandler(this.buttonKQ_Click_1);
            // 
            // textBoxKQ
            // 
            this.textBoxKQ.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxKQ.Location = new System.Drawing.Point(239, 344);
            this.textBoxKQ.Name = "textBoxKQ";
            this.textBoxKQ.Size = new System.Drawing.Size(426, 30);
            this.textBoxKQ.TabIndex = 5;
            // 
            // DoiKieuChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "DoiKieuChu";
            this.Text = "DoiKieuChu";
            this.Load += new System.EventHandler(this.DoiKieuChu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDoiKieuChu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.RadioButton radioButtonInHoa;
        private System.Windows.Forms.RadioButton radioButtonChuThuong;
        private System.Windows.Forms.TextBox textBoxKQ;
        private System.Windows.Forms.Button buttonKQ;
    }
}