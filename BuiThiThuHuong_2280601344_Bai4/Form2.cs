using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuiThiThuHuong_2280601344_Bai4
{ 
    public partial class Form2 : Form
    {

        public delegate void AddNhanVien(NhanVien nhanvien);
        public delegate void SuaNhanVien(NhanVien nhanvien);
        private NhanVien _nhanVien; // Lưu trữ NhanVien đang chỉnh sửa
        private Mode _currentMode; // Chế độ hiện tại (Thêm hoặc Sửa)
        public enum Mode
        {
            Add,
            Edit
        }
        public Form2()
        {
            InitializeComponent();
            _currentMode = Mode.Add;
        }
        public Form2(NhanVien nhanVien) : this() // Gọi constructor mặc định
        {
            _nhanVien = nhanVien; // Lưu đối tượng NhanVien để sửa
            InitializeNhanVien(nhanVien); // Khởi tạo các trường
            _currentMode = Mode.Edit; // Thiết lập chế độ là Sửa
        }
        private void InitializeNhanVien(NhanVien nhanVien)
        {
            txtID.Text = nhanVien.ID.ToString(); // Điền ID
            txtTen.Text = nhanVien.Ten; // Điền tên
            txtLuong.Text = nhanVien.Luong.ToString(); // Điền lương
            txtID.ReadOnly = true; // Làm cho ID không thể sửa
        }
        public AddNhanVien OnAddNhanVien;

        public SuaNhanVien OnSuaNhanVien;
        private void btnDongy_Click(object sender, EventArgs e)
        {
            if (_currentMode == Mode.Add) // Nếu đang ở chế độ Thêm
            {
                var nhanvien = new NhanVien(int.Parse(txtID.Text), txtTen.Text, double.Parse(txtLuong.Text));
                OnAddNhanVien?.Invoke(nhanvien); // Gọi sự kiện thêm
            }
            else if (_currentMode == Mode.Edit) // Nếu đang ở chế độ Sửa
            {
                _nhanVien.Ten = txtTen.Text; // Cập nhật tên
                _nhanVien.Luong = double.Parse(txtLuong.Text); // Cập nhật lương
                OnSuaNhanVien?.Invoke(_nhanVien); // Gọi sự kiện sửa
            }

            this.Close(); // Đóng Form2
        }
        private void btnBoqua_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
