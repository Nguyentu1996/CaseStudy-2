using System;
using System.ComponentModel.DataAnnotations;

namespace CaseStudy.Live.Models.QuanLy.Response
{
    public class DiemDanh
    {
        public int NhanVienId { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string HoTen => Ho + " " + Ten;


        public int TrangThai { get; set; }

        [DataType(DataType.Date)]
        public DateTime Ngay { get; set; }
        public int QuanLyId { get; set; }
    }
}
