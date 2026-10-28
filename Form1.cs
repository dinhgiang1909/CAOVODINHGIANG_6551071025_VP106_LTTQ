using QuanLySanPham.Models;
using System.Globalization;

namespace QuanLySanPham
{
    public partial class Form1 : Form
    {
        private bool isAdding;
        private string? selectedMa;
        public Form1() 
        { 
            InitializeComponent(); 
        }
        private void SetButtonState(bool them, bool sua, bool xoa, bool thoat) 
        { 
            btnThem.Enabled = them; 
            btnSua.Enabled = sua; 
            btnXoa.Enabled = xoa; 
            btnThoat.Enabled = thoat; 
        }
        private void SetInputState(bool enable) 
        { 
            txtMaSanPham.Enabled = enable;
            txtTenSanPham.Enabled = enable; 
            txtGiaBan.Enabled = enable; 
        }
        private void ResetInputFields() 
        { 
            txtMaSanPham.Clear(); 
            txtTenSanPham.Clear(); 
            txtGiaBan.Clear(); 
            selectedMa = null; 
        }
        private void LoadData()
        {
            try
            {
                using var db = new DuLieuContext();

                dgvSanPham.DataSource = db.SanPhams
                    .Select(s => new
                    {
                        s.MaSanPham,
                        s.TenSanPham,
                        s.GiaBan
                    })
                    .ToList();

                dgvSanPham.Columns["MaSanPham"].HeaderText = "Mã sản phẩm";
                dgvSanPham.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
                dgvSanPham.Columns["GiaBan"].HeaderText = "Giá bán";
            }
            catch (Exception ex) 
            { 
                MessageBox.Show($"Không thể tải dữ liệu sản phẩm.\n\nChi tiết: {ex.Message}", "Lỗi kết nối dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
        private void Form1_Load(object sender, EventArgs e) 
        { 
            SetButtonState(true, false, false, true); 
            SetInputState(false); 
            LoadData(); 
        }
        private bool ReadInputs(out string ma, out string ten, out string gia)
        {
            ma = txtMaSanPham.Text.Trim(); 
            ten = txtTenSanPham.Text.Trim(); 
            gia = txtGiaBan.Text.Trim();
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(gia)) 
            { 
                MessageBox.Show("Vui lòng nhập đầy đủ các ô.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return false; 
            }
            if (!decimal.TryParse(gia, NumberStyles.Number, CultureInfo.CurrentCulture, out var value) || value < 0) 
            { 
                MessageBox.Show("Giá bán chỉ được nhập số nguyên hoặc số thực không âm.", "Giá bán không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return false; 
            }
            return true;
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) 
                return;
            var separator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            if (e.KeyChar.ToString() == separator && !txtGiaBan.Text.Contains(separator)) 
                return;
            e.Handled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!isAdding) 
            { 
                isAdding = true; 
                ResetInputFields(); 
                SetInputState(true); 
                SetButtonState(true, false, false, true); 
                txtMaSanPham.Focus(); 
                return; 
            }
            if (!ReadInputs(out var ma, out var ten, out var gia)) return;
            try
            {
                using var db = new DuLieuContext();
                if (db.SanPhams.Any(s => s.MaSanPham == ma)) 
                { 
                    MessageBox.Show("Mã sản phẩm đã tồn tại.", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                    return; 
                }
                db.SanPhams.Add(new SanPham 
                { 
                    MaSanPham = ma, 
                    TenSanPham = ten, 
                    GiaBan = gia 
                }); 
                db.SaveChanges();
                LoadData(); 
                ResetInputFields(); 
                isAdding = false; 
                SetInputState(false); 
                SetButtonState(false, false, false, true);
            }
            catch (Exception ex) 
            { 
                MessageBox.Show($"Không thể thêm sản phẩm.\n\nChi tiết: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 
            var row = dgvSanPham.Rows[e.RowIndex]; 
            selectedMa = row.Cells["MaSanPham"].Value?.ToString();
            txtMaSanPham.Text = selectedMa; 
            txtTenSanPham.Text = row.Cells["TenSanPham"].Value?.ToString(); 
            txtGiaBan.Text = row.Cells["GiaBan"].Value?.ToString();
            isAdding = false; 
            SetInputState(true); 
            SetButtonState(false, true, true, true);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedMa) || !ReadInputs(out var ma, out var ten, out var gia)) return;
            try
            {
                using var db = new DuLieuContext(); 
                var item = db.SanPhams.FirstOrDefault(s => s.MaSanPham == selectedMa);
                if (item == null) return;
                if (ma != selectedMa && db.SanPhams.Any(s => s.MaSanPham == ma)) 
                { 
                    MessageBox.Show("Mã sản phẩm mới đã tồn tại.", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                    return; 
                }
                item.MaSanPham = ma; item.TenSanPham = ten; item.GiaBan = gia; db.SaveChanges(); 
                LoadData(); 
                ResetInputFields(); 
                SetInputState(false); 
                SetButtonState(true, false, false, true);
            }
            catch (Exception ex) 
            { 
                MessageBox.Show($"Không thể sửa sản phẩm.\n\nChi tiết: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedMa) || MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            try
            {
                using var db = new DuLieuContext(); 
                var item = db.SanPhams.FirstOrDefault(s => s.MaSanPham == selectedMa);
                if (item != null) 
                { 
                    db.SanPhams.Remove(item); db.SaveChanges();
                } 
                LoadData(); 
                ResetInputFields(); 
                SetInputState(false); 
                SetButtonState(true, false, false, true);
            }
            catch (Exception ex)
            { 
                MessageBox.Show($"Không thể xóa sản phẩm.\n\nChi tiết: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
