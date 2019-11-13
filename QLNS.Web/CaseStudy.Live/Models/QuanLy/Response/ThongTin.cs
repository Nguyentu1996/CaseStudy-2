using System;
using System.ComponentModel.DataAnnotations;

namespace CaseStudy.Live.Models.QuanLy.Response
{
    public class ThongTin
    {
        public int NhanVienId { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string HoTen => Ho + " " + Ten;
        public bool GioiTinh { get; set; }
        public string Gioi => GioiTinh ? "Nam" : "Nữ";

        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string HinhAnh { get; set; }
        public string ChucVuTen { get; set; }
    }
}
