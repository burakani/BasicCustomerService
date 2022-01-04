using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerService
{
    class CustomerManager
    {
        public void AddCustomer(Customer musteri)
        {
            Console.WriteLine(musteri.CustomerName + " " + musteri.CustomerSurname + " Eklendi!");
        }
        public void DeleteCustomer(Customer musteri)
        {
            Console.WriteLine(musteri.CustomerId + "." + musteri.CustomerName + " Silindi!");
        }
        public void ListCustomer()
        {
            Console.WriteLine("Musteriler Listelendi!");
        }
    }
}
