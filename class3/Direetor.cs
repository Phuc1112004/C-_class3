using ConsoleAppClass3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3
{
    internal class Direetor : Person
    {
        public string Department { set; get; }
        public Direetor() { }

        public override void Display()
        {
            Console.WriteLine("This is Direetor");
            Console.WriteLine($"Name = {Name}, Email = {Email}, Address= {Address}, Department = {Department},Salary= {Salary}");

            Console.WriteLine($"Bonus = {Salary * 5}");
            // kí tự $ để truyền các đối tượng đã nhập vào.
        }

        public override void Input()
        {
            Console.Write("Enter Name: ");
            this.Name = Console.ReadLine();

            Console.Write("Enter Email:");
            this.Email = Console.ReadLine();

            Console.Write("Enter Address:");
            this.Address = Console.ReadLine();

            Console.Write("Enter Department:");
            this.Department = Console.ReadLine();

            Console.Write("Enter Salary:");
            this.Salary = Convert.ToInt32(Console.ReadLine());
        }

        public override void BonusSalary()
        {
            Console.WriteLine($"Bonus = {Salary * 5}");
        }
    }
}
