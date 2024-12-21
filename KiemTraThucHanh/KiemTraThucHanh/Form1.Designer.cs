namespace KiemTraThucHanh
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbCty = new System.Windows.Forms.ComboBox();
            this.rbtDuong = new System.Windows.Forms.RadioButton();
            this.rbtAm = new System.Windows.Forms.RadioButton();
            this.txtSLXN = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filterNVDT = new System.Windows.Forms.ToolStripMenuItem();
            this.filterCtyTest = new System.Windows.Forms.ToolStripMenuItem();
            this.f2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(265, 33);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(69, 23);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(114, 33);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(132, 22);
            this.txtMaNV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CCCD/CMND:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.cmbCty);
            this.groupBox2.Controls.Add(this.rbtDuong);
            this.groupBox2.Controls.Add(this.rbtAm);
            this.groupBox2.Controls.Add(this.txtSLXN);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 278);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin xét nghiệm";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(91, 237);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 26);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbCty
            // 
            this.cmbCty.FormattingEnabled = true;
            this.cmbCty.Location = new System.Drawing.Point(91, 195);
            this.cmbCty.Name = "cmbCty";
            this.cmbCty.Size = new System.Drawing.Size(229, 24);
            this.cmbCty.TabIndex = 7;
            // 
            // rbtDuong
            // 
            this.rbtDuong.AutoSize = true;
            this.rbtDuong.Location = new System.Drawing.Point(94, 163);
            this.rbtDuong.Name = "rbtDuong";
            this.rbtDuong.Size = new System.Drawing.Size(91, 20);
            this.rbtDuong.TabIndex = 6;
            this.rbtDuong.TabStop = true;
            this.rbtDuong.Text = "Dương tính";
            this.rbtDuong.UseVisualStyleBackColor = true;
            // 
            // rbtAm
            // 
            this.rbtAm.AutoSize = true;
            this.rbtAm.Location = new System.Drawing.Point(94, 127);
            this.rbtAm.Name = "rbtAm";
            this.rbtAm.Size = new System.Drawing.Size(71, 20);
            this.rbtAm.TabIndex = 5;
            this.rbtAm.TabStop = true;
            this.rbtAm.Text = "Âm tính";
            this.rbtAm.UseVisualStyleBackColor = true;
            // 
            // txtSLXN
            // 
            this.txtSLXN.Location = new System.Drawing.Point(94, 87);
            this.txtSLXN.Name = "txtSLXN";
            this.txtSLXN.Size = new System.Drawing.Size(118, 22);
            this.txtSLXN.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(94, 41);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(226, 22);
            this.txtHoTen.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Công ty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "KQ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "SLXN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvNhanVien.Location = new System.Drawing.Point(378, 27);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(557, 373);
            this.dgvNhanVien.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CMND/CCCD";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ và Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lần XN";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kết Quả";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterNVDT,
            this.filterCtyTest,
            this.xuấtBáoCáoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(93, 24);
            this.toolStripMenuItem1.Text = "Chức năng";
            // 
            // filterNVDT
            // 
            this.filterNVDT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.f1ToolStripMenuItem});
            this.filterNVDT.Name = "filterNVDT";
            this.filterNVDT.Size = new System.Drawing.Size(299, 26);
            this.filterNVDT.Text = "Danh sách NV Dương Tính";
            this.filterNVDT.Click += new System.EventHandler(this.filterNVDT_Click);
            // 
            // filterCtyTest
            // 
            this.filterCtyTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.f2ToolStripMenuItem});
            this.filterCtyTest.Name = "filterCtyTest";
            this.filterCtyTest.Size = new System.Drawing.Size(299, 26);
            this.filterCtyTest.Text = "Danh Sách Cty đã Test theo Y/C";
            this.filterCtyTest.Click += new System.EventHandler(this.filterCtyTest_Click);
            // 
            // f2ToolStripMenuItem
            // 
            this.f2ToolStripMenuItem.Name = "f2ToolStripMenuItem";
            this.f2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.f2ToolStripMenuItem.Text = "F2";
            // 
            // xuấtBáoCáoToolStripMenuItem
            // 
            this.xuấtBáoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctrRToolStripMenuItem});
            this.xuấtBáoCáoToolStripMenuItem.Name = "xuấtBáoCáoToolStripMenuItem";
            this.xuấtBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.xuấtBáoCáoToolStripMenuItem.Text = "Xuất Báo Cáo";
            // 
            // f1ToolStripMenuItem
            // 
            this.f1ToolStripMenuItem.Name = "f1ToolStripMenuItem";
            this.f1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.f1ToolStripMenuItem.Text = "F1";
            // 
            // ctrRToolStripMenuItem
            // 
            this.ctrRToolStripMenuItem.Name = "ctrRToolStripMenuItem";
            this.ctrRToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ctrRToolStripMenuItem.Text = "Ctr+R";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 450);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSLXN;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.RadioButton rbtDuong;
        private System.Windows.Forms.RadioButton rbtAm;
        private System.Windows.Forms.ComboBox cmbCty;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem filterNVDT;
        private System.Windows.Forms.ToolStripMenuItem filterCtyTest;
        private System.Windows.Forms.ToolStripMenuItem f2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrRToolStripMenuItem;
    }
}

