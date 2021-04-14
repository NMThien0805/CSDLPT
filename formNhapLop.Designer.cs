namespace QLDSV
{
    partial class formNhapLop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btGhi = new System.Windows.Forms.Button();
            this.btPH = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANH0BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet2 = new QLDSV.QLDSVDataSet2();
            this.v_DS_PHANMANH0TableAdapter = new QLDSV.QLDSVDataSet2TableAdapters.V_DS_PHANMANH0TableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVDataSet2TableAdapters.TableAdapterManager();
            this.qLDSVDataSet3 = new QLDSV.QLDSVDataSet3();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.QLDSVDataSet3TableAdapters.LOPTableAdapter();
            this.tableAdapterManager1 = new QLDSV.QLDSVDataSet3TableAdapters.TableAdapterManager();
            this.dtgrNhapLop = new System.Windows.Forms.DataGridView();
            this.mALOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENLOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTL = new System.Windows.Forms.TextBox();
            this.tbML = new System.Windows.Forms.TextBox();
            this.tbKhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANH0BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrNhapLop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ LỚP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÊN LỚP";
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(12, 225);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 38);
            this.btThem.TabIndex = 6;
            this.btThem.Text = "THÊM";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(119, 225);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 38);
            this.btXoa.TabIndex = 7;
            this.btXoa.Text = "XÓA";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btGhi
            // 
            this.btGhi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGhi.Location = new System.Drawing.Point(228, 225);
            this.btGhi.Name = "btGhi";
            this.btGhi.Size = new System.Drawing.Size(75, 38);
            this.btGhi.TabIndex = 8;
            this.btGhi.Text = "GHI";
            this.btGhi.UseVisualStyleBackColor = true;
            this.btGhi.Click += new System.EventHandler(this.btGhi_Click);
            // 
            // btPH
            // 
            this.btPH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPH.Location = new System.Drawing.Point(330, 225);
            this.btPH.Name = "btPH";
            this.btPH.Size = new System.Drawing.Size(75, 38);
            this.btPH.TabIndex = 9;
            this.btPH.Text = "PHỤC HỒI";
            this.btPH.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "KHOA";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DataSource = this.v_DS_PHANMANH0BindingSource;
            this.cmbKhoa.DisplayMember = "TENKHOA";
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(182, 11);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(121, 21);
            this.cmbKhoa.TabIndex = 18;
            this.cmbKhoa.ValueMember = "TENSERVER";
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged_1);
            // 
            // v_DS_PHANMANH0BindingSource
            // 
            this.v_DS_PHANMANH0BindingSource.DataMember = "V_DS_PHANMANH0";
            this.v_DS_PHANMANH0BindingSource.DataSource = this.qLDSVDataSet2;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qLDSVDataSet3
            // 
            this.qLDSVDataSet3.DataSetName = "QLDSVDataSet3";
            this.qLDSVDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSVDataSet3;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DIEMTableAdapter = null;
            this.tableAdapterManager1.GIANGVIENTableAdapter = null;
            this.tableAdapterManager1.KHOATableAdapter = null;
            this.tableAdapterManager1.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager1.MONHOCTableAdapter = null;
            this.tableAdapterManager1.SINHVIENTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QLDSV.QLDSVDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dtgrNhapLop
            // 
            this.dtgrNhapLop.AutoGenerateColumns = false;
            this.dtgrNhapLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrNhapLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mALOPDataGridViewTextBoxColumn,
            this.tENLOPDataGridViewTextBoxColumn,
            this.mAKHDataGridViewTextBoxColumn});
            this.dtgrNhapLop.DataSource = this.lOPBindingSource;
            this.dtgrNhapLop.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtgrNhapLop.Location = new System.Drawing.Point(552, 0);
            this.dtgrNhapLop.Name = "dtgrNhapLop";
            this.dtgrNhapLop.Size = new System.Drawing.Size(345, 392);
            this.dtgrNhapLop.TabIndex = 19;
            this.dtgrNhapLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrNhapLop_CellContentClick);
            this.dtgrNhapLop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrNhapLop_CellContentClick_1);
            // 
            // mALOPDataGridViewTextBoxColumn
            // 
            this.mALOPDataGridViewTextBoxColumn.DataPropertyName = "MALOP";
            this.mALOPDataGridViewTextBoxColumn.HeaderText = "MALOP";
            this.mALOPDataGridViewTextBoxColumn.Name = "mALOPDataGridViewTextBoxColumn";
            // 
            // tENLOPDataGridViewTextBoxColumn
            // 
            this.tENLOPDataGridViewTextBoxColumn.DataPropertyName = "TENLOP";
            this.tENLOPDataGridViewTextBoxColumn.HeaderText = "TENLOP";
            this.tENLOPDataGridViewTextBoxColumn.Name = "tENLOPDataGridViewTextBoxColumn";
            // 
            // mAKHDataGridViewTextBoxColumn
            // 
            this.mAKHDataGridViewTextBoxColumn.DataPropertyName = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.HeaderText = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.Name = "mAKHDataGridViewTextBoxColumn";
            // 
            // tbTL
            // 
            this.tbTL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "TENLOP", true));
            this.tbTL.Location = new System.Drawing.Point(182, 148);
            this.tbTL.Name = "tbTL";
            this.tbTL.Size = new System.Drawing.Size(100, 21);
            this.tbTL.TabIndex = 21;
            // 
            // tbML
            // 
            this.tbML.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MALOP", true));
            this.tbML.Location = new System.Drawing.Point(182, 104);
            this.tbML.Name = "tbML";
            this.tbML.Size = new System.Drawing.Size(100, 21);
            this.tbML.TabIndex = 22;
            // 
            // tbKhoa
            // 
            this.tbKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MAKH", true));
            this.tbKhoa.Location = new System.Drawing.Point(182, 65);
            this.tbKhoa.Name = "tbKhoa";
            this.tbKhoa.Size = new System.Drawing.Size(100, 21);
            this.tbKhoa.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "MÃ KHOA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(430, 225);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 38);
            this.btThoat.TabIndex = 26;
            this.btThoat.Text = "THOÁT";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // formNhapLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 392);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbKhoa);
            this.Controls.Add(this.tbML);
            this.Controls.Add(this.tbTL);
            this.Controls.Add(this.dtgrNhapLop);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btPH);
            this.Controls.Add(this.btGhi);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formNhapLop";
            this.Text = "formNhapLop";
            this.Load += new System.EventHandler(this.formNhapLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANH0BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrNhapLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btGhi;
        private System.Windows.Forms.Button btPH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private QLDSVDataSet2 qLDSVDataSet2;
        private System.Windows.Forms.BindingSource v_DS_PHANMANH0BindingSource;
        private QLDSVDataSet2TableAdapters.V_DS_PHANMANH0TableAdapter v_DS_PHANMANH0TableAdapter;
        private QLDSVDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private QLDSVDataSet3 qLDSVDataSet3;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVDataSet3TableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLDSVDataSet3TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dtgrNhapLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENLOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbTL;
        private System.Windows.Forms.TextBox tbML;
        private System.Windows.Forms.TextBox tbKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btThoat;
    }
}