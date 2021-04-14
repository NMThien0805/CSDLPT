using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmInBangDiemThi : Form
    {
        public frmInBangDiemThi()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        public bool laNhuan(int n)
        {
            return (n % 400 == 0 || (n % 4 == 0 && n % 100 != 0));
        }
        public bool ktradate(int ngay, int thang, int nam)
        {
            int[] soNgay = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (laNhuan(nam))
            {
                soNgay[2] = 29;
            }
            if (thang >= 1 && thang <= 12)
            {
                if (ngay >= 1 && ngay <= soNgay[thang])
                {
                    return true;
                }
            }
            return false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(TxBLop.TextLength != 0 && TxBMHoc.TextLength != 0 && TxBLanThi.TextLength != 0 &&
                TxBDate1.TextLength != 0 && TxBDate2.TextLength != 0 && TxBDate3.TextLength != 0)
            {
                try
                {
                    int ngay = Convert.ToInt32(TxBDate1.Text);
                    int thang = Convert.ToInt32(TxBDate2.Text);
                    int nam = Convert.ToInt32(TxBDate3.Text);
                    if(ktradate(ngay, thang, nam))
                    {
                        try
                        {
                            Convert.ToInt32(TxBLanThi.Text);
                            string Ngaythi = TxBDate1.Text + "/" + TxBDate2.Text + "/" + TxBDate3.Text;
                            RpInBDThi rpt = new RpInBDThi(TxBLop.Text, TxBMHoc.Text, Ngaythi, TxBLanThi.Text);

                            ReportPrintTool print = new ReportPrintTool(rpt);
                            print.ShowPreviewDialog();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Lần thi không thể là chữ", "", MessageBoxButtons.OK);
                            TxBLanThi.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập sai cấu trúc ngày/tháng/năm", "", MessageBoxButtons.OK);
                        TxBLanThi.Text = "";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ngày tháng năm không thể là chữ", "", MessageBoxButtons.OK);
                    TxBLanThi.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Không bỏ trống ô", "", MessageBoxButtons.OK);
                return;
            }
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
                        // Lấy mã chi nhánh hiện tại
                        //String maKHOA = ((DataRowView)gIANGVIENBindingSource[0])["MAKH"].ToString();
                        //MessageBox.Show(maKHOA);
                    }
                }
                catch { }
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
        private void frmInBangDiemThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet2.V_DS_PHANMANH0' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANH0TableAdapter.Fill(this.qLDSVDataSet2.V_DS_PHANMANH0);
            setcmb();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxBDate1_TextChanged(object sender, EventArgs e)
        {
        }

        private void LbKhoa_Click(object sender, EventArgs e)
        {

        }
    }
}
