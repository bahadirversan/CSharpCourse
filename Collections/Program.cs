using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            //Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));//glass diye bir değer var mı diye sorgular
            Console.WriteLine(dictionary.ContainsKey("table"));

            Console.WriteLine(dictionary.ContainsValue("kitap"));

            Console.ReadLine();
        }

        private static void List()
        {
            //ArrayList();
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            //Console.WriteLine(cities.Contains("Ankara"));//true dönmesinin nedeni contains

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { FirstName = "Bahadır", Id = 1 });
            //customers.Add(new Customer { FirstName = "Engin", Id = 2 });

            List<Customer> customers = new List<Customer>
            {
                new Customer { FirstName = "Bahadır", Id = 1 },
                new Customer { FirstName = "Engin", Id = 2 }
            };

            var customer2 = new Customer()
            {
                FirstName = "Ali", Id = 4
            };

            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id = 4, FirstName = "Ahmet"},
                new Customer{Id = 5, FirstName = "Ayşe"}
            });

            Console.WriteLine(customers.Contains(customer2));

            //customers.Clear();

            var index = customers.IndexOf(customer2);
            Console.WriteLine("Index : {0}", index);

            customers.Add(customer2);

            var index2 = customers.LastIndexOf(customer2);
            Console.WriteLine("Index : {0}", index2);

            customers.Insert(0, customer2);//0. indexe customer2 yi ekler

            //customers.Remove(customer2);//bulduğu ilk değeri siler ve biter
            //customers.Remove(customer2);
            //customers.Remove(customer2);
            //customers.Remove(customer2);//customer2 elemanlarıbittiği için hiçbir şey yapmaz
            customers.RemoveAll(c => c.FirstName == "Ali");//Listediki Alileri siler


            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            var count = customers.Count();
            Console.WriteLine("Count : {0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            //Console.WriteLine(cities[2]);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
