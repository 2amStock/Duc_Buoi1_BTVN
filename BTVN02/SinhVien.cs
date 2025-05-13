using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN02
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public double DiemTB { get; set; }

        public SinhVien() 
        { 
        }

        public SinhVien(string maSV, string tenSV, double diemTB)
        {
            MaSV = maSV;
            TenSV = tenSV;
            DiemTB = diemTB;
        }

        public void NhapThongTin()
        {
            
            while (true)
            {
                string diemTB_raw;
                Console.Write("Nhap ma sinh vien: ");
                MaSV = Console.ReadLine();
                Console.Write("Nhap ten sinh vien: ");
                TenSV = Console.ReadLine();
                Console.Write("Nhap diem trung binh: ");
                diemTB_raw = Console.ReadLine();
                if (IsDouble(diemTB_raw))
                {
                    DiemTB = double.Parse(diemTB_raw);
                    break;
                }
                else
                {
                    Console.WriteLine("Diem trung binh khong hop le. Vui long nhap lai.");
                }
            }
        }


        public bool IsDouble(string str)
        {
            double result;
            return double.TryParse(str, out result);
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"MaSV = {MaSV}, TenSV = {TenSV}, DiemTB = {DiemTB}");
        }

        public void XepLoai()
        {
            if (DiemTB >= 8)
            {
                Console.WriteLine("Xep loai: Gioi");
            }
            else if (DiemTB >= 6.5)
            {
                Console.WriteLine("Xep loai: Kha");
            }
            else if (DiemTB >= 5)
            {
                Console.WriteLine("Xep loai: Trung binh");
            }
            else
            {
                Console.WriteLine("Xep loai: Yeu");
            }
        }
    }
}
