using System.Collections;

namespace BTVN02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HinhChuNhat hcn = new HinhChuNhat(5, 3);
            //   hcn.XuatThongTin();




            List<SinhVien> listSV = new List<SinhVien>();
            for (int i = 0; i < 3; i++)
            {
                SinhVien sv = new SinhVien();
                sv.NhapThongTin();
                listSV.Add(sv);
            }
            foreach (SinhVien sv in listSV)
            {
                sv.HienThiThongTin();
                sv.XepLoai();
            }
        }

    }
}
