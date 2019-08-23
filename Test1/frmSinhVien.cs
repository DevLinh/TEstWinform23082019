using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }


        void setNull()
        {
            txtMaSV.Text = "";
            txtHotenSV.Text = "";
            txtHocBong.Text = "0";
            rbNam.Checked = false;
            rbNu.Checked = false;
        }

        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnThoat.Enabled = val;
            btnLuu.Enabled = !val;
            btnKLuu.Enabled = !val;
        }

        SinhVien sv = new SinhVien();

        void ShowSV()
        {
            DataTable dt = sv.GetAllSV();
            dgvSinhVien.DataSource = dt;
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            ShowSV();
            setButton(true);
            setNull();
            ShowLop();
        }

        void ShowLop()
        {
            DataTable dt = sv.GetAllLop();
            cbLop.DataSource = dt;
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaSV.Text = dgvSinhVien.Rows[index].Cells["MaSV"].Value.ToString().ToUpper();
                txtHotenSV.Text = dgvSinhVien.Rows[index].Cells["HotenSV"].Value.ToString();
                txtHocBong.Text = dgvSinhVien.Rows[index].Cells["HocBong"].Value.ToString();
                dtpNgaySinh.Text = dgvSinhVien.Rows[index].Cells["NgaySinh"].Value.ToString();
                if(dgvSinhVien.Rows[index].Cells["GioiTinh"].Value.ToString().Equals("Nam"))
                {
                    rbNam.Checked = true;
                } else
                {
                    rbNu.Checked = true;
                }
                cbLop.Text = dgvSinhVien.Rows[index].Cells["TenLop"].Value.ToString();
            }
        }
        public bool themmoi = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            setNull();
            txtMaSV.Focus();
            setButton(false);
            themmoi = true;
        }

        public bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHotenSV.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên sinh viên", "Thông báo", MessageBoxButtons.OK);
                txtHotenSV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHocBong.Text))
            {
                MessageBox.Show("Vui lòng nhập Học bổng", "Thông báo", MessageBoxButtons.OK);
                txtHocBong.Focus();
                return false;
            }
            if (rbNam.Checked == false && rbNu.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Thông báo", MessageBoxButtons.OK);
                rbNam.Focus();
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngay = String.Format("{0: MM/dd/yyyy}", dtpNgaySinh.Value);
            bool gioitinh;
            if (rbNam.Checked)
            {
                 gioitinh = true;
            }
            else
            {
                gioitinh = false;
            }
            if (themmoi)
            {
                if (CheckData())
                {
                    sv.AddSV(txtMaSV.Text, txtHotenSV.Text, ngay, gioitinh, float.Parse(txtHocBong.Text.ToString()), cbLop.SelectedValue.ToString());
                    MessageBox.Show("Thêm mới thành công!");
                    setButton(true);
                }
            } else
            {
                if (CheckData())
                {
                    sv.UpdateSV(dgvSinhVien.SelectedRows[0].Cells[0].Value.ToString(), txtHotenSV.Text, ngay, gioitinh, float.Parse(txtHocBong.Text.ToString()), cbLop.SelectedValue.ToString());
                    MessageBox.Show("Cập nhật thành công!");
                }
            }

            ShowSV();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int flag = dgvSinhVien.SelectedRows.Count;
            if (flag > 0)
            {
                DialogResult dg = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    sv.DeleteSV(dgvSinhVien.CurrentRow.Cells["MaSV"].Value.ToString());
                    dgvSinhVien.Rows.RemoveAt(this.dgvSinhVien.SelectedRows[0].Index);
                    setButton(true);
                }
            }
            else
                MessageBox.Show("Bạn phải chọn dòng cần xóa", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool flag = dgvSinhVien.CurrentRow.Selected;
            if (flag)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn cập nhật dòng này!", "Thông báo báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    themmoi = false;
                    setButton(false);
                }
            }
            else
                MessageBox.Show("Bạn phải lựa chọn mẩu tin cần cập nhật!", "Lưu ý!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKLuu_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            rp report = new Test1.rp();
            report.Show();
        }
    }
}
