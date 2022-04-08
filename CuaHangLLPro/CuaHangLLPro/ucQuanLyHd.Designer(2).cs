
namespace CuaHangLLPro
{
    partial class ucQuanLyHd
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
            this.tabQlHoaDon = new MetroFramework.Controls.MetroTabControl();
            this.tabPageDsHoaDon = new MetroFramework.Controls.MetroTabPage();
            this.lvwDsHoaDon = new MetroFramework.Controls.MetroListView();
            this.MaHd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenKh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenNv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtTim = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetComboBox1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tabPageLapHoaDon = new MetroFramework.Controls.MetroTabPage();
            this.tabQlHoaDon.SuspendLayout();
            this.tabPageDsHoaDon.SuspendLayout();
            this.metroSetPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabQlHoaDon
            // 
            this.tabQlHoaDon.Controls.Add(this.tabPageDsHoaDon);
            this.tabQlHoaDon.Controls.Add(this.tabPageLapHoaDon);
            this.tabQlHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabQlHoaDon.Location = new System.Drawing.Point(0, 0);
            this.tabQlHoaDon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabQlHoaDon.Name = "tabQlHoaDon";
            this.tabQlHoaDon.SelectedIndex = 0;
            this.tabQlHoaDon.Size = new System.Drawing.Size(868, 701);
            this.tabQlHoaDon.TabIndex = 0;
            this.tabQlHoaDon.UseSelectable = true;
            // 
            // tabPageDsHoaDon
            // 
            this.tabPageDsHoaDon.Controls.Add(this.lvwDsHoaDon);
            this.tabPageDsHoaDon.Controls.Add(this.metroSetPanel1);
            this.tabPageDsHoaDon.HorizontalScrollbarBarColor = true;
            this.tabPageDsHoaDon.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageDsHoaDon.HorizontalScrollbarSize = 8;
            this.tabPageDsHoaDon.Location = new System.Drawing.Point(4, 38);
            this.tabPageDsHoaDon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageDsHoaDon.Name = "tabPageDsHoaDon";
            this.tabPageDsHoaDon.Size = new System.Drawing.Size(860, 659);
            this.tabPageDsHoaDon.TabIndex = 0;
            this.tabPageDsHoaDon.Text = "Danh sách hóa đơn     ";
            this.tabPageDsHoaDon.VerticalScrollbarBarColor = true;
            this.tabPageDsHoaDon.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageDsHoaDon.VerticalScrollbarSize = 8;
            // 
            // lvwDsHoaDon
            // 
            this.lvwDsHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaHd,
            this.TenKh,
            this.TenNv,
            this.ngay,
            this.gia});
            this.lvwDsHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwDsHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvwDsHoaDon.FullRowSelect = true;
            this.lvwDsHoaDon.Location = new System.Drawing.Point(0, 81);
            this.lvwDsHoaDon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvwDsHoaDon.Name = "lvwDsHoaDon";
            this.lvwDsHoaDon.OwnerDraw = true;
            this.lvwDsHoaDon.Size = new System.Drawing.Size(860, 578);
            this.lvwDsHoaDon.TabIndex = 3;
            this.lvwDsHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvwDsHoaDon.UseSelectable = true;
            this.lvwDsHoaDon.View = System.Windows.Forms.View.Details;
            this.lvwDsHoaDon.SelectedIndexChanged += new System.EventHandler(this.lvwDsHoaDon_SelectedIndexChanged);
            // 
            // MaHd
            // 
            this.MaHd.Text = "Mã hóa đơn";
            this.MaHd.Width = 117;
            // 
            // TenKh
            // 
            this.TenKh.Text = "Tên khách hàng";
            this.TenKh.Width = 141;
            // 
            // TenNv
            // 
            this.TenNv.Text = "Tên nhân viên ";
            this.TenNv.Width = 142;
            // 
            // ngay
            // 
            this.ngay.Text = "Ngày lập hóa đơn";
            this.ngay.Width = 163;
            // 
            // gia
            // 
            this.gia.Text = "Thành tiền";
            this.gia.Width = 100;
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Controls.Add(this.metroLabel3);
            this.metroSetPanel1.Controls.Add(this.txtTim);
            this.metroSetPanel1.Controls.Add(this.metroSetComboBox1);
            this.metroSetPanel1.Controls.Add(this.metroLabel2);
            this.metroSetPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroSetPanel1.IsDerivedStyle = true;
            this.metroSetPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroSetPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(860, 81);
            this.metroSetPanel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 2;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroLite";
            // 
            // metroLabel3
            // 
            this.metroLabel3.BackColor = System.Drawing.Color.White;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.ForeColor = System.Drawing.Color.Transparent;
            this.metroLabel3.Location = new System.Drawing.Point(197, 16);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 23);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Nhập:";
            // 
            // txtTim
            // 
            this.txtTim.AutoCompleteCustomSource = null;
            this.txtTim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTim.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTim.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTim.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTim.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTim.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTim.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtTim.Image = null;
            this.txtTim.IsDerivedStyle = true;
            this.txtTim.Lines = null;
            this.txtTim.Location = new System.Drawing.Point(197, 41);
            this.txtTim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTim.MaxLength = 32767;
            this.txtTim.Multiline = false;
            this.txtTim.Name = "txtTim";
            this.txtTim.ReadOnly = false;
            this.txtTim.Size = new System.Drawing.Size(174, 24);
            this.txtTim.Style = MetroSet_UI.Enums.Style.Light;
            this.txtTim.StyleManager = null;
            this.txtTim.TabIndex = 16;
            this.txtTim.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTim.ThemeAuthor = "Narwin";
            this.txtTim.ThemeName = "MetroLite";
            this.txtTim.UseSystemPasswordChar = false;
            this.txtTim.WatermarkText = "";
            // 
            // metroSetComboBox1
            // 
            this.metroSetComboBox1.AllowDrop = true;
            this.metroSetComboBox1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox1.CausesValidation = false;
            this.metroSetComboBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetComboBox1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetComboBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox1.FormattingEnabled = true;
            this.metroSetComboBox1.IsDerivedStyle = true;
            this.metroSetComboBox1.ItemHeight = 20;
            this.metroSetComboBox1.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Mã hóa đơn",
            "Ngày lập hóa đơn",
            "Mã khách hàng"});
            this.metroSetComboBox1.Location = new System.Drawing.Point(10, 44);
            this.metroSetComboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroSetComboBox1.Name = "metroSetComboBox1";
            this.metroSetComboBox1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox1.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox1.Size = new System.Drawing.Size(128, 26);
            this.metroSetComboBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetComboBox1.StyleManager = null;
            this.metroSetComboBox1.TabIndex = 15;
            this.metroSetComboBox1.ThemeAuthor = "Narwin";
            this.metroSetComboBox1.ThemeName = "MetroLite";
            // 
            // metroLabel2
            // 
            this.metroLabel2.BackColor = System.Drawing.Color.White;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(10, 16);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 23);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Tìm theo: ";
            // 
            // tabPageLapHoaDon
            // 
            this.tabPageLapHoaDon.HorizontalScrollbarBarColor = true;
            this.tabPageLapHoaDon.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageLapHoaDon.HorizontalScrollbarSize = 8;
            this.tabPageLapHoaDon.Location = new System.Drawing.Point(4, 38);
            this.tabPageLapHoaDon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageLapHoaDon.Name = "tabPageLapHoaDon";
            this.tabPageLapHoaDon.Size = new System.Drawing.Size(860, 659);
            this.tabPageLapHoaDon.TabIndex = 1;
            this.tabPageLapHoaDon.Text = "Lập hóa đơn    ";
            this.tabPageLapHoaDon.VerticalScrollbarBarColor = true;
            this.tabPageLapHoaDon.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageLapHoaDon.VerticalScrollbarSize = 8;
            // 
            // ucQuanLyHd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabQlHoaDon);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ucQuanLyHd";
            this.Size = new System.Drawing.Size(868, 701);
            this.Load += new System.EventHandler(this.ucQuanLyHd_Load);
            this.tabQlHoaDon.ResumeLayout(false);
            this.tabPageDsHoaDon.ResumeLayout(false);
            this.metroSetPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabQlHoaDon;
        private MetroFramework.Controls.MetroTabPage tabPageDsHoaDon;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private MetroFramework.Controls.MetroTabPage tabPageLapHoaDon;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroSet_UI.Controls.MetroSetTextBox txtTim;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroListView lvwDsHoaDon;
        private System.Windows.Forms.ColumnHeader MaHd;
        private System.Windows.Forms.ColumnHeader TenKh;
        private System.Windows.Forms.ColumnHeader TenNv;
        private System.Windows.Forms.ColumnHeader ngay;
        private System.Windows.Forms.ColumnHeader gia;
    }
}
