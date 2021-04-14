namespace QLDSV
{
    partial class frmInDSDHPhi
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
            this.TxBLop = new System.Windows.Forms.TextBox();
            this.TxBNKhoa = new System.Windows.Forms.TextBox();
            this.TxBHKi = new System.Windows.Forms.TextBox();
            this.LbLop = new System.Windows.Forms.Label();
            this.LbNienKhoa = new System.Windows.Forms.Label();
            this.LbHocKi = new System.Windows.Forms.Label();
            this.LbTongSoSV = new System.Windows.Forms.Label();
            this.LbTongSoTienDong = new System.Windows.Forms.Label();
            this.LbValueTongSoSV = new System.Windows.Forms.Label();
            this.LbValueTongSoTienDong = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxBLop
            // 
            this.TxBLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.TxBLop.Location = new System.Drawing.Point(46, 75);
            this.TxBLop.Margin = new System.Windows.Forms.Padding(4);
            this.TxBLop.MaxLength = 20;
            this.TxBLop.Name = "TxBLop";
            this.TxBLop.Size = new System.Drawing.Size(460, 22);
            this.TxBLop.TabIndex = 0;
            // 
            // TxBNKhoa
            // 
            this.TxBNKhoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.TxBNKhoa.Location = new System.Drawing.Point(46, 135);
            this.TxBNKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.TxBNKhoa.MaxLength = 13;
            this.TxBNKhoa.Name = "TxBNKhoa";
            this.TxBNKhoa.Size = new System.Drawing.Size(460, 22);
            this.TxBNKhoa.TabIndex = 1;
            this.TxBNKhoa.TextChanged += new System.EventHandler(this.TxBNKhoa_TextChanged);
            // 
            // TxBHKi
            // 
            this.TxBHKi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.TxBHKi.Location = new System.Drawing.Point(46, 194);
            this.TxBHKi.Margin = new System.Windows.Forms.Padding(4);
            this.TxBHKi.MaxLength = 2;
            this.TxBHKi.Name = "TxBHKi";
            this.TxBHKi.Size = new System.Drawing.Size(460, 22);
            this.TxBHKi.TabIndex = 2;
            this.TxBHKi.TextChanged += new System.EventHandler(this.TxBHKi_TextChanged);
            // 
            // LbLop
            // 
            this.LbLop.AutoSize = true;
            this.LbLop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.LbLop.Location = new System.Drawing.Point(46, 50);
            this.LbLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbLop.Name = "LbLop";
            this.LbLop.Size = new System.Drawing.Size(69, 17);
            this.LbLop.TabIndex = 3;
            this.LbLop.Text = "MÃ LỚP";
            // 
            // LbNienKhoa
            // 
            this.LbNienKhoa.AutoSize = true;
            this.LbNienKhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.LbNienKhoa.Location = new System.Drawing.Point(46, 110);
            this.LbNienKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbNienKhoa.Name = "LbNienKhoa";
            this.LbNienKhoa.Size = new System.Drawing.Size(97, 17);
            this.LbNienKhoa.TabIndex = 4;
            this.LbNienKhoa.Text = "NIÊN KHÓA";
            // 
            // LbHocKi
            // 
            this.LbHocKi.AutoSize = true;
            this.LbHocKi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.LbHocKi.Location = new System.Drawing.Point(46, 169);
            this.LbHocKi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbHocKi.Name = "LbHocKi";
            this.LbHocKi.Size = new System.Drawing.Size(65, 17);
            this.LbHocKi.TabIndex = 5;
            this.LbHocKi.Text = "HỌC KÌ";
            // 
            // LbTongSoSV
            // 
            this.LbTongSoSV.AutoSize = true;
            this.LbTongSoSV.Location = new System.Drawing.Point(89, 526);
            this.LbTongSoSV.Name = "LbTongSoSV";
            this.LbTongSoSV.Size = new System.Drawing.Size(129, 17);
            this.LbTongSoSV.TabIndex = 14;
            this.LbTongSoSV.Text = "Tổng số sinh viên:";
            // 
            // LbTongSoTienDong
            // 
            this.LbTongSoTienDong.AutoSize = true;
            this.LbTongSoTienDong.Location = new System.Drawing.Point(89, 573);
            this.LbTongSoTienDong.Name = "LbTongSoTienDong";
            this.LbTongSoTienDong.Size = new System.Drawing.Size(162, 17);
            this.LbTongSoTienDong.TabIndex = 15;
            this.LbTongSoTienDong.Text = "Tổng số tiền phải đóng:";
            // 
            // LbValueTongSoSV
            // 
            this.LbValueTongSoSV.AutoSize = true;
            this.LbValueTongSoSV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbValueTongSoSV.Location = new System.Drawing.Point(269, 526);
            this.LbValueTongSoSV.Name = "LbValueTongSoSV";
            this.LbValueTongSoSV.Size = new System.Drawing.Size(0, 17);
            this.LbValueTongSoSV.TabIndex = 16;
            // 
            // LbValueTongSoTienDong
            // 
            this.LbValueTongSoTienDong.AutoSize = true;
            this.LbValueTongSoTienDong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbValueTongSoTienDong.Location = new System.Drawing.Point(301, 573);
            this.LbValueTongSoTienDong.Name = "LbValueTongSoTienDong";
            this.LbValueTongSoTienDong.Size = new System.Drawing.Size(0, 17);
            this.LbValueTongSoTienDong.TabIndex = 17;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(262, 242);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 43);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(47, 242);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(133, 43);
            this.btnShow.TabIndex = 28;
            this.btnShow.Text = "Xem";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmInDSDHPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 340);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.LbValueTongSoTienDong);
            this.Controls.Add(this.LbValueTongSoSV);
            this.Controls.Add(this.LbTongSoTienDong);
            this.Controls.Add(this.LbTongSoSV);
            this.Controls.Add(this.LbHocKi);
            this.Controls.Add(this.LbNienKhoa);
            this.Controls.Add(this.LbLop);
            this.Controls.Add(this.TxBHKi);
            this.Controls.Add(this.TxBNKhoa);
            this.Controls.Add(this.TxBLop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInDSDHPhi";
            this.Text = "frmInDSDHPhi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxBLop;
        private System.Windows.Forms.TextBox TxBNKhoa;
        private System.Windows.Forms.TextBox TxBHKi;
        private System.Windows.Forms.Label LbLop;
        private System.Windows.Forms.Label LbNienKhoa;
        private System.Windows.Forms.Label LbHocKi;
        private System.Windows.Forms.Label LbTongSoSV;
        private System.Windows.Forms.Label LbTongSoTienDong;
        private System.Windows.Forms.Label LbValueTongSoSV;
        private System.Windows.Forms.Label LbValueTongSoTienDong;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShow;
    }
}