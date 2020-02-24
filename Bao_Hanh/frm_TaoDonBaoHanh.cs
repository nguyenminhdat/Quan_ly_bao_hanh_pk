using System;
using System.Data;
using System.Windows.Forms;

namespace Bao_Hanh
{
    public partial class frm_TaoDonBaoHanh : DevExpress.XtraEditors.XtraForm
    {
        public frm_TaoDonBaoHanh()
        {
            InitializeComponent();
        }

        string MaKH;
        private void btnSeachKH_Click(object sender, EventArgs e)
        {
            frm_QLyKhachHang frm = new frm_QLyKhachHang();
            frm.Show();
        }

        private void txt_phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                try
                {
                    if (txt_phone.Text.Trim().Length != 0)
                    {
                        DataTable dt = new DataTable();
                        string sql_timkiem = string.Format("Select MaKH,TenKhachHang, GioiTinh, NgaySinh, DiaChi, SDT FROM dbo.tbl_KhachHang Where SDT = '{0}'",
                                     txt_phone.Text
                                     );
                        dt = Util.GetData(sql_timkiem);
                        if (dt.Rows.Count > 0)
                        {
                            txtHoVaTen.Text = dt.Rows[0]["TenKhachHang"].ToString();
                            txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                            txtMakh.Text = dt.Rows[0]["MaKH"].ToString();

                            Util.f_Notify("Tìm kiếm khách hàng thành công", true);
                        }
                        else
                        {
                            Util.f_Notify("Chưa có danh sách khách hàng", true);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
        }

        private void txt_phone_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_phone.Text.Trim().Length != 0)
                {
                    DataTable dt = new DataTable();
                    string sql_timkiem = string.Format("Select MaKH,TenKhachHang, GioiTinh, NgaySinh, DiaChi, SDT FROM dbo.tbl_KhachHang Where SDT = '{0}'",
                                 txt_phone.Text
                                 );
                    dt = Util.GetData(sql_timkiem);
                    if (dt.Rows.Count > 0)
                    {
                        txtHoVaTen.Text = dt.Rows[0]["TenKhachHang"].ToString();
                        txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                        txtMakh.Text = dt.Rows[0]["MaKH"].ToString();

                        Util.f_Notify("Tìm kiếm khách hàng thành công", true);
                    }
                    else
                    {
                        Util.f_Notify("Chưa có danh sách khách hàng", true);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_phone.Text = "";
            txtMakh.Text = "";
            txtHoVaTen.Text = "";
            txtModelPK.Text = "";
            txtModelPK.Text = "";
            txtNoiDung.Text = "";
            txtPhiBH.Text = "";
            txtTrangThai.Text = "";
            txtThoiGianBH.Text = "";
        }

        #region Class
        public class DTO_BaoHanh
        {
            public string SDT { get; set; }
            public string TenKhachHang { get; set; }
            public string MaBH { get; set; }
            public string TenThietBi { get; set; }
            public string NoiDung { get; set; }
            public string TenLoaiBH { get; set; }
            public string PhiBH { get; set; }

            public DTO_BaoHanh(string p_SDT, string p_TenKhachHang, string p_MaBH, string p_TenThietBi
                , string p_NoiDung, string p_TenLoaiBH, string p_PhiBH
                )
            {
                SDT = p_SDT;
                TenKhachHang = p_TenKhachHang;
                MaBH = p_MaBH;
                TenThietBi = p_TenThietBi;
                NoiDung = p_NoiDung;
                TenLoaiBH = p_TenLoaiBH;
                PhiBH = p_PhiBH;
            }
        }

        #endregion Clas

        private void f_PrintBill()
        {

        }

        private void btnInBill_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            f_PrintBill();
        }


        bool f_validateSave()
        {
            if (txt_phone.Text == "" || txtModelPK.Text == "" || txtDichVu.Text == "" || txtNoiDung.Text == "")
            {
                Util.f_Notify("Chưa đủ thông tin !!!", false);
                return false;
            }
            return true;
        }
        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            if (f_validateSave())
            {
                //string sql_themmoi = string.Format("INSERT INTO tbl_BaoHanh(MaLoaiBH,TenKhachHang, GioiTinh, NgaySinh, DiaChi, SDT) VALUES ('{0}',N'{1}',N'{2}',CONVERT(DATE,'{3}'),N'{4}','{5}')",
                //          strMaKh, strHoten, strGioiTinh, strNgaySinh, strDiaChi, strSDT
                //          );
                int themmoi = 0;//Util.RunSql(sql_themmoi);
                if (themmoi > 0)
                {
                    Util.f_Notify("Hoàn tất bảo hành thành công !", true);
                    f_PrintBill();
                }
                else
                {
                    Util.f_Notify("Hoàn tất bảo hành thất bại !", false);
                    return;
                }
            }
        }

        private void txtModelPK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {

            }
        }



        //POS020 l_Form_POS020 = new POS020();
        //l_Form_POS020.f_FormShow_FromPOS001(this

        //                                    , l_dt

        //                                    , l_dt.Rows[0]["ItemCode"].ToString()

        //                                    , l_dt.Rows[0]["ItemName"].ToString()

        //                                    , 1);

    }


}