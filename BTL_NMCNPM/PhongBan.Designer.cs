
namespace BTL_NMCNPM
{
    partial class PhongBanForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.txtTenPhongBan = new System.Windows.Forms.TextBox();
            this.txtMaPhongBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(332, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 37);
            this.label6.TabIndex = 27;
            this.label6.Text = "Quản Lý Phòng Ban";
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.AccessibleName = "";
            this.dgvPhongBan.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Location = new System.Drawing.Point(2, 86);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.Size = new System.Drawing.Size(643, 461);
            this.dgvPhongBan.TabIndex = 28;
            this.dgvPhongBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBan_CellContentClick);
            this.dgvPhongBan.Click += new System.EventHandler(this.dgvPhongBan_Click);
            // 
            // txtTenPhongBan
            // 
            this.txtTenPhongBan.Location = new System.Drawing.Point(838, 161);
            this.txtTenPhongBan.Name = "txtTenPhongBan";
            this.txtTenPhongBan.Size = new System.Drawing.Size(171, 20);
            this.txtTenPhongBan.TabIndex = 49;
            // 
            // txtMaPhongBan
            // 
            this.txtMaPhongBan.Location = new System.Drawing.Point(838, 125);
            this.txtMaPhongBan.Name = "txtMaPhongBan";
            this.txtMaPhongBan.Size = new System.Drawing.Size(171, 20);
            this.txtMaPhongBan.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(738, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Tên phòng ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(738, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mã phòng ban";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Location = new System.Drawing.Point(750, 472);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 51);
            this.btnThoat.TabIndex = 54;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBoQua.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnBoQua.Location = new System.Drawing.Point(902, 404);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(86, 51);
            this.btnBoQua.TabIndex = 53;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(902, 334);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 51);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Yellow;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnSua.Location = new System.Drawing.Point(750, 404);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 51);
            this.btnSua.TabIndex = 51;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(750, 334);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 51);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(78, 18);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(73, 13);
            this.lblTaiKhoan.TabIndex = 76;
            this.lblTaiKhoan.Text = "Tên tài khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Tài khoản:";
            // 
            // PhongBanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 589);
            this.Controls.Add(this.lblTaiKhoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenPhongBan);
            this.Controls.Add(this.txtMaPhongBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPhongBan);
            this.Controls.Add(this.label6);
            this.Name = "PhongBanForm";
            this.Text = "PhongBan";
            this.Load += new System.EventHandler(this.PhongBanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.TextBox txtTenPhongBan;
        private System.Windows.Forms.TextBox txtMaPhongBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label label5;
    }
}