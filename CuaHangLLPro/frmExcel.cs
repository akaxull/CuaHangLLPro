using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangLLPro
{
    public partial class frmExcel : MetroFramework.Forms.MetroForm
    {
        clsSach sach = new clsSach();
        public frmExcel()
        {
            InitializeComponent();
        }
        bool isFirstRow = true;
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog of = new OpenFileDialog() { Filter = "Excel worlkbook| *.xlsx", Multiselect = false })
            {
                if(of.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataTable dtTable = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(of.FileName))
                    {
                        
                        var rows = workbook.Worksheet(1).RowsUsed();
                        foreach(var row in rows)
                        {
                            if(isFirstRow)
                            {
                                foreach(IXLCell cell in row.Cells() )
                                    dtTable.Columns.Add(cell.Value.ToString());
                                isFirstRow = false;
                            }
                            else
                            {
                                dtTable.Rows.Add();
                                int i = 0;
                                foreach (IXLCell cell in row.Cells())
                                    dtTable.Rows[dtTable.Rows.Count - 1][i++] = cell.Value.ToString();
                            }
                        }
                        dataGridView1.DataSource = dtTable.DefaultView;
                        Cursor.Current = Cursors.Default;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            DataTable dtTable = new DataTable();
            bool isSuccess = true;
            int count = 0;
            int soLuongSach = sach.getSoLuong();
            int[] array = new int[dataGridView1.Rows.Count];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                tblSach tmp = new tblSach();
                bool isExist = false;
                try
                {                   
                    tmp.TenSach = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    tmp.TheLoai = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    tmp.GiaTien = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                    tmp.SoLuong = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    tmp.NhaXuatBan = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    tmp.NamXuatBan = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                    tmp.TacGia = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    string test = dataGridView1.Rows[i].Cells[7].Value.ToString();
                    if (dataGridView1.Rows[i].Cells[7].Value.ToString() != "")
                        tmp.GiamGia = Convert.ToInt32(dataGridView1.Rows[i].Cells[9].Value);
                    tmp.MaSach = sach.getMaSach(tmp.TenSach, soLuongSach);
                    tmp.TrangThai = true;
                    soLuongSach++;                  
                }
                catch (Exception loi)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Dữ liệu sách '"  + tmp.TenSach + "' sai định dạng!", "Dữ liệu lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isSuccess = false;
                    break;
                }
                if(!sach.checkSachTonTai(tmp.TenSach))
                {
                    tblSach tmp2 = sach.getSachTuTen(tmp.TenSach);
                    if(tmp2.TrangThai)
                        MetroFramework.MetroMessageBox.Show(this, "Sách '" + tmp.TenSach + "' đã tồn tại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Sách '" + tmp.TenSach + "' đã ngừng kinh doanh hãy thêm lại trước!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    count++;
                    isExist = true;
                }
                if(!isExist)
                {
                    if (!sach.addSach(tmp))
                        isSuccess = false;
                    else
                    {
                        count++;
                    }
                }            
            }
            if(isSuccess)               
            {
                MetroFramework.MetroMessageBox.Show(this, "Thêm thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }
            }
            else
            {
                for(int i = 0; i < count; i++)
                {                   
                        dataGridView1.Rows.RemoveAt(0);
                }
                    
            }

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
