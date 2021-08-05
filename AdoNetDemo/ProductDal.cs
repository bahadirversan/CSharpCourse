using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server = (localdb)\mssqllocaldb; initial catalog = ETrade; integrated security = true");//@ işaretinden sonra yazılan kısmı stringe çevirir. initial catalog hangii veritabanına bağlanılacağını ifade eder
        public List<Product> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Products", _connection);//Select * from Products Products ın içindeki verileri getirme komutudur. girilen komutu da connection a gönderdik

            SqlDataReader reader = command.ExecuteReader();//komut çalıştırma kodu

            List<Product> products = new List<Product>();

            while (reader.Read())//reader ı tek tek oku
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),//int e çevirme kodu
                    Name = reader["Name"].ToString(),//string e çevirme kodu
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }

            reader.Close();//reader ı kapatma komutu
            _connection.Close();//conneciton u kapatma komutu
            return products;

            //    public DataTable GetAll2()
            //{           
            //    if (connection.State == ConnectionState.Closed)//bağlantı kapalıysa aç
            //    {
            //        connection.Open();//bağlantı açılır
            //    }
            //    SqlCommand command = new SqlCommand("Select * from Products", connection);//Select * from Products Products ın içindeki verileri getirme komutudur. girilen komutu da connection a gönderdik

            //    SqlDataReader reader = command.ExecuteReader();//komut çalıştırma kodu

            //    DataTable dataTable = new DataTable();
            //    dataTable.Load(reader);//reader a doldur komutu
            //    reader.Close();//reader ı kapatma komutu
            //    connection.Close();//conneciton u kapatma komutu
            //    return dataTable;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)//bağlantı kapalıysa aç
            {
                _connection.Open();//bağlantı açılır
            }
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Products values(@name, @unitPrice, @stockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Products set Name = @name, UnitPrice = @unitPrice, StockAmount = @stockAmount where Id = @id", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Delete(int id)// ürünü id üzerinden silicez
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Products where Id = @id", _connection);            
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
