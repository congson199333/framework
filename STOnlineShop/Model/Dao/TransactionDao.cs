using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.Dao
{
    public class TransactionDao
    {
        STOnlineShop db = null;
        
        public TransactionDao()
        {
            db = new STOnlineShop();
        }

        public long Insert(Transaction tran)
        {
            db.Transactions.Add(tran);
            db.SaveChanges();
            return tran.tranId;

        }

        //public decimal Total()
        //{
        //    return db.Transactions
        //}
      
    }
}
