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
    public partial class KhenThuongKyLuatForm : Form
    {
        public KhenThuongKyLuatForm()
        {
            InitializeComponent();
        }

        private string tenTK;
        public string TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }
        private void KhenThuongKyLuatForm_Load(object sender, EventArgs e)
        {
            lblTaiKhoan.Text = tenTK;
            hienKTKL();
        }
        private void hienKTKL(string dieukienloc = "")
        {
            string strCnn = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(strCnn);
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblKhenThuongKyLuat", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dvTK = new DataView(dt);

            if (!string.IsNullOrEmpty(dieukienloc))
                dvTK.RowFilter = dieukienloc;

            dgvKTKL.DataSource = dvTK;
        }

        private void dgvKTKL_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)dgvKTKL.DataSource;
            DataRowView drv = dv[dgvKTKL.CurrentRow.Index];
            txtMaKTKL.Text = drv["PK_iMaKT"].ToString();
            txtNgayLap.Text = string.Format(Convert.ToString(drv["dNgayLap"]));
            txtLoaiDon.Text = drv["sLoaiDon"].ToString();
            txtMaNhanVien.Text = drv["FK_iMaNhanVien"].ToString();
            txtLyDo.Text = drv["sLyDo"].ToString();
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
            txtMaKTKL.Text = txtLoaiDon.Text = txtMaNhanVien.Text = txtLyDo.Text = string.Empty;
            txtNgayLap.ResetText();
            hienKTKL();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtLoaiDon.Text == "" || txtMaNhanVien.Text == "" || txtLyDo.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                return;
            }


            try
            {
                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
                string procedureName = "spKhenThuongKyLuat_insert";


                string MNV = Convert.ToString(btnThem.Tag);

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@NgayLap", Convert.ToDateTime(txtNgayLap.Text));
                        cmd.Parameters.Add("@LoaiDon", txtLoaiDon.Text);
                        cmd.Parameters.Add("@MaNhanVien", txtMaNhanVien.Text);
                        cmd.Parameters.Add("@LyDo", txtLyDo.Text);


                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienKTKL();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKTKL.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã khen thưởng kỷ luật muốn xóa");
                return;
            }
            DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.No) return;

            try
            {
                DataView dvTaiKhoan = (DataView)dgvKTKL.DataSource;
                DataRowView drvTaiKhoan = dvTaiKhoan[dgvKTKL.CurrentRow.Index];

                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("spKhenThuongKyLuat_delete", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaKT", txtMaKTKL.Text);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienKTKL();
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
                string procedureName = "spKhenThuongKyLuat_update";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MaKT", txtMaKTKL.Text);
                        cmd.Parameters.Add("@NgayLap", Convert.ToDateTime(txtNgayLap.Text));
                        cmd.Parameters.Add("@LoaiDon", txtLoaiDon.Text);
                        cmd.Parameters.Add("@MaNhanVien", txtMaNhanVien.Text);
                        cmd.Parameters.Add("@LyDo", txtLyDo.Text);


                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienKTKL();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
