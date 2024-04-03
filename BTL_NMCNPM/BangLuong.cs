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
    public partial class BangLuongForm : Form
    {
        public BangLuongForm()
        {
            InitializeComponent();
        }

        private string tenTK;
        public string TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }
        private void BangLuong_Load(object sender, EventArgs e)
        {
            lblTaiKhoan.Text = tenTK;
            hienBL();
        }

        private void hienBL(string dieukienloc = "")
        {
            string strCnn = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(strCnn);
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblBangLuong", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dvBangLuong = new DataView(dt);

            if (!string.IsNullOrEmpty(dieukienloc))
                dvBangLuong.RowFilter = dieukienloc;

            dgvBangLuong.DataSource = dvBangLuong;
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
            txtMaBangLuong.Text = txtMaNhanVien.Text = txtThuong.Text = txtPhat.Text = string.Empty;
            txtThoiGian.ResetText();
            hienBL();
        }

        private void dgvBangLuong_Click(object sender, EventArgs e)
        {
            DataView dvBangLuong = (DataView)dgvBangLuong.DataSource;
            DataRowView drvBangLuong = dvBangLuong[dgvBangLuong.CurrentRow.Index];
            txtMaBangLuong.Text = drvBangLuong["PK_iMaBangLuong"].ToString();
            txtMaNhanVien.Text = drvBangLuong["FK_iMaNhanVien"].ToString();
            //txtThoiGian.Text = string.Format(Convert.ToString(drvBangLuong["sThoiGian"]));
            txtThoiGian.Text = drvBangLuong["sThoiGian"].ToString();
            txtThuong.Text = drvBangLuong["fThuong"].ToString();
            txtPhat.Text = drvBangLuong["fPhat"].ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "" || txtThoiGian.Text == "" || txtThuong.Text == "" || txtPhat.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                return;
            }


            try
            {
                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
                string procedureName = "spBangLuong_insert";


                string MNV = Convert.ToString(btnThem.Tag);

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@MaNhanVien", txtMaNhanVien.Text);
                        cmd.Parameters.Add("@ThoiGian", txtThoiGian.Text);
                        cmd.Parameters.Add("@Thuong", txtThuong.Text);
                        cmd.Parameters.Add("@Phat", txtPhat.Text);
                        

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienBL();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaBangLuong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã bảng lương muốn xóa");
                return;
            }
            DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.No) return;

            try
            {
                DataView dvBangLuong = (DataView)dgvBangLuong.DataSource;
                DataRowView drvBangLuong = dvBangLuong[dgvBangLuong.CurrentRow.Index];

                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("spBangLuong_delete", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaBangLuong", txtMaBangLuong.Text);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienBL();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_iMaBangLuong"))
                {
                    MessageBox.Show("Không thể xóa chức vụ này do có ràng buộc với bảng khác"
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
                string procedureName = "spBangLuong_update";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MaBangLuong", txtMaBangLuong.Text);
                        cmd.Parameters.Add("@MaNhanVien", txtMaNhanVien.Text);
                        cmd.Parameters.Add("@ThoiGian", txtThoiGian.Text);
                        cmd.Parameters.Add("@Thuong", txtThuong.Text);
                        cmd.Parameters.Add("@Phat", txtPhat.Text);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienBL();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
