namespace bai6quanlysieuthi.Views
{
    partial class NhanVien
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
  
            this.tabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtGiaoCa)).BeginInit();
            this.panel6.SuspendLayout();
            this.mnsNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
 
            this.btnView_PGC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnView_PGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView_PGC.Location = new System.Drawing.Point(739, 158);
            this.btnView_PGC.Name = "btnView_PGC";
            this.btnView_PGC.Size = new System.Drawing.Size(85, 40);
            this.btnView_PGC.TabIndex = 10;
            this.btnView_PGC.Text = "Xem";
            this.btnView_PGC.UseVisualStyleBackColor = false;
            this.btnView_PGC.Click += new System.EventHandler(this.btnView_PGC_Click);
            // 
            // dgvPhieuGC
            // 
            this.dgvPhieuGC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuGC.Location = new System.Drawing.Point(51, 142);
            this.dgvPhieuGC.Name = "dgvPhieuGC";
            this.dgvPhieuGC.Size = new System.Drawing.Size(626, 281);
            this.dgvPhieuGC.TabIndex = 9;
            this.dgvPhieuGC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuGC_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpNgayGC);
            this.panel1.Controls.Add(this.btnSearch_PGC);
            this.panel1.Controls.Add(this.cbCaGc);
            this.panel1.Controls.Add(this.txtMaNhanVienGc);
            this.panel1.Controls.Add(this.txtMaQuayGC);
            this.panel1.Controls.Add(this.txtMaGC);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(51, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 117);
            this.panel1.TabIndex = 0;
            // 
            // dtpNgayGC
            // 
            this.dtpNgayGC.Location = new System.Drawing.Point(157, 77);
            this.dtpNgayGC.Name = "dtpNgayGC";
            this.dtpNgayGC.Size = new System.Drawing.Size(277, 26);
            this.dtpNgayGC.TabIndex = 21;
            // 
            // cbCaGc
            // 
            this.cbCaGc.FormattingEnabled = true;
            this.cbCaGc.Items.AddRange(new object[] {
            "Ca 1",
            "Ca 2",
            "Ca 3"});
            this.cbCaGc.Location = new System.Drawing.Point(536, 45);
            this.cbCaGc.Name = "cbCaGc";
            this.cbCaGc.Size = new System.Drawing.Size(183, 28);
            this.cbCaGc.TabIndex = 20;
            // 
            // txtMaNhanVienGc
            // 
            this.txtMaNhanVienGc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVienGc.Location = new System.Drawing.Point(536, 13);
            this.txtMaNhanVienGc.Name = "txtMaNhanVienGc";
            this.txtMaNhanVienGc.Size = new System.Drawing.Size(183, 26);
            this.txtMaNhanVienGc.TabIndex = 19;
            // 
            // txtMaQuayGC
            // 
            this.txtMaQuayGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaQuayGC.Location = new System.Drawing.Point(157, 45);
            this.txtMaQuayGC.Name = "txtMaQuayGC";
            this.txtMaQuayGC.Size = new System.Drawing.Size(183, 26);
            this.txtMaQuayGC.TabIndex = 17;
            // 
            // txtMaGC
            // 
            this.txtMaGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGC.Location = new System.Drawing.Point(157, 13);
            this.txtMaGC.Name = "txtMaGC";
            this.txtMaGC.Size = new System.Drawing.Size(183, 26);
            this.txtMaGC.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(426, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ca";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(426, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 23);
            this.label10.TabIndex = 14;
            this.label10.Text = "Mã nhân viên";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Ngày";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 23);
            this.label12.TabIndex = 12;
            this.label12.Text = "Mã quầy";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(41, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 23);
            this.label13.TabIndex = 11;
            this.label13.Text = "Mã ";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.btnExit_CTPGC);
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Controls.Add(this.btnDelete_CTPGC);
            this.tabPage3.Controls.Add(this.btnUpdate_CTPGC);
            this.tabPage3.Controls.Add(this.btnInsert_CTPGC);
            this.tabPage3.Controls.Add(this.btnView_CTPGC);
            this.tabPage3.Controls.Add(this.dgvCtGiaoCa);
            this.tabPage3.Controls.Add(this.panel6);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(876, 447);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Chi tiết phiếu giao ca";
            // 
            // btnExit_CTPGC
            // 
            this.btnExit_CTPGC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit_CTPGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit_CTPGC.Location = new System.Drawing.Point(750, 385);
            this.btnExit_CTPGC.Name = "btnExit_CTPGC";
            this.btnExit_CTPGC.Size = new System.Drawing.Size(85, 40);
            this.btnExit_CTPGC.TabIndex = 25;
            this.btnExit_CTPGC.Text = "Thoát";
            this.btnExit_CTPGC.UseVisualStyleBackColor = false;
            this.btnExit_CTPGC.Click += new System.EventHandler(this.btnExit_CTPGC_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cbSearchCgc);
            this.panel5.Controls.Add(this.txtSearchCgc);
            this.panel5.Controls.Add(this.btnSearch_CTPGC);
            this.panel5.Location = new System.Drawing.Point(52, 134);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(601, 43);
            this.panel5.TabIndex = 23;
            // 
            // cbSearchCgc
            // 
            this.cbSearchCgc.FormattingEnabled = true;
            this.cbSearchCgc.Items.AddRange(new object[] {
            "Mã phiếu giao ca",
            "Mã nhân viên",
            "Mã quầy"});
            this.cbSearchCgc.Location = new System.Drawing.Point(36, 8);
            this.cbSearchCgc.Name = "cbSearchCgc";
            this.cbSearchCgc.Size = new System.Drawing.Size(145, 28);
            this.cbSearchCgc.TabIndex = 12;
            // 
            // txtSearchCgc
            // 
            this.txtSearchCgc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCgc.Location = new System.Drawing.Point(210, 8);
            this.txtSearchCgc.Name = "txtSearchCgc";
            this.txtSearchCgc.Size = new System.Drawing.Size(224, 26);
            this.txtSearchCgc.TabIndex = 11;
            // 
            // btnSearch_CTPGC
            // 
            this.btnSearch_CTPGC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch_CTPGC.Location = new System.Drawing.Point(468, 8);
            this.btnSearch_CTPGC.Name = "btnSearch_CTPGC";
            this.btnSearch_CTPGC.Size = new System.Drawing.Size(98, 28);
            this.btnSearch_CTPGC.TabIndex = 1;
            this.btnSearch_CTPGC.Text = "Tìm kiếm";
            this.btnSearch_CTPGC.UseVisualStyleBackColor = false;
            this.btnSearch_CTPGC.Click += new System.EventHandler(this.btnSearch_CTPGC_Click);
            // 
            // btnDelete_CTPGC
            // 
            this.btnDelete_CTPGC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete_CTPGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_CTPGC.Location = new System.Drawing.Point(750, 327);
            this.btnDelete_CTPGC.Name = "btnDelete_CTPGC";
            this.btnDelete_CTPGC.Size = new System.Drawing.Size(85, 40);
            this.btnDelete_CTPGC.TabIndex = 22;
            this.btnDelete_CTPGC.Text = "Xóa";
            this.btnDelete_CTPGC.UseVisualStyleBackColor = false;
            this.btnDelete_CTPGC.Click += new System.EventHandler(this.btnDelete_CTPGC_Click);
            // 
            // btnUpdate_CTPGC
            // 
            this.btnUpdate_CTPGC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate_CTPGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_CTPGC.Location = new System.Drawing.Point(750, 270);
            this.btnUpdate_CTPGC.Name = "btnUpdate_CTPGC";
            this.btnUpdate_CTPGC.Size = new System.Drawing.Size(85, 40);
            this.btnUpdate_CTPGC.TabIndex = 21;
            this.btnUpdate_CTPGC.Text = "Sửa";
            this.btnUpdate_CTPGC.UseVisualStyleBackColor = false;
            this.btnUpdate_CTPGC.Click += new System.EventHandler(this.btnUpdate_CTPGC_Click);
            // 
            // btnInsert_CTPGC
            // 
            this.btnInsert_CTPGC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsert_CTPGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert_CTPGC.Location = new System.Drawing.Point(750, 212);
            this.btnInsert_CTPGC.Name = "btnInsert_CTPGC";
            this.btnInsert_CTPGC.Size = new System.Drawing.Size(85, 40);
            this.btnInsert_CTPGC.TabIndex = 20;
            this.btnInsert_CTPGC.Text = "Thêm";
            this.btnInsert_CTPGC.UseVisualStyleBackColor = false;
            this.btnInsert_CTPGC.Click += new System.EventHandler(this.btnInsert_CTPGC_Click);
            // 
            // btnView_CTPGC
            // 
            this.btnView_CTPGC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnView_CTPGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView_CTPGC.Location = new System.Drawing.Point(750, 155);
            this.btnView_CTPGC.Name = "btnView_CTPGC";
            this.btnView_CTPGC.Size = new System.Drawing.Size(85, 40);
            this.btnView_CTPGC.TabIndex = 19;
            this.btnView_CTPGC.Text = "Xem";
            this.btnView_CTPGC.UseVisualStyleBackColor = false;
            this.btnView_CTPGC.Click += new System.EventHandler(this.btnView_CTPGC_Click);
            // 
            // dgvCtGiaoCa
            // 
            this.dgvCtGiaoCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCtGiaoCa.Location = new System.Drawing.Point(52, 183);
            this.dgvCtGiaoCa.Name = "dgvCtGiaoCa";
            this.dgvCtGiaoCa.Size = new System.Drawing.Size(662, 242);
            this.dgvCtGiaoCa.TabIndex = 18;
            this.dgvCtGiaoCa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCtGiaoCa_CellClick);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtSoLuongCgc);
            this.panel6.Controls.Add(this.txtMaMatHangCgc);
            this.panel6.Controls.Add(this.txtMaGiaoCaCgc);
            this.panel6.Controls.Add(this.txtSTTCgc);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.label18);
            this.panel6.Location = new System.Drawing.Point(52, 21);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(773, 107);
            this.panel6.TabIndex = 17;
            // 
            // txtSoLuongCgc
            // 
            this.txtSoLuongCgc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongCgc.Location = new System.Drawing.Point(536, 58);
            this.txtSoLuongCgc.Name = "txtSoLuongCgc";
            this.txtSoLuongCgc.Size = new System.Drawing.Size(183, 26);
            this.txtSoLuongCgc.TabIndex = 20;
            // 
            // txtMaMatHangCgc
            // 
            this.txtMaMatHangCgc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMatHangCgc.Location = new System.Drawing.Point(536, 12);
            this.txtMaMatHangCgc.Name = "txtMaMatHangCgc";
            this.txtMaMatHangCgc.Size = new System.Drawing.Size(183, 26);
            this.txtMaMatHangCgc.TabIndex = 19;
            // 
            // txtMaGiaoCaCgc
            // 
            this.txtMaGiaoCaCgc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGiaoCaCgc.Location = new System.Drawing.Point(157, 58);
            this.txtMaGiaoCaCgc.Name = "txtMaGiaoCaCgc";
            this.txtMaGiaoCaCgc.Size = new System.Drawing.Size(183, 26);
            this.txtMaGiaoCaCgc.TabIndex = 17;
            // 
            // txtSTTCgc
            // 
            this.txtSTTCgc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTTCgc.Location = new System.Drawing.Point(157, 12);
            this.txtSTTCgc.Name = "txtSTTCgc";
            this.txtSTTCgc.Size = new System.Drawing.Size(183, 26);
            this.txtSTTCgc.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(426, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 15;
            this.label14.Text = "Số lượng";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(426, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 23);
            this.label15.TabIndex = 14;
            this.label15.Text = "Mã mặt hàng";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(41, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 23);
            this.label17.TabIndex = 12;
            this.label17.Text = "Mã giao ca";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(41, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(121, 23);
            this.label18.TabIndex = 11;
            this.label18.Text = "STT";
            // 
            // mnsNhanVien
            // 
            this.mnsNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsNhanVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrangChu,
            this.menuKhachHang,
            this.menuHangHoa,
            this.hướngDấnToolStripMenuItem});
            this.mnsNhanVien.Location = new System.Drawing.Point(0, 0);
            this.mnsNhanVien.Name = "mnsNhanVien";
            this.mnsNhanVien.Size = new System.Drawing.Size(884, 29);
            this.mnsNhanVien.TabIndex = 4;
            this.mnsNhanVien.Text = "menuStrip1";
            // 
            // menuTrangChu
            // 
            this.menuTrangChu.Name = "menuTrangChu";
            this.menuTrangChu.Size = new System.Drawing.Size(90, 25);
            this.menuTrangChu.Text = "Trang chủ";
            this.menuTrangChu.Click += new System.EventHandler(this.menuTrangChu_Click);
            // 
            // menuKhachHang
            // 
            this.menuKhachHang.Name = "menuKhachHang";
            this.menuKhachHang.Size = new System.Drawing.Size(103, 25);
            this.menuKhachHang.Text = "Khách hàng";
            this.menuKhachHang.Click += new System.EventHandler(this.menuKhachHang_Click);
            // 
            // menuHangHoa
            // 
            this.menuHangHoa.Name = "menuHangHoa";
            this.menuHangHoa.Size = new System.Drawing.Size(89, 25);
            this.menuHangHoa.Text = "Hàng hóa";
            this.menuHangHoa.Click += new System.EventHandler(this.menuHangHoa_Click);
            // 
            // hướngDấnToolStripMenuItem
            // 
            this.hướngDấnToolStripMenuItem.Name = "hướngDấnToolStripMenuItem";
            this.hướngDấnToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.hướngDấnToolStripMenuItem.Text = "Hướng dấn";
            this.hướngDấnToolStripMenuItem.Click += new System.EventHandler(this.hướngDấnToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mnsNhanVien);
            this.Name = "NhanVien";
            this.Text = "Nhân viên";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuGC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtGiaoCa)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.mnsNhanVien.ResumeLayout(false);
            this.mnsNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;

        private System.Windows.Forms.Button btnUpdate_CTPGC;
        private System.Windows.Forms.Button btnInsert_CTPGC;
        private System.Windows.Forms.Button btnView_CTPGC;
        private System.Windows.Forms.DataGridView dgvCtGiaoCa;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtMaMatHangCgc;
        private System.Windows.Forms.TextBox txtMaGiaoCaCgc;
        private System.Windows.Forms.TextBox txtSTTCgc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtSoLuongCgc;
    }
}