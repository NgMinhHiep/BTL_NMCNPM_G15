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
    public partial class HopDongLaoDongForm : Form
    {
        public HopDongLaoDongForm()
        {
            InitializeComponent();
        }

        private string tenTK;
        public string TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }
        private void HopDongLaoDongForm_Load(object sender, EventArgs e)
        {
            lblTaiKhoan.Text = tenTK;
            hienHDLD();
        }

        private void hienHDLD(string dieukienloc = "")
        {
            string strCnn = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(strCnn);
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblHopDongLaoDong", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dvHDLD = new DataView(dt);

            if (!string.IsNullOrEmpty(dieukienloc))
                dvHDLD.RowFilter = dieukienloc;

            dgvHDLD.DataSource = dvHDLD;
        }

        private void dgvHDLD_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)dgvHDLD.DataSource;
            DataRowView drv = dv[dgvHDLD.CurrentRow.Index];
            txtMaHDLD.Text = drv["PK_iMaHD"].ToString();
            txtMaNhanVien.Text = drv["FK_iMaNhanVien"].ToString();
            txtNgayLap.Text = string.Format(Convert.ToString(drv["dNgayLapHD"]));
            txtThoiHan.Text = string.Format(Convert.ToString(drv["dThoiHan"]));
            txtLuongCB.Text = drv["fLuongCoBan"].ToString();
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
            txtMaHDLD.Text = txtMaNhanVien.Text = txtLuongCB.Text = string.Empty;
            txtNgayLap.ResetText();
            txtThoiHan.ResetText();
            hienHDLD();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "" || txtLuongCB.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                return;
            }


            try
            {
                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
                string procedureName = "spHopDongLaoDong_insert";


                string MNV = Convert.ToString(btnThem.Tag);

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@MaNhanVien", txtMaNhanVien.Text);
                        cmd.Parameters.Add("@NgayLap", Convert.ToDateTime(txtNgayLap.Text));
                        cmd.Parameters.Add("@ThoiHan", Convert.ToDateTime(txtThoiHan.Text));
                        cmd.Parameters.Add("@LuongCB", txtLuongCB.Text);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienHDLD();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHDLD.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã hợp đồng lao động muốn xóa");
                return;
            }
            DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.No) return;

            try
            {
                DataView dvHDLD = (DataView)dgvHDLD.DataSource;
                DataRowView drvHDLD = dvHDLD[dgvHDLD.CurrentRow.Index];

                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("spHopDongLaoDong_delete", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaHopDong", txtMaHDLD.Text);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienHDLD();
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
                string procedureName = "spHopDongLaoDong_update";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MaHopDong", txtMaHDLD.Text);
                        cmd.Parameters.Add("@MaNhanVien", txtMaNhanVien.Text);
                        cmd.Parameters.Add("@NgayLap", Convert.ToDateTime(txtNgayLap.Text));
                        cmd.Parameters.Add("@ThoiHan", Convert.ToDateTime(txtThoiHan.Text));
                        cmd.Parameters.Add("@LuongCB", txtLuongCB.Text);


                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienHDLD();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
