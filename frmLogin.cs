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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("login name và mật mã không được trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = txtLogin.Text; Program.password = txtPass.Text;
            if (Program.KetNoi() == 0) return;

            Program.frmMain.Show();
            Program.mKHOA = cmbKHOA.SelectedIndex;

            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "EXEC SP_THONGTINDANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh,Program.connstr);
            
            if (Program.myReader == null) return;
            Program.myReader.Read();


            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }

            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);

            Program.frmMain.EnableBtn();
            Program.frmMain.setFooter();

            Program.myReader.Close();
            Program.conn.Close();
            Close();

            MessageBox.Show("Giảng viên - Nhóm: " + Program.mHoten.Trim() + " - " + Program.mGroup, "", MessageBoxButtons.OK);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet1.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'dsdspm.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet1.V_DS_PHANMANH);
            cmbKHOA.SelectedIndex = 1;
            cmbKHOA.SelectedIndex = 0;
            //Console.WriteLine("name : " + Program.servername);
        }

        private void cmbKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbKHOA.SelectedValue!=null)
                try
                {
                    Program.servername = cmbKHOA.SelectedValue.ToString();
                }
                catch (Exception) { }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}