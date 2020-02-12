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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string tendn = txtTaiKhoan.Text.Trim();
                string matkhau = txtMatKhau.Text;
                if (string.IsNullOrEmpty(tendn))
                {
                    MessageBox.Show("Tên đăng nhập không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTaiKhoan.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(matkhau))
                {
                    MessageBox.Show("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus();
                    return;
                }
                string sql = string.Format("select * From tbl_NhanVien where TenDangNhap = '{0}' AND MatKhau = '{1}'",
                    tendn, matkhau);
                DataTable dt = new DataTable();
                
                dt = Util.GetData(sql);
                if (dt != null && dt.Rows.Count > 0 )
                {
                    Infor.tendangnhap = Convert.ToString(dt.Rows[0]["TenDangNhap"]);
                    Infor.HoTen = Convert.ToString(dt.Rows[0]["HoTenNV"]);
                    Infor.ChucDanh = Convert.ToString(dt.Rows[0]["MaChucDanh"]);
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {

                    Infor.tendangnhap = "";
                    Infor.HoTen = "";
                    Infor.ChucDanh = "";
                    MessageBox.Show("Đăng nhập thất bại, Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn đã chắc chắn thoát!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
