using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            OffEnableBtn();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public void OffEnableBtn()
        {
            Boolean gtri = false;

            btnClass.Enabled = gtri;
            btnDangXuat.Enabled = gtri;
            btnDHPhi.Enabled = gtri;
            btnInBDMHoc.Enabled = gtri;
            btnInBDThi.Enabled = gtri;
            btnInBDTKet.Enabled = gtri;
            btnInDSDHPhi.Enabled = gtri;
            btnInDSSV.Enabled = gtri;
            btnInPDiem.Enabled = gtri;
            btnMonHoc.Enabled = gtri;
            btnNDiem.Enabled = gtri;
            btnNDSSVien.Enabled = gtri;
            btnTaoTK.Enabled = gtri;
            btnXoaTK.Enabled = gtri;
            btnThoat.Enabled = true;
            btnLogin.Enabled = true;
        }

        public void EnableBtn()
        {
            Boolean gtri = true;
            //Console.WriteLine("NhomsQuyen: " + Program.mGroup);
            btnDangXuat.Enabled = gtri;
            if(Program.mGroup == "PKeToan")
            {
                btnDHPhi.Enabled = gtri;
                btnInDSDHPhi.Enabled = gtri;
                btnTaoTK.Enabled = gtri;
                btnXoaTK.Enabled = gtri;
            }
            else
            {
                btnInBDMHoc.Enabled = gtri;
                btnInBDThi.Enabled = gtri;
                btnInBDTKet.Enabled = gtri;
                btnInDSSV.Enabled = gtri;
                btnInPDiem.Enabled = gtri;
                btnClass.Enabled = gtri;
                btnMonHoc.Enabled = gtri;
                btnNDSSVien.Enabled = gtri;
                if (Program.mGroup == "PGV" || Program.mGroup == "Khoa")
                {
                    btnNDiem.Enabled = gtri;
                    btnTaoTK.Enabled = gtri;
                    btnXoaTK.Enabled = gtri;
                }
            }
            btnThoat.Enabled = true;
            btnLogin.Enabled = false;
        }

        public void setFooter()
        {
            if(Program.mGroup.Equals("") && Program.mlogin.Equals("") && Program.mHoten.Equals(""))
            {
                tSSLbMaGV.Text = "MAGV";
                tSSLbHoTen.Text = "Họ Tên";
                tSSLbNhomQuyen.Text = "Nhóm";
            }
            else
            {
                tSSLbMaGV.Text = Program.mlogin;
                tSSLbHoTen.Text = Program.mHoten;
                tSSLbNhomQuyen.Text = Program.mGroup;
            }
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLogin));
            if (frm != null) frm.Activate();
            else
            {
                frmLogin f = new frmLogin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát khỏi phiên làm việc ?", "Xác nhận...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Close();
                return;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất khỏi phiên làm việc ?", "Xác nhận đăng xuất...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Program.mlogin = "";
                Program.mHoten = "";
                Program.mGroup = "";
                Program.servername = "";
                Program.mKHOA = 0;
                Program.mloginDN = "";
                Program.passwordDN = "";
                Program.username = "";
                Program.password = "";
                OffEnableBtn();
                setFooter();

                Form frm = this.CheckExists(typeof(frmInBangDiemThi));
                if (frm != null) frm.Close();
                frm = this.CheckExists(typeof(frmInBDMHoc));
                if (frm != null) frm.Close();
                frm = this.CheckExists(typeof(frmInBDTKet));
                if (frm != null) frm.Close();
                frm = this.CheckExists(typeof(frmInDSDHPhi));
                if (frm != null) frm.Close();
                frm = this.CheckExists(typeof(frmInDSSV));
                if (frm != null) frm.Close();
                frm = this.CheckExists(typeof(frmInPhieuDiem));
                if (frm != null) frm.Close();
                frm = this.CheckExists(typeof(frmTaoTaiKhoan));
                if (frm != null) frm.Close();
                frm = this.CheckExists(typeof(frmXoaTK));
                if (frm != null) frm.Close();
                frm = this.CheckExists(typeof(formNhapMH));
                if (frm != null) frm.Close();
                frm = this.CheckExists(typeof(formNhapLop));
                if (frm != null) frm.Close();
                frm = this.CheckExists(typeof(formNhapSV1));
                if (frm != null) frm.Activate();
                frm = this.CheckExists(typeof(formNhapDiem));
                if (frm != null) frm.Activate();
                frm = this.CheckExists(typeof(formDongHP));
                if (frm != null) frm.Activate();
                frm = this.CheckExists(typeof(frmLogin));
                if (frm != null) frm.Activate();
                else
                {
                    frmLogin f = new frmLogin();
                    f.MdiParent = this;
                    f.Show();
                }

            }
        }

        private void btnInDSSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmInDSSV));
            if (frm != null) frm.Activate();
            else
            {
                frmInDSSV f = new frmInDSSV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnXoaTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmXoaTK));
            if (frm != null) frm.Activate();
            else
            {
                frmXoaTK f = new frmXoaTK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInBDThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmInBangDiemThi));
            if (frm != null) frm.Activate();
            else
            {
                frmInBangDiemThi f = new frmInBangDiemThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInBDMHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmInBDMHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmInBDMHoc f = new frmInBDMHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInPDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmInPhieuDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmInPhieuDiem f = new frmInPhieuDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInDSDHPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmInDSDHPhi));
            if (frm != null) frm.Activate();
            else
            {
                frmInDSDHPhi f = new frmInDSDHPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInBDTKet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmInBDTKet));
            if (frm != null) frm.Activate();
            else
            {
                frmInBDTKet f = new frmInBDTKet();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formNhapMH));
            if (frm != null) frm.Activate();
            else
            {
                formNhapMH f = new formNhapMH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnClass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formNhapLop));
            if (frm != null) frm.Activate();
            else
            {
                formNhapLop f = new formNhapLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNDSSVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formNhapSV1));
            if (frm != null) frm.Activate();
            else
            {
                formNhapSV1 f = new formNhapSV1();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formNhapDiem));
            if (frm != null) frm.Activate();
            else
            {
                formNhapDiem f = new formNhapDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDHPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formDongHP));
            if (frm != null) frm.Activate();
            else
            {
                formDongHP f = new formDongHP();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}