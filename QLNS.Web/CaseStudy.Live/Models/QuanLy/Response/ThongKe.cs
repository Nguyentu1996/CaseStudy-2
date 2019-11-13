namespace CaseStudy.Live.Models.QuanLy.Response
{
    public class ThongKe
    {
        public int NhanVienId { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string HoTen => Ho + " " + Ten;
        public int CoMat { get; set; }
        public int Tre { get; set; }
        public int KhongPhep { get; set; }
        public int CoPhep { get; set; }
        public int TheoQuyDinh { get; set; }
    }
}
