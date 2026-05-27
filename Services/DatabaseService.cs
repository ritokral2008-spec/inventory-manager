using SQLite;
using InventoryManager.Models;

namespace InventoryManager.Services
{
    public class DatabaseService
    {
        private const string DatabasePath = "products.db";

        private readonly SQLiteConnection _db;

        public DatabaseService()
        {
            _db = new SQLiteConnection(DatabasePath);

            _db.CreateTable<Product>();
        }

        public void AddProduct(Product product)
        {
            _db.Insert(product);
        }

        public List<Product> GetProducts()
        {
            return _db.Table<Product>().ToList();
        }

        public void UpdateProduct(Product product)
        {
            _db.Update(product);
        }

        public void DeleteProduct(int id)
        {
            var product = _db.Find<Product>(id);

            if(product != null)
            {
                _db.Delete(product);
            }
        }
    }
}