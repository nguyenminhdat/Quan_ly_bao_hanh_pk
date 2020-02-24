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
    public partial class frm_TimKiemKhachHang : Form
    {
        public frm_TimKiemKhachHang()
        {
            InitializeComponent();
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
        bool KiemTraTonTai(string makh, string sdt)
        {
            string sql = "select * from tbl_KhachHang where MaKH = '" + makh + "' or SDT = '"+sdt+"' ";
            DataTable dt = new DataTable();
            dt = Util.GetData(sql);
            return dt.Rows.Count > 0 ? true : false;
        }
        private void f_TimKiem(string strMaKh, string strSDT)
        {
            try
            {
                if (txtPhone.Text.Equals("") && txtMaKH.Text.Equals(""))
                {
                    LoadData();
                    Util.f_Notify("Tìm kiếm khách hàng thành công", true);
                }
                else
                {
                    if (KiemTraTonTai(strMaKh, strSDT))
                    {
                        DataTable dt = new DataTable();
                        string sql_timkiem = string.Format("Select MaKH,TenKhachHang, GioiTinh, NgaySinh, DiaChi, SDT FROM dbo.tbl_KhachHang Where  MaKH = '{0}' OR SDT = '{1}'",
                                     strMaKh, strSDT
                                     );
                        dt = Util.GetData(sql_timkiem);
                        if (dt.Rows.Count > 0)
                        {
                            gc_Data.DataSource = dt;
                            Util.f_Notify("Tìm kiếm khách hàng thành công", true);
                        }
                        else
                        {
                            Util.f_Notify("Chưa có danh sách khách hàng",true);
                        }
                    }
                    else
                    {
                        Util.f_Notify("Khách hàng không tồn tại", false);
                    }
                }
            }
            catch (Exception ex)
            {
                Util.f_Notify("Lỗi khi tìm kiếm khách hàng :" + ex.Message, false);
            }
        }
        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            string strMaKH = txtMaKH.Text.Trim();
            string strPhone = txtPhone.Text.Trim();
            f_TimKiem(strMaKH, strPhone);
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtPhone.Text = string.Empty;
            txtMaKH.Text = string.Empty;
        }
    }
}
