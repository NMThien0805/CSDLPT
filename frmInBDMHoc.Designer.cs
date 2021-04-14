namespace QLDSV
{
    partial class frmInBDMHoc
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
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet3 = new QLDSV.QLDSVDataSet3();
            this.cmbMHoc = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxBLanThi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbMonHoc = new System.Windows.Forms.Label();
            this.LbLanThi = new System.Windows.Forms.Label();
            this.LbValueLop = new System.Windows.Forms.Label();
            this.LbValueMHoc = new System.Windows.Forms.Label();
            this.LbValueHocKi = new System.Windows.Forms.Label();
            this.LbValueLanThi = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.LbKhoa = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANH0BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet2 = new QLDSV.QLDSVDataSet2();
            this.v_DS_PHANMANH0TableAdapter = new QLDSV.QLDSVDataSet2TableAdapters.V_DS_PHANMANH0TableAdapter();
            this.lOPTableAdapter = new QLDSV.QLDSVDataSet3TableAdapters.LOPTableAdapter();
            this.mONHOCTableAdapter = new QLDSV.QLDSVDataSet3TableAdapters.MONHOCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANH0BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLop
            // 
            this.cmbLop.DataSource = this.lOPBindingSource;
            this.cmbLop.DisplayMember = "TENLOP";
            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(30, 143);
            this.cmbLop.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(615, 23);
            this.cmbLop.TabIndex = 0;
            this.cmbLop.ValueMember = "MALOP";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSVDataSet3;
            // 
            // qLDSVDataSet3
            // 
            this.qLDSVDataSet3.DataSetName = "QLDSVDataSet3";
            this.qLDSVDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMHoc
            // 
            this.cmbMHoc.DataSource = this.mONHOCBindingSource;
            this.cmbMHoc.DisplayMember = "TENMH";
            this.cmbMHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMHoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbMHoc.FormattingEnabled = true;
            this.cmbMHoc.Location = new System.Drawing.Point(30, 231);
            this.cmbMHoc.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMHoc.Name = "cmbMHoc";
            this.cmbMHoc.Size = new System.Drawing.Size(615, 23);
            this.cmbMHoc.TabIndex = 1;
            this.cmbMHoc.ValueMember = "MAMH";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSVDataSet3;
            // 
            // TxBLanThi
            // 
            this.TxBLanThi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.TxBLanThi.Location = new System.Drawing.Point(30, 316);
            this.TxBLanThi.Margin = new System.Windows.Forms.Padding(4);
            this.TxBLanThi.Name = "TxBLanThi";
            this.TxBLanThi.Size = new System.Drawing.Size(148, 22);
            this.TxBLanThi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "LỚP";
            // 
            // LbMonHoc
            // 
            this.LbMonHoc.AutoSize = true;
            this.LbMonHoc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMonHoc.Location = new System.Drawing.Point(30, 207);
            this.LbMonHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbMonHoc.Name = "LbMonHoc";
            this.LbMonHoc.Size = new System.Drawing.Size(85, 17);
            this.LbMonHoc.TabIndex = 4;
            this.LbMonHoc.Text = "MÔN HỌC";
            // 
            // LbLanThi
            // 
            this.LbLanThi.AutoSize = true;
            this.LbLanThi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLanThi.Location = new System.Drawing.Point(30, 296);
            this.LbLanThi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbLanThi.Name = "LbLanThi";
            this.LbLanThi.Size = new System.Drawing.Size(72, 17);
            this.LbLanThi.TabIndex = 5;
            this.LbLanThi.Text = "LẦN THI";
            // 
            // LbValueLop
            // 
            this.LbValueLop.AutoSize = true;
            this.LbValueLop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbValueLop.Location = new System.Drawing.Point(866, 322);
            this.LbValueLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbValueLop.Name = "LbValueLop";
            this.LbValueLop.Size = new System.Drawing.Size(0, 17);
            this.LbValueLop.TabIndex = 12;
            // 
            // LbValueMHoc
            // 
            this.LbValueMHoc.AutoSize = true;
            this.LbValueMHoc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbValueMHoc.Location = new System.Drawing.Point(866, 373);
            this.LbValueMHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbValueMHoc.Name = "LbValueMHoc";
            this.LbValueMHoc.Size = new System.Drawing.Size(0, 17);
            this.LbValueMHoc.TabIndex = 13;
            // 
            // LbValueHocKi
            // 
            this.LbValueHocKi.AutoSize = true;
            this.LbValueHocKi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbValueHocKi.Location = new System.Drawing.Point(866, 424);
            this.LbValueHocKi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbValueHocKi.Name = "LbValueHocKi";
            this.LbValueHocKi.Size = new System.Drawing.Size(0, 17);
            this.LbValueHocKi.TabIndex = 14;
            // 
            // LbValueLanThi
            // 
            this.LbValueLanThi.AutoSize = true;
            this.LbValueLanThi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbValueLanThi.Location = new System.Drawing.Point(866, 477);
            this.LbValueLanThi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbValueLanThi.Name = "LbValueLanThi";
            this.LbValueLanThi.Size = new System.Drawing.Size(0, 17);
            this.LbValueLanThi.TabIndex = 15;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(245, 296);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(166, 42);
            this.btnShow.TabIndex = 16;
            this.btnShow.Text = "Xem";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(479, 296);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 42);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LbKhoa
            // 
            this.LbKhoa.AutoSize = true;
            this.LbKhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.LbKhoa.Location = new System.Drawing.Point(30, 26);
            this.LbKhoa.Name = "LbKhoa";
            this.LbKhoa.Size = new System.Drawing.Size(55, 17);
            this.LbKhoa.TabIndex = 27;
            this.LbKhoa.Text = "KHOA";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DataSource = this.vDSPHANMANH0BindingSource;
            this.cmbKhoa.DisplayMember = "TENKHOA";
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(30, 50);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(615, 25);
            this.cmbKhoa.TabIndex = 26;
            this.cmbKhoa.ValueMember = "TENSERVER";
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // vDSPHANMANH0BindingSource
            // 
            this.vDSPHANMANH0BindingSource.DataMember = "V_DS_PHANMANH0";
            this.vDSPHANMANH0BindingSource.DataSource = this.qLDSVDataSet2BindingSource;
            // 
            // qLDSVDataSet2BindingSource
            // 
            this.qLDSVDataSet2BindingSource.DataSource = this.qLDSVDataSet2;
            this.qLDSVDataSet2BindingSource.Position = 0;
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
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // frmInBDMHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 362);
            this.Controls.Add(this.LbKhoa);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.LbValueLanThi);
            this.Controls.Add(this.LbValueHocKi);
            this.Controls.Add(this.LbValueMHoc);
            this.Controls.Add(this.LbValueLop);
            this.Controls.Add(this.LbLanThi);
            this.Controls.Add(this.LbMonHoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxBLanThi);
            this.Controls.Add(this.cmbMHoc);
            this.Controls.Add(this.cmbLop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInBDMHoc";
            this.Text = "frmInBDMHoc";
            this.Load += new System.EventHandler(this.frmInBDMHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANH0BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.ComboBox cmbMHoc;
        private System.Windows.Forms.TextBox TxBLanThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbMonHoc;
        private System.Windows.Forms.Label LbLanThi;
        private System.Windows.Forms.Label LbValueLop;
        private System.Windows.Forms.Label LbValueMHoc;
        private System.Windows.Forms.Label LbValueHocKi;
        private System.Windows.Forms.Label LbValueLanThi;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label LbKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.BindingSource qLDSVDataSet2BindingSource;
        private QLDSVDataSet2 qLDSVDataSet2;
        private System.Windows.Forms.BindingSource vDSPHANMANH0BindingSource;
        private QLDSVDataSet2TableAdapters.V_DS_PHANMANH0TableAdapter v_DS_PHANMANH0TableAdapter;
        private QLDSVDataSet3 qLDSVDataSet3;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVDataSet3TableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLDSVDataSet3TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
    }
}