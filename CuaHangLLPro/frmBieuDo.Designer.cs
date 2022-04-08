
namespace CuaHangLLPro
{
    partial class frmBieuDo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBieuDo));
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvwIt = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lvwVua = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lvwNhieu = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvwKo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pieChart1
            // 
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pieChart1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.pieChart1.Location = new System.Drawing.Point(20, 60);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(630, 794);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "h";
            this.pieChart1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.pieChart1_ChildChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvwIt);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.panel3.Location = new System.Drawing.Point(688, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(845, 179);
            this.panel3.TabIndex = 6;
            // 
            // lvwIt
            // 
            this.lvwIt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwIt.FormattingEnabled = true;
            this.lvwIt.ItemHeight = 28;
            this.lvwIt.Location = new System.Drawing.Point(0, 36);
            this.lvwIt.Name = "lvwIt";
            this.lvwIt.Size = new System.Drawing.Size(845, 143);
            this.lvwIt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(845, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "       Ít hơn 30 cuốn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lvwVua);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.panel4.Location = new System.Drawing.Point(688, 432);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(845, 179);
            this.panel4.TabIndex = 7;
            // 
            // lvwVua
            // 
            this.lvwVua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwVua.FormattingEnabled = true;
            this.lvwVua.ItemHeight = 28;
            this.lvwVua.Location = new System.Drawing.Point(0, 36);
            this.lvwVua.Name = "lvwVua";
            this.lvwVua.Size = new System.Drawing.Size(845, 143);
            this.lvwVua.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(6)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(845, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "       Từ 30 đến 70 cuốn";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lvwNhieu);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.panel5.Location = new System.Drawing.Point(688, 618);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(845, 179);
            this.panel5.TabIndex = 8;
            // 
            // lvwNhieu
            // 
            this.lvwNhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwNhieu.FormattingEnabled = true;
            this.lvwNhieu.ItemHeight = 28;
            this.lvwNhieu.Location = new System.Drawing.Point(0, 36);
            this.lvwNhieu.Name = "lvwNhieu";
            this.lvwNhieu.Size = new System.Drawing.Size(845, 143);
            this.lvwNhieu.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(126)))), ((int)(((byte)(137)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(845, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "      Nhiều hơn 70 cuốn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvwKo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.panel1.Location = new System.Drawing.Point(688, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 179);
            this.panel1.TabIndex = 7;
            // 
            // lvwKo
            // 
            this.lvwKo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwKo.FormattingEnabled = true;
            this.lvwKo.ItemHeight = 28;
            this.lvwKo.Location = new System.Drawing.Point(0, 36);
            this.lvwKo.Name = "lvwKo";
            this.lvwKo.Size = new System.Drawing.Size(845, 143);
            this.lvwKo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(845, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "       Không bán được";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmBieuDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 874);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pieChart1);
            this.Name = "frmBieuDo";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lvwIt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox lvwVua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox lvwNhieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lvwKo;
        private System.Windows.Forms.Label label2;
    }
}