namespace QLDSV
{
    partial class frmInPhieuDiem
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
            this.TxBMaSV = new System.Windows.Forms.TextBox();
            this.cmbMaSV = new System.Windows.Forms.ComboBox();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet3 = new QLDSV.QLDSVDataSet3();
            this.LbMaSV = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.LbKhoa = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANH0BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet2 = new QLDSV.QLDSVDataSet2();
            this.v_DS_PHANMANH0TableAdapter = new QLDSV.QLDSVDataSet2TableAdapters.V_DS_PHANMANH0TableAdapter();
            this.sINHVIENTableAdapter = new QLDSV.QLDSVDataSet3TableAdapters.SINHVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANH0BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxBMaSV
            // 
            this.TxBMaSV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxBMaSV.Location = new System.Drawing.Point(32, 102);
            this.TxBMaSV.Name = "TxBMaSV";
            this.TxBMaSV.Size = new System.Drawing.Size(310, 22);
            this.TxBMaSV.TabIndex = 0;
            // 
            // cmbMaSV
            // 
            this.cmbMaSV.DataSource = this.sINHVIENBindingSource;
            this.cmbMaSV.DisplayMember = "MASV";
            this.cmbMaSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaSV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaSV.FormattingEnabled = true;
            this.cmbMaSV.Location = new System.Drawing.Point(348, 101);
            this.cmbMaSV.Name = "cmbMaSV";
            this.cmbMaSV.Size = new System.Drawing.Size(299, 23);
            this.cmbMaSV.TabIndex = 1;
            this.cmbMaSV.ValueMember = "MASV";
            this.cmbMaSV.SelectedIndexChanged += new System.EventHandler(this.cmbMaSV_SelectedIndexChanged);
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.qLDSVDataSet3;
            // 
            // qLDSVDataSet3
            // 
            this.qLDSVDataSet3.DataSetName = "QLDSVDataSet3";
            this.qLDSVDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LbMaSV
            // 
            this.LbMaSV.AutoSize = true;
            this.LbMaSV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMaSV.Location = new System.Drawing.Point(32, 83);
            this.LbMaSV.Name = "LbMaSV";
            this.LbMaSV.Size = new System.Drawing.Size(95, 17);
            this.LbMaSV.TabIndex = 2;
            this.LbMaSV.Text = "Mã Sinh Viên";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(247, 148);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 43);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(32, 148);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(133, 43);
            this.btnShow.TabIndex = 24;
            this.btnShow.Text = "Xem";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // LbKhoa
            // 
            this.LbKhoa.AutoSize = true;
            this.LbKhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.LbKhoa.Location = new System.Drawing.Point(32, 32);
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
            this.cmbKhoa.Location = new System.Drawing.Point(32, 56);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(615, 21);
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
            // v_DS_PHANMANH0TableAdapter
            // 
            this.v_DS_PHANMANH0TableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmInPhieuDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 236);
            this.Controls.Add(this.LbKhoa);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.LbMaSV);
            this.Controls.Add(this.cmbMaSV);
            this.Controls.Add(this.TxBMaSV);
            this.Name = "frmInPhieuDiem";
            this.Text = "frmInPhieuDiem";
            this.Load += new System.EventHandler(this.frmInPhieuDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANH0BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxBMaSV;
        private System.Windows.Forms.ComboBox cmbMaSV;
        private System.Windows.Forms.Label LbMaSV;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label LbKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private QLDSVDataSet2 qLDSVDataSet2;
        private System.Windows.Forms.BindingSource vDSPHANMANH0BindingSource;
        private QLDSVDataSet2TableAdapters.V_DS_PHANMANH0TableAdapter v_DS_PHANMANH0TableAdapter;
        private QLDSVDataSet3 qLDSVDataSet3;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private QLDSVDataSet3TableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
    }
}