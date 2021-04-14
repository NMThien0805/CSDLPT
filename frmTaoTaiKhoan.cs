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
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void LbUser_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void setcmb()
        {
            cmbRole.Enabled = true;
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.DataSource = v_DS_PHANMANH0BindingSource;
                cmbKhoa.DisplayMember = "TENKHOA";
                cmbKhoa.ValueMember = "TENSERVER";

                cmbRole.Items.Add("PGV");
                cmbRole.Items.Add("Khoa");
                cmbRole.Items.Add("User");
            }
            else
            {
                cmbKhoa.DataSource = v_DS_PHANMANHBindingSource;
                cmbKhoa.DisplayMember = "TENKHOA";
                cmbKhoa.ValueMember = "TENSERVER";

                cmbKhoa.Enabled = false;
                if(Program.mGroup == "Khoa")
                {
                    cmbRole.Items.Add("Khoa");
                    cmbRole.Items.Add("User");
                }
                else
                {
                    cmbRole.Items.Add("PKeToan");
                    cmbRole.Enabled = false;
                }
            }
            cmbKhoa.SelectedIndex = Program.mKHOA;
            cmbRole.SelectedIndex = 0;

            if(Program.mGroup == "PKeToan")
            {
                cmbUser.DataSource = v_TIMLOGINBindingSource1;
                cmbUser.DisplayMember = "MAGV";
                cmbUser.ValueMember = "MAGV";
            }
            else
            {
                cmbUser.DataSource = v_TIMLOGINBindingSource;
                cmbUser.DisplayMember = "MAGV";
                cmbUser.ValueMember = "MAGV";
            }
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSetTimLoginSV3.V_TIMLOGIN' table. You can move, or remove it, as needed.
            this.v_TIMLOGINTableAdapterSV3.Fill(this.qLDSVDataSetTimLoginSV3.V_TIMLOGIN);
            // TODO: This line of code loads data into the 'qLDSVDataSetTimLoginSV12.V_TIMLOGIN' table. You can move, or remove it, as needed.
            this.v_TIMLOGINTableAdapterSV12.Fill(this.qLDSVDataSetTimLoginSV12.V_TIMLOGIN);
            // TODO: This line of code loads data into the 'qLDSVDataSet2.V_DS_PHANMANH0' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANH0TableAdapter.Fill(this.qLDSVDataSet2.V_DS_PHANMANH0);
            // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet1.V_DS_PHANMANH);
            setcmb();
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

                        this.v_TIMLOGINTableAdapterSV12.Connection.ConnectionString = Program.connstr;
                        this.v_TIMLOGINTableAdapterSV12.Fill(this.qLDSVDataSetTimLoginSV12.V_TIMLOGIN);
                        // Lấy mã chi nhánh hiện tại
                        //String maKHOA = ((DataRowView)gIANGVIENBindingSource[0])["MAKH"].ToString();
                        //MessageBox.Show(maKHOA);
                    }
                }
                catch { }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            if(TxBPass.TextLength != 0 && TxBCFirmPass.TextLength != 0)
            {
                if (cmbUser.Text.Trim().CompareTo(Program.mlogin) == 0)
                {
                    MessageBox.Show("Đang đăng nhập bằng tài khoản này", "", MessageBoxButtons.OK);
                }
                else if (TxBCFirmPass.Text.CompareTo(TxBPass.Text) != 0)
                {
                    MessageBox.Show("Password và Confirm Password không khớp", "", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        string strLenh = "EXEC SP_TAOLOGIN '" + cmbUser.SelectedValue.ToString().Trim() + "','" + TxBPass.Text.Trim() +
                                "','" + cmbUser.SelectedValue.ToString().Trim() + "','" + cmbRole.Text + "'";
                        //Console.WriteLine(strLenh + cmbRole.Text);
                        if(Program.ExecSqlNonQuery(strLenh, Program.connstr) == 1)
                        {
                            MessageBox.Show("Tạo tài khoản thành công");
                            Close();
                        }

                        Program.conn.Close();
                    }
                    catch (Exception)
                    {
                        Program.conn.Close();
                        //Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Không được để trống ô", "", MessageBoxButtons.OK);
            }
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
