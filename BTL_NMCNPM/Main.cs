using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_NMCNPM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private string tenTK;
        public string TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            lblTaiKhoan.Text = tenTK;
        }

        private void btnEscape_Click(object sender, EventArgs e)
        {
            LogInForm lgfrm = new LogInForm();
            lgfrm.Show();
            this.Hide();
        }

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                LogInForm lgfrm = new LogInForm();
                lgfrm.Show();
                this.Hide();
            }
        }

        private void QlyPhongBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhongBanForm pbf = new PhongBanForm();
            pbf.TenTK = lblTaiKhoan.Text;
            pbf.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DoiMatKhauForm dmkf = new DoiMatKhauForm();
            dmkf.TenTK = lblTaiKhoan.Text;
            dmkf.Show();
            this.Hide();
        }

        private void QlyChucVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChucVuForm cvf = new ChucVuForm();
            cvf.TenTK = lblTaiKhoan.Text;
            cvf.Show();
            this.Hide();
        }

        private void QLyNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVienForm nvf = new NhanVienForm();
            nvf.TenTK = lblTaiKhoan.Text;
            nvf.Show();
            this.Hide();
        }

        private void QlyBangLuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangLuongForm nvf = new BangLuongForm();
            nvf.TenTK = lblTaiKhoan.Text;
            nvf.Show();
            this.Hide();
        }

        private void QlyChamCongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamCongForm nvf = new ChamCongForm();
            nvf.TenTK = lblTaiKhoan.Text;
            nvf.Show();
            this.Hide();
        }

        private void QlyHDLDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HopDongLaoDongForm nvf = new HopDongLaoDongForm();
            nvf.TenTK = lblTaiKhoan.Text;
            nvf.Show();
            this.Hide();
        }

        private void QlyLoaiTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiTaiKhoanForm nvf = new LoaiTaiKhoanForm();
            nvf.TenTK = lblTaiKhoan.Text;
            nvf.Show();
            this.Hide();
        }

        private void QlyTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaiKhoanForm nvf = new TaiKhoanForm();
            nvf.TenTK = lblTaiKhoan.Text;
            nvf.Show();
            this.Hide();
        }

        private void QlyKTKLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhenThuongKyLuatForm nvf = new KhenThuongKyLuatForm();
            nvf.TenTK = lblTaiKhoan.Text;
            nvf.Show();
            this.Hide();
        }

        private void QlyDXNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonXinNghiViecForm nvf = new DonXinNghiViecForm();
            nvf.TenTK = lblTaiKhoan.Text;
            nvf.Show();
            this.Hide();
        }
    }
}
