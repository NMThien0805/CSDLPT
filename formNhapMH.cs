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
    public partial class formNhapMH : DevExpress.XtraEditors.XtraForm
    {
        string flag;
        public formNhapMH()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void lockControl()
        {
            btThem.Enabled = true;
            btXoa.Enabled = true;
            btGhi.Enabled = false;
            btPH.Enabled = false;

            tbMaMH.ReadOnly = true;
            tbTenMH.ReadOnly = true;
            btThem.Focus();
        }
        public void unlockControl()
        {
            btThem.Enabled = false;
            btXoa.Enabled = false;
            btGhi.Enabled = true;
            btPH.Enabled = true;

            tbMaMH.ReadOnly = false;
            tbTenMH.ReadOnly = false;

            tbMaMH.Focus();
        }
        public bool check()
        {
            if (String.IsNullOrWhiteSpace(tbMaMH.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaMH.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(tbTenMH.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên môn nhọc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTenMH.Focus();
                return false;
            }
            return true;
        }
        public void setcmb()
        {
           
        }
        private void formNhapMH_Load(object sender, EventArgs e)
        {
            lockControl();
            // TODO: This line of code loads data into the 'qLDSVDataSet3.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLDSVDataSet3.MONHOC);
            // TODO: This line of code loads data into the 'qLDSVDataSet2.V_DS_PHANMANH0' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANH0TableAdapter.Fill(this.qLDSVDataSet2.V_DS_PHANMANH0);
            // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            //setcmb();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            unlockControl();
            flag = "add";
            mONHOCBindingSource.AddNew();
        }
        private void updateTableAdapter()
        {
            mONHOCBindingSource.EndEdit();
            mONHOCBindingSource.ResetCurrentItem();
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Update(this.qLDSVDataSet3.MONHOC);
        }
        private void mAMHComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            unlockControl();
            flag = "delete";
            
        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (check())
                {
                    string strLenh = "EXEC SP_KTRAMAMH '" + tbMaMH.Text.Trim() + "'";
                    //Console.WriteLine(strLenh);
                    SqlDataReader kt = Program.ExecSqlDataReader(strLenh, Program.connstr);

                    if (kt == null) return;
                    kt.Read();
                    try
                    {
                        kt.GetString(0);
                        MessageBox.Show("Mã môn học tồn tại", "", MessageBoxButtons.OK);
                        kt.Close();
                        return;
                    }
                    catch(Exception)
                    {
                        kt.Close();
                    }

                    string str = "EXEC SP_KTRATENMH '" + tbTenMH.Text.Trim() + "'";
                    Console.WriteLine(str);
                    SqlDataReader tk = Program.ExecSqlDataReader(str, Program.connstr);

                    if (tk == null) return;
                    tk.Read();
                    try
                    {
                        tk.GetString(0);
                        MessageBox.Show("Tên môn học tồn tại", "", MessageBoxButtons.OK);
                        tk.Close();
                        return;
                    }
                    catch (Exception)
                    {                        
                            MessageBox.Show("Tên môn học chưa tồn tại", "", MessageBoxButtons.OK);
                            if (tbMaMH.Text.Trim().Length > 6 || tbMaMH.Text.Trim().Length == 0)
                            {
                                MessageBox.Show("Sai cấu trúc mã môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tbMaMH.Focus();
                                tk.Close();
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
                int index = dtgrMonHoc.CurrentCell.RowIndex;
                mONHOCBindingSource.RemoveAt(index);
                updateTableAdapter();
                lockControl();
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int index = dtgrMonHoc.CurrentCell.RowIndex;

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}