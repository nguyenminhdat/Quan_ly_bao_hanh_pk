using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bao_Hanh
{
    public partial class frm_QuanLyChucDanh : Form
    {
        public frm_QuanLyChucDanh()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtMaChucDanh.Text = txtTenChucDanh.Text = txt_GhiChu.Text = "";
        }

        private void frm_QuanLyChucDanh_Load(object sender, EventArgs e)
        {
            
        }
        void LoadData()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT MaDV, TenDV, GiaDichVu, ThoiGianBH, TinhTrang FROM dbo.tbl_DichVu";
                dt = Util.GetData(sql);
                gc_Data.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không load được dữ liệu", "Thông báo");
            }
        }
        bool KiemTraKhiLuu(string madv, string tendv)
        {
            if (string.IsNullOrEmpty(madv))
            {
                MessageBox.Show("Chưa điền mã chức danh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (string.IsNullOrEmpty(tendv))
            {
                MessageBox.Show("Chưa điền tên chức danh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return true;
        }
        bool KiemTraTonTai(string madv)
        {
            string sql = "select * from tbl_ChucDanh where MaChucDanh = '"+madv+"'";
            DataTable dt = new DataTable();
            dt = Util.GetData(sql);
            return dt.Rows.Count > 0 ? true : false;
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string madv = txtMaChucDanh.Text.Trim();
                string tendv = txtTenChucDanh.Text.Trim();
                string ghichu = txt_GhiChu.Text;
                if (!KiemTraKhiLuu(madv,tendv))
                {
                    //Nếu tồn tại thì thông báo cập nhật thông tin
                    if (KiemTraTonTai(madv))
                    {
                        if (MessageBox.Show("Thông tin này đã tồn tại, bạn có muốn cập nhật","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string sql_capnhat = string.Format("update tbl_ChucDanh set TenChucDanh = N'{1}', GhiChu = N'{2}' where MaChucDanh = '{0}'",
                                madv,tendv, ghichu
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
                        string sql_themmoi = string.Format("insert into tbl_ChucDanh(MaChucDanh, TenChucDanh, GhiChu) values ('{0}',N'{1}',N'{2}')",
                                madv, tendv, ghichu
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
                string madv = txtMaChucDanh.Text;
                if (string.IsNullOrEmpty(madv))
                {
                    MessageBox.Show("Chưa chọn thông tin xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                string sql = "delete tbl_ChucDanh where MaChucDanh = '" + madv + "'";
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
                string madv = txtMaChucDanh.Text.Trim();
                string tendv = txtTenChucDanh.Text.Trim();

                string sql = "select * from tbl_ChucDanh where 1=1 ";
                if (madv != "")
                {
                    sql += "AND MaChucDanh = '" + madv+"'";
                }
                if (tendv != "")
                {
                    sql += "AND TenChucDanh like N'%" + tendv+"%'";
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

        private void gv_Data_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                int row = e.RowHandle;
                if (row >= 0)
                {
                    txtMaChucDanh.Text = Convert.ToString(gv_Data.GetRowCellValue(row, cMaChucDanh));
                    txtTenChucDanh.Text = Convert.ToString(gv_Data.GetRowCellValue(row, cTenChucDanh));
                    txt_GhiChu.Text = Convert.ToString(gv_Data.GetRowCellValue(row, cGhiChu));
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
