﻿namespace CaseStudy.Live.Models.QuanLy.Request
{
    public class LayDiemDanhNhanVienIdThang : BaseRequest
    {
        public int NhanVienId { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
    }
}
