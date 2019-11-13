using System;
using System.ComponentModel.DataAnnotations;

namespace CaseStudy.Live.Models.QuanLy.Response
{
    public class DonXinPhep
    {
        public int DonXinPhepId { get; set; }
        public int NhanVienId { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string HoTen => Ho + " " + Ten;
        public int TinhTrang { get; set; }

        [DataType(DataType.Date)]
        public DateTime NgayBatDau { get; set; }

        [DataType(DataType.Date)]
        public DateTime NgayKetThuc { get; set; }
        public int SoPhepConLai { get; set; }
        public int SoNgayDaNghi { get; set; }

        [DataType(DataType.Date)]
        public DateTime NgayGui { get; set; }

        [DataType(DataType.Date)]
        public DateTime? NgayPhanHoi { get; set; }
        public string GhiChu { get; set; }
        public string TraLoi { get; set; }
        public int QuanLyId { get; set; }
    }
}
