using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppClass3
{
    internal class Employee : Person   // : là extends trong java (kế thừa)
    {
        //Default Constructor
        public Employee() { }

        //Parameter constructor
        public Employee(string name, string email, string address)
        {
            this.Name = name;
            this.Email = email;
            this.Address = address;
        }

        //Copy constructor
        public Employee(Employee emp)
        {
            this.Name = emp.Name;
            this.Email = emp.Email;
            this.Address = emp.Address;
        }

        public override void Display()
        {
            Console.WriteLine("This is Employee");
            Console.WriteLine("Name = {0}, Email = {1}, Address= {2} , Salary=(3)",
                this.Name, this.Email, this.Address);
            Console.WriteLine($"Bonus = {Salary * 2}");

        }

        public override void BonusSalary()
        {
            Console.WriteLine( $"Bonus = {Salary * 2}" );
        }


        public override void Input()
        {
            Console.Write("Enter name: ");
            this.Name = Console.ReadLine();

            Console.Write("Enter email: ");
            this.Email = Console.ReadLine();

            Console.Write("Enter address: ");
            this.Address = Console.ReadLine();

            Console.Write("Enter Salary: ");
            this.Salary = Convert.ToInt32(Console.ReadLine());
        }
    }
}
