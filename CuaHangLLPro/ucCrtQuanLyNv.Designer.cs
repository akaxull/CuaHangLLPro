namespace CuaHangLLPro
{
    partial class ucCrtQuanLyNv
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
            this.lvwDanhSachNhanVien = new System.Windows.Forms.ListView();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTim = new System.Windows.Forms.Label();
            this.lblTieuchi = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.radTimma = new System.Windows.Forms.RadioButton();
            this.radTimten = new System.Windows.Forms.RadioButton();
            this.cboCV = new System.Windows.Forms.ComboBox();
            this.dtpNS = new System.Windows.Forms.DateTimePicker();
            this.radnu = new System.Windows.Forms.RadioButton();
            this.radnam = new System.Windows.Forms.RadioButton();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNS = new System.Windows.Forms.Label();
            this.lblten = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.lblCV = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblManv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvwDanhSachNhanVien
            // 
            this.lvwDanhSachNhanVien.HideSelection = false;
            this.lvwDanhSachNhanVien.Location = new System.Drawing.Point(31, 415);
            this.lvwDanhSachNhanVien.Name = "lvwDanhSachNhanVien";
            this.lvwDanhSachNhanVien.Size = new System.Drawing.Size(794, 252);
            this.lvwDanhSachNhanVien.TabIndex = 25;
            this.lvwDanhSachNhanVien.UseCompatibleStateImageBehavior = false;
            this.lvwDanhSachNhanVien.SelectedIndexChanged += new System.EventHandler(this.lvwDanhSachNhanVien_SelectedIndexChanged);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(147, 86);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(201, 20);
            this.txtTen.TabIndex = 9;
            // 
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTim.Location = new System.Drawing.Point(341, 350);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(135, 13);
            this.lblTim.TabIndex = 22;
            this.lblTim.Text = "Nhập Thông Tin Muốn Tìm";
            // 
            // lblTieuchi
            // 
            this.lblTieuchi.AutoSize = true;
            this.lblTieuchi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTieuchi.Location = new System.Drawing.Point(27, 353);
            this.lblTieuchi.Name = "lblTieuchi";
            this.lblTieuchi.Size = new System.Drawing.Size(116, 13);
            this.lblTieuchi.TabIndex = 180;
            this.lblTieuchi.Text = "Các Tiêu Chí Tìm Kiếm";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(521, 347);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(181, 20);
            this.txtTim.TabIndex = 23;
            // 
            // radTimma
            // 
            this.radTimma.AutoSize = true;
            this.radTimma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radTimma.Location = new System.Drawing.Point(209, 373);
            this.radTimma.Name = "radTimma";
            this.radTimma.Size = new System.Drawing.Size(68, 17);
            this.radTimma.TabIndex = 21;
            this.radTimma.Text = "Theo Mã";
            this.radTimma.UseVisualStyleBackColor = true;
            this.radTimma.CheckedChanged += new System.EventHandler(this.radTimma_CheckedChanged);
            // 
            // radTimten
            // 
            this.radTimten.AutoSize = true;
            this.radTimten.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radTimten.Location = new System.Drawing.Point(209, 322);
            this.radTimten.Name = "radTimten";
            this.radTimten.Size = new System.Drawing.Size(89, 17);
            this.radTimten.TabIndex = 20;
            this.radTimten.Text = "Theo Họ Tên";
            this.radTimten.UseVisualStyleBackColor = true;
            this.radTimten.CheckedChanged += new System.EventHandler(this.radTimten_CheckedChanged);
            // 
            // cboCV
            // 
            this.cboCV.FormattingEnabled = true;
            this.cboCV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboCV.Items.AddRange(new object[] {
            "NhanVien",
            "QuanLy"});
            this.cboCV.Location = new System.Drawing.Point(147, 142);
            this.cboCV.Name = "cboCV";
            this.cboCV.Size = new System.Drawing.Size(201, 21);
            this.cboCV.TabIndex = 11;
            // 
            // dtpNS
            // 
            this.dtpNS.Location = new System.Drawing.Point(146, 195);
            this.dtpNS.Name = "dtpNS";
            this.dtpNS.Size = new System.Drawing.Size(202, 20);
            this.dtpNS.TabIndex = 15;
            // 
            // radnu
            // 
            this.radnu.AutoSize = true;
            this.radnu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radnu.Location = new System.Drawing.Point(622, 150);
            this.radnu.Name = "radnu";
            this.radnu.Size = new System.Drawing.Size(39, 17);
            this.radnu.TabIndex = 14;
            this.radnu.Text = "Nữ";
            this.radnu.UseVisualStyleBackColor = true;
            // 
            // radnam
            // 
            this.radnam.AutoSize = true;
            this.radnam.Checked = true;
            this.radnam.ForeColor = System.Drawing.Color.Black;
            this.radnam.Location = new System.Drawing.Point(521, 150);
            this.radnam.Name = "radnam";
            this.radnam.Size = new System.Drawing.Size(47, 17);
            this.radnam.TabIndex = 13;
            this.radnam.TabStop = true;
            this.radnam.Text = "Nam";
            this.radnam.UseVisualStyleBackColor = true;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSDT.Location = new System.Drawing.Point(432, 92);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(29, 13);
            this.lblSDT.TabIndex = 168;
            this.lblSDT.Text = "SDT";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCMND.Location = new System.Drawing.Point(432, 36);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(39, 13);
            this.lblCMND.TabIndex = 167;
            this.lblCMND.Text = "CMND";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGioiTinh.Location = new System.Drawing.Point(432, 150);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(47, 13);
            this.lblGioiTinh.TabIndex = 12;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblNS
            // 
            this.lblNS.AutoSize = true;
            this.lblNS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNS.Location = new System.Drawing.Point(27, 195);
            this.lblNS.Name = "lblNS";
            this.lblNS.Size = new System.Drawing.Size(56, 13);
            this.lblNS.TabIndex = 165;
            this.lblNS.Text = "Ngày Sinh";
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblten.Location = new System.Drawing.Point(27, 86);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(59, 13);
            this.lblten.TabIndex = 160;
            this.lblten.Text = "Ho Và Tên";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(521, 33);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(202, 20);
            this.txtCMND.TabIndex = 8;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(521, 92);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(202, 20);
            this.txtSdt.TabIndex = 10;
            // 
            // txtmanv
            // 
            this.txtmanv.Enabled = false;
            this.txtmanv.Location = new System.Drawing.Point(147, 36);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.ReadOnly = true;
            this.txtmanv.Size = new System.Drawing.Size(201, 20);
            this.txtmanv.TabIndex = 7;
            // 
            // lblCV
            // 
            this.lblCV.AutoSize = true;
            this.lblCV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCV.Location = new System.Drawing.Point(27, 142);
            this.lblCV.Name = "lblCV";
            this.lblCV.Size = new System.Drawing.Size(48, 13);
            this.lblCV.TabIndex = 164;
            this.lblCV.Text = "Chức Vụ";
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
          
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(665, 269);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(98, 37);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTim
            // 
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(738, 340);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(87, 32);
            this.btnTim.TabIndex = 24;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
       
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(521, 269);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 37);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
          
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(330, 269);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 37);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
       
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(147, 269);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 37);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblManv
            // 
            this.lblManv.AutoSize = true;
            this.lblManv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblManv.Location = new System.Drawing.Point(28, 40);
            this.lblManv.Name = "lblManv";
            this.lblManv.Size = new System.Drawing.Size(39, 13);
            this.lblManv.TabIndex = 186;
            this.lblManv.Text = "Ma Nv";
            // 
            // ucCrtQuanLyNv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblManv);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lvwDanhSachNhanVien);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.lblTim);
            this.Controls.Add(this.lblTieuchi);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.radTimma);
            this.Controls.Add(this.radTimten);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboCV);
            this.Controls.Add(this.dtpNS);
            this.Controls.Add(this.radnu);
            this.Controls.Add(this.radnam);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblNS);
            this.Controls.Add(this.lblten);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.lblCV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucCrtQuanLyNv";
            this.Size = new System.Drawing.Size(844, 709);
            this.Load += new System.EventHandler(this.ucCrtQuanLyNv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ListView lvwDanhSachNhanVien;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.Label lblTieuchi;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.RadioButton radTimma;
        private System.Windows.Forms.RadioButton radTimten;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboCV;
        private System.Windows.Forms.DateTimePicker dtpNS;
        private System.Windows.Forms.RadioButton radnu;
        private System.Windows.Forms.RadioButton radnam;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNS;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label lblCV;
        private System.Windows.Forms.Label lblManv;
    }
}
