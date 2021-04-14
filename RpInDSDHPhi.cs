using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class RpInDSDHPhi : DevExpress.XtraReports.UI.XtraReport
    {
        public RpInDSDHPhi(string malop, string nienkhoa, string hky, string tsv, string ttien)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = Convert.ToInt32(hky);
            this.sqlDataSource1.Fill();
            LbNKhoa.Text = nienkhoa;
            LbHKy.Text = hky;
            LbTieuDe.Text = "DANH SÁCH ĐÓNG HỌC PHÍ CỦA LỚP \n " + malop;
            LbTSVien.Text = tsv;
            LbTTien.Text = ttien;
        }

    }
}
