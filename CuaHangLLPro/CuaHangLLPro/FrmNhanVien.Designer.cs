
namespace CuaHangLLPro
{
    partial class FrmNhanVien
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
            this.lblmanv = new System.Windows.Forms.Label();
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
            this.label11 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwDanhSachNhanVien
            // 
            this.lvwDanhSachNhanVien.Location = new System.Drawing.Point(41, 427);
            this.lvwDanhSachNhanVien.Name = "lvwDanhSachNhanVien";
            this.lvwDanhSachNhanVien.Size = new System.Drawing.Size(812, 252);
            this.lvwDanhSachNhanVien.TabIndex = 158;
            this.lvwDanhSachNhanVien.UseCompatibleStateImageBehavior = false;
            this.lvwDanhSachNhanVien.SelectedIndexChanged += new System.EventHandler(this.lvwDanhSachNhanVien_SelectedIndexChanged);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(157, 98);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(201, 26);
            this.txtTen.TabIndex = 157;
            // 
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTim.Location = new System.Drawing.Point(351, 362);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(194, 20);
            this.lblTim.TabIndex = 155;
            this.lblTim.Text = "Nhập Thông Tin Muốn Tìm";
            // 
            // lblTieuchi
            // 
            this.lblTieuchi.AutoSize = true;
            this.lblTieuchi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTieuchi.Location = new System.Drawing.Point(37, 365);
            this.lblTieuchi.Name = "lblTieuchi";
            this.lblTieuchi.Size = new System.Drawing.Size(166, 20);
            this.lblTieuchi.TabIndex = 154;
            this.lblTieuchi.Text = "Các Tiêu Chí Tìm Kiếm";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(564, 356);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(181, 26);
            this.txtTim.TabIndex = 153;
            // 
            // radTimma
            // 
            this.radTimma.AutoSize = true;
            this.radTimma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radTimma.Location = new System.Drawing.Point(219, 385);
            this.radTimma.Name = "radTimma";
            this.radTimma.Size = new System.Drawing.Size(89, 24);
            this.radTimma.TabIndex = 152;
            this.radTimma.Text = "Theo Mã";
            this.radTimma.UseVisualStyleBackColor = true;
            this.radTimma.CheckedChanged += new System.EventHandler(this.radTimma_CheckedChanged);
            // 
            // radTimten
            // 
            this.radTimten.AutoSize = true;
            this.radTimten.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radTimten.Location = new System.Drawing.Point(219, 334);
            this.radTimten.Name = "radTimten";
            this.radTimten.Size = new System.Drawing.Size(119, 24);
            this.radTimten.TabIndex = 151;
            this.radTimten.Text = "Theo Họ Tên";
            this.radTimten.UseVisualStyleBackColor = true;
            this.radTimten.CheckedChanged += new System.EventHandler(this.radTimten_CheckedChanged);
            // 
            // lblmanv
            // 
            this.lblmanv.AutoSize = true;
            this.lblmanv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblmanv.Location = new System.Drawing.Point(37, 48);
            this.lblmanv.Name = "lblmanv";
            this.lblmanv.Size = new System.Drawing.Size(53, 20);
            this.lblmanv.TabIndex = 147;
            this.lblmanv.Text = "MaNV";
            // 
            // cboCV
            // 
            this.cboCV.FormattingEnabled = true;
            this.cboCV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboCV.Items.AddRange(new object[] {
            "NhanVien",
            "QuanLy"});
            this.cboCV.Location = new System.Drawing.Point(157, 154);
            this.cboCV.Name = "cboCV";
            this.cboCV.Size = new System.Drawing.Size(201, 28);
            this.cboCV.TabIndex = 146;
            // 
            // dtpNS
            // 
            this.dtpNS.Location = new System.Drawing.Point(156, 207);
            this.dtpNS.Name = "dtpNS";
            this.dtpNS.Size = new System.Drawing.Size(202, 26);
            this.dtpNS.TabIndex = 145;
            // 
            // radnu
            // 
            this.radnu.AutoSize = true;
            this.radnu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radnu.Location = new System.Drawing.Point(632, 162);
            this.radnu.Name = "radnu";
            this.radnu.Size = new System.Drawing.Size(47, 24);
            this.radnu.TabIndex = 144;
            this.radnu.Text = "Nữ";
            this.radnu.UseVisualStyleBackColor = true;
            // 
            // radnam
            // 
            this.radnam.AutoSize = true;
            this.radnam.Checked = true;
            this.radnam.ForeColor = System.Drawing.Color.White;
            this.radnam.Location = new System.Drawing.Point(531, 162);
            this.radnam.Name = "radnam";
            this.radnam.Size = new System.Drawing.Size(60, 24);
            this.radnam.TabIndex = 143;
            this.radnam.TabStop = true;
            this.radnam.Text = "Nam";
            this.radnam.UseVisualStyleBackColor = true;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSDT.Location = new System.Drawing.Point(442, 104);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(41, 20);
            this.lblSDT.TabIndex = 142;
            this.lblSDT.Text = "SDT";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCMND.Location = new System.Drawing.Point(442, 48);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(56, 20);
            this.lblCMND.TabIndex = 140;
            this.lblCMND.Text = "CMND";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGioiTinh.Location = new System.Drawing.Point(442, 162);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(67, 20);
            this.lblGioiTinh.TabIndex = 139;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblNS
            // 
            this.lblNS.AutoSize = true;
            this.lblNS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNS.Location = new System.Drawing.Point(37, 207);
            this.lblNS.Name = "lblNS";
            this.lblNS.Size = new System.Drawing.Size(81, 20);
            this.lblNS.TabIndex = 138;
            this.lblNS.Text = "Ngày Sinh";
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblten.Location = new System.Drawing.Point(37, 98);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(85, 20);
            this.lblten.TabIndex = 132;
            this.lblten.Text = "Ho Và Tên";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(531, 45);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(202, 26);
            this.txtCMND.TabIndex = 136;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(531, 104);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(202, 26);
            this.txtSdt.TabIndex = 134;
            // 
            // txtmanv
            // 
            this.txtmanv.Enabled = false;
            this.txtmanv.Location = new System.Drawing.Point(157, 48);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.ReadOnly = true;
            this.txtmanv.Size = new System.Drawing.Size(201, 26);
            this.txtmanv.TabIndex = 133;
            // 
            // lblCV
            // 
            this.lblCV.AutoSize = true;
            this.lblCV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCV.Location = new System.Drawing.Point(37, 154);
            this.lblCV.Name = "lblCV";
            this.lblCV.Size = new System.Drawing.Size(70, 20);
            this.lblCV.TabIndex = 137;
            this.lblCV.Text = "Chức Vụ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(4, -82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 20);
            this.label11.TabIndex = 130;
            this.label11.Text = "Giao Diện Quản Lý Nhân Viên";
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLuu.Image = global::CuaHangLLPro.Properties.Resources.icons8_add_user_group_man_man_30px;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(675, 281);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(98, 37);
            this.btnLuu.TabIndex = 159;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTim
            // 
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTim.Image = global::CuaHangLLPro.Properties.Resources.icons8_find_user_male_skin_type_7_30px;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(766, 350);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(87, 32);
            this.btnTim.TabIndex = 156;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoa.Image = global::CuaHangLLPro.Properties.Resources.icons8_waste_30px_1;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(531, 281);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 37);
            this.btnXoa.TabIndex = 150;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSua.Image = global::CuaHangLLPro.Properties.Resources.icons8_support_30px;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(340, 281);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 37);
            this.btnSua.TabIndex = 149;
            this.btnSua.Text = "Sữa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThem.Image = global::CuaHangLLPro.Properties.Resources.icons8_add_user_group_man_man_30px;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(157, 281);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 37);
            this.btnThem.TabIndex = 148;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
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
            this.Controls.Add(this.lblmanv);
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
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmNhanVien";
            this.Size = new System.Drawing.Size(871, 701);
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label lblmanv;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLuu;
    }
}
