using System;

namespace CustomerService
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer musteri1 = new Customer();
            musteri1.CustomerId = 1;
            musteri1.CustomerName = "Burak";
            musteri1.CustomerSurname = "ANI";

            Customer musteri2 = new Customer();
            musteri2.CustomerId = 2;
            musteri2.CustomerName = "Ahmet";
            musteri2.CustomerSurname = "Ümit";

            Customer[] musteriler = new Customer[] { musteri1, musteri2 };
            CustomerManager customerManager = new CustomerManager();

            foreach (var musteri in musteriler)
            {
                customerManager.AddCustomer(musteri);
                Console.WriteLine();
            }

            foreach (Customer musteri in musteriler)
            {
                Console.WriteLine(musteri.CustomerId);
                Console.WriteLine(musteri.CustomerName);
                Console.WriteLine(musteri.CustomerSurname);
                Console.WriteLine("--------------------------");
            }
            Console.WriteLine();
            customerManager.ListCustomer();

            Console.WriteLine();
            customerManager.DeleteCustomer(musteri1);
        }
    }
}
