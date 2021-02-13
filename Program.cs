using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Ali";
            customer1.Surname = "ARMUT";
            customer1.Age = 32;
            customer1.TC = "12345678911";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Emel";
            customer2.Surname = "ELMA";
            customer2.Age = 25;
            customer2.TC = "12345678912";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Kemal";
            customer3.Surname = "KİRAZ";
            customer3.Age = 38;
            customer3.TC = "12345678913";

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.Name = "Pelin";
            customer4.Surname = "PORTAKAL";
            customer4.Age = 29;
            customer4.TC = "12345678914";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };
            Console.WriteLine("Müşteri Listesi");
            Console.WriteLine("Sıra -- İsim -- Soyisim  -- Yaş -- TC Numarası");
            foreach (var customer in customers)
            {
                customerManager.ListAll(customer);
            }
            Console.WriteLine("**************************************");

            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);
            customerManager.Delete(customer4);


        }
    }
}
