using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH2_bai1
{
    class stack
    {
        int[] a = new int[10];
        int top = -1;
        public void Push(int x)
        {
            a[++top] = x;
        }
        public int Pop()
        {
            return a[top--];
        }
        public bool IsEmpty()
        {

            return top == -1;
        }
    }
      class Hexa
    {
        int n;
        stack s = new stack();
        public void Nhap() 
        {
            Console.Write("Nhập N :");
            n = int.Parse(Console.ReadLine());
        }
        public void ChuyenDoiSo ()
        {
            int tmp = n;
            if (tmp == 0)
            {
                s.Push(0);
                return;
            }
            while (tmp >0)
            {
                int du = tmp %16;
                s.Push(du);
                tmp = tmp / 16;
            }    
        }
        public void Hien()
        {
            Console.Write("So he 16 la: ");

            while (!s.IsEmpty())
            {
                int x = s.Pop();

                if (x < 10)
                    Console.Write(x);
                else
                    Console.Write((char)('A' + x - 10));
            }

            Console.WriteLine();
        }
       }
    internal class Program
    {
        static void Main(string[] args)
        {
           Hexa h = new Hexa();
            h.Nhap();
            h.ChuyenDoiSo();
            h.Hien();
            Console.ReadKey();
        }
    }
}
