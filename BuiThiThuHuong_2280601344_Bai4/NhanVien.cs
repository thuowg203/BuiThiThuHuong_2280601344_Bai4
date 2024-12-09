using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiThiThuHuong_2280601344_Bai4
{
    public class NhanVien
    {
        public int ID {  get; set; }
        public string Ten { get; set; }
        public double Luong { get; set; }
        public NhanVien() { }

        // Constructor với 3 tham số
        public NhanVien(int id, string ten, double luong)
        {
            ID = id;
            Ten = ten;
            Luong = luong;
        }
    }
}
