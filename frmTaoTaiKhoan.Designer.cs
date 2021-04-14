namespace QLDSV
{
    partial class frmTaoTaiKhoan
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
            this.TxBPass = new System.Windows.Forms.TextBox();
            this.TxBCFirmPass = new System.Windows.Forms.TextBox();
            this.LbUser = new System.Windows.Forms.Label();
            this.LbPass = new System.Windows.Forms.Label();
            this.LbCfPass = new System.Windows.Forms.Label();
            this.LbKhoa = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.btnTaoTK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.LbRole = new System.Windows.Forms.Label();
            this.qLDSVDataSet1 = new QLDSV.QLDSVDataSet1();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new QLDSV.QLDSVDataSet1TableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVDataSet1TableAdapters.TableAdapterManager();
            this.qLDSVDataSet2 = new QLDSV.QLDSVDataSet2();
            this.v_DS_PHANMANH0BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANH0TableAdapter = new QLDSV.QLDSVDataSet2TableAdapters.V_DS_PHANMANH0TableAdapter();
            this.tableAdapterManager1 = new QLDSV.QLDSVDataSet2TableAdapters.TableAdapterManager();
            this.qLDSVDataSetTimLoginSV12 = new QLDSV.QLDSVDataSetTimLoginSV12();
            this.v_TIMLOGINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_TIMLOGINTableAdapterSV12 = new QLDSV.QLDSVDataSetTimLoginSV12TableAdapters.V_TIMLOGINTableAdapter();
            this.tableAdapterManager2 = new QLDSV.QLDSVDataSetTimLoginSV12TableAdapters.TableAdapterManager();
            this.qLDSVDataSetTimLoginSV3 = new QLDSV.QLDSVDataSetTimLoginSV3();
            this.v_TIMLOGINBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.v_TIMLOGINTableAdapterSV3 = new QLDSV.QLDSVDataSetTimLoginSV3TableAdapters.V_TIMLOGINTableAdapter();
            this.tableAdapterManager3 = new QLDSV.QLDSVDataSetTimLoginSV3TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANH0BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetTimLoginSV12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_TIMLOGINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetTimLoginSV3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_TIMLOGINBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxBPass
            // 
            this.TxBPass.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.TxBPass.Location = new System.Drawing.Point(56, 202);
            this.TxBPass.Name = "TxBPass";
            this.TxBPass.PasswordChar = '*';
            this.TxBPass.Size = new System.Drawing.Size(250, 22);
            this.TxBPass.TabIndex = 1;
            this.TxBPass.UseSystemPasswordChar = true;
            // 
            // TxBCFirmPass
            // 
            this.TxBCFirmPass.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.TxBCFirmPass.Location = new System.Drawing.Point(56, 254);
            this.TxBCFirmPass.Name = "TxBCFirmPass";
            this.TxBCFirmPass.PasswordChar = '*';
            this.TxBCFirmPass.Size = new System.Drawing.Size(250, 22);
            this.TxBCFirmPass.TabIndex = 2;
            this.TxBCFirmPass.UseSystemPasswordChar = true;
            // 
            // LbUser
            // 
            this.LbUser.AutoSize = true;
            this.LbUser.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.LbUser.Location = new System.Drawing.Point(53, 129);
            this.LbUser.Name = "LbUser";
            this.LbUser.Size = new System.Drawing.Size(78, 17);
            this.LbUser.TabIndex = 3;
            this.LbUser.Text = "UserName";
            this.LbUser.Click += new System.EventHandler(this.LbUser_Click);
            // 
            // LbPass
            // 
            this.LbPass.AutoSize = true;
            this.LbPass.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.LbPass.Location = new System.Drawing.Point(53, 182);
            this.LbPass.Name = "LbPass";
            this.LbPass.Size = new System.Drawing.Size(70, 17);
            this.LbPass.TabIndex = 4;
            this.LbPass.Text = "Password";
            // 
            // LbCfPass
            // 
            this.LbCfPass.AutoSize = true;
            this.LbCfPass.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.LbCfPass.Location = new System.Drawing.Point(56, 234);
            this.LbCfPass.Name = "LbCfPass";
            this.LbCfPass.Size = new System.Drawing.Size(127, 17);
            this.LbCfPass.TabIndex = 5;
            this.LbCfPass.Text = "Confirm Password";
            // 
            // LbKhoa
            // 
            this.LbKhoa.AutoSize = true;
            this.LbKhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbKhoa.Location = new System.Drawing.Point(56, 34);
            this.LbKhoa.Name = "LbKhoa";
            this.LbKhoa.Size = new System.Drawing.Size(55, 17);
            this.LbKhoa.TabIndex = 6;
            this.LbKhoa.Text = "KHOA";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(56, 51);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(523, 23);
            this.cmbKhoa.TabIndex = 7;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoTK.Location = new System.Drawing.Point(440, 149);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(139, 23);
            this.btnTaoTK.TabIndex = 8;
            this.btnTaoTK.Text = "Tạo Tài Khoản";
            this.btnTaoTK.UseVisualStyleBackColor = true;
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(440, 202);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(56, 306);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(250, 23);
            this.cmbRole.TabIndex = 10;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            // 
            // cmbUser
            // 
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(56, 151);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(250, 23);
            this.cmbUser.TabIndex = 11;
            this.cmbUser.SelectedIndexChanged += new System.EventHandler(this.cmbUser_SelectedIndexChanged);
            // 
            // LbRole
            // 
            this.LbRole.AutoSize = true;
            this.LbRole.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.LbRole.Location = new System.Drawing.Point(59, 287);
            this.LbRole.Name = "LbRole";
            this.LbRole.Size = new System.Drawing.Size(90, 17);
            this.LbRole.TabIndex = 12;
            this.LbRole.Text = "Nhóm quyền";
            // 
            // qLDSVDataSet1
            // 
            this.qLDSVDataSet1.DataSetName = "QLDSVDataSet1";
            this.qLDSVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.qLDSVDataSet1;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qLDSVDataSet2
            // 
            this.qLDSVDataSet2.DataSetName = "QLDSVDataSet2";
            this.qLDSVDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANH0BindingSource
            // 
            this.v_DS_PHANMANH0BindingSource.DataMember = "V_DS_PHANMANH0";
            this.v_DS_PHANMANH0BindingSource.DataSource = this.qLDSVDataSet2;
            // 
            // v_DS_PHANMANH0TableAdapter
            // 
            this.v_DS_PHANMANH0TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QLDSV.QLDSVDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qLDSVDataSetTimLoginSV12
            // 
            this.qLDSVDataSetTimLoginSV12.DataSetName = "QLDSVDataSetTimLoginSV12";
            this.qLDSVDataSetTimLoginSV12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_TIMLOGINBindingSource
            // 
            this.v_TIMLOGINBindingSource.DataMember = "V_TIMLOGIN";
            this.v_TIMLOGINBindingSource.DataSource = this.qLDSVDataSetTimLoginSV12;
            // 
            // v_TIMLOGINTableAdapterSV12
            // 
            this.v_TIMLOGINTableAdapterSV12.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.UpdateOrder = QLDSV.QLDSVDataSetTimLoginSV12TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qLDSVDataSetTimLoginSV3
            // 
            this.qLDSVDataSetTimLoginSV3.DataSetName = "QLDSVDataSetTimLoginSV3";
            this.qLDSVDataSetTimLoginSV3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_TIMLOGINBindingSource1
            // 
            this.v_TIMLOGINBindingSource1.DataMember = "V_TIMLOGIN";
            this.v_TIMLOGINBindingSource1.DataSource = this.qLDSVDataSetTimLoginSV3;
            // 
            // v_TIMLOGINTableAdapterSV3
            // 
            this.v_TIMLOGINTableAdapterSV3.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.Connection = null;
            this.tableAdapterManager3.UpdateOrder = QLDSV.QLDSVDataSetTimLoginSV3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 356);
            this.Controls.Add(this.LbRole);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTaoTK);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.LbKhoa);
            this.Controls.Add(this.LbCfPass);
            this.Controls.Add(this.LbPass);
            this.Controls.Add(this.LbUser);
            this.Controls.Add(this.TxBCFirmPass);
            this.Controls.Add(this.TxBPass);
            this.Name = "frmTaoTaiKhoan";
            this.Text = "frmTaoTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANH0BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetTimLoginSV12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_TIMLOGINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetTimLoginSV3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_TIMLOGINBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxBPass;
        private System.Windows.Forms.TextBox TxBCFirmPass;
        private System.Windows.Forms.Label LbUser;
        private System.Windows.Forms.Label LbPass;
        private System.Windows.Forms.Label LbCfPass;
        private System.Windows.Forms.Label LbKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Button btnTaoTK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Label LbRole;
        private QLDSVDataSet1 qLDSVDataSet1;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private QLDSVDataSet1TableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private QLDSVDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private QLDSVDataSet2 qLDSVDataSet2;
        private System.Windows.Forms.BindingSource v_DS_PHANMANH0BindingSource;
        private QLDSVDataSet2TableAdapters.V_DS_PHANMANH0TableAdapter v_DS_PHANMANH0TableAdapter;
        private QLDSVDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private QLDSVDataSetTimLoginSV12 qLDSVDataSetTimLoginSV12;
        private System.Windows.Forms.BindingSource v_TIMLOGINBindingSource;
        private QLDSVDataSetTimLoginSV12TableAdapters.V_TIMLOGINTableAdapter v_TIMLOGINTableAdapterSV12;
        private QLDSVDataSetTimLoginSV12TableAdapters.TableAdapterManager tableAdapterManager2;
        private QLDSVDataSetTimLoginSV3 qLDSVDataSetTimLoginSV3;
        private System.Windows.Forms.BindingSource v_TIMLOGINBindingSource1;
        private QLDSVDataSetTimLoginSV3TableAdapters.V_TIMLOGINTableAdapter v_TIMLOGINTableAdapterSV3;
        private QLDSVDataSetTimLoginSV3TableAdapters.TableAdapterManager tableAdapterManager3;
    }
}