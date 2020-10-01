using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
namespace Model.Dao
{
    public class adminDao
    {
        STOnlineShop db = null;


        public adminDao()
        {
            db = new STOnlineShop();

        }
        
        public long Insert (AdminUser entity)
        {
            db.AdminUsers.Add(entity);
            db.SaveChanges();
            return entity.adminId;
        }

        public AdminUser GetById(string AdminName)
        {
            return db.AdminUsers.SingleOrDefault(x => x.adminName ==AdminName);
        }

        public Product ViewDetail(long id)
        {
            return db.Products.Find(id);
        }




        public bool Login(string adminName, string passWord)
        {
            var result = db.AdminUsers.Count(x => x.adminName == adminName && x.adminPass == passWord);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }



}

