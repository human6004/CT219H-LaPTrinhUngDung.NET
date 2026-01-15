namespace QuanLyQuanCaPhe
{
    partial class fTableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewBill = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxFood = new System.Windows.Forms.ComboBox();
            this.buttonThemMon = new System.Windows.Forms.Button();
            this.numericUpDownFoodCount = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanelTable = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonThanhToan = new System.Windows.Forms.Button();
            this.buttonDistCount = new System.Windows.Forms.Button();
            this.numericUpDownDistcount = new System.Windows.Forms.NumericUpDown();
            this.buttonSwitchTable = new System.Windows.Forms.Button();
            this.comboBoxSwitchTable = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFoodCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistcount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.adminToolStripMenuItem.Text = "admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "thông tin tài khoản";
            // 
            // thôngTinCáToolStripMenuItem
            // 
            this.thôngTinCáToolStripMenuItem.Name = "thôngTinCáToolStripMenuItem";
            this.thôngTinCáToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thôngTinCáToolStripMenuItem.Text = "thông tin cá ";
            this.thôngTinCáToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewBill);
            this.panel2.Location = new System.Drawing.Point(305, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 296);
            this.panel2.TabIndex = 1;
            // 
            // listViewBill
            // 
            this.listViewBill.HideSelection = false;
            this.listViewBill.Location = new System.Drawing.Point(0, 0);
            this.listViewBill.Name = "listViewBill";
            this.listViewBill.Size = new System.Drawing.Size(290, 293);
            this.listViewBill.TabIndex = 0;
            this.listViewBill.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBoxSwitchTable);
            this.panel3.Controls.Add(this.buttonSwitchTable);
            this.panel3.Controls.Add(this.numericUpDownDistcount);
            this.panel3.Controls.Add(this.buttonDistCount);
            this.panel3.Controls.Add(this.buttonThanhToan);
            this.panel3.Location = new System.Drawing.Point(305, 402);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 52);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numericUpDownFoodCount);
            this.panel4.Controls.Add(this.buttonThemMon);
            this.panel4.Controls.Add(this.comboBoxFood);
            this.panel4.Controls.Add(this.comboBoxCategory);
            this.panel4.Location = new System.Drawing.Point(304, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(306, 57);
            this.panel4.TabIndex = 3;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(3, 3);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(166, 21);
            this.comboBoxCategory.TabIndex = 0;
            // 
            // comboBoxFood
            // 
            this.comboBoxFood.FormattingEnabled = true;
            this.comboBoxFood.Location = new System.Drawing.Point(3, 30);
            this.comboBoxFood.Name = "comboBoxFood";
            this.comboBoxFood.Size = new System.Drawing.Size(166, 21);
            this.comboBoxFood.TabIndex = 1;
            // 
            // buttonThemMon
            // 
            this.buttonThemMon.Location = new System.Drawing.Point(175, 6);
            this.buttonThemMon.Name = "buttonThemMon";
            this.buttonThemMon.Size = new System.Drawing.Size(81, 51);
            this.buttonThemMon.TabIndex = 2;
            this.buttonThemMon.Text = "thêm món";
            this.buttonThemMon.UseVisualStyleBackColor = true;
            // 
            // numericUpDownFoodCount
            // 
            this.numericUpDownFoodCount.Location = new System.Drawing.Point(262, 20);
            this.numericUpDownFoodCount.Name = "numericUpDownFoodCount";
            this.numericUpDownFoodCount.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownFoodCount.TabIndex = 4;
            this.numericUpDownFoodCount.ValueChanged += new System.EventHandler(this.numericUpDownFoodCount_ValueChanged);
            // 
            // flowLayoutPanelTable
            // 
            this.flowLayoutPanelTable.Location = new System.Drawing.Point(6, 29);
            this.flowLayoutPanelTable.Name = "flowLayoutPanelTable";
            this.flowLayoutPanelTable.Size = new System.Drawing.Size(298, 424);
            this.flowLayoutPanelTable.TabIndex = 4;
            // 
            // buttonThanhToan
            // 
            this.buttonThanhToan.Location = new System.Drawing.Point(212, 0);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.Size = new System.Drawing.Size(81, 51);
            this.buttonThanhToan.TabIndex = 5;
            this.buttonThanhToan.Text = "thanh toán";
            this.buttonThanhToan.UseVisualStyleBackColor = true;
            // 
            // buttonDistCount
            // 
            this.buttonDistCount.Location = new System.Drawing.Point(109, 3);
            this.buttonDistCount.Name = "buttonDistCount";
            this.buttonDistCount.Size = new System.Drawing.Size(81, 26);
            this.buttonDistCount.TabIndex = 6;
            this.buttonDistCount.Text = "giảm giá";
            this.buttonDistCount.UseVisualStyleBackColor = true;
            this.buttonDistCount.Click += new System.EventHandler(this.buttonDistCount_Click);
            // 
            // numericUpDownDistcount
            // 
            this.numericUpDownDistcount.Location = new System.Drawing.Point(109, 31);
            this.numericUpDownDistcount.Name = "numericUpDownDistcount";
            this.numericUpDownDistcount.Size = new System.Drawing.Size(81, 20);
            this.numericUpDownDistcount.TabIndex = 5;
            this.numericUpDownDistcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownDistcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonSwitchTable
            // 
            this.buttonSwitchTable.Location = new System.Drawing.Point(0, 3);
            this.buttonSwitchTable.Name = "buttonSwitchTable";
            this.buttonSwitchTable.Size = new System.Drawing.Size(81, 26);
            this.buttonSwitchTable.TabIndex = 7;
            this.buttonSwitchTable.Text = "chuyển bàn";
            this.buttonSwitchTable.UseVisualStyleBackColor = true;
            // 
            // comboBoxSwitchTable
            // 
            this.comboBoxSwitchTable.FormattingEnabled = true;
            this.comboBoxSwitchTable.Location = new System.Drawing.Point(0, 30);
            this.comboBoxSwitchTable.Name = "comboBoxSwitchTable";
            this.comboBoxSwitchTable.Size = new System.Drawing.Size(81, 21);
            this.comboBoxSwitchTable.TabIndex = 5;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 466);
            this.Controls.Add(this.flowLayoutPanelTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTableManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFoodCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistcount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listViewBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxFood;
        private System.Windows.Forms.NumericUpDown numericUpDownFoodCount;
        private System.Windows.Forms.Button buttonThemMon;
        private System.Windows.Forms.NumericUpDown numericUpDownDistcount;
        private System.Windows.Forms.Button buttonDistCount;
        private System.Windows.Forms.Button buttonThanhToan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTable;
        private System.Windows.Forms.ComboBox comboBoxSwitchTable;
        private System.Windows.Forms.Button buttonSwitchTable;
    }
}