namespace QLDSV
{
    partial class formDongHP
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
            this.qLDSVDataSet4 = new QLDSV.QLDSVDataSet4();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new QLDSV.QLDSVDataSet4TableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVDataSet4TableAdapters.TableAdapterManager();
            this.dtgrHocPhi = new System.Windows.Forms.DataGridView();
            this.NK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sP_GETHOCPHISVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btBatDau = new System.Windows.Forms.Button();
            this.btGhi = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.cmbMaSV = new System.Windows.Forms.ComboBox();
            this.sINHVIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbHT = new System.Windows.Forms.Label();
            this.lbML = new System.Windows.Forms.Label();
            this.btCANCEL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GETHOCPHISVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // qLDSVDataSet4
            // 
            this.qLDSVDataSet4.DataSetName = "QLDSVDataSet4";
            this.qLDSVDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.qLDSVDataSet4;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dtgrHocPhi
            // 
            this.dtgrHocPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrHocPhi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NK,
            this.HK,
            this.HP,
            this.STDD,
            this.STD});
            this.dtgrHocPhi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgrHocPhi.Location = new System.Drawing.Point(0, 189);
            this.dtgrHocPhi.Name = "dtgrHocPhi";
            this.dtgrHocPhi.Size = new System.Drawing.Size(543, 150);
            this.dtgrHocPhi.TabIndex = 13;
            // 
            // NK
            // 
            this.NK.HeaderText = "NIÊN KHÓA";
            this.NK.Name = "NK";
            // 
            // HK
            // 
            this.HK.HeaderText = "HỌC KÌ";
            this.HK.Name = "HK";
            // 
            // HP
            // 
            this.HP.HeaderText = "HỌC PHÍ";
            this.HP.Name = "HP";
            // 
            // STDD
            // 
            this.STDD.HeaderText = "SỐ TIỀN ĐÃ ĐÓNG";
            this.STDD.Name = "STDD";
            // 
            // STD
            // 
            this.STD.HeaderText = "SỐ TIỀN ĐÓNG";
            this.STD.Name = "STD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã SV";
            // 
            // btBatDau
            // 
            this.btBatDau.Location = new System.Drawing.Point(46, 122);
            this.btBatDau.Name = "btBatDau";
            this.btBatDau.Size = new System.Drawing.Size(75, 23);
            this.btBatDau.TabIndex = 16;
            this.btBatDau.Text = "BẮT ĐẦU";
            this.btBatDau.UseVisualStyleBackColor = true;
            this.btBatDau.Click += new System.EventHandler(this.btBatDau_Click);
            // 
            // btGhi
            // 
            this.btGhi.Location = new System.Drawing.Point(182, 122);
            this.btGhi.Name = "btGhi";
            this.btGhi.Size = new System.Drawing.Size(75, 23);
            this.btGhi.TabIndex = 17;
            this.btGhi.Text = "GHI";
            this.btGhi.UseVisualStyleBackColor = true;
            this.btGhi.Click += new System.EventHandler(this.btGhi_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(318, 122);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 18;
            this.btThoat.Text = "THOÁT";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // cmbMaSV
            // 
            this.cmbMaSV.DataSource = this.sINHVIENBindingSource1;
            this.cmbMaSV.DisplayMember = "MASV";
            this.cmbMaSV.FormattingEnabled = true;
            this.cmbMaSV.Location = new System.Drawing.Point(132, 22);
            this.cmbMaSV.Name = "cmbMaSV";
            this.cmbMaSV.Size = new System.Drawing.Size(121, 21);
            this.cmbMaSV.TabIndex = 19;
            this.cmbMaSV.ValueMember = "MASV";
            // 
            // sINHVIENBindingSource1
            // 
            this.sINHVIENBindingSource1.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource1.DataSource = this.qLDSVDataSet4;
            // 
            // lbHT
            // 
            this.lbHT.AutoSize = true;
            this.lbHT.Location = new System.Drawing.Point(69, 67);
            this.lbHT.Name = "lbHT";
            this.lbHT.Size = new System.Drawing.Size(0, 13);
            this.lbHT.TabIndex = 20;
            // 
            // lbML
            // 
            this.lbML.AutoSize = true;
            this.lbML.Location = new System.Drawing.Point(70, 96);
            this.lbML.Name = "lbML";
            this.lbML.Size = new System.Drawing.Size(0, 13);
            this.lbML.TabIndex = 21;
            // 
            // btCANCEL
            // 
            this.btCANCEL.Location = new System.Drawing.Point(456, 122);
            this.btCANCEL.Name = "btCANCEL";
            this.btCANCEL.Size = new System.Drawing.Size(75, 23);
            this.btCANCEL.TabIndex = 22;
            this.btCANCEL.Text = "CANCEL";
            this.btCANCEL.UseVisualStyleBackColor = true;
            this.btCANCEL.Click += new System.EventHandler(this.btCANCEL_Click);
            // 
            // formDongHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 339);
            this.Controls.Add(this.btCANCEL);
            this.Controls.Add(this.lbML);
            this.Controls.Add(this.lbHT);
            this.Controls.Add(this.cmbMaSV);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btGhi);
            this.Controls.Add(this.btBatDau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgrHocPhi);
            this.Name = "formDongHP";
            this.Text = "formDongHP";
            this.Load += new System.EventHandler(this.formDongHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GETHOCPHISVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLDSVDataSet4 qLDSVDataSet4;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private QLDSVDataSet4TableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private QLDSVDataSet4TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dtgrHocPhi;
        private System.Windows.Forms.BindingSource sP_GETHOCPHISVBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBatDau;
        private System.Windows.Forms.Button btGhi;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.ComboBox cmbMaSV;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NK;
        private System.Windows.Forms.DataGridViewTextBoxColumn HK;
        private System.Windows.Forms.DataGridViewTextBoxColumn HP;
        private System.Windows.Forms.DataGridViewTextBoxColumn STDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn STD;
        private System.Windows.Forms.Label lbHT;
        private System.Windows.Forms.Label lbML;
        private System.Windows.Forms.Button btCANCEL;
    }
}