
namespace BTL_NMCNPM
{
    partial class ChamCongForm
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
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaChamCong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dTPCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dTPCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Location = new System.Drawing.Point(749, 485);
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
            this.btnBoQua.Location = new System.Drawing.Point(901, 417);
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
            this.btnXoa.Location = new System.Drawing.Point(901, 347);
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
            this.btnSua.Location = new System.Drawing.Point(749, 417);
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
            this.btnThem.Location = new System.Drawing.Point(749, 347);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 51);
            this.btnThem.TabIndex = 61;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(837, 174);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(171, 20);
            this.txtMaNhanVien.TabIndex = 60;
            // 
            // txtMaChamCong
            // 
            this.txtMaChamCong.Location = new System.Drawing.Point(837, 138);
            this.txtMaChamCong.Name = "txtMaChamCong";
            this.txtMaChamCong.Size = new System.Drawing.Size(171, 20);
            this.txtMaChamCong.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(737, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(737, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Mã chấm công";
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.AccessibleName = "";
            this.dgvChamCong.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Location = new System.Drawing.Point(1, 99);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.Size = new System.Drawing.Size(643, 461);
            this.dgvChamCong.TabIndex = 56;
            this.dgvChamCong.Click += new System.EventHandler(this.dgvChamCong_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(331, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 37);
            this.label6.TabIndex = 55;
            this.label6.Text = "Quản Lý Chấm Công";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(737, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "CheckIn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(737, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "CheckOut";
            // 
            // dTPCheckIn
            // 
            this.dTPCheckIn.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dTPCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPCheckIn.Location = new System.Drawing.Point(837, 216);
            this.dTPCheckIn.Name = "dTPCheckIn";
            this.dTPCheckIn.Size = new System.Drawing.Size(171, 20);
            this.dTPCheckIn.TabIndex = 70;
            // 
            // dTPCheckOut
            // 
            this.dTPCheckOut.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dTPCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPCheckOut.Location = new System.Drawing.Point(837, 257);
            this.dTPCheckOut.Name = "dTPCheckOut";
            this.dTPCheckOut.Size = new System.Drawing.Size(171, 20);
            this.dTPCheckOut.TabIndex = 71;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(76, 22);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(73, 13);
            this.lblTaiKhoan.TabIndex = 76;
            this.lblTaiKhoan.Text = "Tên tài khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Tài khoản:";
            // 
            // ChamCongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 622);
            this.Controls.Add(this.lblTaiKhoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dTPCheckOut);
            this.Controls.Add(this.dTPCheckIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.txtMaChamCong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvChamCong);
            this.Controls.Add(this.label6);
            this.Name = "ChamCongForm";
            this.Text = "ChamCong";
            this.Load += new System.EventHandler(this.ChamCongForm_Load);
            this.Click += new System.EventHandler(this.ChamCongForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtMaChamCong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dTPCheckIn;
        private System.Windows.Forms.DateTimePicker dTPCheckOut;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label label5;
    }
}