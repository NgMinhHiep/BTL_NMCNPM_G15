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
    public partial class ChucVuForm : Form
    {
        public ChucVuForm()
        {
            InitializeComponent();
        }

        private string tenTK;
        public string TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }
        private void ChucVu_Load(object sender, EventArgs e)
        {
            lblTaiKhoan.Text = tenTK;
            hienCV();
        }

        private void hienCV(string dieukienloc = "")
        {
            string strCnn = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(strCnn);
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblChucVu", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dvChucVu = new DataView(dt);

            if (!string.IsNullOrEmpty(dieukienloc))
                dvChucVu.RowFilter = dieukienloc;

            dgvChucVu.DataSource = dvChucVu;
        }

        private void dgvChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvChucVu_Click(object sender, EventArgs e)
        {
            DataView dvChucVu = (DataView)dgvChucVu.DataSource;
            DataRowView drvChucVu = dvChucVu[dgvChucVu.CurrentRow.Index];
            txtMaChucVu.Text = drvChucVu["PK_iMaChucVu"].ToString();
            txtTenChucVu.Text = drvChucVu["sTenChucVu"].ToString();
            txtHeSoLuong.Text = drvChucVu["fHeSoLuong"].ToString();
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
            txtMaChucVu.Text = txtTenChucVu.Text =  txtHeSoLuong.Text = string.Empty;
            hienCV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenChucVu.Text == "" || txtHeSoLuong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                return;
            }


            try
            {
                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
                string procedureName = "spChucVu_insert";


                string MNV = Convert.ToString(btnThem.Tag);

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@TenChucVu", txtTenChucVu.Text);
                        cmd.Parameters.Add("@HeSoLuong", txtHeSoLuong.Text);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienCV();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaChucVu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã chức vụ muốn xóa");
                return;
            }
            DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.No) return;

            try
            {
                DataView dvChucVu = (DataView)dgvChucVu.DataSource;
                DataRowView drvChucVu = dvChucVu[dgvChucVu.CurrentRow.Index];

                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("spChucVu_delete", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaChucVu", txtMaChucVu.Text);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienCV();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_iMaChucVu"))
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
                string procedureName = "spChucVu_update";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MaChucVu", txtMaChucVu.Text);
                        cmd.Parameters.Add("@TenChucVu", txtTenChucVu.Text);
                        cmd.Parameters.Add("@HeSoLuong", txtHeSoLuong.Text);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienCV();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
