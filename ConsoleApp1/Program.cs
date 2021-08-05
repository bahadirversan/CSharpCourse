using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(14,27);//burdaki 27 silinse bile 22.satırdaki number2 ya verilen değer geçerli olacak

            int number1 = 20;//ref sayesinde number1 i yazzdırdığımızda 30 yazdırır
            //ref yerine out yazılabilir. farkı ref için number1 set edilmiş yani değer gönderilmiş olması lazımdır. fakat outta number1 e sayı girilmese bile çalışır
            int number2 = 100;
            var result2 = Add3(ref number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            //Console.WriteLine(result);
            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine(Add4(1,2,3,4,5,6));//51.satırdaki params kısmına 2 ve sonrası dahil olur number 1 değerini alır ve 51.satırdaki metodun içinde number ile alakalı işlem yapılmadığı için sonuç 20 olur
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!!");
        }
        static int Add2(int number1, int number2=27)//default parametreli metot
        {
           var result = number1 + number2;
           return result;
        }
        static int Add3(ref int number1, int number2)
        {
            number1 = 30;//outun kullanıldığı metot içerisinde number1 mutlaka set edilmelidir yani değer verilmelidir
            return number1 + number2;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)//method overloading
        {
            return number1 * number2 * number3;
        }
        static int Add4(int number, params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
