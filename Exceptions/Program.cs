using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            //TryCatch();

            //ActionDemo();

            Func<int, int, int> add = Topla;//3 tane int tanımlamamızın sebebi 2 tane int değer olamsı 1 tanede int sonuç olması

            Console.WriteLine(add(3, 5));

            Func<int> getRandomNumber = delegate () 
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
          
            Console.WriteLine(getRandomNumber());
            Thread.Sleep(1000);//1 saniye uygulamayı bekletmek demek. üretilen random sayıların birbirinden farklı olmasını sağlıyo
            Console.WriteLine(getRandomNumber2());
            //Console.WriteLine(Topla(2, 3));

            Console.ReadLine();
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }

        private static void ActionDemo()
        {
            HandleException(() => {
                Find();//action kısmı
            });
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();//try ın içinde Find metodunu çalıştır demek
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Engin", "Derin", "Salih" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Engin", "Derin", "Salih" };
                students[3] = "Ahmet";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception!!");
                //Console.WriteLine(exception.Message);//hata mesajı
                Console.WriteLine(exception.InnerException);//hatayla ilgili daha detaylı bilgi verir

                throw;
            }
        }
    }
}
