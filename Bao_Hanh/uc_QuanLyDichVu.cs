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
    public partial class uc_QuanLyDichVu : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_QuanLyDichVu()
        {
            InitializeComponent();
        }
        private static uc_QuanLyDichVu _instance;
        public static uc_QuanLyDichVu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_QuanLyDichVu();
                return _instance;
            }
        }

        private void uc_QuanLyDichVu_Load(object sender, EventArgs e)
        {
            txtMaDichVu.Text = "1";
        }
    }
}
