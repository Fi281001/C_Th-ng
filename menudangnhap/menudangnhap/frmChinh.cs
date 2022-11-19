using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menudangnhap
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
            lock_unlock(save.KT);
        }
        void lock_unlock(bool kt)
        {
            mnDangNhap.Enabled = mnThoat.Enabled = kt;
            mnDangXuat.Enabled = mnDanhMuc.Enabled = mnTraCuu.Enabled = !kt;
        }

        private void mnDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
        }

        private void mnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmChinh_Activated(object sender, EventArgs e)
        {
            // để mơ khóa các key khi đang nhập
            lock_unlock(save.KT);
        }

        private void mnDangXuat_Click(object sender, EventArgs e)
        {
            save.KT = !save.KT;
            lock_unlock(save.KT);
        }
    }
}
