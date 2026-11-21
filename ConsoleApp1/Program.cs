using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {  
        private static int dem = 0;
        private static double basicSalary = 0;
        private readonly int Id;
        private string name;
        private readonly int YearOfBirth;
        private double SalaryLevel;
        public Employee(string name, int yearOfBirth, double salaryLevel)
        {
            this.Id = ++dem;
            this.name = name;
            this.YearOfBirth = yearOfBirth;
            this.SalaryLevel = salaryLevel;
        }
        public int getId() { return Id; }
        public string getName() { return name; }
        public int getYearOfBirth() { return YearOfBirth; }
        public double getIncome() {  return SalaryLevel * basicSalary;}
        public void display()
        {
            Console.WriteLine("Id:"+Id);
            Console.WriteLine("Tên :"+name);
            Console.WriteLine("Năm sinh :" +YearOfBirth);
            Console.WriteLine("Lương cơ bản:" + basicSalary);
            Console.WriteLine("Thu nhập:"+getIncome());
        }
        public void setSalaryLevel(double SalaryLevel)
        {
            this.SalaryLevel = SalaryLevel;
        }
        public static void setBasicSalary( double salary)
        {
            basicSalary = salary;
        }
        static void Main(string[] args)
        {
            Employee.setBasicSalary(140000000);
            Employee e1 = new Employee("Nguyen Van A",2000,2.35);
            Employee e2 = new Employee("Tran Thi B ", 1988, 3.0);
            e1.display();
            Console.WriteLine();
            e2.display();
            e1.setSalaryLevel(2.67);
            Console.WriteLine("\nThu nhap moi cua A :"+e1.getIncome());
        }
    }
}
