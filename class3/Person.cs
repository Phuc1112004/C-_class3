using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass3
{
    internal abstract class Person
    {
        public Person() { }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public double Salary { set; get; }

        public abstract void Input();

        public abstract void Display();

        public abstract void BonusSalary();

        //public int Sum(int a, int b)
        //{
        //    return a + b;
        //}

        //public int Sum(double a, double b)
        //{
        //    return (int)(a + b);
        //}



    }
}
