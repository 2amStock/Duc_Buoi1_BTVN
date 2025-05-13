namespace BTVN01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cau 1:");
            int a = 2, b = 3;
            Console.WriteLine($"Truoc khi doi: a = { a}, b = {b}");
            HoanDoi(ref a, ref b);
            Console.WriteLine($"Sau khi doi: a = {a}, b = {b}");

            Console.WriteLine("Cau 2");
            int so=123;
            
            int tram, chuc, donvi;
            PhanTichSo(so, out tram, out chuc, out donvi);
            Console.WriteLine($"So = {so}, tram = {tram}, chuc = {chuc}, don vi = {donvi}");

            Console.WriteLine("Cau 3");
            a = 100;
            b = 0;
            int tong, hieu, tich;
            double thuong;
            TinhToan(a, b, out tong, out hieu, out tich, out thuong);
            if (thuong == 0)
            {
                Console.WriteLine($"a + b = {tong}, a - b = {hieu}, a * b = {tich}, ");
                Console.Write("khong the chia cho 0");
            }
            else
            {
                Console.WriteLine($"a + b = {tong}, a - b = {hieu}, a * b = {tich}, a : b = {thuong}");
            }
        }


        static void HoanDoi(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void PhanTichSo(int so, out int tram, out int chuc, out int donvi)
        {
            tram = so / 100;
            chuc = (so % 100) / 10;
            donvi = so % 10;
        }

        static void TinhToan(int a, int b, out int tong, out int hieu, out int tich, out double thuong)
        {
            if (b == 0)
            {
                tong = a + b;
                hieu = a - b;
                tich = a * b;
                thuong = 0;
            }
            else
            {
                tong = a + b;
                hieu = a - b;
                tich = a * b;
                thuong = (double)a / b;
            }
        }
    }
}

//he he he 22222
