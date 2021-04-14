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
    public partial class formNhapDiem : DevExpress.XtraEditors.XtraForm
    {
        public formNhapDiem()
        {
            InitializeComponent();
            btGhi.Enabled = false;
            btCANCEL.Enabled = false;
            tbLanThi.Text = "1";
        }
        private void updateTableAdapter()
        {
            dIEMBindingSource.EndEdit();
            dIEMBindingSource.ResetCurrentItem();
            this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dIEMTableAdapter.Update(this.qLDSVDataSet3.DIEM);
        }
        public void setcmb()
        {
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.DataSource = v_DS_PHANMANH0BindingSource;
                cmbKhoa.DisplayMember = "TENCN";
                cmbKhoa.ValueMember = "TENSERVER";

            }
            else
            {
                cmbKhoa.DataSource = v_DS_PHANMANHBindingSource;
                cmbKhoa.DisplayMember = "TENCN";
                cmbKhoa.ValueMember = "TENSERVER";

                cmbKhoa.Enabled = false;

            }
            cmbKhoa.SelectedIndex = Program.mKHOA;


        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVDataSet3);

        }

        private void kHOABindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVDataSet3);

        }

        private void formNhapDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet3.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Fill(this.qLDSVDataSet3.DIEM);
            // TODO: This line of code loads data into the 'qLDSVDataSet3.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Fill(this.qLDSVDataSet3.DIEM);
            // TODO: This line of code loads data into the 'qLDSVDataSet3.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLDSVDataSet3.MONHOC);
            // TODO: This line of code loads data into the 'qLDSVDataSet3.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSVDataSet3.LOP);
            // TODO: This line of code loads data into the 'qLDSVDataSet2.V_DS_PHANMANH0' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANH0TableAdapter.Fill(this.qLDSVDataSet2.V_DS_PHANMANH0);
            // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet1.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'qLDSVDataSet3.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.qLDSVDataSet3.KHOA);
            setcmb();
            
    
        }

        private void mALOPComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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

                        //this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        //this.gIANGVIENTableAdapter.Fill(this.qLDSVDataSet3.GIANGVIEN);
                        // Lấy mã chi nhánh hiện tại
                        //String maKHOA = ((DataRowView)gIANGVIENBindingSource[0])["MAKH"].ToString();
                        //MessageBox.Show(maKHOA);
                    }
                }
                catch { }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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

                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Fill(this.qLDSVDataSet3.LOP);

                        this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.mONHOCTableAdapter.Fill(this.qLDSVDataSet3.MONHOC);
                        // Lấy mã chi nhánh hiện tại
                        //String maKHOA = ((DataRowView)gIANGVIENBindingSource[0])["MAKH"].ToString();
                        //MessageBox.Show(maKHOA);
                    }
                }
                catch { }
        }

        private void dtgrDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            cmbKhoa.Enabled = false;
            cmbMaLop.Enabled = false;
            cmbMaMH.Enabled = false;
            tbLanThi.Enabled = false;
            btStart.Enabled = false;
            btGhi.Enabled = true;
            btCANCEL.Enabled = true;

            if(tbLanThi.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống ô lần thi");
                return;
            }
            else
            {
                try
                {
                    if(Convert.ToInt16(tbLanThi.Text.Trim()) > 2 || Convert.ToInt16(tbLanThi.Text.Trim()) < 1)
                    {
                        MessageBox.Show("Chỉ có 2 lần thi");
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Số lần thi không thể là chữ");
                    return;
                }
            }
            this.Controls.Add(this.dtgrDiem);
            int i = 0;
            string strLenh = "EXEC SP_LAYDATANHAPDIEM '" + cmbMaLop.Text.Trim() + "','" + cmbMaMH.Text.Trim() + "'," + tbLanThi.Text;

            try
            {
                SqlDataReader drd = Program.ExecSqlDataReader(strLenh, Program.connstr);
                while (drd.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dtgrDiem.Rows[i].Clone();
                    row.Cells[0].Value = (string)drd[0];
                    row.Cells[1].Value = (string)drd[1];
                    row.Cells[2].Value = Convert.ToString(drd[2]);
                    dtgrDiem.Rows.Add(row);
                    i = i + 1;
                    //Console.WriteLine(Convert.ToString(drd[2]));
                }
                drd.Close();
                dtgrDiem.AllowUserToAddRows = false;
                dtgrDiem.AllowUserToDeleteRows = false;
            }
            catch (Exception)
            {

            }
        }

        private void dtgrDiem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dtgrDiem_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

        private void dtgrDiem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Convert.ToInt32(dtgrDiem.CurrentCell.Value.ToString().Trim());

            }
            catch (Exception)
            {
                MessageBox.Show("Điểm không thể là chữ");
                dtgrDiem.CurrentCell.Value = 0;
                return;
            }
        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            for(int j = 0; j < dtgrDiem.RowCount; j++)
            {
                string lenhSQL = "EXEC SP_NHAP_DIEM '" + dtgrDiem.Rows[j].Cells[0].Value.ToString().Trim()
                                    + "','" + cmbMaMH.Text.Trim()
                                    + "'," + tbLanThi.Text.Trim()
                                    + "," + dtgrDiem.Rows[j].Cells[2].Value.ToString().Trim();
                //MessageBox.Show(lenhSQL);
                Program.ExecSqlNonQuery(lenhSQL, Program.connstr);
            }
            cmbKhoa.Enabled = true;
            cmbMaLop.Enabled = true;
            cmbMaMH.Enabled = true;
            tbLanThi.Enabled = true;
            btStart.Enabled = true;
            btGhi.Enabled = false;
            btCANCEL.Enabled = false;
            tbLanThi.Text = "1";

            while (dtgrDiem.RowCount > 0)
            {
                dtgrDiem.Rows.RemoveAt(dtgrDiem.RowCount - 1);
            }

            dtgrDiem.AllowUserToAddRows = true;
            dtgrDiem.AllowUserToDeleteRows = true;
            this.Controls.Remove(this.dtgrDiem);
        }

        private void btCANCEL_Click(object sender, EventArgs e)
        {
            cmbKhoa.Enabled = true;
            cmbMaLop.Enabled = true;
            cmbMaMH.Enabled = true;
            tbLanThi.Enabled = true;
            btStart.Enabled = true;
            btGhi.Enabled = false;
            btCANCEL.Enabled = false;
            tbLanThi.Text = "1";

            while (dtgrDiem.RowCount > 0)
            {
                dtgrDiem.Rows.RemoveAt(dtgrDiem.RowCount-1);
            }

            dtgrDiem.AllowUserToAddRows = true;
            dtgrDiem.AllowUserToDeleteRows = true;
            this.Controls.Remove(this.dtgrDiem);
        }
    }
}