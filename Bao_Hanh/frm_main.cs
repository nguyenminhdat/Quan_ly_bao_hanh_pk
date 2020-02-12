using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bao_Hanh
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Main()
        {
            InitializeComponent();
        }
        public void MoForm(Form a_form)
        {

            if (KiemTraTonTaiForm(a_form))
            {
                return;
            }

            a_form.MdiParent = this;
            a_form.WindowState = FormWindowState.Maximized;
            a_form.Show();
        }

        bool KiemTraTonTaiForm(Form a_form)
        {

            foreach (Form item in this.MdiChildren)
            {
                if (item.Name == a_form.Name)
                {
                    xtraTabbedMdiManager2.Pages[item].MdiChild.Activate();
                    return true;
                }
            }
            return false;
        }
        private void DongTatCaForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != Parent)
                {
                    frm.Close();
                }
            }
        }
        void PhanQuyenMenu(string chucdanh)
        {
            isDangNhap();

            switch (chucdanh)
            {
                case "CD0001":
                    {
                        accordionControlElement3.Visible = true;
                        accordionControlElement4.Visible = true;
                        pnl_qlbaohanh.Visible = true;
                    }
                    break;
                default:
                    {
                        accordionControlElement3.Visible = false;
                        accordionControlElement4.Visible = false;
                        pnl_qlbaohanh.Visible = false;
                    }
                    break;
            }
        }
        bool isDangNhap()
        {
            if (string.IsNullOrEmpty(Infor.tendangnhap))
            {
                btn_logout.Enabled = false;
                btn_changePass.Enabled = false;
                btn_login.Enabled = true;
                return false;
            }
            btn_logout.Enabled = true;
            btn_changePass.Enabled = true;
            btn_login.Enabled = false;
            return true;
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void btn_changePass_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DoiMatKhau frm = new frm_DoiMatKhau();
            MoForm(frm);

        }

        private void btn_quanlyKH_Click(object sender, EventArgs e)
        {
            frm_QLyKhachHang frm = new frm_QLyKhachHang();
            MoForm(frm);
        }

        private void btn_timKiemKH_Click(object sender, EventArgs e)
        {
            if (!div_container.Controls.Contains(uc_QuanLyDichVu.Instance))
            {
                div_container.Controls.Add(uc_QuanLyDichVu.Instance);
                uc_QuanLyDichVu.Instance.Dock = DockStyle.Fill;
                uc_QuanLyDichVu.Instance.BringToFront();
            }
            else
            {
                uc_QuanLyDichVu.Instance.BringToFront();
            }
            frm_TimKiemKhachHang frm = new frm_TimKiemKhachHang();
            MoForm(frm);

        }

        private void btn_exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn đã chắc chắn thoát!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            frm_login frm = new frm_login();
            frm.ShowDialog();
            PhanQuyenMenu(Infor.ChucDanh);

            Util.s_FormMain = this;
        }

        private void btn_logout_ItemClick(object sender, ItemClickEventArgs e)
        {
            DongTatCaForm();
            Infor.tendangnhap = "";
            Infor.HoTen = "";
            Infor.ChucDanh = "";
            PhanQuyenMenu(Infor.ChucDanh);
        }

        private void btn_login_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_login frm = new frm_login();
            frm.ShowDialog();
            PhanQuyenMenu(Infor.ChucDanh);
        }

        private void btn_employ_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QuanLyNhanVien frm = new frm_QuanLyNhanVien();
            MoForm(frm);
        }

        private void bar_QuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frm_QuanLyNhanVien frm = new frm_QuanLyNhanVien();
            MoForm(frm);
        }

        private void btn_taoDonBH_Click(object sender, EventArgs e)
        {
            frm_TaoDonBaoHanh frm = new frm_TaoDonBaoHanh();
            MoForm(frm);
        }
    }
}
