
namespace CuaHangLLPro
{
    partial class frmDangNhap
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
            this.components = new System.ComponentModel.Container();
            this.btnDn = new MetroSet_UI.Controls.MetroSetButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxMk = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDn
            // 
            this.btnDn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDn.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnDn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDn.HoverTextColor = System.Drawing.Color.White;
            this.btnDn.IsDerivedStyle = true;
            this.btnDn.Location = new System.Drawing.Point(53, 304);
            this.btnDn.Name = "btnDn";
            this.btnDn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDn.NormalTextColor = System.Drawing.Color.White;
            this.btnDn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDn.PressTextColor = System.Drawing.Color.White;
            this.btnDn.Size = new System.Drawing.Size(250, 30);
            this.btnDn.Style = MetroSet_UI.Enums.Style.Light;
            this.btnDn.StyleManager = null;
            this.btnDn.TabIndex = 0;
            this.btnDn.Text = "Đăng nhập";
            this.btnDn.ThemeAuthor = "Narwin";
            this.btnDn.ThemeName = "MetroLite";
            this.btnDn.Click += new System.EventHandler(this.btnDn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.panel1.Location = new System.Drawing.Point(53, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 2);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.panel2.Location = new System.Drawing.Point(0, -8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 2);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.panel3.Location = new System.Drawing.Point(53, 257);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 2);
            this.panel3.TabIndex = 9;
            // 
            // txtMa
            // 
            this.txtMa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMa.Location = new System.Drawing.Point(95, 151);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(208, 20);
            this.txtMa.TabIndex = 10;
            this.txtMa.Text = "QLM04";
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // txtMk
            // 
            this.txtMk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMk.Location = new System.Drawing.Point(90, 231);
            this.txtMk.Name = "txtMk";
            this.txtMk.Size = new System.Drawing.Size(208, 20);
            this.txtMk.TabIndex = 11;
            this.txtMk.Text = "aa123";
            this.txtMk.TextChanged += new System.EventHandler(this.txtMk_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::CuaHangLLPro.Properties.Resources.user1;
            this.label2.Location = new System.Drawing.Point(54, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 40);
            this.label2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::CuaHangLLPro.Properties.Resources.padlock__2_;
            this.label1.Location = new System.Drawing.Point(49, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 40);
            this.label1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.label3.Location = new System.Drawing.Point(205, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quên mật khẩu?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkBoxMk
            // 
            this.checkBoxMk.AutoSize = true;
            this.checkBoxMk.BackColor = System.Drawing.Color.White;
            this.checkBoxMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkBoxMk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.checkBoxMk.Location = new System.Drawing.Point(53, 285);
            this.checkBoxMk.Name = "checkBoxMk";
            this.checkBoxMk.Size = new System.Drawing.Size(109, 19);
            this.checkBoxMk.TabIndex = 15;
            this.checkBoxMk.Text = "Hiện mật khẩu.";
            this.checkBoxMk.UseVisualStyleBackColor = false;
            this.checkBoxMk.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 410);
            this.Controls.Add(this.checkBoxMk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMk);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDn);
            this.Name = "frmDangNhap";
            this.Style = MetroSet_UI.Enums.Style.Custom;
            this.Text = "Đăng nhập";
            this.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetButton btnDn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxMk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}