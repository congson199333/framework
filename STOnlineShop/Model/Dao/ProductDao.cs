using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;
using Model.ViewModel;

namespace Model.Dao
{
    public class ProductDao
    {
        STOnlineShop db = null;


        public ProductDao()
        {
            db = new STOnlineShop();

        }

        public IEnumerable<Product> ListProduct1(int page, int pageSize)
        {
            return db.Products.Where(x=>x.brandId== 1 && x.sale == 0).OrderByDescending(x => x.datem).ToList().ToPagedList(page, pageSize);
        }

        public IEnumerable<Product> ListProduct2(int page, int pageSize)
        {
            return db.Products.Where(x => x.brandId == 2 && x.sale == 0).OrderByDescending(x => x.datem).ToList().ToPagedList(page, pageSize);
        }

        public IEnumerable<Product> ListProduct3(int page, int pageSize)
        {
            return db.Products.Where(x => x.brandId == 3 && x.sale == 0).OrderByDescending(x => x.datem).ToList().ToPagedList(page, pageSize);
        }

        public List<Product> ListNewProduct(int top)
        {
            return db.Products.Where(x => x.sale == 0).OrderByDescending(x => x.datem).Take(top).ToList();
        }

        public IEnumerable<Product> ListAll(int page, int pageSize)
        {
            return db.Products.Where(x => x.sale == 0).OrderByDescending(x => x.datem).ToList().ToPagedList(page, pageSize);

        }


        public IEnumerable<Product> ListSale(int page, int pageSize)
        {
            return db.Products.Where(x => x.sale!=0).ToList().ToPagedList(page, pageSize);

        }

        public Product GetById(string ProductName)
        {
            return db.Products.SingleOrDefault(x => x.productName == ProductName);
        }

        public long Insert(Product entity)
        {
            db.Products.Add(entity);

            db.SaveChanges();
            return entity.productId;
        }


        public void UpdateImages(long productId, string images)
        {
            var product = db.Products.Find(productId);
            product.img = images;
            db.SaveChanges();
        }

        public Product ViewDetail(long id)
        {
            return db.Products.Find(id);
        }




        public bool Delete(long id)
        {
            try
            {
                var pro = db.Products.Find(id);
                db.Products.Remove(pro);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

      

        public bool Update(Product entity)
        {
            try
            {
                var product = db.Products.Find(entity.productId);
                product.img = entity.img;
                product.productName = entity.productName;
               
               
                product.price = entity.price;
                product.brandId = entity.brandId;
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }





    }
}
