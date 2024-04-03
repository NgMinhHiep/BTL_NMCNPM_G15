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
    public partial class DonXinNghiViecForm : Form
    {
        public DonXinNghiViecForm()
        {
            InitializeComponent();
        }

        private string tenTK;
        public string TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }
        private void DonXinNghiViecForm_Load(object sender, EventArgs e)
        {
            lblTaiKhoan.Text = tenTK;
            hienDXNV();
        }
        private void hienDXNV(string dieukienloc = "")
        {
            string strCnn = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(strCnn);
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblDonXinNghiViec", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dvTK = new DataView(dt);

            if (!string.IsNullOrEmpty(dieukienloc))
                dvTK.RowFilter = dieukienloc;

            dgvDXNV.DataSource = dvTK;
        }

        private void dgvDXNV_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)dgvDXNV.DataSource;
            DataRowView drv = dv[dgvDXNV.CurrentRow.Index];
            txtMaDXNV.Text = drv["PK_iMaDon"].ToString();
            txtNgayLap.Text = string.Format(Convert.ToString(drv["dNgayLap"]));
            txtNgayBatDau.Text = string.Format(Convert.ToString(drv["dNgayBatDau"]));
            txtNgayKetThuc.Text = string.Format(Convert.ToString(drv["dNgayKetThuc"]));
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
            txtMaDXNV.Text =  txtMaNhanVien.Text = txtLyDo.Text = string.Empty;
            txtNgayLap.ResetText();
            txtNgayBatDau.ResetText();
            txtNgayKetThuc.ResetText();
            hienDXNV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "" || txtLyDo.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                return;
            }


            try
            {
                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
                string procedureName = "spDonXinNghiViec_insert";


                string MNV = Convert.ToString(btnThem.Tag);

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@NgayLap", Convert.ToDateTime(txtNgayLap.Text));
                        cmd.Parameters.Add("@NgayBatDau", Convert.ToDateTime(txtNgayBatDau.Text));
                        cmd.Parameters.Add("@NgayKetThuc", Convert.ToDateTime(txtNgayKetThuc.Text));
                        cmd.Parameters.Add("@MaNhanVien", txtMaNhanVien.Text);
                        cmd.Parameters.Add("@LyDo", txtLyDo.Text);


                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienDXNV();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDXNV.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã đơn xin nghỉ việc muốn xóa");
                return;
            }
            DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.No) return;

            try
            {
                DataView dvTaiKhoan = (DataView)dgvDXNV.DataSource;
                DataRowView drvTaiKhoan = dvTaiKhoan[dgvDXNV.CurrentRow.Index];

                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("spDonXinNghiViec_delete", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaDon", txtMaDXNV.Text);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienDXNV();
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
                string procedureName = "spDonXinNghiViec_update";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MaDon", txtMaDXNV.Text);
                        cmd.Parameters.Add("@NgayLap", Convert.ToDateTime(txtNgayLap.Text));
                        cmd.Parameters.Add("@NgayBatDau", Convert.ToDateTime(txtNgayBatDau.Text));
                        cmd.Parameters.Add("@NgayKetThuc", Convert.ToDateTime(txtNgayKetThuc.Text));
                        cmd.Parameters.Add("@MaNhanVien", txtMaNhanVien.Text);
                        cmd.Parameters.Add("@LyDo", txtLyDo.Text);


                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienDXNV();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
