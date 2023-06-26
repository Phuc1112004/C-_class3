using ConsoleAppClass3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManagement personManagement = new PersonManagement();


            do
            {
                Console.WriteLine("Choosen 1: Add New Person");
                Console.WriteLine("Choosen 2: Get All");
                Console.WriteLine("Choosen 3: Exit");
                int choosen = Convert.ToInt32(Console.ReadLine());
                switch (choosen)
                {
                    case 1:
                        personManagement.AddPerson();
                        break;
                    case 2:
                        personManagement.DisplayAll();
                        break;
                    case 3:
                        return;


                }
            } while (true);
        }
    }
}
