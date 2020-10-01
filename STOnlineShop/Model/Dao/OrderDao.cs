using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.Dao
{
    public class OrderDao
    {
        STOnlineShop db = null;

        public OrderDao()
        {
            db = new STOnlineShop();
        }

        public bool Insert(Oder order)
        {
            try
            {
                db.Oders.Add(order);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }


        public List<Oder> ListAll()
        {
            return db.Oders.ToList();


        }

        //public Product GetById(string order)
        //{
        //    return db.Products.SingleOrDefault(x => x.productName == ProductName);
        //}

        public Oder ViewDetail(int id)
        {
            return db.Oders.Find(id);
        }


        public bool Update(Oder entity)
        {
            try
            {
                var order = db.Oders.Find(entity.oderId);
                order.quatity = entity.quatity;
                order.size = order.size;
                order.statusOrder = order.statusOrder;

                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var or = db.Oders.Find(id);
                db.Oders.Remove(or);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }


    }
}
