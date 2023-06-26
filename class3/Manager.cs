using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass3
{
    internal class Manager : Person
    {
        public string Role { get; set; }
        public Manager() { }

        public override void Display()
        {
            Console.WriteLine("This is Manager");
            Console.WriteLine("Name = {0}, Email = {1}, Address= {2},Salary={3},Role = {4}", 
                this.Name, this.Email, this.Address,this.Salary, this.Role);
            Console.Write($"Bonus={Salary * 3}");

        }

        public override void BonusSalary()
        {
            Console.WriteLine($"Bonus={Salary * 3}");

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

            Console.Write("Enter Role: ");
            this.Role = Console.ReadLine();
        }
    }
}
