using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class RpInBDTKet : DevExpress.XtraReports.UI.XtraReport
    {
        public RpInBDTKet(string tenlop)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = tenlop;
            this.sqlDataSource1.Fill();
            LbLop.Text = tenlop;
        }

    }
}
