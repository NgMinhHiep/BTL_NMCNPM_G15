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
    public partial class PhongBanForm : Form
    {
        public PhongBanForm()
        {
            InitializeComponent();           

        }

        private string tenTK;
        public string TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }
        private void hienPB(string dieukienloc = "")
        {
            string strCnn = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(strCnn);
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblPhongBan", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dvPhongBan = new DataView(dt);

            if (!string.IsNullOrEmpty(dieukienloc))
                dvPhongBan.RowFilter = dieukienloc;

            dgvPhongBan.DataSource = dvPhongBan;
        }

        private void dgvPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtMaPhongBan.Text = txtTenPhongBan.Text = string.Empty;        
            hienPB();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (txtTenPhongBan.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên phòng ban");
                return;
            }
         
            
            try
            {
                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
                string procedureName = "spPhongBan_insert";


                string MNV = Convert.ToString(btnThem.Tag);

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        
                        cmd.Parameters.Add("@TenPhongBan", txtTenPhongBan.Text);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienPB();
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
                string procedureName = "spPhongBan_update";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MaPhongBan", txtMaPhongBan.Text);
                        cmd.Parameters.Add("@TenPhongBan", txtTenPhongBan.Text);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienPB();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhongBan.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã phòng ban muốn xóa");
                return;
            }
            DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.No) return;

            try
            {
                DataView dvPhongBan = (DataView)dgvPhongBan.DataSource;
                DataRowView drvPhongBan = dvPhongBan[dgvPhongBan.CurrentRow.Index];

                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("spPhongBan_delete", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaPhongBan", txtMaPhongBan.Text);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienPB();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_iMaPhongBan"))
                {
                    MessageBox.Show("Không thể xóa phòng ban này do có ràng buộc với bảng nhân viên"
                        , "kết quả"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    btnBoQua_Click(sender, e);
                }
            }
        }

        private void PhongBanForm_Load(object sender, EventArgs e)
        {
            lblTaiKhoan.Text = tenTK;
            hienPB();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.TenTK = lblTaiKhoan.Text;
            mf.Show();
            this.Hide();
        }

        private void dgvPhongBan_Click(object sender, EventArgs e)
        {
            DataView dvPhongBan = (DataView)dgvPhongBan.DataSource;
            DataRowView drvPhongBan = dvPhongBan[dgvPhongBan.CurrentRow.Index];
            txtMaPhongBan.Text = drvPhongBan["PK_iMaPhongBan"].ToString();
            txtTenPhongBan.Text = drvPhongBan["sTenPhongBan"].ToString();
        }
    }
}
