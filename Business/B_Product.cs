using DataAccess;
using Entities;

namespace Business
{
    public class B_Product
    {
        public List<ProductEntity> ProductList()
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList();
            }
        }

        public void CreateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Add(oProduct);

                db.SaveChanges();
            }
        }

        public void UpdateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Update(oProduct);

                db.SaveChanges();
            }
        }
    }
}
