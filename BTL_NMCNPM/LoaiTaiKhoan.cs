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
    public partial class LoaiTaiKhoanForm : Form
    {
        public LoaiTaiKhoanForm()
        {
            InitializeComponent();
        }

        private string tenTK;
        public string TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }
        private void LoaiTaiKhoanForm_Load(object sender, EventArgs e)
        {
            lblTaiKhoan.Text = tenTK;
            hienLoaiTK();
        }

        private void hienLoaiTK(string dieukienloc = "")
        {
            string strCnn = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(strCnn);
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblLoaiTaiKhoan", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dvLoaiTK = new DataView(dt);

            if (!string.IsNullOrEmpty(dieukienloc))
                dvLoaiTK.RowFilter = dieukienloc;

            dgvLoaiTaiKhoan.DataSource = dvLoaiTK;
        }

        private void dgvLoaiTaiKhoan_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)dgvLoaiTaiKhoan.DataSource;
            DataRowView drv = dv[dgvLoaiTaiKhoan.CurrentRow.Index];
            txtMaLoaiTaiKhoan.Text = drv["PK_iMaLoaiTK"].ToString();
            txtTenLoaiTaiKhoan.Text = drv["sTenLoaiTK"].ToString();
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
            txtMaLoaiTaiKhoan.Text = txtTenLoaiTaiKhoan.Text =  string.Empty;
            hienLoaiTK();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                return;
            }


            try
            {
                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
                string procedureName = "spLoaiTaiKhoan_insert";


                string MNV = Convert.ToString(btnThem.Tag);

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@TenLoaiTaiKhoan", txtTenLoaiTaiKhoan.Text);
                        

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienLoaiTK();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã loại tài khoản muốn xóa");
                return;
            }
            DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.No) return;

            try
            {
                DataView dvLoaiTK = (DataView)dgvLoaiTaiKhoan.DataSource;
                DataRowView drvLoaiTK = dvLoaiTK[dgvLoaiTaiKhoan.CurrentRow.Index];

                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("spLoaiTaiKhoan_delete", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaLoaiTaiKhoan", txtMaLoaiTaiKhoan.Text);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienLoaiTK();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PK_iMaLoaiTK"))
                {
                    MessageBox.Show("Không thể xóa loại tài khoản này do có ràng buộc với bảng khác"
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
                string procedureName = "spLoaiTaiKhoan_update";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MaLoaiTaiKhoan", txtMaLoaiTaiKhoan.Text);
                        cmd.Parameters.Add("@TenLoaiTaiKhoan", txtTenLoaiTaiKhoan.Text);


                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienLoaiTK();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtTenLoaiTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaLoaiTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvLoaiTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
