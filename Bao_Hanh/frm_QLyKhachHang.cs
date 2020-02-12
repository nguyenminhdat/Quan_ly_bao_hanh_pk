using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Text.RegularExpressions;

namespace Bao_Hanh
{
    public partial class frm_QLyKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frm_QLyKhachHang()
        {
            InitializeComponent();
        }

        private void frm_QLyKhachHang_Load(object sender, EventArgs e)
        {
            txtPhone.Focus();

            cbo_GioiTinh.Properties.Items.Add("Nam");
            cbo_GioiTinh.Properties.Items.Add("Nữ");
            cbo_GioiTinh.Properties.Items.Add("Khác");
        }

        void f_validate_save()
        {
            if (!txtPhone.Text.Trim().Equals(""))
            {
                if (txtPhone.Text.Trim().Length < 10 || txtPhone.Text.Trim().Length > 11)
                {
                    Util.f_Notify("Số ĐT phải nhập 10 hoặc 11 số", false);
                    txtPhone.Focus();
                    return;
                }
                if (!Regex.IsMatch(txtPhone.Text.Trim(), "^[0-9]*$"))
                {
                    Util.f_Notify("Số ĐT sai", false);
                    txtPhone.Focus();
                    return;
                }
            }
        }


        void LoadData()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT MaKH,TenKhachHang, GioiTinh, NgaySinh, DiaChi, SDT FROM dbo.tbl_KhachHang";
                dt = Util.GetData(sql);
                gc_Data.DataSource = dt;
            }
            catch (Exception ex)
            {
                Util.f_Notify("Không load được dữ liệu", false);

            }
        }
        //Save Thông tin khách hàng
        private void f_save(string strMaKh, string strHoten, string strGioiTinh, string strSDT, string strDiaChi, DateTime strNgaySinh)
        {
            try
            {
                // Nếu tồn tại thì thông báo cập nhật thông tin
                if (KiemTraTonTai(strMaKh))
                {
                    if (MessageBox.Show("Thông tin này đã tồn tại, bạn có muốn cập nhật", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (txtHoVaTen.Text.Equals("") || txtPhone.Text.Equals(""))
                        {
                            Util.f_Notify("Thông tin khách hàng không được để trống ", false);
                            return;
                        }
                        else 
                        { 
                            string sql_capnhat = string.Format("update tbl_KhachHang set TenKhachHang = N'{1}', GioiTinh = N'{2}', NgaySinh = CONVERT(DATE,'{3}'), DiaChi = N'{4}', SDT = {5} where MaKH = '{0}'",
                                strMaKh, strHoten, strGioiTinh, strNgaySinh, strDiaChi, strSDT
                                );
                            int capnhat = Util.RunSql(sql_capnhat);
                            if (capnhat > 0)
                            {
                                LoadData();
                                Util.f_Notify("Cập nhật khách hàng thành công", true);
                            }
                            else
                            {
                                Util.f_Notify("Cập nhật khách hàng thất bại", false);
                            }
                        }
                    }
                }
                else // Thêm mới
                {
                    string sql_themmoi = string.Format("INSERT INTO tbl_KhachHang(MaKH,TenKhachHang, GioiTinh, NgaySinh, DiaChi, SDT) VALUES ('{0}',N'{1}',{2},'{3}',{4})",
                           strMaKh, strHoten, strGioiTinh, strNgaySinh, strDiaChi, strSDT
                           );
                    int themmoi = Util.RunSql(sql_themmoi);
                    if (themmoi > 0)
                    {
                        LoadData();
                        MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                Util.f_Notify("Thêm khách hàng thất bại !", false);
                return;
            }
            Util.f_Notify("Thêm khách hàng thành công !", true);

        }

        private void f_Delete(string strMaKh)
        {
            try
            {
                // Nếu tồn tại thì thông báo cập nhật thông tin
                if (KiemTraTonTai(strMaKh))
                {
                    if (MessageBox.Show("Bạn có muốn xóa khách hàng "+strMaKh+" không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sql_delete = string.Format("delete tbl_KhachHang where MaKH = '{0}'",
                            strMaKh
                            );
                        int delete = Util.RunSql(sql_delete);
                        if (delete > 0)
                        {
                            LoadData();
                            Util.f_Notify("Xóa khách hàng thành công !", true);
    
                        }
                        else
                        {
                            Util.f_Notify("Xóa khách hàng thất bại", true);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Util.f_Notify("Xóa khách hàng thất bại !", false);
                return;
            }
        }

        private void f_TimKiem(string strMaKh, string strHoten, string strSDT)
        {
            try
            {
                if (txtPhone.Text.Equals("") && txtMaKH.Text.Equals("") && txtHoVaTen.Text.Equals(""))
                {
                    LoadData();
                    Util.f_Notify("Tìm kiếm khách hàng thành công", true);
                }
                else
                {
                    DataTable dt = new DataTable();
                    string sql_timkiem = string.Format("Select MaKH,TenKhachHang, GioiTinh, NgaySinh, DiaChi, SDT FROM dbo.tbl_KhachHang Where  MaKH = '{0}' OR TenKhachHang LIKE '%'{1}'%' OR SDT = '{2}'",
                                 strMaKh, strHoten, strSDT
                                 );
                    dt = Util.GetData(sql_timkiem);
                    if (dt != null)
                    {
                        gc_Data.DataSource = dt;
                        Util.f_Notify("Tìm kiếm khách hàng thành công", true);
                    }
                    else
                    {
                        Util.f_Notify("Tìm kiếm khách hàng thất bại", false);
                    }
                }
            }
            catch (Exception ex)
            {
                Util.f_Notify("Lỗi khi tìm kiếm khách hàng :" + ex.Message, false);
            }
        }
        bool KiemTraTonTai(string makh)
        {
            string sql = "select * from tbl_KhachHang where MaKH = '" + makh + "'";
            DataTable dt = new DataTable();
            dt = Util.GetData(sql);
            return dt.Rows.Count > 0 ? true : false;
        }
        private void f_clear()
        {
            txtPhone.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtMaKH.Text = string.Empty;
            txtHoVaTen.Text = string.Empty;
            cboNgaySinh.Text = string.Empty;
            cbo_GioiTinh.Text = string.Empty;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string strMakh;
            strMakh = gv_Data.GetRowCellValue(gv_Data.FocusedRowHandle, "MaKH").ToString();
            if (string.IsNullOrEmpty(strMakh))
            {
                Util.f_Notify("Chưa chọn thông tin xóa",false);
                return;
            }
            f_Delete(strMakh);
        }
        private void txtPhone_Enter(object sender, EventArgs e)
        {
            f_validate_save();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            f_save(txtMaKH.Text, txtHoVaTen.Text, cbo_GioiTinh.Text, txtPhone.Text, txtDiaChi.Text, Convert.ToDateTime(cboNgaySinh.EditValue));
        }
        private void txt_sdt_Leave(object sender, EventArgs e)
        {
            f_validate_save();
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            // txtPhone.SelectAll();
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string strMaKH = txtMaKH.Text.Trim();
            string strTen = txtHoVaTen.Text.Trim();
            string strPhone = txtPhone.Text.Trim();
            f_TimKiem(strMaKH, strTen, strPhone);
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            f_clear();
        }

        private void gv_Data_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString().Trim();
                e.Info.ImageIndex = -1;
            }
        }

        private void gv_Data_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            try
            {
                int row = e.RowHandle;
                if (row >= 0)
                {
                    txtMaKH.Text = Convert.ToString(gv_Data.GetRowCellValue(row, cMaKH));
                    txtHoVaTen.Text = Convert.ToString(gv_Data.GetRowCellValue(row, cTenKH));
                    txtDiaChi.Text = Convert.ToString(gv_Data.GetRowCellValue(row, cDiaChi));
                    txtPhone.Text = Convert.ToString(gv_Data.GetRowCellValue(row, cSDT));
                    cboNgaySinh.Text = Convert.ToString(gv_Data.GetRowCellValue(row, cNgaySinh));
                    cbo_GioiTinh.Text = Convert.ToString(gv_Data.GetRowCellValue(row, cGioiTinh));
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}