namespace QLDSV
{
    partial class frmInBDTKet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TxBLop = new System.Windows.Forms.TextBox();
            this.LbLop = new System.Windows.Forms.Label();
            this.LbKhoa = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANH0BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet2 = new QLDSV.QLDSVDataSet2();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.v_DS_PHANMANH0TableAdapter = new QLDSV.QLDSVDataSet2TableAdapters.V_DS_PHANMANH0TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANH0BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxBLop
            // 
            this.TxBLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxBLop.Location = new System.Drawing.Point(139, 97);
            this.TxBLop.Name = "TxBLop";
            this.TxBLop.Size = new System.Drawing.Size(418, 22);
            this.TxBLop.TabIndex = 0;
            // 
            // LbLop
            // 
            this.LbLop.AutoSize = true;
            this.LbLop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLop.Location = new System.Drawing.Point(53, 100);
            this.LbLop.Name = "LbLop";
            this.LbLop.Size = new System.Drawing.Size(79, 17);
            this.LbLop.TabIndex = 1;
            this.LbLop.Text = "TÊN LỚP:";
            // 
            // LbKhoa
            // 
            this.LbKhoa.AutoSize = true;
            this.LbKhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.LbKhoa.Location = new System.Drawing.Point(53, 35);
            this.LbKhoa.Name = "LbKhoa";
            this.LbKhoa.Size = new System.Drawing.Size(55, 17);
            this.LbKhoa.TabIndex = 29;
            this.LbKhoa.Text = "KHOA";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DataSource = this.vDSPHANMANH0BindingSource;
            this.cmbKhoa.DisplayMember = "TENKHOA";
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(53, 59);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(504, 21);
            this.cmbKhoa.TabIndex = 28;
            this.cmbKhoa.ValueMember = "TENSERVER";
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // vDSPHANMANH0BindingSource
            // 
            this.vDSPHANMANH0BindingSource.DataMember = "V_DS_PHANMANH0";
            this.vDSPHANMANH0BindingSource.DataSource = this.qLDSVDataSet2;
            // 
            // qLDSVDataSet2
            // 
            this.qLDSVDataSet2.DataSetName = "QLDSVDataSet2";
            this.qLDSVDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(268, 156);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 43);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(53, 156);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(133, 43);
            this.btnShow.TabIndex = 30;
            this.btnShow.Text = "Xem";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // v_DS_PHANMANH0TableAdapter
            // 
            this.v_DS_PHANMANH0TableAdapter.ClearBeforeFill = true;
            // 
            // frmInBDTKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 236);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.LbKhoa);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.LbLop);
            this.Controls.Add(this.TxBLop);
            this.Name = "frmInBDTKet";
            this.Text = "frmInBDTKet";
            this.Load += new System.EventHandler(this.frmInBDTKet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANH0BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxBLop;
        private System.Windows.Forms.Label LbLop;
        private System.Windows.Forms.Label LbKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShow;
        private QLDSVDataSet2 qLDSVDataSet2;
        private System.Windows.Forms.BindingSource vDSPHANMANH0BindingSource;
        private QLDSVDataSet2TableAdapters.V_DS_PHANMANH0TableAdapter v_DS_PHANMANH0TableAdapter;
    }
}