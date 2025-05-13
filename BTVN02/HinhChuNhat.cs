using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN02
{
    public class HinhChuNhat
    {
        public double ChieuDai { get; set; }
        public double ChieuRong { get; set; }

        public HinhChuNhat(double chieuDai, double chieuRong)
        {
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
        }

        public double TinhDienTich()
        {
            return ChieuDai * ChieuRong;
        }

        public double TinhChuVi()
        {
            return 2 * (ChieuDai + ChieuRong);
        }
        public void XuatThongTin()
        {
            Console.WriteLine($"chieu dai {ChieuDai} và chieu rong {ChieuRong}");
            Console.WriteLine($"S: {TinhDienTich()}");
            Console.WriteLine($"P: {TinhChuVi()}");
        }
    }
}
