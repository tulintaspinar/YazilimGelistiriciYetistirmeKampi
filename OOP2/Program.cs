using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.ID = 1;
            customer1.CustomerNo = "12345";
            customer1.CustomerFirstName = "Tülin";
            customer1.CustomerLastName = "Taşpınar";
            customer1.CustometTC = "256325417895";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.ID = 2;
            customer2.CustomerNo = "12345";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "1234567890";


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
