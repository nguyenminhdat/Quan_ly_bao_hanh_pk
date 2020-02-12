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

namespace Bao_Hanh
{
    public partial class frm_QuanLyNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frm_QuanLyNhanVien()
        {
            InitializeComponent();
            dtp_NgaySinh.DateTime = DateTime.Now.AddYears(-16);
        }
        void LoadData()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT tnv.TenDangNhap, tnv.MatKhau, tnv.HoTenNV, tnv.GioiTinh, tnv.NgaySinh, tnv.DiaChi, tnv.SDT, tnv.MaChucDanh FROM dbo.tbl_NhanVien AS tnv";
                dt = Util.GetData(sql);
                gc_Data.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không load được dữ liệu", "Thông báo");
            }
        }

        bool KiemTraKhiLuu(string tendangnhap, string matkhau, string hoten, string chucdanh)
        {
            if (string.IsNullOrEmpty(tendangnhap))
            {
                MessageBox.Show("Chưa điền tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (string.IsNullOrEmpty(matkhau))
            {
                MessageBox.Show("Chưa điền mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (string.IsNullOrEmpty(hoten))
            {
                MessageBox.Show("Chưa điền họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (string.IsNullOrEmpty(chucdanh))
            {
                MessageBox.Show("Chưa chọn chức danh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            return true;
        }
        bool KiemTraTonTai(string madv)
        {
            string sql = "select TenDangNhap from tbl_NhanVien where TenDangNhap = '" + madv + "'";
            DataTable dt = new DataTable();
            dt = Util.GetData(sql);
            return dt.Rows.Count > 0 ? true : false;
        }

        private void gv_Data_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                int row = e.RowHandle;
                if (row >= 0)
                {
                    txt_TenDangNhap.Text = Convert.ToString(gv_Data.GetRowCellValue(row, cTenDangNhap));
                    txt_MatKhau.Text = Convert.ToString(gv_Data.GetRowCellValue(row, cMatKhau));
                    txt_HoTen.Text = Convert.ToString(gv_Data.GetRowCellValue(row, cHoTenNV));
                    txt_SoDienThoai.Text = Convert.ToString(gv_Data.GetRowCellValue(row, cSDT));
                    txt_DiaChi.Text = Convert.ToString(gv_Data.GetRowCellValue(row, cDiaChi));
                    dtp_NgaySinh.DateTime = Convert.ToDateTime(gv_Data.GetRowCellValue(row, cNgaySinh));
                    cbb_GioiTinh.Text = Convert.ToString(gv_Data.GetRowCellValue(row, cGioiTinh));
                }
            }
            catch (Exception  ex)
            {
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_TenDangNhap.Text = txt_SoDienThoai.Text = txt_MatKhau.Text = txt_HoTen.Text = txt_DiaChi.Text = "";
            cbb_GioiTinh.SelectedIndex = 0;
            dtp_NgaySinh.DateTime = DateTime.Now.AddYears(-16);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string tendangnhap = txt_TenDangNhap.Text.Trim();
                string matkhau = txt_MatKhau.Text;
                string hoten = txt_HoTen.Text.Trim();
                string sdt = txt_SoDienThoai.Text.Trim();
                string diachi = txt_DiaChi.Text.Trim();
                string gioitinh = cbb_GioiTinh.Text.Trim();
                string ngaysinh = dtp_NgaySinh.DateTime.ToString("yyyy-MM-dd");
                string chucdanh = Convert.ToString(cbb_ChucDanh.SelectedValue);
                if (!KiemTraKhiLuu(tendangnhap, matkhau, hoten, chucdanh))
                {
                    //Nếu tồn tại thì thông báo cập nhật thông tin
                    if (KiemTraTonTai(tendangnhap))
                    {
                        if (MessageBox.Show("Thông tin này đã tồn tại, bạn có muốn cập nhật", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string sql_capnhat = string.Format("update tbl_NhanVien set MatKhau = N'{1}', HoTenNV = N'{2}', SDT = '{3}', GioiTinh = {4}, Ngaysinh = '{5}', DiaChi = N'{6}', MaChucDanh = '{7}',  where TenDangNhap = '{0}'",
                                tendangnhap, matkhau, hoten, sdt, gioitinh, ngaysinh, diachi, chucdanh
                                );
                            int capnhat = Util.RunSql(sql_capnhat);
                            if (capnhat > 0)
                            {
                                LoadData();
                                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    //Thêm mới thông tin
                    else
                    {
                        string sql_themmoi = string.Format("INSERT INTO dbo.tbl_NhanVien (TenDangNhap, MatKhau, HoTenNV, GioiTinh, NgaySinh, DiaChi, SDT, MaChucDanh) "
                                            + " VALUES('{0}',N'{1}',N{2},'{3}',{4},N{5},{6},{7})",
                                tendangnhap, matkhau, hoten, gioitinh, ngaysinh, diachi, sdt, chucdanh
                                );
                        int themmoi = Util.RunSql(sql_themmoi);
                        if (themmoi > 0)
                        {
                            LoadData();
                            MessageBox.Show("Thêm mới thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thêm mới thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi Lưu dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string madv = txt_TenDangNhap.Text;
                if (string.IsNullOrEmpty(madv))
                {
                    MessageBox.Show("Chưa chọn thông tin xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                string sql = "delete tbl_NhanVien where TenDangNhap = '" + madv + "'";
                int isxoa = Util.RunSql(sql);
                if (isxoa > 0)
                {
                    LoadData();
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi Xóa dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string madv = txt_TenDangNhap.Text.Trim();
                string tendv = txt_HoTen.Text.Trim();

                string sql = "SELECT tnv.TenDangNhap, tnv.MatKhau, tnv.HoTenNV, tnv.GioiTinh, tnv.NgaySinh, tnv.DiaChi, tnv.SDT, tnv.MaChucDanh FROM dbo.tbl_NhanVien AS tnv where 1=1 ";
                if (madv != "")
                {
                    sql += "AND tnv.TenDangNhap = '" + madv + "'";
                }
                if (tendv != "")
                {
                    sql += "AND tnv.HoTenNVl like N'%" + tendv + "%'";
                }
                DataTable dt = new DataTable();
                dt = Util.GetData(sql);
                if (dt.Rows.Count > 0)
                {
                    gc_Data.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi Tìm kiếm dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}