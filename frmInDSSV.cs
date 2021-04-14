using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmInDSSV : Form
    {
        public frmInDSSV()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void setcmb()
        {
            cmbKhoa.Enabled = true;
            cmbKhoa.SelectedIndex = Program.mKHOA;
            if (Program.mGroup.CompareTo("PGV") != 0)
            {
                cmbKhoa.Enabled = false;
            }
        }
        private void frmInDSSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet3.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSVDataSet3.LOP);
            // TODO: This line of code loads data into the 'qLDSVDataSet2.V_DS_PHANMANH0' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANH0TableAdapter.Fill(this.qLDSVDataSet2.V_DS_PHANMANH0);
            setcmb();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue != null)
                try
                {
                    if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                    {
                        return;
                    }
                    // Gán chi nhánh mới
                    Program.servername = cmbKhoa.SelectedValue.ToString();
                    // Dùng HTKN để kết nối tới server mới thay cho login cũ nếu như thay đổi chi nhánh mới trên combobox
                    if (cmbKhoa.SelectedIndex != Program.mKHOA)
                    {
                        Program.mlogin = Program.remoteLogin;
                        Program.password = Program.remotePassword;
                    }
                    // Dùng tài khoản khi đăng nhập nếu như chọn lại chi nhánh chọn khi đăng nhập
                    else
                    {
                        Program.mlogin = Program.mloginDN;
                        Program.password = Program.passwordDN;
                    }
                    if (Program.KetNoi() == 0)
                    {
                        MessageBox.Show("Lỗi kết nối với chi nhánh mới", "", MessageBoxButtons.OK);
                    }
                    else
                    {

                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Fill(this.qLDSVDataSet3.LOP);
                        // Lấy mã chi nhánh hiện tại
                        //String maKHOA = ((DataRowView)gIANGVIENBindingSource[0])["MAKH"].ToString();
                        //MessageBox.Show(maKHOA);
                    }
                }
                catch { }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            RpInDSSV rpt = new RpInDSSV(cmbLop.SelectedValue.ToString(), cmbLop.Text.Trim());

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
