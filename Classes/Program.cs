using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "İzmit";
            customer.Id = 41;
            customer.FirstName = "Bahadır";//Bu işlemi yaptığımızda Customer classındaki firstname i set etmiş yani değer vermiş oluyoruz
            customer.LastName = "Versan";

            Customer customer2 = new Customer
            {
                City = "İstanbul",
                Id = 34,
                FirstName = "Engin",
                LastName = "Demiroğ"
            };

            Console.WriteLine(customer2.FirstName);//Bu kısım ise get bloğunu çalıştırır

            Console.ReadLine();
        }
    }
}
