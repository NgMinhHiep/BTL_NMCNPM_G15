
namespace BTL_NMCNPM
{
    partial class LoaiTaiKhoanForm
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenLoaiTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMaLoaiTaiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLoaiTaiKhoan = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Location = new System.Drawing.Point(749, 486);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 51);
            this.btnThoat.TabIndex = 65;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBoQua.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnBoQua.Location = new System.Drawing.Point(901, 418);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(86, 51);
            this.btnBoQua.TabIndex = 64;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(901, 348);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 51);
            this.btnXoa.TabIndex = 63;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Yellow;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnSua.Location = new System.Drawing.Point(749, 418);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 51);
            this.btnSua.TabIndex = 62;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(749, 348);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 51);
            this.btnThem.TabIndex = 61;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenLoaiTaiKhoan
            // 
            this.txtTenLoaiTaiKhoan.Location = new System.Drawing.Point(837, 175);
            this.txtTenLoaiTaiKhoan.Name = "txtTenLoaiTaiKhoan";
            this.txtTenLoaiTaiKhoan.Size = new System.Drawing.Size(171, 20);
            this.txtTenLoaiTaiKhoan.TabIndex = 60;
            this.txtTenLoaiTaiKhoan.TextChanged += new System.EventHandler(this.txtTenLoaiTaiKhoan_TextChanged);
            // 
            // txtMaLoaiTaiKhoan
            // 
            this.txtMaLoaiTaiKhoan.Location = new System.Drawing.Point(837, 139);
            this.txtMaLoaiTaiKhoan.Name = "txtMaLoaiTaiKhoan";
            this.txtMaLoaiTaiKhoan.Size = new System.Drawing.Size(171, 20);
            this.txtMaLoaiTaiKhoan.TabIndex = 59;
            this.txtMaLoaiTaiKhoan.TextChanged += new System.EventHandler(this.txtMaLoaiTaiKhoan_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(737, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Tên loại tài khoản";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(737, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Mã loại tài khoản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvLoaiTaiKhoan
            // 
            this.dgvLoaiTaiKhoan.AccessibleName = "";
            this.dgvLoaiTaiKhoan.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvLoaiTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiTaiKhoan.Location = new System.Drawing.Point(1, 100);
            this.dgvLoaiTaiKhoan.Name = "dgvLoaiTaiKhoan";
            this.dgvLoaiTaiKhoan.Size = new System.Drawing.Size(643, 461);
            this.dgvLoaiTaiKhoan.TabIndex = 56;
            this.dgvLoaiTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiTaiKhoan_CellContentClick);
            this.dgvLoaiTaiKhoan.Click += new System.EventHandler(this.dgvLoaiTaiKhoan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(331, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 37);
            this.label6.TabIndex = 55;
            this.label6.Text = "Quản Lý Loại Tài Khoản";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(79, 23);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(73, 13);
            this.lblTaiKhoan.TabIndex = 76;
            this.lblTaiKhoan.Text = "Tên tài khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Tài khoản:";
            // 
            // LoaiTaiKhoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 645);
            this.Controls.Add(this.lblTaiKhoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenLoaiTaiKhoan);
            this.Controls.Add(this.txtMaLoaiTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLoaiTaiKhoan);
            this.Controls.Add(this.label6);
            this.Name = "LoaiTaiKhoanForm";
            this.Text = "LoaiTaiKhoan";
            this.Load += new System.EventHandler(this.LoaiTaiKhoanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenLoaiTaiKhoan;
        private System.Windows.Forms.TextBox txtMaLoaiTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoaiTaiKhoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label label5;
    }
}