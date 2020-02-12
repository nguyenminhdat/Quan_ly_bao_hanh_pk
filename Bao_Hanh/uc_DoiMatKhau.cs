using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Bao_Hanh
{
    public partial class uc_DoiMatKhau : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_DoiMatKhau()
        {
            InitializeComponent();
        }
        private static uc_DoiMatKhau _instance;
        public static uc_DoiMatKhau Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_DoiMatKhau();
                return _instance;
            }
        }

        private void uc_DoiMatKhau_Load(object sender, EventArgs e)
        {
            txt_TenDangNhap.Text = Infor.tendangnhap;
        }

        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            try
            {
                string tendangnhap = txt_TenDangNhap.Text.Trim();
                string matkhaucu = txt_MatKhauCu.Text;
                string matkhaumoi = txt_MatKhauMoi.Text;
                string xacnhanmk = txt_XacNhanMK.Text;
                if (string.IsNullOrEmpty(tendangnhap))
                {
                    MessageBox.Show("Chưa có tên đăng nhập", "Thông báo");
                    return;
                }
                if (string.IsNullOrEmpty(matkhaucu))
                {
                    MessageBox.Show("Chưa có mật khẩu cũ", "Thông báo");
                    return;
                }
                if (string.IsNullOrEmpty(matkhaumoi))
                {
                    MessageBox.Show("Chưa có mật khẩu mới", "Thông báo");
                    return;
                }
                if (string.IsNullOrEmpty(matkhaucu))
                {
                    MessageBox.Show("Chưa có xác nhận mật khẩu", "Thông báo");
                    return;
                }
                if (xacnhanmk != matkhaumoi)
                {
                    MessageBox.Show("Mật khẩu mới và xác nhận không giống nhau", "Thông báo");
                    return;
                }
                string kiemtramk = "select * from tbl_NhanVien where TenDangNhap = '" + tendangnhap + "' AND MatKhau = '" + matkhaucu + "'";
                DataTable dt = Util.GetData(kiemtramk);
                if (dt.Rows.Count > 0)
                {
                    string sql_doimatkhau = string.Format("update tbl_NhanVien set MatKhau = {1} where TenDangNhap = {0}"
                        , matkhaumoi, tendangnhap);
                    int doimatkhau = Util.RunSql(sql_doimatkhau);
                    if (doimatkhau > 0)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_TenDangNhap.Text = txt_MatKhauCu.Text = txt_MatKhauMoi.Text = txt_XacNhanMK.Text = "";
        }
    }
}
