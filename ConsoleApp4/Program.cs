using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{ 
    class Queue
    {
        int[] a;
        int front, rear, count;

        // Ham tao Queue(int n)
        public Queue(int n)
        {
            a = new int[n];
            front = 0;
            rear = -1;
            count = 0;
        }

        // Kiem tra Queue rong
        public bool isEmpty()
        {
            return count == 0;
        }

        // Kiem tra Queue day
        public bool isFull()
        {
            return count == a.Length;
        }

        // Them phan tu vao Queue
        public void push(int x)
        {
            if (isFull())
            {
                Console.WriteLine("Queue da day!");
                return;
            }

            rear = (rear + 1) % a.Length;
            a[rear] = x;
            count++;
        }

        // Lay phan tu ra khoi Queue
        public int pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue rong!");
                return -1;
            }

            int x = a[front];
            front = (front + 1) % a.Length;
            count--;

            return x;
        }
    }
    internal class Program
    { 
        static void Main(string[] args)
        {
            Queue q = new Queue(5);

            q.push(10);
            q.push(20);
            q.push(30);

            Console.WriteLine("Lay ra: " + q.pop());
            Console.WriteLine("Lay ra: " + q.pop());

            Console.WriteLine("Queue rong: " + q.isEmpty());
            Console.WriteLine("Queue day: " + q.isFull());

            Console.ReadKey();
        }
    }
}
