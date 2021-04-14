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
    public partial class formNhapLop : DevExpress.XtraEditors.XtraForm
    {

        string flag;
        public formNhapLop()
        {
            InitializeComponent();
        }
        public void lockControl()
        {
            btThem.Enabled = true;
            btXoa.Enabled = true;
            btGhi.Enabled = false;
            btPH.Enabled = false;
           
            tbML.Enabled =false;
            tbTL.Enabled = false;
            tbKhoa.Enabled = false;
            btThem.Focus();
  
        }
        public void unclockControl()
        {
            btThem.Enabled = false;
            btXoa.Enabled = false;
            btGhi.Enabled = true;
            btPH.Enabled = true;
         
            tbML.Enabled = true;
            tbTL.Enabled = true;
            tbKhoa.Enabled = false;
            tbML.Focus();
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

        private void formNhapLop_Load(object sender, EventArgs e)
        {
            lockControl();
            // TODO: This line of code loads data into the 'qLDSVDataSet3.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSVDataSet3.LOP);
           
            // TODO: This line of code loads data into the 'qLDSVDataSet2.V_DS_PHANMANH0' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANH0TableAdapter.Fill(this.qLDSVDataSet2.V_DS_PHANMANH0);
            
            //dttSV = createTable();
            setcmb();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            unclockControl();
            //cmbKhoa.Enabled = false;
            flag = "add";
                       
            lOPBindingSource.AddNew();           
            tbKhoa.Text = cmbKhoa.Text.Trim();
            tbKhoa.Enabled = false;
        }
        private void updateTableAdapter()
        {
            lOPBindingSource.EndEdit();
            lOPBindingSource.ResetCurrentItem();
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Update(this.qLDSVDataSet3.LOP);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            unclockControl();
            flag = "delete";                     
        }
        public bool checkData()
        {
            if(String.IsNullOrWhiteSpace(tbML.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbML.Focus();
                return false;
            }
            if(String.IsNullOrWhiteSpace(tbTL.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTL.Focus();
                return false;
            }
            return true;
        }     
        private void btGhi_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (checkData())
                { 
                    string strLenh = "EXEC SP_KTRAMALOP '" + tbML.Text.Trim() + "'";
                    //Console.WriteLine(strLenh);
                    SqlDataReader kt = Program.ExecSqlDataReader(strLenh, Program.connstr);

                    if (kt == null) return;
                    kt.Read();
                    try
                    {
                        kt.GetString(0);
                        MessageBox.Show("Mã lớp tồn tại", "", MessageBoxButtons.OK);
                        kt.Close();
                        return;
                    }
                    catch (Exception)
                    {
                        kt.Close();
                    }

                    string str = "EXEC SP_KTRATENLOP '" + tbTL.Text.Trim() + "'";
                    Console.WriteLine(str);
                    SqlDataReader tk = Program.ExecSqlDataReader(str, Program.connstr);

                    if (tk == null) return;
                    tk.Read();
                    try
                    {
                        tk.GetString(0);
                        MessageBox.Show("Tên lớp tồn tại", "", MessageBoxButtons.OK);
                        tk.Close();
                        return;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Tên lớp chưa tồn tại", "", MessageBoxButtons.OK);
                        if (tbML.Text.Trim().Length > 8 || tbML.Text.Trim().Length == 0)
                        {
                            MessageBox.Show("Sai cấu trúc mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbML.Focus();
                            tk.Close();
                            return;
                        }
                        else
                        {
                            updateTableAdapter();
                            lockControl();
                            tk.Close();
                        }
                        
                    }
                }
            }
            if (flag == "delete")
            {
                int index = dtgrNhapLop.CurrentCell.RowIndex;
                lOPBindingSource.RemoveAt(index);
                updateTableAdapter();
                lockControl();              
            }
        }

        private void cmbKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //MessageBox.Show(Program.servername);
            if (cmbKhoa.SelectedValue != null)
            {
                try
                {
                    if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView") return;
                    // Gán chi nhánh mới
                    Console.WriteLine(cmbKhoa.SelectedValue.ToString());
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
                        
                        //MessageBox.Show(Program.connstr);
                        //Lấy mã chi nhánh hiện tại
                        //string maKHOA = ((DataRowView)lOPBindingSource[0])["MAKH"].ToString();
                        //MessageBox.Show(cmbKhoa.Text);
                    }

                }

                catch
                {
                    return;
                }
            }
        }

        private void tbML_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgrNhapLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgrNhapLop_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}