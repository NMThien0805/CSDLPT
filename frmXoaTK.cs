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
    public partial class frmXoaTK : Form
    {
        public frmXoaTK()
        {
            InitializeComponent();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(cmbUser.Text.Trim().CompareTo(Program.mlogin) == 0)
            {
                MessageBox.Show("Đang đăng nhập bằng tài khoản này ko thể xoá", "", MessageBoxButtons.OK);
            }
            else
            {
                string strLenh = "EXEC SP_THONGTINDANGNHAP '" + cmbUser.SelectedValue.ToString().Trim() + "'";

                SqlDataReader myReader0 = Program.ExecSqlDataReader(strLenh, Program.connstr);

                if (myReader0 == null) return;
                myReader0.Read();
                string gan;
                //Console.WriteLine(myReader0.GetString(0));
                try
                {
                    gan = myReader0.GetString(0);
                }
                catch (Exception)
                {
                    MessageBox.Show("User không tồn tại!!!", "", MessageBoxButtons.OK);
                    Program.conn.Close();
                    myReader0.Close();
                    return;
                }
                if (Convert.IsDBNull(gan))
                {
                    MessageBox.Show("Thông tin bạn nhập không chính xác\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                    return;
                }

                String quyenDelete = myReader0.GetString(2);
                if (Program.mGroup == "Khoa" && quyenDelete != "User")
                {
                    MessageBox.Show("Tài khoản đã đăng nhập không đủ quyền xóa", "", MessageBoxButtons.OK);
                    return;
                }
                else if (Program.mGroup == "PGV" && quyenDelete == "PKeToan")
                {
                    MessageBox.Show("Tài khoản đã đăng nhập không đủ quyền xóa", "", MessageBoxButtons.OK);
                    return;
                }
                else if (Program.mGroup == "PKeToan" && quyenDelete != "PKeToan")
                {
                    MessageBox.Show("Tài khoản đã đăng nhập không đủ quyền xóa", "", MessageBoxButtons.OK);
                    return;
                }


                if (MessageBox.Show("Bạn có thật sự muốn xóa tài khoản ?", "Xác nhận xóa...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    strLenh = "EXEC Xoa_Login '" + cmbUser.SelectedValue.ToString().Trim() + "','" + cmbUser.SelectedValue.ToString().Trim() + "'";
                    //Console.WriteLine(strLenh);
                    Program.ExecSqlNonQuery(strLenh, Program.connstr);

                    MessageBox.Show("Xóa thành công", "", MessageBoxButtons.OK);
                }
                Program.conn.Close();
                myReader0.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void setcmb()
        {
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.DataSource = v_DS_PHANMANH0BindingSource;
                cmbKhoa.DisplayMember = "TENKHOA";
                cmbKhoa.ValueMember = "TENSERVER";
            }
            else
            {
                cmbKhoa.DataSource = v_DS_PHANMANHBindingSource;
                cmbKhoa.DisplayMember = "TENKHOA";
                cmbKhoa.ValueMember = "TENSERVER";

                cmbKhoa.Enabled = false;
            }
            cmbKhoa.SelectedIndex = Program.mKHOA;
        }

        private void frmXoaTK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet2.V_DS_PHANMANH0' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANH0TableAdapter.Fill(this.qLDSVDataSet2.V_DS_PHANMANH0);
            // TODO: This line of code loads data into the 'qLDSVDataSet3.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this.qLDSVDataSet3.GIANGVIEN);
            // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet1.V_DS_PHANMANH);
            setcmb();
        }

        private void cmbKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
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

                        this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.gIANGVIENTableAdapter.Fill(this.qLDSVDataSet3.GIANGVIEN);
                        // Lấy mã chi nhánh hiện tại
                        String maKHOA = ((DataRowView)gIANGVIENBindingSource[0])["MAKH"].ToString();
                        //MessageBox.Show(maKHOA);
                    }
                }
                catch { }
        }
    }
}
