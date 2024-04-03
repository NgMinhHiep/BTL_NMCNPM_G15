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
    
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Nhập tài khoản");
                return;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Nhập mật khẩu");
                return;
            }
            

            string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_DangNhap", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TenDangNhap", txtTaiKhoan.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    object kq = cmd.ExecuteScalar();
                    int code = Convert.ToInt32(kq);
                    if (code == 1)
                    {
                        MessageBox.Show("Chào mừng bạn đăng nhập!"
                        , "thông báo"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);

                        /*
                        DoiMatKhauForm dmkf = new DoiMatKhauForm();
                        dmkf.TenTK = txtTaiKhoan.Text;
                        dmkf.Show();
                        this.Hide();
                        */
                        MainForm frm = new MainForm();
                        frm.TenTK = txtTaiKhoan.Text;
                        frm.Show();
                        this.Hide();
                        
                    }
                    else if (code == 2)
                    {

                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!"
                        , "thông báo"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    }
                    else if (code == 3)
                    {
                        MessageBox.Show("Tài khoản không tồn tại!"
                        , "thông báo"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    }                   
                    cnn.Close();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
        }
    }
}
