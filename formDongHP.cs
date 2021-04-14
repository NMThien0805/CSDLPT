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
    public partial class formDongHP : DevExpress.XtraEditors.XtraForm
    {
        public formDongHP()
        {
            InitializeComponent();
        }
        public void lockControl()
        {
            btBatDau.Enabled = true;
            btGhi.Enabled = false;
            cmbMaSV.Enabled = true;
            btCANCEL.Enabled = false;
        }
        public void unlockControl()
        {
            btBatDau.Enabled = false;
            btGhi.Enabled = true;
            cmbMaSV.Enabled = false;
            btCANCEL.Enabled = true;
        }
        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVDataSet4);

        }

        private void formDongHP_Load(object sender, EventArgs e)
        {
            lockControl();
            // TODO: This line of code loads data into the 'qLDSVDataSet4.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet4.SINHVIEN);


        }

        private void mASVComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMaLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void tENLabel_Click(object sender, EventArgs e)
        {

        }

        private void tENTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hOLabel_Click(object sender, EventArgs e)
        {

        }

        private void hOTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mASVLabel_Click(object sender, EventArgs e)
        {

        }

        private void mALOPLabel_Click(object sender, EventArgs e)
        {

        }

        private void cmbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btBatDau_Click(object sender, EventArgs e)
        {
            unlockControl();

            string ma = "EXEC SP_GETHOTENSV '" + cmbMaSV.Text.Trim() + "'";
            SqlDataReader a = Program.ExecSqlDataReader(ma, Program.connstr);
            a.Read();
            lbHT.Text = Convert.ToString(a[0]);
            lbML.Text = Convert.ToString(a[1]);
            a.Close();

            int i = 0;
            string strLenh = "EXEC SP_GETHOCPHISV '" + cmbMaSV.Text.Trim() + "'";
            //MessageBox.Show(strLenh);

            SqlDataReader drd = Program.ExecSqlDataReader(strLenh, Program.connstr);

            while (drd.Read())
            {
                DataGridViewRow row = (DataGridViewRow)dtgrHocPhi.Rows[0].Clone();
                row.Cells[0].Value = (string)drd[0];
                row.Cells[1].Value = Convert.ToString(drd[1]);
                row.Cells[2].Value = Convert.ToString(drd[2]);
                row.Cells[3].Value = Convert.ToString(drd[3]);
                row.Cells[4].Value = Convert.ToString(drd[4]);
                dtgrHocPhi.Rows.Add(row);
                i = i + 1;
                //Console.WriteLine(Convert.ToString(drd[2]));
            }
            drd.Close();
        }

        private void cmbMaSV_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < dtgrHocPhi.RowCount-1; j++)
            {
                string lenhSQL = "EXEC SP_INSERTHOCPHI '" + cmbMaSV.Text.Trim()
                                    + "','" + dtgrHocPhi.Rows[j].Cells[0].Value.ToString().Trim()
                                    + "','" + dtgrHocPhi.Rows[j].Cells[1].Value.ToString().Trim()
                                    + "'," + dtgrHocPhi.Rows[j].Cells[4].Value.ToString().Trim();
                //MessageBox.Show(lenhSQL);
                Program.ExecSqlNonQuery(lenhSQL, Program.connstr);
            }
            lockControl();
            while (dtgrHocPhi.RowCount > 1)
            {
                //MessageBox.Show(Convert.ToString(dtgrHocPhi.RowCount));
                dtgrHocPhi.Rows.RemoveAt(dtgrHocPhi.RowCount - 2);
            }

            dtgrHocPhi.AllowUserToAddRows = true;
            dtgrHocPhi.AllowUserToDeleteRows = true;
        }

        private void btCANCEL_Click(object sender, EventArgs e)
        {
            lockControl();

            while (dtgrHocPhi.RowCount > 1)
            {
                //MessageBox.Show(Convert.ToString(dtgrHocPhi.RowCount));
                dtgrHocPhi.Rows.RemoveAt(dtgrHocPhi.RowCount - 2);
            }

            dtgrHocPhi.AllowUserToAddRows = true;
            dtgrHocPhi.AllowUserToDeleteRows = true;
            //this.Controls.Remove(this.dtgrDiem);
        }
    }
}