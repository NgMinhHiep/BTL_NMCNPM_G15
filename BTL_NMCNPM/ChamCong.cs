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
    public partial class ChamCongForm : Form
    {
        public ChamCongForm()
        {
            InitializeComponent();
        }

        private string tenTK;
        public string TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }
        private void ChamCongForm_Load(object sender, EventArgs e)
        {
            lblTaiKhoan.Text = tenTK;
            hienCC();
        }

        private void hienCC(string dieukienloc = "")
        {
            string strCnn = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(strCnn);
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblChamCong", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dvChamCong = new DataView(dt);

            if (!string.IsNullOrEmpty(dieukienloc))
                dvChamCong.RowFilter = dieukienloc;

            dgvChamCong.DataSource = dvChamCong;
        }

        private void ChamCongForm_Click(object sender, EventArgs e)
        {
            
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
            txtMaChamCong.Text = txtMaNhanVien.Text =  string.Empty;
            dTPCheckIn.ResetText();
            dTPCheckOut.ResetText();
            hienCC();
        }

        private void dgvChamCong_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)dgvChamCong.DataSource;
            DataRowView drv = dv[dgvChamCong.CurrentRow.Index];
            txtMaChamCong.Text = drv["PK_iMaChamCong"].ToString();
            txtMaNhanVien.Text = drv["FK_iMaNhanVien"].ToString();
            dTPCheckIn.Text = string.Format(Convert.ToString(drv["dCheckIn"]));
            dTPCheckOut.Text = string.Format(Convert.ToString(drv["dCheckOut"]));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if ( txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                return;
            }


            try
            {
                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";
                string procedureName = "spChamCong_insert";


                string MNV = Convert.ToString(btnThem.Tag);

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@MaNhanVien", txtMaNhanVien.Text);
                        cmd.Parameters.Add("@CheckIn", Convert.ToDateTime(dTPCheckIn.Text));
                        cmd.Parameters.Add("@CheckOut", Convert.ToDateTime(dTPCheckOut.Text));

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienCC();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaChamCong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã chấm công muốn xóa");
                return;
            }
            DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.No) return;

            try
            {
                DataView dvChamCong = (DataView)dgvChamCong.DataSource;
                DataRowView drvChamCong = dvChamCong[dgvChamCong.CurrentRow.Index];

                string constr = @"Data Source=DESKTOP-NQMPRA5;Initial Catalog=NMCNPM_BTL_G15;Integrated Security=True";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("spChamCong_delete", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaChamCong", txtMaChamCong.Text);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienCC();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_iMaChamCong"))
                {
                    MessageBox.Show("Không thể xóa chấm công này do có ràng buộc với bảng khác"
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
                string procedureName = "spChamCong_update";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MaChamCong", txtMaChamCong.Text);
                        cmd.Parameters.Add("@MaNhanVien", txtMaNhanVien.Text);
                        cmd.Parameters.Add("@CheckIn", Convert.ToDateTime(dTPCheckIn.Text));
                        cmd.Parameters.Add("@CheckOut", Convert.ToDateTime(dTPCheckOut.Text));


                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQua_Click(sender, e);
                        hienCC();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
