using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Canbo
    {
        public string Hoten, QueQuan;
        private static double LuongCB = 1000000;
        private double HSL;
        public void Nhap()
        {
            Console.Write(" Họ tên của cán bộ :");
            Hoten = Console.ReadLine();
            Console.WriteLine("Quê Quán của cán bộ :");
            QueQuan = Console.ReadLine();
            Console.WriteLine("Nhập hệ số lương :");
            SetLuong(double.Parse(Console.ReadLine()));
        }
        public void HienThi()
        {
            Console.WriteLine("{0}\t{1}\t{2}",Hoten,QueQuan,HSL); 
        }
        public double GetLuong()
        {
            return LuongCB;
        }
        public void SetLuong( double value)
        {
         if (value >=0 && value <=1000000)
            {
                LuongCB = value;
            }    
        }
        public double Tinh()
        {
            Console.Write("Lương của cán bộ ");
            double Luong = LuongCB * HSL;
            return Luong;
        }
    }
    class QLCB
    {
        private Canbo[] ds;
        private int scb;
        private void Nhap()
        {
            Console.Write("Nhập số cán bộ ");
            scb = int .Parse(Console.ReadLine());
            ds = new Canbo[scb];
            for (int i = 0; i < ds.Length;++i)
            {
                Console.WriteLine("Nhập thông tin cho cán bộ " + (i + 1));
                ds[i] = new Canbo();
                ds[i].Nhap();
            }    
        }
        public void Hien()
        {
            for (int i = 0;i < ds.Length;++i)
                ds[i].HienThi();
        }
        public void SapXep()
        {
            for (int i = 0;i <scb-1;++i)
             for (int j = i+1; j < scb; ++i)
                if (ds[i].GetLuong() > ds[j].GetLuong())
                    {
                        Canbo tg = ds[i];
                        ds[i] = ds[j];
                        tg = ds[j];
                    }    
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            QLCB t = new QLCB();
            t.Nhap();
            Console.WriteLine("Danh sách cán bộ lúc đầu :");
            t.Hien();
            Console.WriteLine("Danh sách sau khi sắp xếp ");

        }
    }
}
