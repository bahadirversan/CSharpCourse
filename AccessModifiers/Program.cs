using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
        protected public int Id { get; set; }
        public void Save()
        {
            
        }
        public void Delete()
        {

        }
    }
    class Student : Customer//private sadece bulunduğu blokta çalışır. protected ise private gibidir fakat burda olduğu gibi inhertitance olan nesnelerde de çalışır
    {
        public void Save2()
        {
            
            
        }
    }
    internal class Course
        //internal sadece AccessModifiers içerisindeki projelerde çalışır
        //public tüm projelerde kullanılabilir
        //bir class ın default gelen bildirgeci internaldır
    {
        public string Name { get; set; }

        private class NestedClass
        {

        }
    }
}
