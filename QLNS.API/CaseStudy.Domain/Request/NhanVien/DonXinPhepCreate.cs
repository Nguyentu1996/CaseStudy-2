using System;

namespace CaseStudy.Domain.Request.NhanVien
{
    public class DonXinPhepCreate
    {
        public int Id { get; set; }
        public int NhanVienId { get; set; }
        public int QuanLyId { get; set; }
        public int TinhTrang { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int SoPhepConLai { get; set; }
        public int SoNgayDaNghi { get; set; }
        public DateTime NgayGui { get; set; }
        public DateTime NgayPhanHoi { get; set; }
        public string GhiChu { get; set; }
        public string TraLoi { get; set; }
        public string HoTen { get; set; }
        public string BoPhan { get; set; }
        public int Tre { get; set; }
        public int KhongPhep { get; set; }

    }
}
