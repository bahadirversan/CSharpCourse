using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Bahadır Versan";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Engin Demiroğ";

            bool result3 = sentence.EndsWith("n");//sentence n harfiyle bitiyor mu
            bool result4 = sentence.StartsWith("My name");//sentence My name ile başlıyor mu

            var result5 = sentence.IndexOf("name");//sentence içerisinde name kaçıncı karakteden itibaren başlıyor. eğer olmayan bir kelime girilirse -1 döner
            var result6 = sentence.IndexOf(" ");//sentence içerisinde boşluk karakterini arar.bulduğu ilk boşluk karakterini yazdırır
            var result7 = sentence.LastIndexOf(" ");//sentence içerisinde sondaki boşluk karakterini aramaya başlar
            var result8 = sentence.Insert(0, "Hello, ");//sentence in 0. karakterinden itibaren Hello,  ifadesini ekle 
            var result9 = sentence.Substring(3, 4);//sentence in 3. karakterinden itibaren 4 tane ayır demektir
            var result10 = sentence.ToLower();//sentence deki bütün harfleri küçük harfe çevirir
            var result11 = sentence.ToUpper();//sentence deki bütün harfleri büyük harfe çevirir
            var result12 = sentence.Replace(" ","-");//sentence içerisindeki boşluk karakteri yerine - koy
            var result13 = sentence.Remove(2, 5);//sentence içerisinde 2.karakterden itibaren 5 tane karakteri atar

            Console.WriteLine(result13);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "İzmit";
            //Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            //string result = city + " " + city2;
            //Console.WriteLine(result);
            Console.WriteLine(String.Format("{0} {1}", city, city2));//21 ve 22. satır yerine bu işlemde uygulanabilir
        }
    }
}
