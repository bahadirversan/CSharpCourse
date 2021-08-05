using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())//using tanımlanan nesnenin bellekten atılmasını garantilemek için kullanılır. yani ETradeContext nesnesinin işi bitince direkt olarak bellekten silinecektir                
            {
                return context.Products.ToList();//entity frameworkde veri tabanındaki tabloya erişip listeye çevirme
            }
        }

        public List<Product> GetByName(string key)//isme göre arama
        {
            using (ETradeContext context = new ETradeContext())                
            {
                return context.Products.Where(p => p.Name.Contains(key)).ToList();//context.Products tabloyu ifade eder
            }
        }

        public List<Product> GetByUnitPrice(decimal price)//fiyata göre arama
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= price).ToList();//ürünleri filtrele
            }
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice <= max).ToList();//ürünleri minimum ve maksimum fiyata göre filtreleme
            }
        }

        public Product GetById(int id)
        {
            using (ETradeContext context = new ETradeContext())               
            {
                var result = context.Products.SingleOrDefault(p => p.Id == id);
                return result;
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())           
            {
                context.Products.Add(product);
                context.SaveChanges();//veri tabanına yazdırma
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);//gönderilen product ı veritabanındaki product ile eşliyo
                entity.State = EntityState.Modified;
                context.SaveChanges();//veri tabanına yazdırma
            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
