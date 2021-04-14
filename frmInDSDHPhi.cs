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
    public partial class frmInDSDHPhi : Form
    {
        public frmInDSDHPhi()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool ktra_nkhoa(string nkhoa)
        {
            string[] arr = nkhoa.Split('-');
            arr[0] = arr[0].Trim();
            arr[1] = arr[1].Trim();
            if(arr.Length == 2)
            {
                try
                {
                    int truoc = Convert.ToInt32(arr[0]);
                    int sau = Convert.ToInt32(arr[1]);

                    if (truoc > sau)
                    {
                        MessageBox.Show("Năm ở trước phải bé hơn năm ở sau", "", MessageBoxButtons.OK);
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Các năm không thể là chữ", "", MessageBoxButtons.OK);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Sai cấu trúc niên khóa", "", MessageBoxButtons.OK);
                return false;
                return false;
            }
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(TxBNKhoa.TextLength != 0 && TxBLop.TextLength != 0 && TxBHKi.TextLength != 0)
            {
                try
                {
                    Convert.ToInt32(TxBHKi.Text);
                    if (ktra_nkhoa(TxBNKhoa.Text))
                    {
                        string strLenh = "EXEC SP_LAYDATA_InDSDHPhi '" + TxBLop.Text + "','" + TxBNKhoa.Text + "'," + TxBHKi.Text;

                        SqlDataReader myReader0 = Program.ExecSqlDataReader(strLenh, Program.connstr);

                        if (myReader0 == null) return;
                        myReader0.Read();
                        string tsv = "";
                        string ttien = "";
                        //Console.WriteLine(myReader0.GetString(0));
                        try
                        {
                            //Console.WriteLine(myReader0.GetValue(0));
                            tsv = Convert.ToString(myReader0.GetValue(0));
                            ttien = Convert.ToString(myReader0.GetValue(1));
                            RpInDSDHPhi rpt = new RpInDSDHPhi(TxBLop.Text, TxBNKhoa.Text, TxBHKi.Text, tsv, ttien);

                            ReportPrintTool print = new ReportPrintTool(rpt);
                            print.ShowPreviewDialog();
                        }
                        catch (Exception)
                        {
                            Program.conn.Close();
                            myReader0.Close();
                            return;
                        }
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Học kỳ không thể là chữ", "", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Không bỏ trống ô", "", MessageBoxButtons.OK);
            }           
        }

        private void TxBHKi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt16(TxBHKi.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("Học kì là số");
                return;
            }
        }

        private void TxBNKhoa_TextChanged(object sender, EventArgs e)
        {
            
        }
    }        
}
