using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname);
            Console.WriteLine("İsimli Müşteri Eklendi");
            Console.WriteLine("**************************************");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname);
            Console.WriteLine("İsimli Müşteri Silindi");
            Console.WriteLine("**************************************");
        }
        public void ListAll(Customer customer)
        {
            
            Console.WriteLine(customer.Id + "    -- " + customer.Name + " -- " + customer.Surname + " -- " + customer.Age + "  -- " + customer.TC);
        }
    }
}
