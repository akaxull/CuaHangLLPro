
namespace CuaHangLLPro
{
    partial class uCrtSach
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uCrtSach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxTim = new MetroSet_UI.Controls.MetroSetComboBox();
            this.lvwS = new System.Windows.Forms.ListView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.customButton3 = new CuaHangLLPro.Resources.CustomControl.CustomButton();
            this.btnSua = new CuaHangLLPro.Resources.CustomControl.CustomButton();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new CuaHangLLPro.Resources.CustomControl.CustomButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnThemSach = new CuaHangLLPro.Resources.CustomControl.CustomButton();
            this.btnXoaSach = new CuaHangLLPro.Resources.CustomControl.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radTt = new MetroFramework.Controls.MetroCheckBox();
            this.radVhNt = new MetroFramework.Controls.MetroCheckBox();
            this.radCtPL = new MetroFramework.Controls.MetroCheckBox();
            this.radGt = new MetroFramework.Controls.MetroCheckBox();
            this.radTn = new MetroFramework.Controls.MetroCheckBox();
            this.radVhLs = new MetroFramework.Controls.MetroCheckBox();
            this.radKhcn = new MetroFramework.Controls.MetroCheckBox();
            this.radTlTg = new MetroFramework.Controls.MetroCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radCon = new MetroFramework.Controls.MetroRadioButton();
            this.radHet = new MetroFramework.Controls.MetroRadioButton();
            this.radNgungKinhDoanh = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.qlCuaHangDataSet1 = new CuaHangLLPro.QLCuaHangDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlCuaHangDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1395, 0);
            this.panel1.TabIndex = 0;
            // 
            // cbxTim
            // 
            this.cbxTim.AllowDrop = true;
            this.cbxTim.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbxTim.BackColor = System.Drawing.Color.Transparent;
            this.cbxTim.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbxTim.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbxTim.CausesValidation = false;
            this.cbxTim.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbxTim.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cbxTim.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cbxTim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbxTim.FormattingEnabled = true;
            this.cbxTim.IsDerivedStyle = true;
            this.cbxTim.ItemHeight = 20;
            this.cbxTim.Items.AddRange(new object[] {
            "Tên sách",
            "Tên tác giả",
            "Mã Sách",
            "Nhà xuất bản"});
            this.cbxTim.Location = new System.Drawing.Point(1, 64);
            this.cbxTim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxTim.Name = "cbxTim";
            this.cbxTim.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbxTim.SelectedItemForeColor = System.Drawing.Color.White;
            this.cbxTim.Size = new System.Drawing.Size(125, 26);
            this.cbxTim.Style = MetroSet_UI.Enums.Style.Light;
            this.cbxTim.StyleManager = null;
            this.cbxTim.TabIndex = 162;
            this.cbxTim.ThemeAuthor = "Narwin";
            this.cbxTim.ThemeName = "MetroLite";
            this.cbxTim.SelectedIndexChanged += new System.EventHandler(this.cbxTim_SelectedIndexChanged);
            // 
            // lvwS
            // 
            this.lvwS.Font = new System.Drawing.Font("Bahnschrift", 13F);
            this.lvwS.HideSelection = false;
            this.lvwS.Location = new System.Drawing.Point(229, 139);
            this.lvwS.Name = "lvwS";
            this.lvwS.Size = new System.Drawing.Size(1126, 553);
            this.lvwS.TabIndex = 2;
            this.lvwS.UseCompatibleStateImageBehavior = false;
            this.lvwS.SelectedIndexChanged += new System.EventHandler(this.lvwS_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.customButton3);
            this.panel.Controls.Add(this.btnSua);
            this.panel.Controls.Add(this.txtTim);
            this.panel.Controls.Add(this.btnTim);
            this.panel.Controls.Add(this.cbxTim);
            this.panel.Controls.Add(this.panel10);
            this.panel.Controls.Add(this.btnThemSach);
            this.panel.Controls.Add(this.btnXoaSach);
            this.panel.Controls.Add(this.label2);
            this.panel.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.panel.Location = new System.Drawing.Point(229, 14);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1126, 118);
            this.panel.TabIndex = 261;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.customButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.customButton3.BoderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.customButton3.BoderRadius = 40;
            this.customButton3.BoderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Image = ((System.Drawing.Image)(resources.GetObject("customButton3.Image")));
            this.customButton3.Location = new System.Drawing.Point(792, 53);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(96, 40);
            this.customButton3.TabIndex = 282;
            this.customButton3.TextColor = System.Drawing.Color.White;
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.btnSua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.btnSua.BoderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.btnSua.BoderRadius = 40;
            this.btnSua.BoderSize = 0;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(1030, 53);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 40);
            this.btnSua.TabIndex = 281;
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // txtTim
            // 
            this.txtTim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTim.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtTim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTim.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTim.Location = new System.Drawing.Point(145, 64);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(332, 26);
            this.txtTim.TabIndex = 277;
            this.txtTim.Text = "Nhập mã sách";
            this.txtTim.Enter += new System.EventHandler(this.txtTim_Enter);
            this.txtTim.Leave += new System.EventHandler(this.txtTim_Leave);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.btnTim.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.btnTim.BoderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.btnTim.BoderRadius = 40;
            this.btnTim.BoderSize = 0;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(483, 50);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(47, 40);
            this.btnTim.TabIndex = 274;
            this.btnTim.TextColor = System.Drawing.Color.White;
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.panel10.Location = new System.Drawing.Point(-1, 96);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(531, 2);
            this.panel10.TabIndex = 278;
            // 
            // btnThemSach
            // 
            this.btnThemSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.btnThemSach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.btnThemSach.BoderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.btnThemSach.BoderRadius = 40;
            this.btnThemSach.BoderSize = 0;
            this.btnThemSach.FlatAppearance.BorderSize = 0;
            this.btnThemSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSach.ForeColor = System.Drawing.Color.White;
            this.btnThemSach.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSach.Image")));
            this.btnThemSach.Location = new System.Drawing.Point(673, 53);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(96, 40);
            this.btnThemSach.TabIndex = 276;
            this.btnThemSach.TextColor = System.Drawing.Color.White;
            this.btnThemSach.UseVisualStyleBackColor = false;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.btnXoaSach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.btnXoaSach.BoderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.btnXoaSach.BoderRadius = 40;
            this.btnXoaSach.BoderSize = 0;
            this.btnXoaSach.FlatAppearance.BorderSize = 0;
            this.btnXoaSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSach.ForeColor = System.Drawing.Color.White;
            this.btnXoaSach.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaSach.Image")));
            this.btnXoaSach.Location = new System.Drawing.Point(911, 53);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(96, 40);
            this.btnXoaSach.TabIndex = 275;
            this.btnXoaSach.TextColor = System.Drawing.Color.White;
            this.btnXoaSach.UseVisualStyleBackColor = false;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1126, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "      Thông tin tìm kiếm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radTt
            // 
            this.radTt.AutoSize = true;
            this.radTt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.radTt.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radTt.Location = new System.Drawing.Point(28, 319);
            this.radTt.Name = "radTt";
            this.radTt.Size = new System.Drawing.Size(141, 19);
            this.radTt.TabIndex = 269;
            this.radTt.Text = "Truyện Tiểu Thuyết";
            this.radTt.UseSelectable = true;
            // 
            // radVhNt
            // 
            this.radVhNt.AutoSize = true;
            this.radVhNt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.radVhNt.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radVhNt.Location = new System.Drawing.Point(28, 283);
            this.radVhNt.Name = "radVhNt";
            this.radVhNt.Size = new System.Drawing.Size(146, 19);
            this.radVhNt.TabIndex = 268;
            this.radVhNt.Text = "Văn học nghệ thuật";
            this.radVhNt.UseSelectable = true;
            // 
            // radCtPL
            // 
            this.radCtPL.AutoSize = true;
            this.radCtPL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.radCtPL.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radCtPL.Location = new System.Drawing.Point(28, 103);
            this.radCtPL.Name = "radCtPL";
            this.radCtPL.Size = new System.Drawing.Size(140, 19);
            this.radCtPL.TabIndex = 262;
            this.radCtPL.Text = "Chính trị pháp luật";
            this.radCtPL.UseSelectable = true;
            // 
            // radGt
            // 
            this.radGt.AutoSize = true;
            this.radGt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.radGt.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radGt.Location = new System.Drawing.Point(28, 247);
            this.radGt.Name = "radGt";
            this.radGt.Size = new System.Drawing.Size(87, 19);
            this.radGt.TabIndex = 267;
            this.radGt.Text = "Giáo Trình";
            this.radGt.UseSelectable = true;
            // 
            // radTn
            // 
            this.radTn.AutoSize = true;
            this.radTn.BackColor = System.Drawing.Color.White;
            this.radTn.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radTn.Location = new System.Drawing.Point(28, 67);
            this.radTn.Name = "radTn";
            this.radTn.Size = new System.Drawing.Size(111, 19);
            this.radTn.TabIndex = 263;
            this.radTn.Text = "Sách thiếu nhi";
            this.radTn.UseSelectable = true;
            // 
            // radVhLs
            // 
            this.radVhLs.AutoSize = true;
            this.radVhLs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.radVhLs.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radVhLs.Location = new System.Drawing.Point(28, 139);
            this.radVhLs.Name = "radVhLs";
            this.radVhLs.Size = new System.Drawing.Size(168, 19);
            this.radVhLs.TabIndex = 264;
            this.radVhLs.Text = "Văn hóa xã hội – lịch sử";
            this.radVhLs.UseSelectable = true;
            // 
            // radKhcn
            // 
            this.radKhcn.AutoSize = true;
            this.radKhcn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.radKhcn.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radKhcn.Location = new System.Drawing.Point(28, 211);
            this.radKhcn.Name = "radKhcn";
            this.radKhcn.Size = new System.Drawing.Size(151, 19);
            this.radKhcn.TabIndex = 266;
            this.radKhcn.Text = "Khoa học công nghệ";
            this.radKhcn.UseSelectable = true;
            // 
            // radTlTg
            // 
            this.radTlTg.AutoSize = true;
            this.radTlTg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.radTlTg.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radTlTg.Location = new System.Drawing.Point(28, 175);
            this.radTlTg.Name = "radTlTg";
            this.radTlTg.Size = new System.Drawing.Size(130, 19);
            this.radTlTg.TabIndex = 265;
            this.radTlTg.Text = "Tâm linh tôn giáo";
            this.radTlTg.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 36);
            this.label1.TabIndex = 191;
            this.label1.Text = "      Thể loại";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(27, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 36);
            this.label3.TabIndex = 270;
            this.label3.Text = "      Trạng thái";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radCon
            // 
            this.radCon.AutoSize = true;
            this.radCon.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radCon.Location = new System.Drawing.Point(28, 468);
            this.radCon.Name = "radCon";
            this.radCon.Size = new System.Drawing.Size(85, 19);
            this.radCon.TabIndex = 277;
            this.radCon.Text = "Còn hàng";
            this.radCon.UseSelectable = true;
            this.radCon.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // radHet
            // 
            this.radHet.AutoSize = true;
            this.radHet.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radHet.Location = new System.Drawing.Point(27, 540);
            this.radHet.Name = "radHet";
            this.radHet.Size = new System.Drawing.Size(82, 19);
            this.radHet.TabIndex = 278;
            this.radHet.Text = "Hết hàng";
            this.radHet.UseSelectable = true;
            this.radHet.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // radNgungKinhDoanh
            // 
            this.radNgungKinhDoanh.AutoSize = true;
            this.radNgungKinhDoanh.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radNgungKinhDoanh.Location = new System.Drawing.Point(28, 504);
            this.radNgungKinhDoanh.Name = "radNgungKinhDoanh";
            this.radNgungKinhDoanh.Size = new System.Drawing.Size(140, 19);
            this.radNgungKinhDoanh.TabIndex = 279;
            this.radNgungKinhDoanh.Text = "Ngừng kinh doanh";
            this.radNgungKinhDoanh.UseSelectable = true;
            this.radNgungKinhDoanh.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Checked = true;
            this.metroRadioButton1.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioButton1.Location = new System.Drawing.Point(27, 432);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(131, 19);
            this.metroRadioButton1.TabIndex = 280;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "Đang kinh doanh";
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // qlCuaHangDataSet1
            // 
            this.qlCuaHangDataSet1.DataSetName = "QLCuaHangDataSet";
            this.qlCuaHangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uCrtSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.radNgungKinhDoanh);
            this.Controls.Add(this.radHet);
            this.Controls.Add(this.radCon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radTt);
            this.Controls.Add(this.radVhNt);
            this.Controls.Add(this.radCtPL);
            this.Controls.Add(this.radGt);
            this.Controls.Add(this.radTn);
            this.Controls.Add(this.radVhLs);
            this.Controls.Add(this.radKhcn);
            this.Controls.Add(this.radTlTg);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lvwS);
            this.Controls.Add(this.panel1);
            this.Name = "uCrtSach";
            this.Size = new System.Drawing.Size(1395, 701);
            this.Load += new System.EventHandler(this.uCrtSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlCuaHangDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroSet_UI.Controls.MetroSetComboBox cbxTim;
        public System.Windows.Forms.ListView lvwS;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroCheckBox radTt;
        private MetroFramework.Controls.MetroCheckBox radVhNt;
        private MetroFramework.Controls.MetroCheckBox radCtPL;
        private MetroFramework.Controls.MetroCheckBox radGt;
        private MetroFramework.Controls.MetroCheckBox radVhLs;
        private MetroFramework.Controls.MetroCheckBox radKhcn;
        private MetroFramework.Controls.MetroCheckBox radTlTg;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroCheckBox radTn;
        private System.Windows.Forms.Label label3;
        private Resources.CustomControl.CustomButton btnTim;
        private Resources.CustomControl.CustomButton btnXoaSach;
        private Resources.CustomControl.CustomButton btnThemSach;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtTim;
        private MetroFramework.Controls.MetroRadioButton radNgungKinhDoanh;
        private MetroFramework.Controls.MetroRadioButton radHet;
        private MetroFramework.Controls.MetroRadioButton radCon;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private Resources.CustomControl.CustomButton customButton3;
        private Resources.CustomControl.CustomButton btnSua;
        private QLCuaHangDataSet qlCuaHangDataSet1;
    }
}
