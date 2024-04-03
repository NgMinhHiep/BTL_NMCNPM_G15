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
    public partial class DoiMatKhauForm : Form
    {
        public DoiMatKhauForm()
        {
            InitializeComponent();
        }

        private string tenTK;
        public string TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }
        private void DoiMatKhauForm_Load(object sender, EventArgs e)
        {
            lblTaiKhoan.Text = tenTK;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.TenTK = lblTaiKhoan.Text;
            mf.Show();
            this.Hide();
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == "")
            {
                MessageBox.Show("Nhập mật khẩu cũ");
                return;
            }
            if (txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Nhập mật khẩu mới");
                return;
            }
            if (txtXacNhanMK.Text == "")
            {
                MessageBox.Show("Nhập xác nhận mật khẩu");
                return;
            }
            if (txtMatKhauMoi.Text.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải có số lượng ký tự lớn hơn hoặc bằng 8");
                return;
            }
            if (txtMatKhauMoi.Text != txtXacNhanMK.Text)
            {
                MessageBox.Show("Bạn phải xác nhận đúng mật khẩu mới");
                return;
            }

            string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_DoiMatKhau", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TenDangNhap", lblTaiKhoan.Text);
                    cmd.Parameters.Add("@MatKhauCu", txtMatKhauCu.Text.ToString());
                    cmd.Parameters.Add("@MatKhauMoi", txtMatKhauMoi.Text);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    object kq = cmd.ExecuteScalar();
                    int code = Convert.ToInt32(kq);
                    if (code == 1)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!"
                        , "thông báo"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);                       
                    }
                    else if (code == 2)
                    {

                        MessageBox.Show("Mật khẩu cũ không đúng!"
                        , "thông báo"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    }                   
                    cnn.Close();
                }
            }
        }
    }
}
