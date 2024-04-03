using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_NMCNPM
{
    public partial class NhanVienForm : Form
    {
        public NhanVienForm()
        {
            InitializeComponent();
        }

        private string tenTK;
        public string TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }
        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            lblTaiKhoan.Text = tenTK;
            hienNV();
        }

        private void hienNV(string dieukienloc = "")
        {
            string strCnn = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(strCnn);
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblNhanVien", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dvNhanVien = new DataView(dt);

            if (!string.IsNullOrEmpty(dieukienloc))
                dvNhanVien.RowFilter = dieukienloc;

            dgvNhanVien.DataSource = dvNhanVien;
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.TenTK = lblTaiKhoan.Text;
            mf.Show();
            this.Hide();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = txtTenNhanVien.Text = txtEmail.Text = txtSDT.Text = txtLuongCB.Text = txtMaPhongBan.Text = txtMaChucVu.Text = string.Empty;
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
            txtNgaySinh.ResetText();
            txtMaNhanVien.Focus();
            hienNV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenNhanVien.Text == "" || txtEmail.Text == "" || txtSDT.Text == "" || txtLuongCB.Text==""
                || txtMaChucVu.Text == "" || txtMaPhongBan.Text == "" || rbtnNam.Checked == false && rbtnNu.Checked == false)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                return;
            }


            try
            {
                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
                string procedureName = "spNhanVien_insert";


                string MNV = Convert.ToString(btnThem.Tag);

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@TenNhanVien", txtTenNhanVien.Text);
                        cmd.Parameters.Add("@Email", txtEmail.Text);
                        cmd.Parameters.Add("@SDT", txtSDT.Text);
                        cmd.Parameters.Add("@MaPhongBan", txtMaPhongBan.Text);
                        cmd.Parameters.Add("@MaChucVu", txtMaChucVu.Text);
                        cmd.Parameters.Add("@LuongCB", txtLuongCB.Text);

                        if (rbtnNam.Checked == true)
                            cmd.Parameters.Add("@GioiTinh", "Nam");
                        if (rbtnNu.Checked == true)
                            cmd.Parameters.Add("@GioiTinh", "Nữ");

                        cmd.Parameters.Add("@NgaySinh", Convert.ToDateTime(txtNgaySinh.Text));

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienNV();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn phải nhập nhân viên bạn muốn xóa");
                return;
            }
            DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.No) return;

            try
            {
                DataView dvNhanVien = (DataView)dgvNhanVien.DataSource;
                DataRowView drvNhanVien = dvNhanVien[dgvNhanVien.CurrentRow.Index];

                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("spNhanVien_delete", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienNV();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_iMaPhongBan"))
                {
                    MessageBox.Show("Không thể xóa nhân viên này do có ràng buộc với bảng khác"
                        , "kết quả"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    btnBoQua_Click(sender, e);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
                string procedureName = "spNhanVien_update";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MaNhanVien", txtMaNhanVien.Text);
                        cmd.Parameters.Add("@TenNhanVien", txtTenNhanVien.Text);
                        cmd.Parameters.Add("@Email", txtEmail.Text);
                        cmd.Parameters.Add("@SDT", txtSDT.Text);
                        cmd.Parameters.Add("@MaPhongBan", txtMaPhongBan.Text);
                        cmd.Parameters.Add("@MaChucVu", txtMaChucVu.Text);
                        cmd.Parameters.Add("@LuongCB", txtLuongCB.Text);

                        if (rbtnNam.Checked == true)
                            cmd.Parameters.Add("@GioiTinh", "Nam");
                        if (rbtnNu.Checked == true)
                            cmd.Parameters.Add("@GioiTinh", "Nữ");

                        cmd.Parameters.Add("@NgaySinh", Convert.ToDateTime(txtNgaySinh.Text));

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienNV();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            DataView dvNhanVien = (DataView)dgvNhanVien.DataSource;
            DataRowView drvNhanVien = dvNhanVien[dgvNhanVien.CurrentRow.Index];
            txtMaNhanVien.Text = drvNhanVien["PK_iMaNhanVien"].ToString();
            txtTenNhanVien.Text = drvNhanVien["sTenNhanVien"].ToString();
            txtEmail.Text = drvNhanVien["sEmail"].ToString();
            txtSDT.Text = drvNhanVien["sSDT"].ToString();
            txtLuongCB.Text = drvNhanVien["fLuongCB"].ToString();
            txtNgaySinh.Text = string.Format(Convert.ToString(drvNhanVien["dNgaySinh"]));

            if (drvNhanVien["sGioiTinh"].ToString() == "Nam")
                rbtnNam.Checked = Convert.ToBoolean("true");
            rbtnNu.Checked = !rbtnNam.Checked;
            txtMaPhongBan.Text = drvNhanVien["FK_iMaPhongBan"].ToString();
            txtMaChucVu.Text = drvNhanVien["FK_iMaChucVu"].ToString();
        }
    }
    
}
