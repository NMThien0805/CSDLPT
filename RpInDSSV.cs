using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class RpInDSSV : DevExpress.XtraReports.UI.XtraReport
    {
        public RpInDSSV(string malop, string tenlop)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;
            this.sqlDataSource1.Fill();
            lbLop.Text = tenlop;
        }

    }
}
