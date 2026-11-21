using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class PS
    {
        // Cac thuoc tinh
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        // 1. Khoi tao khong tham so
        public PS()
        {
            TuSo = 0;
            MauSo = 1;
        }

        // 2. Khoi tao co 2 tham so
        public PS(int ts, int ms)
        {
            if (ms == 0)
                throw new ArgumentException("Mau so phai khac 0");

            TuSo = ts;
            MauSo = ms;
            ChuanHoa();
        }

        // 3. Khoi tao tu mot doi tuong PS khac
        public PS(PS p)
        {
            TuSo = p.TuSo;
            MauSo = p.MauSo;
        }

        // 4. Tim UCLN (phuong thuc private)
        private int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }

            return a;
        }

        // 5. Chuan hoa phan so
        public void ChuanHoa()
        {
            if (MauSo < 0)
            {
                TuSo = -TuSo;
                MauSo = -MauSo;
            }

            int ucln = UCLN(TuSo, MauSo);

            TuSo = TuSo / ucln;
            MauSo = MauSo / ucln;
        }

        // 6. Cong hai phan so
        public PS Cong(PS p)
        {
            PS kq = new PS(
                TuSo * p.MauSo + p.TuSo * MauSo,
                MauSo * p.MauSo
            );

            return kq;
        }

        // 7. Tru hai phan so
        public PS Tru(PS p)
        {
            PS kq = new PS(
                TuSo * p.MauSo - p.TuSo * MauSo,
                MauSo * p.MauSo
            );

            return kq;
        }

        // 8. Nhan hai phan so
        public PS Nhan(PS p)
        {
            PS kq = new PS(
                TuSo * p.TuSo,
                MauSo * p.MauSo
            );

            return kq;
        }

        // 9. Chia hai phan so
        public PS Chia(PS p)
        {
            if (p.TuSo == 0)
                throw new DivideByZeroException("Khong the chia cho 0");

            PS kq = new PS(
                TuSo * p.MauSo,
                MauSo * p.TuSo
            );

            return kq;
        }

        // 10. So sanh hai phan so (private)
        private bool SoSanh(PS p)
        {
            return TuSo * p.MauSo == p.TuSo * MauSo;
        }

        // 11. Kiem tra hai phan so bang nhau
        public bool BangNhau(PS p)
        {
            return SoSanh(p);
        }

        // 12. In phan so
        public void Hien()
        {
            Console.Write(TuSo + "/" + MauSo);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PS p1 = new PS(2, 4);
            PS p2 = new PS(1, 3);

            Console.Write("Phan so 1: ");
            p1.Hien();

            Console.Write("\nPhan so 2: ");
            p2.Hien();

            Console.Write("\nTong: ");
            p1.Cong(p2).Hien();

            Console.Write("\nHieu: ");
            p1.Tru(p2).Hien();

            Console.Write("\nTich: ");
            p1.Nhan(p2).Hien();

            Console.Write("\nThuong: ");
            p1.Chia(p2).Hien();

            Console.WriteLine();

            if (p1.BangNhau(p2))
                Console.WriteLine("Hai phan so bang nhau");
            else
                Console.WriteLine("Hai phan so khong bang nhau");

            Console.ReadKey();
        }
    }
}
