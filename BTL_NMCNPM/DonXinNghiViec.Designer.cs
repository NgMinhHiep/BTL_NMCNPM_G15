
namespace BTL_NMCNPM
{
    partial class DonXinNghiViecForm
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
            this.txtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaDXNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDXNV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDXNV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayLap.Location = new System.Drawing.Point(835, 124);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(171, 20);
            this.txtNgayLap.TabIndex = 99;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(712, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 98;
            this.label8.Text = "Ngày lập";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(835, 279);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(171, 20);
            this.txtLyDo.TabIndex = 97;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(835, 243);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(171, 20);
            this.txtMaNhanVien.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(712, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 95;
            this.label3.Text = "Lý do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(712, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "Mã nhân viên";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Location = new System.Drawing.Point(747, 484);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 51);
            this.btnThoat.TabIndex = 93;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBoQua.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnBoQua.Location = new System.Drawing.Point(899, 416);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(86, 51);
            this.btnBoQua.TabIndex = 92;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(899, 346);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 51);
            this.btnXoa.TabIndex = 91;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Yellow;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnSua.Location = new System.Drawing.Point(747, 416);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 51);
            this.btnSua.TabIndex = 90;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(747, 346);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 51);
            this.btnThem.TabIndex = 89;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaDXNV
            // 
            this.txtMaDXNV.Location = new System.Drawing.Point(835, 87);
            this.txtMaDXNV.Name = "txtMaDXNV";
            this.txtMaDXNV.Size = new System.Drawing.Size(171, 20);
            this.txtMaDXNV.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(712, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Mã đơn xin nghỉ việc";
            // 
            // dgvDXNV
            // 
            this.dgvDXNV.AccessibleName = "";
            this.dgvDXNV.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvDXNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDXNV.Location = new System.Drawing.Point(0, 80);
            this.dgvDXNV.Name = "dgvDXNV";
            this.dgvDXNV.Size = new System.Drawing.Size(643, 461);
            this.dgvDXNV.TabIndex = 84;
            this.dgvDXNV.Click += new System.EventHandler(this.dgvDXNV_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(354, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 37);
            this.label6.TabIndex = 83;
            this.label6.Text = "Quản Lý Đơn Xin Nghỉ Việc";
            // 
            // txtNgayBatDau
            // 
            this.txtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayBatDau.Location = new System.Drawing.Point(835, 162);
            this.txtNgayBatDau.Name = "txtNgayBatDau";
            this.txtNgayBatDau.Size = new System.Drawing.Size(171, 20);
            this.txtNgayBatDau.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(712, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // txtNgayKetThuc
            // 
            this.txtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayKetThuc.Location = new System.Drawing.Point(835, 200);
            this.txtNgayKetThuc.Name = "txtNgayKetThuc";
            this.txtNgayKetThuc.Size = new System.Drawing.Size(171, 20);
            this.txtNgayKetThuc.TabIndex = 103;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(712, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 102;
            this.label5.Text = "Ngày kết thúc";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(81, 18);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(73, 13);
            this.lblTaiKhoan.TabIndex = 105;
            this.lblTaiKhoan.Text = "Tên tài khoản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 104;
            this.label7.Text = "Tài khoản:";
            // 
            // DonXinNghiViecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 585);
            this.Controls.Add(this.lblTaiKhoan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNgayKetThuc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNgayBatDau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNgayLap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaDXNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDXNV);
            this.Controls.Add(this.label6);
            this.Name = "DonXinNghiViecForm";
            this.Text = "DonXinNghiViec";
            this.Load += new System.EventHandler(this.DonXinNghiViecForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDXNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtNgayLap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaDXNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDXNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtNgayBatDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtNgayKetThuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label label7;
    }
}