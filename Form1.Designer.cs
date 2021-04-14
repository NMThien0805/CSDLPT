namespace QLDSV
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barbuttonLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnClass = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnNDSSVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDSSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnInBDThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnInBDMHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnInPDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDSDHPhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnInBDTKet = new DevExpress.XtraBars.BarButtonItem();
            this.btnNDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnDHPhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaTK = new DevExpress.XtraBars.BarButtonItem();
            this.PageQtri = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonLogin = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonTaoTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonXoaTK = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonDangXuat = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonThoat = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageDMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonClass = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonMonHoc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonSV = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonNDiem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonDHPhi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonInDSSV = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonInBangDiemThi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonInBDMHoc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonInPhieuDiem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonInDSDHPhi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonBDTKet = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSSLbMaGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLbHoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLbNhomQuyen = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbMaGC_frmMain = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barbuttonLogin,
            this.btnLogin,
            this.btnTaoTK,
            this.btnDangXuat,
            this.btnThoat,
            this.btnClass,
            this.btnMonHoc,
            this.btnNDSSVien,
            this.btnInDSSV,
            this.btnInBDThi,
            this.btnInBDMHoc,
            this.btnInPDiem,
            this.btnInDSDHPhi,
            this.btnInBDTKet,
            this.btnNDiem,
            this.btnDHPhi,
            this.btnXoaTK});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 18;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.PageQtri,
            this.PageDMuc,
            this.ribbonBaoCao});
            this.ribbonControl1.Size = new System.Drawing.Size(825, 158);
            // 
            // barbuttonLogin
            // 
            this.barbuttonLogin.Caption = "Login";
            this.barbuttonLogin.Id = 1;
            this.barbuttonLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbuttonLogin.ImageOptions.Image")));
            this.barbuttonLogin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbuttonLogin.ImageOptions.LargeImage")));
            this.barbuttonLogin.Name = "barbuttonLogin";
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng nhập";
            this.btnLogin.Id = 2;
            this.btnLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogin.ImageOptions.SvgImage")));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.False;
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Caption = "Tạo tài khoản";
            this.btnTaoTK.Id = 3;
            this.btnTaoTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaoTK.ImageOptions.SvgImage")));
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTK_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 4;
            this.btnDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangXuat.ImageOptions.SvgImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnClass
            // 
            this.btnClass.Caption = "Nhập Lớp";
            this.btnClass.Id = 6;
            this.btnClass.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClass.ImageOptions.SvgImage")));
            this.btnClass.Name = "btnClass";
            this.btnClass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClass_ItemClick);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "Nhập Môn Học";
            this.btnMonHoc.Id = 7;
            this.btnMonHoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMonHoc.ImageOptions.SvgImage")));
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonHoc_ItemClick);
            // 
            // btnNDSSVien
            // 
            this.btnNDSSVien.Caption = "Nhập DSSV";
            this.btnNDSSVien.Id = 8;
            this.btnNDSSVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNDSSVien.ImageOptions.SvgImage")));
            this.btnNDSSVien.Name = "btnNDSSVien";
            this.btnNDSSVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNDSSVien_ItemClick);
            // 
            // btnInDSSV
            // 
            this.btnInDSSV.Caption = "In DSSV";
            this.btnInDSSV.Id = 9;
            this.btnInDSSV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInDSSV.ImageOptions.SvgImage")));
            this.btnInDSSV.Name = "btnInDSSV";
            this.btnInDSSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInDSSV_ItemClick);
            // 
            // btnInBDThi
            // 
            this.btnInBDThi.Caption = "In Bảng điểm thi";
            this.btnInBDThi.Id = 10;
            this.btnInBDThi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInBDThi.ImageOptions.SvgImage")));
            this.btnInBDThi.Name = "btnInBDThi";
            this.btnInBDThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInBDThi_ItemClick);
            // 
            // btnInBDMHoc
            // 
            this.btnInBDMHoc.Caption = "In Bảng điểm môn học";
            this.btnInBDMHoc.Id = 11;
            this.btnInBDMHoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInBDMHoc.ImageOptions.SvgImage")));
            this.btnInBDMHoc.Name = "btnInBDMHoc";
            this.btnInBDMHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInBDMHoc_ItemClick);
            // 
            // btnInPDiem
            // 
            this.btnInPDiem.Caption = "In Phiếu điểm";
            this.btnInPDiem.Id = 12;
            this.btnInPDiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInPDiem.ImageOptions.SvgImage")));
            this.btnInPDiem.Name = "btnInPDiem";
            this.btnInPDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInPDiem_ItemClick);
            // 
            // btnInDSDHPhi
            // 
            this.btnInDSDHPhi.Caption = "In Danh sách đóng học phí";
            this.btnInDSDHPhi.Id = 13;
            this.btnInDSDHPhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInDSDHPhi.ImageOptions.SvgImage")));
            this.btnInDSDHPhi.Name = "btnInDSDHPhi";
            this.btnInDSDHPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInDSDHPhi_ItemClick);
            // 
            // btnInBDTKet
            // 
            this.btnInBDTKet.Caption = "In Bảng điểm tổng kết";
            this.btnInBDTKet.Id = 14;
            this.btnInBDTKet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInBDTKet.ImageOptions.SvgImage")));
            this.btnInBDTKet.Name = "btnInBDTKet";
            this.btnInBDTKet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInBDTKet_ItemClick);
            // 
            // btnNDiem
            // 
            this.btnNDiem.Caption = "Nhập điểm";
            this.btnNDiem.Id = 15;
            this.btnNDiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNDiem.ImageOptions.SvgImage")));
            this.btnNDiem.Name = "btnNDiem";
            this.btnNDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNDiem_ItemClick);
            // 
            // btnDHPhi
            // 
            this.btnDHPhi.Caption = "Đóng học phí";
            this.btnDHPhi.Id = 16;
            this.btnDHPhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDHPhi.ImageOptions.SvgImage")));
            this.btnDHPhi.Name = "btnDHPhi";
            this.btnDHPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDHPhi_ItemClick);
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.Caption = "Xóa tài khoản";
            this.btnXoaTK.Id = 17;
            this.btnXoaTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaTK.ImageOptions.SvgImage")));
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaTK_ItemClick);
            // 
            // PageQtri
            // 
            this.PageQtri.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonLogin,
            this.ribbonTaoTaiKhoan,
            this.ribbonXoaTK,
            this.ribbonDangXuat,
            this.ribbonThoat});
            this.PageQtri.Name = "PageQtri";
            this.PageQtri.Text = "Quản trị";
            // 
            // ribbonLogin
            // 
            this.ribbonLogin.ItemLinks.Add(this.btnLogin);
            this.ribbonLogin.Name = "ribbonLogin";
            // 
            // ribbonTaoTaiKhoan
            // 
            this.ribbonTaoTaiKhoan.ItemLinks.Add(this.btnTaoTK);
            this.ribbonTaoTaiKhoan.Name = "ribbonTaoTaiKhoan";
            // 
            // ribbonXoaTK
            // 
            this.ribbonXoaTK.ItemLinks.Add(this.btnXoaTK);
            this.ribbonXoaTK.Name = "ribbonXoaTK";
            // 
            // ribbonDangXuat
            // 
            this.ribbonDangXuat.ItemLinks.Add(this.btnDangXuat);
            this.ribbonDangXuat.Name = "ribbonDangXuat";
            // 
            // ribbonThoat
            // 
            this.ribbonThoat.ItemLinks.Add(this.btnThoat);
            this.ribbonThoat.Name = "ribbonThoat";
            // 
            // PageDMuc
            // 
            this.PageDMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonClass,
            this.ribbonMonHoc,
            this.ribbonSV,
            this.ribbonNDiem,
            this.ribbonDHPhi});
            this.PageDMuc.Name = "PageDMuc";
            this.PageDMuc.Text = "Danh mục";
            // 
            // ribbonClass
            // 
            this.ribbonClass.ItemLinks.Add(this.btnClass);
            this.ribbonClass.Name = "ribbonClass";
            // 
            // ribbonMonHoc
            // 
            this.ribbonMonHoc.ItemLinks.Add(this.btnMonHoc);
            this.ribbonMonHoc.Name = "ribbonMonHoc";
            // 
            // ribbonSV
            // 
            this.ribbonSV.ItemLinks.Add(this.btnNDSSVien);
            this.ribbonSV.Name = "ribbonSV";
            // 
            // ribbonNDiem
            // 
            this.ribbonNDiem.ItemLinks.Add(this.btnNDiem);
            this.ribbonNDiem.Name = "ribbonNDiem";
            // 
            // ribbonDHPhi
            // 
            this.ribbonDHPhi.ItemLinks.Add(this.btnDHPhi);
            this.ribbonDHPhi.Name = "ribbonDHPhi";
            // 
            // ribbonBaoCao
            // 
            this.ribbonBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonInDSSV,
            this.ribbonInBangDiemThi,
            this.ribbonInBDMHoc,
            this.ribbonInPhieuDiem,
            this.ribbonInDSDHPhi,
            this.ribbonBDTKet});
            this.ribbonBaoCao.Name = "ribbonBaoCao";
            this.ribbonBaoCao.Text = "Báo cáo";
            // 
            // ribbonInDSSV
            // 
            this.ribbonInDSSV.ItemLinks.Add(this.btnInDSSV);
            this.ribbonInDSSV.Name = "ribbonInDSSV";
            // 
            // ribbonInBangDiemThi
            // 
            this.ribbonInBangDiemThi.ItemLinks.Add(this.btnInBDThi);
            this.ribbonInBangDiemThi.Name = "ribbonInBangDiemThi";
            // 
            // ribbonInBDMHoc
            // 
            this.ribbonInBDMHoc.ItemLinks.Add(this.btnInBDMHoc);
            this.ribbonInBDMHoc.Name = "ribbonInBDMHoc";
            // 
            // ribbonInPhieuDiem
            // 
            this.ribbonInPhieuDiem.ItemLinks.Add(this.btnInPDiem);
            this.ribbonInPhieuDiem.Name = "ribbonInPhieuDiem";
            // 
            // ribbonInDSDHPhi
            // 
            this.ribbonInDSDHPhi.ItemLinks.Add(this.btnInDSDHPhi);
            this.ribbonInDSDHPhi.Name = "ribbonInDSDHPhi";
            // 
            // ribbonBDTKet
            // 
            this.ribbonBDTKet.ItemLinks.Add(this.btnInBDTKet);
            this.ribbonBDTKet.Name = "ribbonBDTKet";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSLbMaGV,
            this.tSSLbHoTen,
            this.tSSLbNhomQuyen,
            this.lbMaGC_frmMain});
            this.statusStrip1.Location = new System.Drawing.Point(0, 263);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(825, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSSLbMaGV
            // 
            this.tSSLbMaGV.Name = "tSSLbMaGV";
            this.tSSLbMaGV.Size = new System.Drawing.Size(39, 17);
            this.tSSLbMaGV.Text = "MaGV";
            this.tSSLbMaGV.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // tSSLbHoTen
            // 
            this.tSSLbHoTen.Name = "tSSLbHoTen";
            this.tSSLbHoTen.Size = new System.Drawing.Size(44, 17);
            this.tSSLbHoTen.Text = "Họ Tên";
            // 
            // tSSLbNhomQuyen
            // 
            this.tSSLbNhomQuyen.Name = "tSSLbNhomQuyen";
            this.tSSLbNhomQuyen.Size = new System.Drawing.Size(41, 17);
            this.tSSLbNhomQuyen.Text = "Nhóm";
            // 
            // lbMaGC_frmMain
            // 
            this.lbMaGC_frmMain.Name = "lbMaGC_frmMain";
            this.lbMaGC_frmMain.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 285);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageQtri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonLogin;
        private DevExpress.XtraBars.BarButtonItem barbuttonLogin;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageDMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonClass;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonTaoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonThoat;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSSLbHoTen;
        private System.Windows.Forms.ToolStripStatusLabel tSSLbNhomQuyen;
        private DevExpress.XtraBars.BarButtonItem btnClass;
        private DevExpress.XtraBars.BarButtonItem btnMonHoc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnNDSSVien;
        private DevExpress.XtraBars.BarButtonItem btnInDSSV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonSV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonNDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonInDSSV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonInBangDiemThi;
        private DevExpress.XtraBars.BarButtonItem btnInBDThi;
        private DevExpress.XtraBars.BarButtonItem btnInBDMHoc;
        private DevExpress.XtraBars.BarButtonItem btnInPDiem;
        private DevExpress.XtraBars.BarButtonItem btnInDSDHPhi;
        private DevExpress.XtraBars.BarButtonItem btnInBDTKet;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonInBDMHoc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonInPhieuDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonInDSDHPhi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonBDTKet;
        private DevExpress.XtraBars.BarButtonItem btnNDiem;
        private DevExpress.XtraBars.BarButtonItem btnDHPhi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonDHPhi;
        public DevExpress.XtraBars.BarButtonItem btnTaoTK;
        public System.Windows.Forms.ToolStripStatusLabel tSSLbMaGV;
        public System.Windows.Forms.ToolStripStatusLabel lbMaGC_frmMain;
        private DevExpress.XtraBars.BarButtonItem btnXoaTK;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonXoaTK;
    }
}

