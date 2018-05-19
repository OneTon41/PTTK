using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyPhongMay.Views;

namespace QuanLyPhongMay
{
    public partial class frm_main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_main()
        {
            InitializeComponent();
        }

        public void GiaoDien()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Office 2007 Blue";
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            this.GiaoDien();
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDangNhap login = null;
            if (login == null || login.IsDisposed)
                login = new frmDangNhap();
            Check_Login:
            if (login.ShowDialog() == DialogResult.OK)
            {
                if (login.txtTenDangNhap.Text == "")
                {
                    XtraMessageBox.Show("Hãy nhập vào tên đăng nhập!");
                    goto Check_Login;
                }
                if (login.txtMatKhau.Text == "")
                {
                    XtraMessageBox.Show("Hãy nhập vào mật khẩu!");
                    goto Check_Login;
                }


            }
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMatKhau changepass = null;
            if (changepass == null || changepass.IsDisposed)
                changepass = new frmDoiMatKhau();
            changepass.ShowDialog();

        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
