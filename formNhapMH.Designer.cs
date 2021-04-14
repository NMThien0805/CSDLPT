namespace QLDSV
{
    partial class formNhapMH
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
            this.btPH = new System.Windows.Forms.Button();
            this.btGhi = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.v_DS_PHANMANH0BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet2 = new QLDSV.QLDSVDataSet2();
            this.v_DS_PHANMANH0TableAdapter = new QLDSV.QLDSVDataSet2TableAdapters.V_DS_PHANMANH0TableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVDataSet2TableAdapters.TableAdapterManager();
            this.dtgrMonHoc = new System.Windows.Forms.DataGridView();
            this.mAMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet3 = new QLDSV.QLDSVDataSet3();
            this.mONHOCTableAdapter = new QLDSV.QLDSVDataSet3TableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager1 = new QLDSV.QLDSVDataSet3TableAdapters.TableAdapterManager();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbMaMH = new System.Windows.Forms.TextBox();
            this.tbTenMH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANH0BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ MÔN HỌC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÊN MÔN HỌC";
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(27, 161);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(94, 37);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "THÊM";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(127, 161);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(94, 37);
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "XÓA";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btPH
            // 
            this.btPH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPH.Location = new System.Drawing.Point(327, 161);
            this.btPH.Name = "btPH";
            this.btPH.Size = new System.Drawing.Size(94, 37);
            this.btPH.TabIndex = 6;
            this.btPH.Text = "PHỤC HOÀI";
            this.btPH.UseVisualStyleBackColor = true;
            // 
            // btGhi
            // 
            this.btGhi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGhi.Location = new System.Drawing.Point(227, 161);
            this.btGhi.Name = "btGhi";
            this.btGhi.Size = new System.Drawing.Size(94, 37);
            this.btGhi.TabIndex = 7;
            this.btGhi.Text = "GHI";
            this.btGhi.UseVisualStyleBackColor = true;
            this.btGhi.Click += new System.EventHandler(this.btGhi_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(427, 161);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(94, 37);
            this.btThoat.TabIndex = 8;
            this.btThoat.Text = "THOÁT";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
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
            // dtgrMonHoc
            // 
            this.dtgrMonHoc.AutoGenerateColumns = false;
            this.dtgrMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAMHDataGridViewTextBoxColumn,
            this.tENMHDataGridViewTextBoxColumn});
            this.dtgrMonHoc.DataSource = this.mONHOCBindingSource;
            this.dtgrMonHoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtgrMonHoc.Location = new System.Drawing.Point(597, 0);
            this.dtgrMonHoc.Name = "dtgrMonHoc";
            this.dtgrMonHoc.Size = new System.Drawing.Size(240, 636);
            this.dtgrMonHoc.TabIndex = 11;
            this.dtgrMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dtgrMonHoc.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // mAMHDataGridViewTextBoxColumn
            // 
            this.mAMHDataGridViewTextBoxColumn.DataPropertyName = "MAMH";
            this.mAMHDataGridViewTextBoxColumn.HeaderText = "MAMH";
            this.mAMHDataGridViewTextBoxColumn.Name = "mAMHDataGridViewTextBoxColumn";
            // 
            // tENMHDataGridViewTextBoxColumn
            // 
            this.tENMHDataGridViewTextBoxColumn.DataPropertyName = "TENMH";
            this.tENMHDataGridViewTextBoxColumn.HeaderText = "TENMH";
            this.tENMHDataGridViewTextBoxColumn.Name = "tENMHDataGridViewTextBoxColumn";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSVDataSet3;
            // 
            // qLDSVDataSet3
            // 
            this.qLDSVDataSet3.DataSetName = "QLDSVDataSet3";
            this.qLDSVDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DIEMTableAdapter = null;
            this.tableAdapterManager1.GIANGVIENTableAdapter = null;
            this.tableAdapterManager1.KHOATableAdapter = null;
            this.tableAdapterManager1.LOPTableAdapter = null;
            this.tableAdapterManager1.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager1.SINHVIENTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QLDSV.QLDSVDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbMaMH
            // 
            this.tbMaMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "MAMH", true));
            this.tbMaMH.Location = new System.Drawing.Point(234, 47);
            this.tbMaMH.Name = "tbMaMH";
            this.tbMaMH.Size = new System.Drawing.Size(100, 21);
            this.tbMaMH.TabIndex = 15;
            // 
            // tbTenMH
            // 
            this.tbTenMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "TENMH", true));
            this.tbTenMH.Location = new System.Drawing.Point(234, 91);
            this.tbTenMH.Name = "tbTenMH";
            this.tbTenMH.Size = new System.Drawing.Size(100, 21);
            this.tbTenMH.TabIndex = 16;
            // 
            // formNhapMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 636);
            this.Controls.Add(this.tbTenMH);
            this.Controls.Add(this.tbMaMH);
            this.Controls.Add(this.dtgrMonHoc);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btGhi);
            this.Controls.Add(this.btPH);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formNhapMH";
            this.Text = "formNhapMH";
            this.Load += new System.EventHandler(this.formNhapMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANH0BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btPH;
        private System.Windows.Forms.Button btGhi;
        private System.Windows.Forms.Button btThoat;
        private QLDSVDataSet2 qLDSVDataSet2;
        private System.Windows.Forms.BindingSource v_DS_PHANMANH0BindingSource;
        private QLDSVDataSet2TableAdapters.V_DS_PHANMANH0TableAdapter v_DS_PHANMANH0TableAdapter;
        private QLDSVDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dtgrMonHoc;
        private QLDSVDataSet3 qLDSVDataSet3;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLDSVDataSet3TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private QLDSVDataSet3TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowguidDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbMaMH;
        private System.Windows.Forms.TextBox tbTenMH;
    }
}