using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QLDSV
{
    public partial class formNhapSV1 : DevExpress.XtraEditors.XtraForm
    {
        string flag;
        public formNhapSV1()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public bool checkData()
        {
            if (String.IsNullOrWhiteSpace(tbMaSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaSV.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(tbHo.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbHo.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(tbTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTen.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(tbMaLop.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaLop.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(cmbNgaySinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbNgaySinh.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(tbNoiSinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập nơi sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNoiSinh.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(tbDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbDiaChi.Focus();
                return false;
            }
            return true;
        }
        public void setcmb()
        {
            if (Program.mGroup != "PGV")
            {
                cmbKhoa.Enabled = false;

            }
            //tbKhoa.Enabled = false;
            cmbKhoa.SelectedIndex = Program.mKHOA;
        }
        public void lockControl()
        {
            btThem.Enabled = true;
            btXoa.Enabled = true;
            btGhi.Enabled = false;
            btPH.Enabled = false;

            tbMaSV.Enabled = false;
            tbHo.Enabled = false;
            tbTen.Enabled = false;
            tbMaLop.Enabled = false;
            rbtPhai.Enabled = false;
            cmbNgaySinh.Enabled = false;
            tbNoiSinh.Enabled = false;
            tbDiaChi.Enabled = false;
            tbGhiChu.Enabled = false;
            rbtNghiHoc.Enabled = false;
        }
        public void unlockControl()
        {
            btThem.Enabled = false;
            btXoa.Enabled = false;
            btGhi.Enabled = true;
            btPH.Enabled = true;

            tbMaSV.Enabled = true;
            tbHo.Enabled = true;
            tbTen.Enabled = true;
            tbMaLop.Enabled = true;
            rbtPhai.Enabled = true;
            cmbNgaySinh.Enabled = true;
            tbNoiSinh.Enabled = true;
            tbDiaChi.Enabled = true;
            tbGhiChu.Enabled = true;
            rbtNghiHoc.Enabled = true;
        }
        private void formNhapSV1_Load(object sender, EventArgs e)
        {
            lockControl();
            // TODO: This line of code loads data into the 'qLDSVDataSet3.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet3.SINHVIEN);
            // TODO: This line of code loads data into the 'qLDSVDataSet2.V_DS_PHANMANH0' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANH0TableAdapter.Fill(this.qLDSVDataSet2.V_DS_PHANMANH0);
            // TODO: This line of code loads data into the 'qLDSVDataSet3.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSVDataSet3.LOP);
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
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Fill(this.qLDSVDataSet3.LOP);
                        this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet3.SINHVIEN);
                    }
                }
                catch { }
        }
        private void updateTableAdapter()
        {
            sINHVIENBindingSource.EndEdit();
            sINHVIENBindingSource.ResetCurrentItem();
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Update(this.qLDSVDataSet3.SINHVIEN);
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            unlockControl();
            //cmbKhoa.Enabled = false;
            flag = "add";

            sINHVIENBindingSource.AddNew();
            tbMaLop.Text = dtgrLop.CurrentRow.Cells[0].Value.ToString();
            tbMaLop.Enabled = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            unlockControl();
            flag = "delete";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (checkData())
                {
                    string strLenh = "EXEC SP_KTRAMASV '" + tbMaSV.Text.Trim() + "'";
                    //Console.WriteLine(strLenh);
                    SqlDataReader kt = Program.ExecSqlDataReader(strLenh, Program.connstr);

                    if (kt == null) return;
                    kt.Read();
                    try
                    {
                        kt.GetString(0);
                        MessageBox.Show("Mã sinh vien tồn tại", "", MessageBoxButtons.OK);
                        kt.Close();
                        return;
                    }
                    catch (Exception)
                    {

                        //MessageBox.Show("Tên lớp chưa tồn tại", "", MessageBoxButtons.OK);
                        if (tbMaSV.Text.Trim().Length > 12 || tbMaSV.Text.Trim().Length == 0 || tbTen.Text.Trim().Length > 10)
                        {
                            MessageBox.Show("Sai cấu trúc mã sinh vien", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbMaSV.Focus();
                            kt.Close();
                            return;
                        }
                        else
                        {
                            updateTableAdapter();
                            lockControl();
                            kt.Close();
                        }
                        
                    }                  
                }
            }
            if (flag == "delete")
            {
                int index = dtgrSV.CurrentCell.RowIndex;
                sINHVIENBindingSource.RemoveAt(index);
                updateTableAdapter();
                lockControl();
            }
        }
    }
}