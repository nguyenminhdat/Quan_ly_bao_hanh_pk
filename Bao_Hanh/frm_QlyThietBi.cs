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
    public partial class frm_QlyThietBi : DevExpress.XtraEditors.XtraForm
    {
        public frm_QlyThietBi()
        {
            InitializeComponent();
        }
        bool KiemTraTonTai(string MaTB)
        {
            string sql = "select * from dbo.ThietBi where MaThietBi = '" + MaTB + "'";
            DataTable dt = new DataTable();
            dt = Util.GetData(sql);
            return dt.Rows.Count > 0 ? true : false;
        }
        void LoadData()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM dbo.ThietBi";
                dt = Util.GetData(sql);
                gc_Data.DataSource = dt;
            }
            catch (Exception ex)
            {
                Util.f_Notify("Không load được dữ liệu", false);
            }
        }
        bool f_validate_save()
        {
            if (txtTenThietBi.Text.Equals("") || txtMaThietBi.Text.Equals(""))
            {
                Util.f_Notify("Thông tin thiết bị không được để trống ", false);
                return false;
            }
            return true;
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                // Nếu tồn tại thì thông báo cập nhật thông tin
                if (KiemTraTonTai(txtMaThietBi.Text.Trim()))
                {
                    if (MessageBox.Show("Thông tin này đã tồn tại, bạn có muốn cập nhật", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Kiểm trả thông tin trước khi cập nhật 
                        if (!f_validate_save()) { return; }
                        else
                        {
                            string sql_capnhat = string.Format("update dbo.ThietBi set MaThietBi = N'{1}', MaLoai = N'{2}', TenThietBi ='{3}', SoSeri = N'{4}', NgayMua = '{5}' where MaThietBi = '{0}'",
                                txtMaThietBi.Text, txtMaLoai.Text, txtTenThietBi.Text, txtSeri.Text, txtNgayMua.Text
                                );
                            int capnhat = Util.RunSql(sql_capnhat);
                            if (capnhat > 0)
                            {
                                LoadData();
                                Util.f_Notify("Cập nhật thiết bị thành công", true);
                            }
                            else
                            {
                                Util.f_Notify("Cập nhật thiết bị thất bại", false);
                            }
                        }
                    }
                }
                else //Thêm mới 
                {
                    f_validate_save();
                    string sql_themmoi = string.Format("INSERT INTO dbo.ThietBi(MaThietBi, MaLoai, TenThietBi, SoSeri, NgayMua) VALUES ('{0}',N'{1}',N'{2}','{3}',N'{4}','{5}')",
                           txtMaThietBi.Text, txtMaLoai.Text, txtTenThietBi.Text, txtSeri.Text, txtNgayMua.Text
                           );
                    int themmoi = Util.RunSql(sql_themmoi);
                    if (themmoi > 0)
                    {
                        LoadData();
                        MessageBox.Show("Thêm thiết bị thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thiết bị thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                Util.f_Notify("Thêm khách hàng thất bại !", false);
                return;
            }
        }
    }
}