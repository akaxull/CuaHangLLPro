
namespace CuaHangLLPro
{
    partial class FrmKhachHang
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
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblten = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblgioitinh = new System.Windows.Forms.Label();
            this.lvwDanhSachKhachHang = new System.Windows.Forms.ListView();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.radnam = new System.Windows.Forms.RadioButton();
            this.radnu = new System.Windows.Forms.RadioButton();
            this.lblmakh = new System.Windows.Forms.Label();
            this.lbltimma = new System.Windows.Forms.Label();
            this.btnGiam = new System.Windows.Forms.Button();
            this.btnSapXepTang = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(179, 110);
            this.txtma.Name = "txtma";
            this.txtma.ReadOnly = true;
            this.txtma.Size = new System.Drawing.Size(241, 26);
            this.txtma.TabIndex = 0;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(179, 190);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(241, 26);
            this.txtTen.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(639, 113);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(228, 26);
            this.txtSDT.TabIndex = 2;
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblten.Location = new System.Drawing.Point(46, 196);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(120, 20);
            this.lblten.TabIndex = 5;
            this.lblten.Text = "TênKháchHàng";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSDT.Location = new System.Drawing.Point(511, 116);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(109, 20);
            this.lblSDT.TabIndex = 6;
            this.lblSDT.Text = "Số Điện Thoại";
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.AutoSize = true;
            this.lblgioitinh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblgioitinh.Location = new System.Drawing.Point(511, 196);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(71, 20);
            this.lblgioitinh.TabIndex = 7;
            this.lblgioitinh.Text = "Giới Tính";
            // 
            // lvwDanhSachKhachHang
            // 
            this.lvwDanhSachKhachHang.Location = new System.Drawing.Point(12, 399);
            this.lvwDanhSachKhachHang.Name = "lvwDanhSachKhachHang";
            this.lvwDanhSachKhachHang.Size = new System.Drawing.Size(868, 280);
            this.lvwDanhSachKhachHang.TabIndex = 8;
            this.lvwDanhSachKhachHang.UseCompatibleStateImageBehavior = false;
            this.lvwDanhSachKhachHang.SelectedIndexChanged += new System.EventHandler(this.lvwDanhSachKhachHang_SelectedIndexChanged);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(228, 38);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(374, 26);
            this.txtTim.TabIndex = 161;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // radnam
            // 
            this.radnam.AutoSize = true;
            this.radnam.Checked = true;
            this.radnam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radnam.Location = new System.Drawing.Point(639, 202);
            this.radnam.Name = "radnam";
            this.radnam.Size = new System.Drawing.Size(60, 24);
            this.radnam.TabIndex = 163;
            this.radnam.TabStop = true;
            this.radnam.Text = "Nam";
            this.radnam.UseVisualStyleBackColor = true;
            this.radnam.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radnu
            // 
            this.radnu.AutoSize = true;
            this.radnu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radnu.Location = new System.Drawing.Point(761, 202);
            this.radnu.Name = "radnu";
            this.radnu.Size = new System.Drawing.Size(47, 24);
            this.radnu.TabIndex = 164;
            this.radnu.Text = "Nữ";
            this.radnu.UseVisualStyleBackColor = true;
            // 
            // lblmakh
            // 
            this.lblmakh.AutoSize = true;
            this.lblmakh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblmakh.Location = new System.Drawing.Point(46, 110);
            this.lblmakh.Name = "lblmakh";
            this.lblmakh.Size = new System.Drawing.Size(115, 20);
            this.lblmakh.TabIndex = 165;
            this.lblmakh.Text = "MãKháchHàng";
            // 
            // lbltimma
            // 
            this.lbltimma.AutoSize = true;
            this.lbltimma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbltimma.Location = new System.Drawing.Point(85, 44);
            this.lbltimma.Name = "lbltimma";
            this.lbltimma.Size = new System.Drawing.Size(115, 20);
            this.lbltimma.TabIndex = 166;
            this.lbltimma.Text = "MãKháchHàng";
            // 
            // btnGiam
            // 
            this.btnGiam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiam.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGiam.Image = global::CuaHangLLPro.Properties.Resources.icons8_sort_right_30px1;
            this.btnGiam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiam.Location = new System.Drawing.Point(705, 292);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(175, 37);
            this.btnGiam.TabIndex = 168;
            this.btnGiam.Text = "Giảm Theo Tên";
            this.btnGiam.UseVisualStyleBackColor = true;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // btnSapXepTang
            // 
            this.btnSapXepTang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSapXepTang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSapXepTang.Image = global::CuaHangLLPro.Properties.Resources.icons8_sort_right_30px;
            this.btnSapXepTang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSapXepTang.Location = new System.Drawing.Point(515, 290);
            this.btnSapXepTang.Name = "btnSapXepTang";
            this.btnSapXepTang.Size = new System.Drawing.Size(169, 40);
            this.btnSapXepTang.TabIndex = 167;
            this.btnSapXepTang.Text = "Tăng Theo Tên";
            this.btnSapXepTang.UseVisualStyleBackColor = true;
            this.btnSapXepTang.Click += new System.EventHandler(this.btnSapXepTang_Click);
            // 
            // btnTim
            // 
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTim.Image = global::CuaHangLLPro.Properties.Resources.icons8_find_user_male_skin_type_7_30px;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(643, 38);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(87, 32);
            this.btnTim.TabIndex = 162;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLuu.Image = global::CuaHangLLPro.Properties.Resources.icons8_add_user_group_man_man_30px;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(384, 292);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(98, 37);
            this.btnLuu.TabIndex = 160;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSua.Image = global::CuaHangLLPro.Properties.Resources.icons8_support_30px;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(228, 292);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 37);
            this.btnSua.TabIndex = 150;
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
            this.btnThem.Location = new System.Drawing.Point(77, 292);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 37);
            this.btnThem.TabIndex = 149;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.btnGiam);
            this.Controls.Add(this.btnSapXepTang);
            this.Controls.Add(this.lbltimma);
            this.Controls.Add(this.lblmakh);
            this.Controls.Add(this.radnu);
            this.Controls.Add(this.radnam);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lvwDanhSachKhachHang);
            this.Controls.Add(this.lblgioitinh);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblten);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtma);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmKhachHang";
            this.Size = new System.Drawing.Size(908, 701);
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblgioitinh;
        private System.Windows.Forms.ListView lvwDanhSachKhachHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.RadioButton radnam;
        private System.Windows.Forms.RadioButton radnu;
        private System.Windows.Forms.Label lblmakh;
        private System.Windows.Forms.Label lbltimma;
        private System.Windows.Forms.Button btnSapXepTang;
        private System.Windows.Forms.Button btnGiam;
    }
}
