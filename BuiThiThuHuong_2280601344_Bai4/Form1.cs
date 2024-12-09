using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BuiThiThuHuong_2280601344_Bai4
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private BindingSource bindingSource;
        private List<NhanVien> nhanviens;
        private void Form1_Load(object sender, EventArgs e)
        {
            nhanviens = new List<NhanVien>();
            nhanviens.Add(new NhanVien() { ID = 1, Ten = "A", Luong = 20 });
            nhanviens.Add(new NhanVien() { ID = 2, Ten = "B", Luong = 30 });
            nhanviens.Add(new NhanVien() { ID = 3, Ten = "C", Luong = 40 });
            bindingSource = new BindingSource { DataSource = nhanviens };
            dtgNhanvien.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.OnAddNhanVien += AddNhanVien;
            frm2.ShowDialog();
        }
        private void AddNhanVien(NhanVien nhanvien)
        {
            nhanviens.Add(nhanvien);
            dtgNhanvien.DataSource = null;
            dtgNhanvien.DataSource = nhanviens;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgNhanvien.SelectedRows.Count > 0)
            {
                var selectedRow = dtgNhanvien.SelectedRows[0];
                var selectedNhanVien = (NhanVien)selectedRow.DataBoundItem;

                Form2 frm2 = new Form2(selectedNhanVien); // Mở Form2 với NhanVien đã chọn
                frm2.OnSuaNhanVien += UpdateNhanVien; // Đăng ký sự kiện sửa
                frm2.ShowDialog(); // Hiện Form2
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một NhanVien để sửa.");
            }
        }
        private void UpdateNhanVien(NhanVien nhanvien)
        {
            var original = nhanviens.FirstOrDefault(nv => nv.ID == nhanvien.ID);
            if (original != null)
            {
                original.Ten = nhanvien.Ten;
                original.Luong = nhanvien.Luong;
            }
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dtgNhanvien.DataSource = null; // Đặt lại nguồn dữ liệu
            dtgNhanvien.DataSource = nhanviens; // Cập nhật nguồn dữ liệu mới
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgNhanvien.SelectedRows.Count > 0)
            {
                var selectedRow = dtgNhanvien.SelectedRows[0];
                var selectedNhanVien = (NhanVien)selectedRow.DataBoundItem;

                // Hiện hộp thoại xác nhận
                var result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa nhân viên này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Nếu người dùng chọn "Có", thực hiện xóa
                if (result == DialogResult.Yes)
                {
                    nhanviens.Remove(selectedNhanVien); // Xóa nhân viên khỏi danh sách
                    UpdateDataGridView(); // Cập nhật giao diện
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một NhanVien để xóa."); // Thông báo nếu không có hàng nào được chọ
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
