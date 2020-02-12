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
    public partial class frm_DoiMatKhauNew : DevExpress.XtraEditors.XtraForm
    {
        public frm_DoiMatKhauNew()
        {
            InitializeComponent();
        }
        private static frm_DoiMatKhauNew _instance;
        public static frm_DoiMatKhauNew Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frm_DoiMatKhauNew();
                return _instance;
            }
        }
    }
}