using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHĐT
{ 
  
     class Diem
    {
        public double x;
        public double y;
        public  Diem ()
        {
            this.x = 0;
            this.y = 0;
        }
        public  Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void hienThi()
        {
            Console.WriteLine("("+x+","+y+")");
        }
        public void Nhap()
        { 
           Console.Write("Nhập toạ độ điểm x :");
           x = double.Parse(Console.ReadLine());
           Console.Write("Nhập toạ độ điểm y:");
           y = double.Parse(Console.ReadLine());
        }
        public double KhoangCach( Diem d)
        {
            double dx = this.x - d.x;
            double dy = this.y - d.y;
            return Math.Sqrt(dx*dx + dy*dy);
        }
        static void Main(string[] args)
        {
            Diem a = new Diem();
            Diem b = new Diem(3,4);
            a.hienThi();
            b.hienThi();
            Console.WriteLine("Khoảng Cách:"+a.KhoangCach(b));
            Console.WriteLine("Khoảng cách :"+b.KhoangCach(a));
            Diem c = new Diem(3,4);
            c.Nhap();
            c.hienThi();
        }
    }
}
