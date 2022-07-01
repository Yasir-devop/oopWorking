using System;

namespace oopWorking
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer Manager sınıfından bir nesne üretme.
            CustomerManager customerManager = new CustomerManager();
            //Customer Manager sınıfının içindeki methodları kullanma.
            customerManager.Add();
            customerManager.Update();

            //Product Manager sınıfından bir nesne üretme.
            ProductManager productManager = new ProductManager();
            //Product Manager sınıfının içindeki methodları kullanma.
            productManager.Add();
            productManager.Update();

            //Customer sınıfından bir nesne oluştırma ve property(özelliklere) değer atama.
            Customer customer = new Customer
            {
                ID = 1,
                FirstName = "Mahir",
                LastName = "Kurt",
                City = "İstanbul"
            };

            Console.WriteLine("İsim : " + customer.FirstName + "\nSoyisim: " + customer.LastName);

            Console.ReadLine();
        }
    }
}
