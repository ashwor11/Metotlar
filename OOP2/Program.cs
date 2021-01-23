using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kerim Hasan Yıldırım
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerNumber = "123145";
            customer1.FirstName = "Kerim Hasan";
            customer1.LastName = "Yıldırım";
            customer1.IdNumber = "2222233232223";
            customer1.Id = 1;
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CompanyName = "rootsocial.us";
            customer2.CustomerNumber = "2342312312";
            customer2.TaxNumber = "12312312312";



            //Gerçek - Tüzel

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
