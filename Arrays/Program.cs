using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Bahadır";
            students[1] = "Ali";
            students[2] = "Ahmet";

            string[] students3 = new string[3] {"Bahadır", "Ali", "Ahmet" };
            
            string[] students2 = {"Bahadır", "Ali", "Ahmet"};
           
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[5, 3] 
            {                
                {"İstanbul" , "İzmit", "Bursa"},
                {"Ankara" , "Konya", "Kırıkkale"},
                {"Antalya" , "Adana", "Mersin"},
                {"Rize" , "Trabzon", "Samsun"},
                {"İzmir" , "Muğla", "Manisa"},               
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("*******");
            }

            Console.ReadLine();
        }
    }
}
