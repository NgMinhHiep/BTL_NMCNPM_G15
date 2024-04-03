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
    public partial class TaiKhoanForm : Form
    {
        public TaiKhoanForm()
        {
            InitializeComponent();
        }

        private string tenTK;
        public string TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }
        private void TaiKhoanForm_Load(object sender, EventArgs e)
        {
            lblTaiKhoan.Text = tenTK;
            hienTK();
        }
        private void hienTK(string dieukienloc = "")
        {
            string strCnn = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(strCnn);
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblTaiKhoan", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dvTK = new DataView(dt);

            if (!string.IsNullOrEmpty(dieukienloc))
                dvTK.RowFilter = dieukienloc;

            dgvTaiKhoan.DataSource = dvTK;
        }

        private void dgvTaiKhoan_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)dgvTaiKhoan.DataSource;
            DataRowView drv = dv[dgvTaiKhoan.CurrentRow.Index];
            txtMaTaiKhoan.Text = drv["PK_iMaTaiKhoan"].ToString();
            txtTenDangNhap.Text = drv["sTenDangNhap"].ToString();
            txtMatKhau.Text = drv["sMatKhau"].ToString();
            txtMaLoaiTaiKhoan.Text = drv["FK_iMaLoaiTK"].ToString();
            txtMaNhanVien.Text = drv["FK_iMaNhanVien"].ToString();
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
            txtMaTaiKhoan.Text = txtMaLoaiTaiKhoan.Text = txtMaNhanVien.Text = txtTenDangNhap.Text = txtMatKhau.Text = string.Empty;
            hienTK();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiTaiKhoan.Text == "" || txtMaNhanVien.Text == "" || txtTenDangNhap.Text == "" || txtMatKhau.Text=="")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                return;
            }


            try
            {
                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
                string procedureName = "spTaiKhoan_insert";


                string MNV = Convert.ToString(btnThem.Tag);

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@TenDangNhap", txtTenDangNhap.Text);
                        cmd.Parameters.Add("@MatKhau", txtMatKhau.Text);
                        cmd.Parameters.Add("@MaLoaiTaiKhoan", txtMaLoaiTaiKhoan.Text);
                        cmd.Parameters.Add("@MaNhanVien", txtMaNhanVien.Text);


                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienTK();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã tài khoản muốn xóa");
                return;
            }
            DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.No) return;

            try
            {
                DataView dvTaiKhoan = (DataView)dgvTaiKhoan.DataSource;
                DataRowView drvTaiKhoan = dvTaiKhoan[dgvTaiKhoan.CurrentRow.Index];

                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("spTaiKhoan_delete", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaTaiKhoan", txtMaLoaiTaiKhoan.Text);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienTK();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PK_iMaTaiKhoan"))
                {
                    MessageBox.Show("Không thể xóa tài khoản này do có ràng buộc với bảng khác"
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
                string procedureName = "spTaiKhoan_update";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MaTaiKhoan", txtMaTaiKhoan.Text);
                        cmd.Parameters.Add("@TenDangNhap", txtTenDangNhap.Text);
                        cmd.Parameters.Add("@MatKhau", txtMatKhau.Text);
                        cmd.Parameters.Add("@MaLoaiTaiKhoan", txtMaLoaiTaiKhoan.Text);
                        cmd.Parameters.Add("@MaNhanVien", txtMaNhanVien.Text);


                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienTK();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
