using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class RpInBDMHoc : DevExpress.XtraReports.UI.XtraReport
    {
        public RpInBDMHoc(string tenlop, string tenmhoc, string lanthi)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = tenlop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = tenmhoc;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = Convert.ToInt32(lanthi);
            this.sqlDataSource1.Fill();
            LbLop.Text = tenlop;
            LbMonHoc.Text = tenmhoc;
            LbLanthi.Text = lanthi;
        }

    }
}
